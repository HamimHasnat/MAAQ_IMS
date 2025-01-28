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
    public partial class Item_Issue : Form
    {
        DataTable dataItems = null;
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        private DataGridViewCheckBoxColumn selectColumn;
        private const string SELECT_COLUMN_NAME = "SelectColumn";
        CheckBox headerbox = null;
        bool isHeadercheckboxclicked = false;
        public Item_Issue()
        {
            InitializeComponent();
        }

        private void Item_Issue_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                GlobalInfo.GlobalInfo.PopulateCombobox(cboDepartment, "Dept_ID", "Dept_Name", "New_Department", "Dept_Name");
                //GlobalInfo.GlobalInfo.combo_add_with_Value(cboDepartment, "select Dept_ID,Dept_Name from New_Department order by Dept_Name");
                GlobalInfo.GlobalInfo.PopulateCombobox(cboSubgroup, "SubGroup_ID", "SubGroup_Name", "New_Item_SubGroup", "SubGroup_Name");
                cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;
                cboSubgroup.SelectedIndexChanged += cboSubgroup_SelectedIndexChanged;
                dgvmasterIssue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //btnRemove.Click += btnRemove_Click;
                txtIssueID.Text = GlobalInfo.GlobalInfo.GetMaxID("Issue_Master", "Issue_ID").ToString();
                addDetails();


                dgvmasterIssue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //btnRemove.Click += btnRemove_Click;
                btnReset_Click(sender, e);
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
                SqlCommand cmd = new SqlCommand("Select ISNULL(MAX(Issue_ID),0)+1 As MPO_No from  Issue_Master", conn);
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

                sqlQ = $"Exec sp_GetItemDetails '" + cboIssueID.Text + "'";

                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dgvIssuedetails.Columns.Clear();

                //dgvmastermpo.Rows.Clear();
                dgvIssuedetails.DataSource = dataItems;
                foreach (DataGridViewColumn c in dgvmasterIssue.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Action";
                checkBoxColumn.Width = 30;
                checkBoxColumn.Name = "SelectColumnDetails";
                dgvIssuedetails.Columns.Insert(0, checkBoxColumn);
                dgvIssuedetails.AllowUserToAddRows = false;


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

        private void btnReset_Click(object sender, EventArgs e)
        {

            cboSubgroup.Text = string.Empty;
            cboItemCatagory.Text = string.Empty;
            cboDepartment.Text = string.Empty;
            cboSection.Text = string.Empty;
            dtpIssueDate.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            dgvmasterIssue.DataSource = null;
            dgvIssuedetails.DataSource = null;
            lblrow.Text = "0";

            //chcAll.Text = string.Empty;
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboDepartment.SelectedItem != null)
                {
                    DataRowView selectedRow = (DataRowView)cboDepartment.SelectedItem;

                    if (selectedRow != null)
                    {
                        int selectedDepartmentId = Convert.ToInt32(selectedRow["Dept_ID"]);

                        string query = $"SELECT Sec_ID,Sec_Name FROM New_Section NS inner join New_Department ND on NS.Dept_ID=ND.Dept_ID WHERE ND.Dept_ID ='{selectedDepartmentId}' ORDER BY Sec_Name";

                        GlobalInfo.GlobalInfo.combo_add_with_Value(cboSection, query);
                        //dgvmastermpo.AllowUserToAddRows = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        dgvmasterIssue.AllowUserToAddRows = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = 0;
                bool flag = false;

                foreach (DataGridViewRow row in dgvmasterIssue.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["selectColumn"].Value);

                    if (isSelected)
                    {
                        DataRowView dataRowView = (DataRowView)row.DataBoundItem;
                        if (dataRowView != null)
                        {
                            DataRow dataRow = dataRowView.Row;

                            string itemid = dataRow["Item_ID"].ToString();
                            string grnno1 = dataRow["GRN_No"].ToString();

                            // Check if the itemNo is already in dgvmpodetails
                            bool isDuplicate = dgvIssuedetails.Rows.Cast<DataGridViewRow>().Any(detailRow =>
                                itemid == detailRow.Cells["Item_ID"].Value?.ToString() &&
                            grnno1 == detailRow.Cells["GRN_No"].Value?.ToString());

                            if (!isDuplicate)
                            {
                                string subGroupName = dataRow["SubGroup_Name"].ToString();
                                string categoryName = dataRow["Category_Name"].ToString();
                                string Item_ID = dataRow["Item_ID"].ToString();
                                string itemArticle = dataRow["Item_Article"].ToString();
                                string unitName = dataRow["Unit_Name"].ToString();
                                string colorName = dataRow["Color_Name"].ToString();
                                string itemSizeWidth = dataRow["Item_Size_Width"].ToString();
                                decimal unitPrice = Convert.ToDecimal(dataRow["Item_Unit_Prize"]);
                                string grnno = dataRow["GRN_No"].ToString();
                                decimal currentStock = Convert.ToDecimal(dataRow["CurrentStock"]);

                                //decimal totalissuePrice = Convert.ToDecimal(unitPrice* currentStock);

                                // Add a new row to dgvdetails
                                dgvIssuedetails.Rows.Add(subGroupName, categoryName, Item_ID, itemArticle, unitName, colorName, itemSizeWidth, unitPrice, grnno, currentStock);
                                dgvIssuedetails.AllowUserToAddRows = false;
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
                    dgvmasterIssue.Columns.Add(selectColumn);// Insert as the first column
                }

                string selectedCategory = cboItemCatagory.SelectedItem.ToString();

                // Assuming that you have a column named Category_Name in the New_Item_Category table
                // Adjust the column names accordingly based on your database structure
                /*  sqlQ = $"SELECT SG.SubGroup_Name,IC.Category_Name,IE.Item_ID,IE.Item_Article,NU.Unit_Name,NC.Color_Name,IE.Item_Size_Width,IE.Item_Unit_Prize,gm.GRN_Qty as CurrentStock,s.GRN_No FROM New_Item_Entry IE Inner join New_Item_SubGroup SG on IE.SubGroup_ID = SG.SubGroup_ID Inner join New_Item_Category IC on IE.Catagory_ID = IC.Category_ID Inner join New_Unit_Info NU on IE.Unit_ID = NU.Unit_ID Inner join New_Color_Info NC on IE.Color_ID = NC.Color_ID inner join Item_Stock s on ie.Item_ID = s.Item_ID Inner join GRN_Details gm on IE.Item_ID = gm.Item_ID  WHERE Category_Name = '{selectedCategory}'"; */

                sqlQ = $"Select isg.SubGroup_Name,nic.Category_Name,nie.Item_ID,nie.Item_Article,nui.Unit_Name,nci.Color_Name,nie.Item_Size_Width,nie.Item_Unit_Prize,  gd.GRN_No , gd.GRN_Qty as CurrentStock  from New_Item_SubGroup isg inner join New_Item_Category nic on isg.Group_ID = nic.Group_ID and isg.SubGroup_ID = nic.SubGroup_ID inner join New_Item_Entry nie on nie.Group_ID = nic.Group_ID and nie.SubGroup_ID = isg.SubGroup_ID and nie.Catagory_ID = nic.Category_ID inner join New_Unit_Info nui on nie.Unit_ID = nui.Unit_ID inner join New_Color_Info nci on nie.Color_ID = nci.Color_ID inner join GRN_Details gd on nie.Item_ID = gd.Item_ID  WHERE Category_Name = '{selectedCategory}'";

                dgvmasterIssue.DataSource = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dgvmasterIssue.AllowUserToAddRows = false;

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
            dgvIssuedetails.Columns.Add("SubGroup", "SubGroup");
            dgvIssuedetails.Columns.Add("Category", "Category_Name");
            dgvIssuedetails.Columns.Add("Item_ID", "Item_ID");
            dgvIssuedetails.Columns.Add("ItemArticle", "Item Article");
            dgvIssuedetails.Columns.Add("Unit_Name", "Unit_Name");
            dgvIssuedetails.Columns.Add("Color_Name", "Color_Name");
            dgvIssuedetails.Columns.Add("ItemSizeWidth", "Item Size Width");
            dgvIssuedetails.Columns.Add("UnitPrice", "Unit Price");
            dgvIssuedetails.Columns.Add("GRN_No", "GRN No");
            dgvIssuedetails.Columns.Add("CurrentStock", "Current Stock");

            dgvIssuedetails.Columns.Add("Issue_Qty", "Issue_Qty");
            dgvIssuedetails.Columns.Add("Total_Issue_Price", "Total Issue Price");
            // Set specific column properties if needed, e.g., make Req.QTY and Unit Price editable
            dgvIssuedetails.Columns["Issue_Qty"].DefaultCellStyle.NullValue = "0";
            dgvIssuedetails.Columns["Total_Issue_Price"].DefaultCellStyle.NullValue = "0";
            dgvIssuedetails.Columns["Issue_Qty"].ReadOnly = false;
            dgvIssuedetails.Columns["Total_Issue_Price"].ReadOnly = false;
            //dgvIssuedetails.CellEndEdit += dgvIssuedetails_CellEndEdit;
            //DataGridViewCheckBoxColumn selectColumnDetails = new DataGridViewCheckBoxColumn();
            //selectColumnDetails.HeaderText = "Select";
            //selectColumnDetails.Name = "SelectColumnDetails";
            //// Add the "Select" column to the beginning of the Columns collection
            //dgvIssuedetails.Columns.Insert(0, selectColumnDetails);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string issuemasterQuery = string.Empty, deleteQuery = string.Empty;
            var issueid = GenerateAutompoNo();
            SqlConnection con = new SqlConnection(GlobalInfo.ConnectionInfo.GenerateConnectionString());
            SqlCommand cmd = null;
            con.Open();

            SqlTransaction transaction = null;

            try
            {
                transaction = con.BeginTransaction();

                //if (chcModifyIssue.Checked == true)

                //    issuemasterQuery = "UPDATE Issue_Master SET Issue_Date=@Issue_Date, Dept_ID=@Dept_ID, Sec_ID = @Sec_ID, Remarks = @Remarks WHERE Issue_ID = @Issue_ID";
                //    issueid = Convert.ToInt32(txtIssueID.Text);

                //    deleteQuery = "DELETE FROM Issue_Details WHERE Issue_ID = @Issue_ID";
                //    cmd = new SqlCommand(deleteQuery, con, transaction);
                //    cmd.Parameters.AddWithValue("@Issue_ID", issueid);
                //cmd.ExecuteNonQuery();

                //else
                //{
                //    issuemasterQuery = "INSERT INTO Issue_Master (Issue_ID,Issue_Date,Dept_ID,Sec_ID,Remarks) VALUES(@Issue_ID, @Issue_Date, @Dept_ID, @Sec_ID, @Remarks) ";
                //}


                issuemasterQuery = "INSERT INTO Issue_Master (Issue_ID,Issue_Date,Dept_ID,Sec_ID,Remarks) VALUES(@Issue_ID, @Issue_Date, @Dept_ID, @Sec_ID, @Remarks) ";

                cmd = new SqlCommand(issuemasterQuery, con, transaction);
                cmd.Parameters.AddWithValue("@Issue_ID", issueid);
                cmd.Parameters.AddWithValue("@Issue_Date", Convert.ToDateTime(dtpIssueDate.Text.Trim()));
                cmd.Parameters.AddWithValue("@Dept_ID", Convert.ToInt32(cboDepartment.SelectedValue));
                cmd.Parameters.AddWithValue("@Sec_ID", Convert.ToInt32(cboSection.SelectedValue));
                cmd.Parameters.AddWithValue("@Remarks", Convert.ToString(txtRemarks.Text));

                cmd.ExecuteNonQuery();

                foreach (DataGridViewRow row in dgvIssuedetails.Rows)
                {
                    //bool isSelected = Convert.ToBoolean(row.Cells["SelectColumnDetails"].Value);
                    // Check if the checkbox cell exists and is checked
                    //if (isSelected)

                    int _itemID = Convert.ToInt32(row.Cells["Item_ID"].Value);
                    int issueqty = Convert.ToInt32(row.Cells["Issue_Qty"].Value);
                    int _grnno = Convert.ToInt32(row.Cells["GRN_No"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    decimal totalissueAmt = Convert.ToDecimal(row.Cells["Total_Issue_Price"].Value);



                    string insertDetailsQuery = "insert into Issue_Details (Item_ID,Issue_ID,Unit_Price,GRN_No,Issue_Qty,Total_Issue_Price)values(@Item_ID, @Issue_ID, @Unit_Price, @GRN_No, @Issue_Qty, @Total_Issue_Price)";

                    SqlCommand cmd2 = new SqlCommand(insertDetailsQuery, con, transaction);
                    cmd2.Parameters.AddWithValue("@Item_ID", _itemID);
                    cmd2.Parameters.AddWithValue("@Issue_ID", issueid);

                    cmd2.Parameters.AddWithValue("@Issue_Qty", issueqty);
                    cmd2.Parameters.AddWithValue("@Unit_Price", unitPrice);
                    cmd2.Parameters.AddWithValue("@GRN_No", _grnno);
                    cmd2.Parameters.AddWithValue("@Total_Issue_Price", totalissueAmt);
                    cmd2.ExecuteNonQuery();

                    cmd2.CommandText = @"exec sp_Update_Issue_Stock  " + issueid;
                    cmd2.ExecuteNonQuery();



                }
                transaction.Commit();
                btnReset_Click(sender, e);

                MessageBox.Show("Data saved to database successfully.\nMPO No: " + issueid.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvIssuedetails.Rows.Clear();

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

        private void cboIssueID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIssueID.Text = cboIssueID.Text;
            if (txtIssueID.Text == cboIssueID.Text)
                try
                {

                    string _sqlQ = @"select Issue_ID,Issue_Date,Dept_ID,Sec_ID,Remarks from Issue_Master where (Issue_ID = N'" + cboIssueID.Text + "') ";
                    DataTable _dt = GlobalInfo.GlobalInfo.getDataTable(_sqlQ);
                    if (_dt.Rows.Count > 0)
                    {
                        foreach (DataRow r in _dt.Rows)
                        {
                            cboIssueID.Text = Convert.ToString(r["Issue_ID"]).ToString();
                            dtpIssueDate.Text = Convert.ToDateTime(r["Issue_Date"]).ToString("dd-MMM-yyyy");
                            cboDepartment.Text = Convert.ToString(r["Dept_ID"]).ToString();

                            cboSection.Text = Convert.ToString(r["Sec_ID"]).ToString();
                            txtRemarks.Text = Convert.ToString(r["Remarks"]).ToString();
                            //cboPayMode.Text = Convert.ToString(r["Pay_Mode"]).ToString();
                            btnSave.Text = "Update";
                            //cboSubgroup.Text = Convert.ToString(r["SubGroup_Name"]).ToString();
                            //cboItemCatagory.Text = Convert.ToString(r["Category_Name"]).ToString();
                        }
                        //ItemEntrygridViewBind();

                    }
                    _dt.Dispose();
                }
                catch (Exception)
                {

                    throw;
                }
        }

        private void dgvIssuedetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {

                CalculateTotalAmount();
            }
        }
        private void CalculateTotalAmount()
        {
            // Iterate through each row in dgvmpodetails
            foreach (DataGridViewRow row in dgvIssuedetails.Rows)
            {
                // Check if the ReqQty and Unit_Price columns exist
                if (row.Cells["Issue_Qty"].Value != null && row.Cells["Unit_Price"].Value != null)
                {
                    string issueQty = row.Cells["Issue_Qty"].Value.ToString();
                    string unitPrice = row.Cells["Unit_Price"].Value.ToString();

                    // Calculate Total_AMT by multiplying ReqQty and Unit_Price
                    double totalAmt = Convert.ToDouble(issueQty) * Convert.ToDouble(unitPrice);

                    // Update the Total_AMT column in the current row
                    row.Cells["Total_Issue_Price"].Value = totalAmt;
                }
                else
                {
                    // Handle the case where the columns are not found
                    MessageBox.Show("Error: Columns ReqQty or Unit_Price not found.");
                }
            }
        }

        private void dgvIssuedetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {

                DataGridViewRow row = dgvIssuedetails.Rows[e.RowIndex];
                if (e.ColumnIndex == dgvIssuedetails.Columns["Issue_Qty"].Index)
                {
                    decimal issueQty = Convert.ToInt32(row.Cells["Issue_Qty"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    decimal currenstock = Convert.ToDecimal(row.Cells["CurrentStock"].Value
                        );
                    if (currenstock < issueQty) issueQty = currenstock;
                    {
                        decimal totalAmt = issueQty * unitPrice;
                        row.Cells["Issue_Qty"].Value = issueQty;
                        row.Cells["Total_Issue_Price"].Value = totalAmt;
                    }
                }
                _getTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void _getTotal()
        {

            decimal _totalissueQTY = 0, totalAmt = 0;

            foreach (DataGridViewRow r in dgvIssuedetails.Rows)
            {
                _totalissueQTY += Convert.ToDecimal(r.Cells[dgvIssuedetails.Columns["Issue_Qty"].Index].Value);

                totalAmt += Convert.ToDecimal(r.Cells[dgvIssuedetails.Columns["Total_Issue_Price"].Index].Value);


            }

            lblIssueQty.Text = _totalissueQTY.ToString(); lblIssuePrice.Text = totalAmt.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a list to store the rows to be removed
                List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

                // Iterate through all rows
                foreach (DataGridViewRow row in dgvIssuedetails.Rows)
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
                    dgvIssuedetails.Rows.Remove(rowToRemove);
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

    }
}