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

namespace MAAQ_IMS.Reports
{
    public partial class ItemStockrpt : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        public ItemStockrpt()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                //string _sql = "", _wc = "";
                //if (cboIssueID.Text.Length > 0) _wc += " and (Issue_ID='" + cboIssueID.SelectedItem + "')";
                ////if (chkPoDate.Checked == true) _wc += " and (M.MPO_Date  between '" + dtFrom.Text + "' and '" + dtTo.Text + "')";
                //if (txtSearch.Text.Length > 0) _wc += " and (Issue_ID='" + txtSearch.Text + "')";
                //_sql = @"SELECT     Issue_ID, Issue_Date, Dept_ID, Sec_ID, Remarks FROM            Issue_Master where Issue_ID > 0  " + _wc + " ";
                //dgvIssue.DataSource = GlobalInfo.GlobalInfo.getDataTable(_sql);
                int itemid = 0;
                if (cboIssueID.Text.Length > 0) itemid = Convert.ToInt32(cboIssueID.SelectedValue.ToString());
 
                string _sqlQ = "exec sp_ItemStockissuerpt '" + itemid + "' ";
                GlobalInfo.GlobalInfo._ReportView(_sqlQ, new Reports.rptItemStock());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ItemStockrpt_Load(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.combo_add_with_Value(cboIssueID, "select Item_ID,Item_Name from New_Item_Entry order by Item_Name");
        }

        private void dgvIssue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 0) return;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string itemid = Convert.ToString(dgvIssue.Rows[e.RowIndex].Cells[1].Value);
                string _sqlQ = "exec sp_ItemStockissuerpt '" + itemid + "' ";
                GlobalInfo.GlobalInfo._ReportView(_sqlQ, new Reports.rptItemStock());
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { this.Cursor = Cursors.Default; }
        }

        private void cboIssueID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
