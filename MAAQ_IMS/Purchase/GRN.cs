//using DevExpress.XtraSpreadsheet.Model;
using MAAQ_IMS.Reports;
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
    public partial class GRN : Form
    {

        public GRN()
        {
            InitializeComponent();

        }



        private void GRN_Load(object sender, EventArgs e)
        {
            //GlobalInfo.GlobalInfo.combo_add_with_Value(cboSupplierName, "SELECT Supp_ID, Supplier_Name FROM [Supplier_Info] ORDER BY Supplier_Name");
            GlobalInfo.GlobalInfo.combo_add_with_Value(cboSupplierName, @"SELECT SupplierID, CompanyName FROM Supplier_Info ORDER BY CompanyName");
            ItemEntrygridViewBind();
            txtGrnNo.Text = GlobalInfo.GlobalInfo.GetMaxID("GRN_Master", "GRN_No").ToString();
            btnRefresh_Click(sender, e);
        }

        private void ItemEntrygridViewBind()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {
                string _suppID = "0";
                if(cboSupplierName.Text.Trim().Length>0) _suppID = Convert.ToString(cboSupplierName.SelectedValue);
                sqlQ = $"Exec sp_GetgrnPending   "+ _suppID;
                dgvGRNpandding.DataSource = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
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

        private void dgvGRNpandding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                int selectedRowCount = 0;
                string _sql = "";

                if (dgvGRNpandding.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvGRNpandding.SelectedCells[0].RowIndex;

                    if (selectedRowIndex >= 0)
                    {
                        DataGridViewRow selectedRow = dgvGRNpandding.Rows[selectedRowIndex];
                        cboSupplierName.Text = Convert.ToString(selectedRow.Cells["CompanyName"].Value);
                        txtMPONO.Text = Convert.ToString(selectedRow.Cells["MPO_No"].Value);
                    }


                    _sql = @"SELECT IC.Category_Name, md.Item_ID,IE.Item_Name, IE.Item_Article, NU.Unit_Name, NC.Color_Name, IE.Item_Size_Width, md.Req_Qty, md.Unit_Price,isnull(GRN_Qty,0) AlreadyRcvd,md.Req_Qty-isnull(GRN_Qty,0) BalanceRcvd, md.Total_AMT 
                       FROM MPO_Details AS md 
                       INNER JOIN New_Item_Entry IE ON IE.Item_ID = md.Item_ID 
                       INNER JOIN New_Item_SubGroup SG ON SG.SubGroup_ID = IE.SubGroup_ID
                       INNER JOIN New_Item_Category IC ON IE.Catagory_ID = IC.Category_ID 
                       INNER JOIN New_Unit_Info NU ON IE.Unit_ID = NU.Unit_ID 
                       INNER JOIN New_Color_Info NC ON IE.Color_ID = NC.Color_ID 
                       INNER JOIN MPO_Master M ON md.MPO_No = M.MPO_No
                       INNER JOIN Supplier_Info S ON M.SupplierID = S.SupplierID 
LEFT JOIN (SELECT  D.Item_ID, SUM(D.GRN_Qty)GRN_Qty 
FROM            GRN_Details AS D INNER JOIN
                         GRN_Master AS M ON D.GRN_No = M.GRN_No
WHERE        (M.MPO_No = '" + txtMPONO.Text + "') group by D.Item_ID)GD ON gd.Item_ID=md.Item_ID " +
" WHERE md.MPO_No = '" + txtMPONO.Text + "' ";

                    DataTable dtt = GlobalInfo.GlobalInfo.getDataTable(_sql);
                    dgvGRNDetails.Rows.Clear();
                    if (dtt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtt.Rows)
                        {
                            dgvGRNDetails.Rows.Add(dr["Category_Name"], dr["Item_ID"], dr["Item_Name"], dr["Item_Article"], dr["Color_Name"], dr["Item_Size_Width"], dr["Unit_Name"], dr["Unit_Price"], dr["Req_Qty"], dr["AlreadyRcvd"], dr["BalanceRcvd"], 0, 0);
                            selectedRowCount++;
                        }
                    }
                    //dgvGRNDetails.Columns["Total_AMT"].DataPropertyName = "Total_AMT";


                }
                _sql = @"SELECT  MPO_Date, ETD_Date, CON_ETDDate, Currency, Rate_USD,Pay_Mode,PO_Type,Delv_Mode FROM MPO_Master";
                DataTable dt = GlobalInfo.GlobalInfo.getDataTable(_sql);
                if (dt.Rows.Count > 0)
                {
                   
                    foreach (DataRow r in dt.Rows)
                    {
                        txtMPODate.Text = Convert.ToDateTime(r["MPO_Date"]).ToString("dd-MMM-yyyy");
                        txtETDdate.Text = Convert.ToDateTime(r["ETD_Date"]).ToString("dd-MMM-yyyy");
                        txtConEtddate.Text = Convert.ToDateTime(r["CON_ETDDate"]).ToString("dd-MMM-yyyy");
                        cboCurrency.Text = Convert.ToString(r["Currency"]);
                        txtRate.Text = Convert.ToString(r["Rate_USD"]);
                        cboDevMode.Text = Convert.ToString(r["Delv_Mode"]);
                        cboPayMode.Text = Convert.ToString(r["Pay_Mode"]);
                        txtPOtype.Text = Convert.ToString(r["PO_Type"]);
                       
                    }
                    lblrow.Text = $"{selectedRowCount}";
                }
                else
                {
                    MessageBox.Show("No cell selected in dgvAppPending.");
                }

               
                dt.Dispose();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ItemEntrygridViewBind();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                dgvGRNDetails.DataSource = null;
                cboSupplierName.Text = null;
                txtMPONO.Text = null;
                cboCurrency.Text = null;
                txtRate.Text = null;
                cboDevMode.Text = null;
                txtPOtype.Text = null;
                txtConEtddate.Text = null;
                txtETDdate.Text = null;
                txtMPODate.Text = null;
                cboPayMode.Text = null;
                btnSearch_Click(sender, e);
                dgvGRNDetails.DataSource= null;
                txtInvoiceNo.Text = null;
                dtInvoiceDate.Text = null;
                txtBillNo.Text = null;
                txtRemarks.Text = null;
                //lblrow.Text = null;
                //lblvalue.Text = null;
                //lblQty.Text = null;

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

        private void dgvGRNDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 
            try
            {
                DataGridViewRow row = dgvGRNDetails.Rows[e.RowIndex];
                if (e.ColumnIndex == dgvGRNDetails.Columns["GRN_Qty"].Index  )
                {
                        // Calculate TotalAmt when ReqQty or UnitPrice is edited
                         
                        decimal unitPrice = Convert.ToDecimal(row.Cells["Unit_Price"].Value),
                        _balQty= Convert.ToDecimal(row.Cells[txtGridBalance.Index].Value),
                        _grnQty= Convert.ToDecimal(row.Cells["GRN_Qty"].Value);
                    if (_grnQty > _balQty) _grnQty = _balQty;
                        decimal totalAmt = _grnQty * unitPrice;
                    row.Cells["GRN_Qty"].Value = _grnQty;
                    row.Cells["GRNValue"].Value = totalAmt;
                    
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

            decimal _totalagrnQTY = 0, _totalGrnValue = 0; decimal _totalbalance = 0;
            decimal _totalbalancevalue = 0; decimal totalunitprice = 0;

            foreach (DataGridViewRow r in dgvGRNDetails.Rows)
            {
                _totalagrnQTY += Convert.ToDecimal(r.Cells[dgvGRNDetails.Columns["GRN_Qty"].Index].Value);

                _totalGrnValue += Convert.ToDecimal(r.Cells[dgvGRNDetails.Columns["GRNValue"].Index].Value);
                _totalbalance += Convert.ToDecimal(r.Cells[dgvGRNDetails.Columns["txtGridBalance"].Index].Value);
                totalunitprice = Convert.ToDecimal(r.Cells[dgvGRNDetails.Columns["Unit_Price"].Index].Value);
                _totalbalancevalue = _totalbalance * totalunitprice;
            }

            lblGrnQty.Text = _totalagrnQTY.ToString();
            lblGrnValue.Text = _totalGrnValue.ToString();
            lblBalQty.Text = _totalbalance.ToString();
            lblBalValue.Text = _totalbalancevalue.ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string mpoMasterQuery = string.Empty;
            if (MessageBox.Show("Are you sure you want to Save with this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var grnNo = GlobalInfo.GlobalInfo.GetMaxID("GRN_Master", "GRN_No").ToString();
            SqlConnection con = new SqlConnection(GlobalInfo.ConnectionInfo.GenerateConnectionString());
            SqlCommand cmd = null;
            con.Open();
            SqlTransaction transaction = null;

            try
            {
               
                transaction = con.BeginTransaction();
                this.Cursor = Cursors.WaitCursor;
                cmd = new SqlCommand();
                cmd.Transaction = transaction;
                if (btnSave.Text != "Update")
                {
                    cmd.Connection = con; 
                    cmd.CommandText = @"INSERT INTO GRN_Master (GRN_No,MPO_No,SupplierID,Invoice_No, Invoice_Date,Bill_No,Remarks) values ('" + grnNo + "','" + txtMPONO.Text + "','" + cboSupplierName.SelectedValue + "','" + txtInvoiceNo.Text + "','" + dtInvoiceDate.Text + "','" + txtBillNo.Text + "','" + txtRemarks.Text + "')";
                    cmd.ExecuteNonQuery();

                    
                }
                
                foreach (DataGridViewRow row in dgvGRNDetails.Rows)
                {
                    if (!row.IsNewRow) 
                    {
                        int itemIDColumnIndex = dgvGRNDetails.Columns["Item_ID"].Index; 
                        int grnQtyColumnIndex = dgvGRNDetails.Columns["GRN_Qty"].Index; 
                        int unitPriceColumnIndex = dgvGRNDetails.Columns["Unit_Price"].Index; 

                        int Item_ID = Convert.ToInt32(row.Cells[itemIDColumnIndex].Value);
                        int GRN_Qty = Convert.ToInt32(row.Cells[grnQtyColumnIndex].Value);
                        decimal Unit_Price = Convert.ToDecimal(row.Cells[unitPriceColumnIndex].Value);

                        string insertDetailsQuery = @"INSERT INTO GRN_Details (GRN_No, Item_ID, GRN_Qty, Unit_Price)
                                      VALUES (@GRN_No, @Item_ID, @GRN_Qty, @Unit_Price)";

                        using (SqlCommand cmd2 = new SqlCommand(insertDetailsQuery, con, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@GRN_No", grnNo);
                            cmd2.Parameters.AddWithValue("@Item_ID", Item_ID);
                            cmd2.Parameters.AddWithValue("@GRN_Qty", GRN_Qty);
                            cmd2.Parameters.AddWithValue("@Unit_Price", Unit_Price);

                            cmd2.ExecuteNonQuery();
                        }
                    }
                   
                }
                transaction.Commit();
                MessageBox.Show("Data Saved successfully.");

            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                if (cmd != null)
                {
                    cmd.Dispose(); 
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void dgvGRNDetails_KeyDown(object sender, KeyEventArgs e)
        {
        //    if (e.KeyCode == Keys.Tab)
        //    {

        //        CalculateTotalAmount();
        //    }
        }

        private void CalculateTotalAmount()
        {
        //    foreach (DataGridViewRow row in dgvGRNDetails.Rows)
        //    {
        //        // Check if the ReqQty and Unit_Price columns exist
        //        if (row.Cells["ReqQty"].Value != null && row.Cells["Unit_Price"].Value != null)
        //        {
        //            string reqQty = row.Cells["ReqQty"].Value.ToString();
        //            string unitPrice = row.Cells["Unit_Price"].Value.ToString();

        //            // Calculate Total_AMT by multiplying ReqQty and Unit_Price
        //            double totalAmt = Convert.ToDouble(reqQty) * Convert.ToDouble(unitPrice);

        //            // Update the Total_AMT column in the current row
        //            row.Cells["GRN VALUE"].Value = totalAmt;
        //        }
        //        else
        //        {
        //            // Handle the case where the columns are not found
        //            MessageBox.Show("Error: Columns ReqQty or Unit_Price not found.");
        //        }
        //    }
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                string grnNo = Convert.ToString(txtGrnNo.Text);

                cmd.CommandText = @"UPDATE GRN_Master set Sent_for_Approval=1 WHERE GRN_No = @GRN_No";
                cmd.Parameters.AddWithValue("@GRN_No", grnNo);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Procced Successfully.", "Procced");
                success = "Saved";
                trans.Commit();
                btnRefresh_Click(sender, e);
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

        

        

        private void cboGRNno_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void chkModify_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkModify.Checked == true)
            {
                txtGrnNo.Visible = false; cboGRNno.Visible = true; cboGRNno.Location = txtGrnNo.Location;
                GlobalInfo.GlobalInfo.combo_add(cboGRNno, @"select GRN_No from GRN_Master where Sent_for_Approval = 0 order by GRN_No");
            }
            else { txtGrnNo.Visible = true; cboGRNno.Visible = false; }
        }

        private void cboGRNno_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtGrnNo.Text = cboGRNno.Text;
            if (txtGrnNo.Text == cboGRNno.Text)
                try
                {

                    string _sqlQ = @"select gm.GRN_No,m.MPO_No,s.CompanyName, gm.Invoice_No, gm.Invoice_Date, gm.Bill_No, gm.Remarks,MPO_Date,m.ETD_Date, m.CON_ETDDate,m.Currency,m.Rate_USD,m.Delv_Mode,m.Pay_Mode,m.PO_Type  from GRN_Master as GM 
inner join MPO_Master m on gm.MPO_No = m.MPO_No
inner join Supplier_Info s on gm.SupplierID = s.SupplierID where (gm.GRN_No = N'" + cboGRNno.Text + "')";
                    DataTable _dt = GlobalInfo.GlobalInfo.getDataTable(_sqlQ);
                    if (_dt.Rows.Count > 0)
                    {
                        foreach (DataRow r in _dt.Rows)
                        {
                            txtGrnNo.Text = Convert.ToString(r["GRN_No"]).ToString();
                            txtMPONO.Text = Convert.ToString(r["MPO_No"]).ToString();
                            cboSupplierName.Text = Convert.ToString(r["CompanyName"]).ToString();
                            txtInvoiceNo.Text = Convert.ToInt32(r["Invoice_No"]).ToString();
                            dtInvoiceDate.Text = Convert.ToDateTime(r["Invoice_Date"]).ToString();
                            txtBillNo.Text = Convert.ToString(r["Bill_No"]).ToString();
                            txtRemarks.Text = Convert.ToString(r["Remarks"]).ToString();
                            txtMPODate.Text = Convert.ToDateTime(r["MPO_Date"]).ToString("dd-MMM-yyyy");
                            txtETDdate.Text = Convert.ToDateTime(r["ETD_Date"]).ToString("dd-MMM-yyyy");
                            txtConEtddate.Text = Convert.ToDateTime(r["CON_ETDDate"]).ToString("dd-MMM-yyyy");
                            cboCurrency.Text = Convert.ToString(r["Currency"]).ToString();
                            cboDevMode.Text = Convert.ToString(r["Delv_Mode"]).ToString();
                            cboPayMode.Text = Convert.ToString(r["Pay_Mode"]).ToString();
                            btnSave.Text = "Update";
                            //cboSubgroup.Text = Convert.ToString(r["SubGroup_Name"]).ToString();
                            //cboItemCatagory.Text = Convert.ToString(r["Category_Name"]).ToString();
                        }
                        _sqlQ = @"
SELECT IC.Category_Name, md.Item_ID,IE.Item_Name, IE.Item_Article, NU.Unit_Name, NC.Color_Name, IE.Item_Size_Width, md.Req_Qty, md.Unit_Price,isnull(GRN_Qty,0) AlreadyRcvd,md.Req_Qty-isnull(GRN_Qty,0) BalanceRcvd, md.Total_AMT 
                       FROM MPO_Details AS md 
                       INNER JOIN New_Item_Entry IE ON IE.Item_ID = md.Item_ID 
                       INNER JOIN New_Item_SubGroup SG ON SG.SubGroup_ID = IE.SubGroup_ID
                       INNER JOIN New_Item_Category IC ON IE.Catagory_ID = IC.Category_ID 
                       INNER JOIN New_Unit_Info NU ON IE.Unit_ID = NU.Unit_ID 
                       INNER JOIN New_Color_Info NC ON IE.Color_ID = NC.Color_ID 
                       INNER JOIN MPO_Master M ON md.MPO_No = M.MPO_No
                       INNER JOIN Supplier_Info S ON M.SupplierID = S.SupplierID 
LEFT JOIN (SELECT  D.Item_ID, SUM(D.GRN_Qty)GRN_Qty 
FROM            GRN_Details AS D INNER JOIN
                         GRN_Master AS M ON D.GRN_No = M.GRN_No
WHERE        (M.MPO_No = '" + txtMPONO.Text + "') group by D.Item_ID)GD ON gd.Item_ID=md.Item_ID " +
" WHERE md.MPO_No = '" + txtMPONO.Text + "' ";

                        DataTable dtt = GlobalInfo.GlobalInfo.getDataTable(_sqlQ);
                        dgvGRNDetails.Rows.Clear();
                        if (dtt.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dtt.Rows)
                            {
                                dgvGRNDetails.Rows.Add(dr["Category_Name"], dr["Item_ID"], dr["Item_Name"], dr["Item_Article"], dr["Color_Name"], dr["Item_Size_Width"], dr["Unit_Name"], dr["Unit_Price"], dr["Req_Qty"], dr["AlreadyRcvd"], dr["BalanceRcvd"], 0, 0);
                                
                            }
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportShow R1 = new frmReportShow();
                R1.Show();
                using (SqlConnection con = new SqlConnection(GlobalInfo.ConnectionInfo.GenerateConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"Exec sp_rptGRN  '" + txtMPONO.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, cmd.CommandText);
                    CryRptGRN cry = new CryRptGRN();
                    cry.SetDataSource(ds.Tables[0]);
                    //R1.crystalReportViewer1.ReportSource = cry;
                    //R1.crystalReportViewer1.Refresh();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvGRNDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
