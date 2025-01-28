//using DevExpress.Xpo.DB.Helpers;
//using DevExpress.XtraEditors;
//using DevExpress.XtraGauges.Core.Model;
//using DevExpress.XtraLayout.Customization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAAQ_IMS.Purchase
{
    public partial class Material_Purchase_Order : Form
    {
        DataTable dataItems = null;
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        private DataGridViewCheckBoxColumn selectColumn;
        private const string SELECT_COLUMN_NAME = "SelectColumn";
        CheckBox headerbox = null;
        bool isHeadercheckboxclicked = false;
        public Material_Purchase_Order()
        {
            InitializeComponent();
        }

        private void Material_Purchase_Order_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {

                DelvMode();
                PayMode();
                GlobalInfo.GlobalInfo.combo_add_with_Value(cboSupplierName, "SELECT SupplierID, CompanyName FROM Supplier_Info ORDER BY CompanyName");

                //GlobalInfo.GlobalInfo.combo_add_with_Value(cboSubgroup, "select SubGroup_ID,SubGroup_Name from New_Item_SubGroup order by SubGroup_Name");

                GlobalInfo.GlobalInfo.PopulateCombobox(cboSubgroup, "SubGroup_ID", "SubGroup_Name", "New_Item_SubGroup", "SubGroup_Name");
                Currency();
                txtMpoNo.Text = GenerateAutompoNo().ToString();
                cboSubgroup.SelectedIndexChanged += cboSubgroup_SelectedIndexChanged;
                dgvmastermpo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                addDetails();
                btnRemove.Click += btnRemove_Click;
                //btnReset_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }
        
        private int GenerateAutompoNo()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("Select ISNULL(MAX(MPO_No),0)+1 As MPO_No from MPO_Master", conn);
                conn.Open();
                return Convert.ToInt16(cmd.ExecuteScalar().ToString());
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }

        }

        private void ItemEntrygridViewBind()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {

                sqlQ = $"Exec sp_GetItemDetails '" + cboMpoNo.Text + "'";

                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dgvmpodetails.Columns.Clear();

                //dgvmastermpo.Rows.Clear();
                dgvmpodetails.DataSource = dataItems;
                foreach (DataGridViewColumn c in dgvmastermpo.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Action";
                checkBoxColumn.Width = 30;
                checkBoxColumn.Name = "SelectColumnDetails";
                dgvmpodetails.Columns.Insert(0, checkBoxColumn);
                dgvmpodetails.AllowUserToAddRows = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;

            }

        }

        private void cboSubgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboSubgroup.SelectedItem != null)
                {
                    DataRowView selectedRow = (DataRowView)cboSubgroup.SelectedItem;

                    if (selectedRow != null)
                    {
                        int selectedSubGroupId = Convert.ToInt32(selectedRow["SubGroup_ID"]);

                        string query = $"SELECT Category_Name FROM New_Item_Category IC inner join New_Item_SubGroup SG on IC.SubGroup_ID=SG.SubGroup_ID WHERE SG.SubGroup_ID ='{selectedSubGroupId}' ORDER BY Category_Name";

                        GlobalInfo.GlobalInfo.combo_add(cboItemCatagory, query);
                        dgvmastermpo.AllowUserToAddRows = false;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboItemCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlQ = string.Empty;

                // Check if the selectColumn is null or not added already
                if (selectColumn == null)
                {
                    selectColumn = new DataGridViewCheckBoxColumn();

                    selectColumn.HeaderText = "Select";
                    selectColumn.Name = SELECT_COLUMN_NAME;
                    //dgvmastermpo.Columns.Insert(0, selectColumn);
                    dgvmastermpo.Columns.Add(selectColumn);// Insert as the first column
                }

                string selectedCategory = cboItemCatagory.SelectedItem.ToString();

                // Assuming that you have a column named Category_Name in the New_Item_Category table
                // Adjust the column names accordingly based on your database structure
                sqlQ = $"SELECT SG.SubGroup_Name,IC.Category_Name,IE.Item_ID,IE.Item_Name ,IE.Item_Article,NU.Unit_Name,NC.Color_Name,IE.Item_Size_Width,IE.Item_Unit_Prize FROM New_Item_Entry IE Inner join New_Item_SubGroup SG on IE.SubGroup_ID = SG.SubGroup_ID Inner join New_Item_Category IC on IE.Catagory_ID = IC.Category_ID Inner join New_Unit_Info NU on IE.Unit_ID = NU.Unit_ID Inner join New_Color_Info NC on IE.Color_ID = NC.Color_ID WHERE Category_Name = '{selectedCategory}'";

                dgvmastermpo.DataSource = GlobalInfo.GlobalInfo.getDataTable(sqlQ);

                // Bind the DataTable to the DataGridView
                //dgvmastermpo.DataSource = dataItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addDetails()
        {
            dgvmpodetails.Columns.Add("SubGroup", "SubGroup");
            dgvmpodetails.Columns.Add("Category", "Category_Name");
            dgvmpodetails.Columns.Add("Item_ID", "Item_ID");
            dgvmpodetails.Columns.Add("Item_Name", "Item_Name");
            dgvmpodetails.Columns.Add("ItemArticle", "Item Article");
            dgvmpodetails.Columns.Add("Unit", "Unit_Name");
            dgvmpodetails.Columns.Add("Color", "Color");
            dgvmpodetails.Columns.Add("ItemSizeWidth", "Item Size Width");
            dgvmpodetails.Columns.Add("UnitPrice", "Unit Price");
            dgvmpodetails.Columns.Add("ReqQty", "Req.QTY");
            dgvmpodetails.Columns.Add("TotalAmt", "Total Amt");
            // Set specific column properties if needed, e.g., make Req.QTY and Unit Price editable
            dgvmpodetails.Columns["ReqQty"].DefaultCellStyle.NullValue = "0";
            dgvmpodetails.Columns["UnitPrice"].DefaultCellStyle.NullValue = "0";
            dgvmpodetails.Columns["ReqQty"].ReadOnly = false;
            dgvmpodetails.Columns["UnitPrice"].ReadOnly = false;
            dgvmpodetails.CellEndEdit += dgvmpodetails_CellEndEdit;
            //DataGridViewCheckBoxColumn selectColumnDetails = new DataGridViewCheckBoxColumn();
            //selectColumnDetails.HeaderText = "Select";
            //selectColumnDetails.Name = "SelectColumnDetails";
            //// Add the "Select" column to the beginning of the Columns collection
            //dgvmpodetails.Columns.Insert(0, selectColumnDetails);

        }
        private string GetSelectedPOType()
        {
            if (RdoLocal.Checked) return "LOCAL";
            else if (RdoOverseas.Checked) return "IMPORT";
            else return string.Empty;
        }
        private void DelvMode()
        {
            // Add fixed values to the ComboBox
            cboDevMode.Items.Add("By Sea");
            cboDevMode.Items.Add("By Train");
            cboDevMode.Items.Add("By Air");
            cboDevMode.Items.Add("By Road");

        }
        private void PayMode()
        {
            cboPayMode.Items.Add("By Check");
            cboPayMode.Items.Add("By CC");
            cboPayMode.Items.Add("By LC");
            cboPayMode.Items.Add("Online Payment");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = 0;
                bool flag = false;

                foreach (DataGridViewRow row in dgvmastermpo.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["selectColumn"].Value);

                    if (isSelected)
                    {
                        DataRowView dataRowView = (DataRowView)row.DataBoundItem;
                        if (dataRowView != null)
                        {
                            DataRow dataRow = dataRowView.Row;

                            string itemid = dataRow["Item_ID"].ToString();

                            // Check if the itemNo is already in dgvmpodetails
                            bool isDuplicate = dgvmpodetails.Rows.Cast<DataGridViewRow>().Any(detailRow =>
                                itemid == detailRow.Cells["Item_ID"].Value?.ToString());

                            if (!isDuplicate)
                            {
                                string subGroupName = dataRow["SubGroup_Name"].ToString();
                                string categoryName = dataRow["Category_Name"].ToString();
                                string Item_ID = dataRow["Item_ID"].ToString();
                                string itemName = dataRow["Item_Name"].ToString();
                                string itemArticle = dataRow["Item_Article"].ToString();
                                string unitName = dataRow["Unit_Name"].ToString();
                                string colorName = dataRow["Color_Name"].ToString();
                                string itemSizeWidth = dataRow["Item_Size_Width"].ToString();
                                decimal unitPrice = Convert.ToDecimal(dataRow["Item_Unit_Prize"]);

                                // Add a new row to dgvdetails
                                dgvmpodetails.Rows.Add(subGroupName, categoryName, Item_ID, itemName, itemArticle, unitName, colorName, itemSizeWidth, unitPrice, 0, 0);
                                dgvmpodetails.AllowUserToAddRows = false;
                                flag = true;
                                selectedRowCount++;
                            }
                        }
                    }
                }

                lblrow.Text = $"{selectedRowCount}";

                if (selectedRowCount == 0)
                {
                    MessageBox.Show("The rows selected from dgvmastermpo.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!flag)
                {
                    MessageBox.Show("No unique rows selected from dgvmastermpo.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void dgvmpodetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                
                CalculateTotalAmount();
            }
        }
        private void CalculateTotalAmount()
        {
            // Iterate through each row in dgvmpodetails
            foreach (DataGridViewRow row in dgvmpodetails.Rows)
            {
                // Check if the ReqQty and Unit_Price columns exist
                if (row.Cells["ReqQty"].Value != null && row.Cells["Unit_Price"].Value != null)
                {
                    string reqQty = row.Cells["ReqQty"].Value.ToString();
                    string unitPrice = row.Cells["Unit_Price"].Value.ToString();

                    // Calculate Total_AMT by multiplying ReqQty and Unit_Price
                    double totalAmt = Convert.ToDouble(reqQty) * Convert.ToDouble(unitPrice);

                    // Update the Total_AMT column in the current row
                    row.Cells["Total_AMT"].Value = totalAmt;
                }
                else
                {
                    // Handle the case where the columns are not found
                    MessageBox.Show("Error: Columns ReqQty or Unit_Price not found.");
                }
            }
        }

        private void dgvmpodetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex == dgvmpodetails.Columns["ReqQty"].Index ||
            e.ColumnIndex == dgvmpodetails.Columns["UnitPrice"].Index)
                {
                    DataGridViewRow row = dgvmpodetails.Rows[e.RowIndex];

                    if (row != null && row.Cells["ReqQty"].Value != null &&
                        row.Cells["UnitPrice"].Value != null && row.Cells["TotalAmt"] != null)
                    {
                        // Calculate TotalAmt when ReqQty or UnitPrice is edited
                        int reqQty = Convert.ToInt32(row.Cells["ReqQty"].Value);
                        decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                        decimal totalAmt = reqQty * unitPrice;

                        row.Cells["TotalAmt"].Value = totalAmt;
                    }
                }
                _getTotal();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private decimal GetCurrencyRate(string currency)
        {

            switch (currency)
            {
                case "US dollar":
                    return 1.0m;
                case "Euro":
                    return 0.85m;
                case "Canadian Dollar":
                    return 0.75m;
                case "Yen":
                    return 0.0069m;
                case "Pound":
                    return 1.27m;
                case "Dinar":
                    return 3.26m;
                case "Taka":
                    return 0.0091m;
                case "Ruble":
                    return 0.011m;

                default:
                    return 1.0m;
            }
        }

        private void cboCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurrency.Text.ToString() != "--Select--")
            {
                try
                {
                    string selectedCurrency = cboCurrency.SelectedItem.ToString();
                    decimal currencyRate = GetCurrencyRate(selectedCurrency);
                    txtRate.Text = currencyRate.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mpoMasterQuery = string.Empty, deleteQuery = string.Empty;
            var mpoNo = GenerateAutompoNo();
            SqlConnection con = new SqlConnection(GlobalInfo.ConnectionInfo.GenerateConnectionString());
            SqlCommand cmd = null;
            con.Open();

            SqlTransaction transaction = null;

            try
            {
                transaction = con.BeginTransaction();

                if (chkModifyMpo.Checked == true)
                {
                    mpoMasterQuery = "UPDATE MPO_Master SET SupplierID=@Supplier_Name, MPO_Date=@MPO_Date, ETD_Date=@ETD_Date, CON_ETDDate=@CON_ETDDate, Currency=@Currency, Rate_USD=@Rate_USD, Delv_Mode=@Delv_Mode, Pay_Mode=@Pay_Mode, PO_Type=@PO_Type WHERE MPO_No = @MPO_No";
                    mpoNo = Convert.ToInt32(txtMpoNo.Text);
                    deleteQuery = "DELETE FROM MPO_Details WHERE MPO_No = @MPO_No";
                    cmd = new SqlCommand(deleteQuery, con, transaction);
                    cmd.Parameters.AddWithValue("@MPO_No", mpoNo);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    mpoMasterQuery = "INSERT INTO MPO_Master (MPO_No,SupplierID, MPO_Date, ETD_Date, CON_ETDDate, Currency, Rate_USD, Delv_Mode, Pay_Mode, PO_Type) VALUES (@MPO_No,@Supplier_Name, @MPO_Date, @ETD_Date, @CON_ETDDate, @Currency, @Rate_USD, @Delv_Mode, @Pay_Mode, @PO_Type); ";
                }

                cmd = new SqlCommand(mpoMasterQuery, con, transaction);
                cmd.Parameters.AddWithValue("@MPO_No", mpoNo);
                cmd.Parameters.AddWithValue("@Supplier_Name", cboSupplierName.SelectedValue);
                cmd.Parameters.AddWithValue("@MPO_Date", Convert.ToDateTime(dtMPODate.Text.Trim()));
                cmd.Parameters.AddWithValue("@ETD_Date", Convert.ToDateTime(dtETDDATE.Text.Trim()));
                cmd.Parameters.AddWithValue("@CON_ETDDate", Convert.ToDateTime(dtConEtddate.Text.Trim()));
                cmd.Parameters.AddWithValue("@Currency", Convert.ToString(cboCurrency.Text));
                cmd.Parameters.AddWithValue("@Rate_USD", Convert.ToDecimal(txtRate.Text.Trim()));
                cmd.Parameters.AddWithValue("@Delv_Mode", cboDevMode.Text);
                cmd.Parameters.AddWithValue("@Pay_Mode", cboPayMode.Text);
                string selectedPOType = GetSelectedPOType();
                cmd.Parameters.AddWithValue("@PO_Type", selectedPOType);
                cmd.ExecuteNonQuery();
               
                foreach (DataGridViewRow row in dgvmpodetails.Rows)
                {
                    //bool isSelected = Convert.ToBoolean(row.Cells["SelectColumnDetails"].Value);
                    // Check if the checkbox cell exists and is checked
                    //if (isSelected)
                    
                        int _itemID = Convert.ToInt32(row.Cells["Item_ID"].Value);
                        int reqQty = Convert.ToInt32(row.Cells["ReqQty"].Value);
                        decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                        decimal totalAmt = reqQty * unitPrice;

                        string insertDetailsQuery = "INSERT INTO MPO_Details (MPO_No,Item_ID,Req_Qty,Unit_Price,Total_AMT) " +
                                                    "VALUES (@MPO_No,@Item_ID,@Req_Qty,@Unit_Price,@Total_AMT)";

                        SqlCommand cmd2 = new SqlCommand(insertDetailsQuery, con, transaction);
                        cmd2.Parameters.AddWithValue("@MPO_No", mpoNo);
                        cmd2.Parameters.AddWithValue("@Item_ID", _itemID);
                        cmd2.Parameters.AddWithValue("@Req_Qty", reqQty);
                        cmd2.Parameters.AddWithValue("@Unit_Price", unitPrice);
                        cmd2.Parameters.AddWithValue("@Total_AMT", totalAmt);
                        cmd2.ExecuteNonQuery();
                        
                    
                }
                transaction.Commit();
                btnReset_Click(sender, e);
                
                MessageBox.Show("Data saved to database successfully.\nMPO No: " + mpoNo.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvmpodetails.Rows.Clear();

            }

            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show($"Error saving data to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            
        }

        private void chcModifyMpo_Click(object sender, EventArgs e)
        {
            if (chkModifyMpo.Checked == true)
            {
                txtMpoNo.Visible = false; cboMpoNo.Visible = true; cboMpoNo.Location = txtMpoNo.Location;
                GlobalInfo.GlobalInfo.combo_add(cboMpoNo, @"SELECT  MPO_No  FROM MPO_Master  where  Sent_for_Approval =0  order by MPO_No");
            }
            else { txtMpoNo.Visible = true; cboMpoNo.Visible = false; }
        }

        private void cboMpoNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMpoNo.Text = cboMpoNo.Text;
            if (txtMpoNo.Text == cboMpoNo.Text)
                try
                {

                    string _sqlQ = @"select * from MPO_Master where (MPO_No = N'" + cboMpoNo.Text + "') ";
                    DataTable _dt = GlobalInfo.GlobalInfo.getDataTable(_sqlQ);
                    if (_dt.Rows.Count > 0)
                    {
                        foreach (DataRow r in _dt.Rows)
                        {
                            cboSupplierName.Text = Convert.ToString(r["SupplierID"]).ToString();
                            dtMPODate.Text = Convert.ToDateTime(r["MPO_Date"]).ToString("dd-MMM-yyyy");
                            dtETDDATE.Text = Convert.ToDateTime(r["ETD_Date"]).ToString("dd-MMM-yyyy");
                            dtConEtddate.Text = Convert.ToDateTime(r["CON_ETDDate"]).ToString("dd-MMM-yyyy");
                            cboCurrency.Text = Convert.ToString(r["Currency"]).ToString();
                            cboDevMode.Text = Convert.ToString(r["Delv_Mode"]).ToString();
                            cboPayMode.Text = Convert.ToString(r["Pay_Mode"]).ToString();
                            btnSave.Text = "Update";
                            //cboSubgroup.Text = Convert.ToString(r["SubGroup_Name"]).ToString();
                            //cboItemCatagory.Text = Convert.ToString(r["Category_Name"]).ToString();
                        }
                        ItemEntrygridViewBind();

                    }
                    _dt.Dispose();
                }
                catch (Exception)
                {

                    throw;
                }
        }
        void _getTotal()
        {

            decimal _totalQTY = 0, _totalValue = 0;

            foreach (DataGridViewRow r in dgvmpodetails.Rows)
            {
                _totalQTY += Convert.ToDecimal(r.Cells[dgvmpodetails.Columns["ReqQty"].Index].Value);

                _totalValue += Convert.ToDecimal(r.Cells[dgvmpodetails.Columns["TotalAmt"].Index].Value);


            }

            lblQty.Text = _totalQTY.ToString(); lblvalue.Text = _totalValue.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a list to store the rows to be removed
                List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

                // Iterate through all rows
                foreach (DataGridViewRow row in dgvmpodetails.Rows)
                {
                    // Check if the cell in the "SelectColumnDetails" column is selected
                    DataGridViewCheckBoxCell chkCell = row.Cells["SelectColumnDetails"] as DataGridViewCheckBoxCell;
                    bool isSelected = Convert.ToBoolean(chkCell.Value);

                    if (isSelected)
                    {
                        // Add the row to the list for removal
                        rowsToRemove.Add(row);
                    }
                }

                // Remove the selected rows
                foreach (DataGridViewRow rowToRemove in rowsToRemove)
                {
                    dgvmpodetails.Rows.Remove(rowToRemove);
                }

                // Recalculate totals after removing rows
                _getTotal();
                btnReset_Click(sender, e);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void Headercheckbox(CheckBox HcheckBox)
        {
            isHeadercheckboxclicked = true;

            foreach (DataGridViewRow row in dgvmpodetails.Rows)
            {
                ((DataGridViewCheckBoxCell)row.Cells["SelectColumnDetails"]).Value = HcheckBox.Checked;
            }

            dgvmpodetails.EndEdit();
            isHeadercheckboxclicked = false;
        }

        private void chcAll_MouseClick(object sender, MouseEventArgs e)
        {
            Headercheckbox((CheckBox)sender);
        }
        private void Currency()
        {
            // Add fixed values to the ComboBox
            cboCurrency.Items.Add("US dollar");
            cboCurrency.Items.Add("Euro");
            cboCurrency.Items.Add("Yen");
            cboCurrency.Items.Add("Canadian dollar");
            cboCurrency.Items.Add("Pound");
            cboCurrency.Items.Add("Dinar");
            cboCurrency.Items.Add("Taka");
            cboCurrency.Items.Add("Chinese Yuan");
            cboCurrency.Items.Add("Ruble");

        }
        private void btnApproveToProcced_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string success = string.Empty;
            
            if (MessageBox.Show("Are you sure you want to proceed with this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                cmd.Transaction = trans;
                try
                {
                    string mpoNo = Convert.ToString(cboMpoNo.Text);
                    cmd.CommandText = @"UPDATE MPO_MASTER SET Sent_For_Approval = 1 WHERE MPO_No = @MPO_No";
                    cmd.Parameters.AddWithValue("@MPO_No", mpoNo);
                    cmd.ExecuteNonQuery();

                MessageBox.Show("Procced Successfully.", "Procced");
                success = "Saved";
                    trans.Commit();
                    btnReset_Click(sender, e);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                    Cursor = Cursors.Default;
                }
            
            

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            
            
            cboSupplierName.Text = string.Empty;
            cboSubgroup.Text = string.Empty;
            cboItemCatagory.Text = string.Empty;
            cboPayMode.Text = string.Empty;
            cboCurrency.Text = string.Empty;
            dtConEtddate.Text = string.Empty;
            dtETDDATE.Text = string.Empty;
            dtMPODate.Text = string.Empty;
           
            txtRate.Text = string.Empty;
            cboDevMode.Text = string.Empty;
            dgvmastermpo.DataSource = null;
            dgvmpodetails.DataSource = null;
            lblrow.Text = "0";
            lblRate.Text = "0";
            chcAll.Text = string.Empty;
            
            
            //if(cboMpoNo.Text != null)
            //{
            //    cboMpoNo.Text = null;
            //}

        }

        private void chcModifyMpo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void chcAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
