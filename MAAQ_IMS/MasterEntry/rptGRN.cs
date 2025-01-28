using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAAQ_IMS.MasterEntry
{
    public partial class rptGRN : Form
    {
        public rptGRN()
        {
            InitializeComponent();
        }

        private void rptGRN_Load(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.combo_add_with_Value(CboSupplierName, "SELECT SupplierID, CompanyName FROM Supplier_Info ORDER BY CompanyName");
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string _sql = "", _wc = "";
            if (CboSupplierName.Text.Length > 0) _wc += " and (M.SupplierID='" + CboSupplierName.SelectedValue + "')";
            if (chkGrnDate.Checked == true) _wc += " and (M.MPO_Date  between '" + dtFrom.Text + "' and '" + dtTo.Text + "')";
            if (txtGRNNO.Text.Length > 0) _wc += " and (gm.GRN_No='" + txtGRNNO.Text + "')";
            if (txtSearch.Text.Length > 0) _wc += " and (gm.MPO_No='" + txtSearch.Text + "')";
            if (txtSearch.Text.Length > 0) _wc += " and (gm.GRN_No='" + txtSearch.Text + "')";
            _sql = @" select    GRN_No, MPO_No, SupplierID, Invoice_No, Invoice_Date, Bill_No, Remarks, Sent_for_Approval, Approval1, U1.UserFullName Approval1_By, Approval1_Date, Approval2,U2.UserFullName Approval2_By, Approval2_Date from GRN_Master gm
left join User_Info u1 on gm.Approval1_By=u1.userID 
left join User_Info u2 on gm.Approval2_By=u2.userID where (gm.GRN_No is not null)  " + _wc + "";
            dgvGRN.DataSource = GlobalInfo.GlobalInfo.getDataTable(_sql);
        }

        private void dgvMPO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 0) return;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string _GRNID = Convert.ToString(dgvGRN.Rows[e.RowIndex].Cells[1].Value);
                string _sqlQ = "Exec sp_rptGRN '" + _GRNID + "' ";
                
                GlobalInfo.GlobalInfo._ReportView(_sqlQ, new Reports.CryRptGRN());

                   
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { this.Cursor = Cursors.Default; }
        }

        private void chkGrnDate_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
