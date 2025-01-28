//using DevExpress.XtraReports.Design;
//using DevExpress.XtraSpreadsheet.Model;
using MAAQ_IMS.GlobalInfo;
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
    public partial class POApproval1 : Form
    {
        DataTable dataItems = null;
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        string _AppLayer = "1";
        
        public POApproval1(string layer)
        {
            InitializeComponent();
            _AppLayer = layer;
        }

        private void POApproval1_Load(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.combo_add_with_Value(cboSupplierName, @"select S.SupplierID,s.CompanyName from Supplier_Info S inner join MPO_Master m on s.SupplierID = m.SupplierID where m.Sent_for_Approval =1 order by s.CompanyName");
            GlobalInfo.GlobalInfo.combo_add_with_Value(cboUsers, "SELECT UserID,UserName FROM User_Info ORDER BY UserName");
            ItemEntrygridViewBind();
        }

        private void ItemEntrygridViewBind()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {
                sqlQ = $"Exec sp_Getpopending '"+ _AppLayer + "' ";
                dgvAppPending.DataSource = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
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

        private void dgvAppPending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                string _sql = "";

                if (dgvAppPending.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvAppPending.SelectedCells[0].RowIndex;

                    if (selectedRowIndex >= 0)
                    {
                        DataGridViewRow selectedRow = dgvAppPending.Rows[selectedRowIndex];
                        cboSupplierName.Text = Convert.ToString(selectedRow.Cells["CompanyName"].Value);
                        txtMPONO.Text = Convert.ToString(selectedRow.Cells["MPO_No"].Value);
                    }


                     _sql = @"SELECT IC.Category_Name, md.Item_ID, IE.Item_Article, NU.Unit_Name, NC.Color_Name, IE.Item_Size_Width, md.Req_Qty, md.Unit_Price, md.Total_AMT 
                       FROM MPO_Details AS md 
                       INNER JOIN New_Item_Entry IE ON IE.Item_ID = md.Item_ID 
                       INNER JOIN New_Item_SubGroup SG ON SG.SubGroup_ID = IE.SubGroup_ID
                       INNER JOIN New_Item_Category IC ON IE.Catagory_ID = IC.Category_ID 
                       INNER JOIN New_Unit_Info NU ON IE.Unit_ID = NU.Unit_ID 
                       INNER JOIN New_Color_Info NC ON IE.Color_ID = NC.Color_ID 
                       INNER JOIN MPO_Master M ON md.MPO_No = M.MPO_No
                       INNER JOIN Supplier_Info S ON M.SupplierID = S.SupplierID 
                       WHERE md.MPO_No = '" + txtMPONO.Text+"' ";
                    dgvMpoDetails.DataSource = GlobalInfo.GlobalInfo.getDataTable(_sql);
                     
                }
                 _sql = @"SELECT  MPO_Date, ETD_Date, CON_ETDDate, Currency, Rate_USD,Pay_Mode,PO_Type,Delv_Mode FROM MPO_Master";
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
                dgvMpoDetails.DataSource = null;
                cboSupplierName.Text = null;
                txtMPONO.Text = null;
                cboCurrency.Text = null;
                txtRate.Text = null;
                cboDevMode.Text = null;
                txtPOtype.Text = null;
                dtConEtddate.Text = null;
                dtETDDATE.Text = null;
                dtMPODate.Text = null;
                cboPayMode.Text= null;
                btnSearch_Click( sender,  e);
                lblrow.Text = null;
                lblvalue.Text = null;
                lblQty.Text = null;
               
            }
            catch(Exception ex)
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
            if( MessageBox.Show("Are you sure to approve?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)return;

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
                if(_AppLayer=="1")
                    cmd.CommandText = @"UPDATE MPO_MASTER SET Approval1=1, Approval1_By='"+cboUsers.SelectedValue+"', Approval1_Date=getdate() WHERE MPO_No = @MPO_No";
                else if (_AppLayer == "2")
                    cmd.CommandText = @"UPDATE MPO_MASTER SET Approval2=1, Approval2_By='" +cboUsers.SelectedValue + "', Approval2_Date=getdate() WHERE MPO_No = @MPO_No";
                cmd.Parameters.AddWithValue("@MPO_No", txtMPONO.Text);
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

        private void cboSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
