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
    public partial class GRNApproval1 : Form
    {
        DataTable dataItems = null;
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        string _AppLayer = "1";
        public GRNApproval1(string layer)
        {
            InitializeComponent();
            _AppLayer = layer;
        }

        private void GRNApproval1_Load(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.combo_add_with_Value(cboSupplierName, @"select S.SupplierID,s.CompanyName from Supplier_Info S inner join GRN_Master m on s.SupplierID = m.SupplierID where m.Sent_for_Approval =1 order by s.CompanyName");
            GlobalInfo.GlobalInfo.combo_add_with_Value(cboUsers, "SELECT UserID,UserName FROM User_Info ORDER BY UserName");
            ItemEntrygridViewBind();
        }
        private void ItemEntrygridViewBind()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {
                sqlQ = $"Exec sp_GetgrnPending2 '" + _AppLayer + "' ";
                dgvGRNAppPending.DataSource = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
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

        private void dgvGRNAppPending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                string _sql = "";

                if (dgvGRNAppPending.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvGRNAppPending.SelectedCells[0].RowIndex;

                    if (selectedRowIndex >= 0)
                    {
                        DataGridViewRow selectedRow = dgvGRNAppPending.Rows[selectedRowIndex];
                        cboSupplierName.Text = Convert.ToString(selectedRow.Cells["CompanyName"].Value);
                        txtGRNNO.Text = Convert.ToString(selectedRow.Cells["GRN_No"].Value);
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
					   Inner join GRN_Master GM on M.MPO_No = GM.MPO_No
LEFT JOIN (SELECT  D.Item_ID, SUM(D.GRN_Qty)GRN_Qty FROM  GRN_Details AS D INNER JOIN GRN_Master AS M ON D.GRN_No = M.GRN_No WHERE (D.GRN_No ='" + txtGRNNO.Text + "') group by D.Item_ID)GD ON gd.Item_ID=md.Item_ID WHERE GM.GRN_No = '" +txtGRNNO.Text + "'";
                    dgvGRNDetails.DataSource = GlobalInfo.GlobalInfo.getDataTable(_sql);

                }
                _sql = @"select m.MPO_Date, m.ETD_Date, m.CON_ETDDate, m.Currency, m.Rate_USD,m.Pay_Mode,m.PO_Type,m.Delv_Mode,gm.Invoice_No, gm.Invoice_Date, gm.Bill_No, gm.Remarks
from GRN_Master gm inner join MPO_Master m on gm.MPO_No =m.MPO_No";
                DataTable dt = GlobalInfo.GlobalInfo.getDataTable(_sql);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        dtMPODate.Text = Convert.ToString(r["MPO_Date"]);
                        dtETDDATE.Text = Convert.ToString(r["ETD_Date"]);
                        dtConEtddate.Text = Convert.ToString(r["CON_ETDDate"]);
                        cboCurrency.Text = Convert.ToString(r["Currency"]);
                        txtRate.Text = Convert.ToString(r["Rate_USD"]);
                        cboDevMode.Text = Convert.ToString(r["Delv_Mode"]);
                        cboPayMode.Text = Convert.ToString(r["Pay_Mode"]);
                        txtPOtype.Text = Convert.ToString(r["PO_Type"]);
                        //txtGRNNO.Text = Convert.ToString(r["GRN_No"]);
                        txtInvoiceNo.Text = Convert.ToString(r["Invoice_No"]);
                        dtInvoiceDate.Text = Convert.ToString(r["Invoice_Date"]);
                        txtBillNo.Text = Convert.ToString(r["Bill_No"]);
                        txtRemarks.Text = Convert.ToString(r["Remarks"]);
                    }
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
                txtGRNNO.Text = null;
                cboCurrency.Text = null;
                txtRate.Text = null;
                cboDevMode.Text = null;
                txtPOtype.Text = null;
                dtConEtddate.Text = null;
                dtETDDATE.Text = null;
                dtMPODate.Text = null;
                cboPayMode.Text = null;
                btnSearch_Click(sender, e);
                lblrow.Text = null;
                lblvalue.Text = null;
                lblQty.Text = null;
                txtInvoiceNo.Text = null;
                dtInvoiceDate.Text = null;
                txtBillNo.Text = null;
                txtRemarks.Text = null;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string success = string.Empty;
            if (MessageBox.Show("Are you sure to approve?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Cursor = Cursors.WaitCursor;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            SqlTransaction trans = con.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                if (_AppLayer == "1")
                    cmd.CommandText = @"UPDATE GRN_Master SET Approval1=1, Approval1_By='" + cboUsers.SelectedValue + "', Approval1_Date=getdate() WHERE GRN_No = @GRN_No";
                else if (_AppLayer == "2")
                    cmd.CommandText = @"UPDATE GRN_Master SET Approval2=1, Approval2_By='" + cboUsers.SelectedValue + "', Approval2_Date=getdate() WHERE GRN_No = @GRN_No";
                cmd.Parameters.AddWithValue("@GRN_No", txtGRNNO.Text);
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"exec sp_ItemStock '" + txtGRNNO.Text + "' ";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Approved Successfully", "Approved");
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
    }
}
