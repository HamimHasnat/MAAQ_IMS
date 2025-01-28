using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAAQ_IMS.Report
{
    public partial class mpo : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        DataTable dataItems = null;
        public mpo()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string _sql = "", _wc = "";
                if (cboSupplierName.Text.Length > 0) _wc += " and (M.Supp_ID='" + cboSupplierName.SelectedValue + "')";
                //if (chkPoDate.Checked == true) _wc += " and (M.MPO_Date  between '" + dtFrom.Text + "' and '" + dtTo.Text + "')";
                if (txtSearch.Text.Length > 0) _wc += " and (M.MPO_No='" + txtSearch.Text + "')";
                _sql = @"SELECT M.MPO_No, S.Supplier_Name, M.MPO_Date, M.ETD_Date, M.CON_ETDDate, M.Currency, M.Delv_Mode, M.Pay_Mode, M.PO_Type, SUM(D.Req_Qty) AS MPO_Qty, SUM(D.Total_AMT) AS MPO_Value, Sent_for_Approval, Approval1, U1.UserFullName Approval1_By, Approval1_Date, Approval2, 
                   U2.UserFullName Approval2_By, Approval2_Date FROM MPO_Master AS M INNER JOIN  MPO_Details AS D ON M.MPO_No = D.MPO_No INNER JOIN Supplier_Info AS S ON M.Supp_ID = S.Supp_ID left join User_Info u1 on m.Approval1_By=u1.userID left join User_Info u2 on m.Approval2_By=u2.userID
where (M.MPO_No is not null) " + _wc + "  " +
" GROUP BY M.MPO_No, M.MPO_Date, M.ETD_Date, M.CON_ETDDate, M.Currency, M.Delv_Mode, M.Pay_Mode, M.PO_Type, S.Supplier_Name, Sent_for_Approval, Approval1, U1.UserFullName, Approval1_Date, Approval2,  U2.UserFullName, Approval2_Date";
                dgvMpo.DataSource = GlobalInfo.GlobalInfo.getDataTable(_sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mpo_Load(object sender, EventArgs e)
        {

        }

        private void dgvMpo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           

            if (e.RowIndex < 0 || e.ColumnIndex != 0) return;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string _mpoID = Convert.ToString(dgvMpo.Rows[e.RowIndex].Cells[1].Value);
                string _sqlQ = "exec sp_rptmpo '" + _mpoID + "' ";
                GlobalInfo.GlobalInfo._ReportView(_sqlQ, new Reports.rptMPO());
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { this.Cursor = Cursors.Default; }
        }
    }
}
