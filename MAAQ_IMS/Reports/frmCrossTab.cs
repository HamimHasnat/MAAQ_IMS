using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAAQ_IMS.Reports
{
    public partial class frmCrossTab : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        DataTable dataItems = null;
        public frmCrossTab()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string sqlQ = string.Empty;
                int catagoryId = 0, _subGID = 0;
                if (cboSubGroup.Text.Length > 0) _subGID = Convert.ToInt32(cboSubGroup.SelectedValue);
                if (cboCategory.Text.Length > 0) catagoryId = Convert.ToInt32(cboCategory.SelectedValue);
                sqlQ = "Exec sp_Crossrpt  '" + _subGID + "','" + catagoryId + "'";
                GlobalInfo.GlobalInfo._ReportViewSamePage(sqlQ, new Reports.rptCross(), crystalReportViewer1);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);  }
            finally { this.Cursor = Cursors.Default; }
            
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroup.Text.ToString() != "--Select--")
            {
                int groupId = Convert.ToInt32(cboGroup.SelectedValue.ToString());

                GlobalInfo.GlobalInfo.PopulateCombobox(cboSubGroup, "SubGroup_ID", "SubGroup_Name", "New_Item_SubGroup", "Group_ID", groupId, "SubGroup_Name");

            }
        }

        private void frmCrossTab_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
               

                btnRefresh_Click(sender, e);

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

        private void cboSubGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                cboCategory.Text = string.Empty;
                if (GlobalInfo.GlobalInfo.getComboDataValidaty(cboSubGroup) == false) return;
                GlobalInfo.GlobalInfo.combo_add_with_Value(cboCategory, $"Select Category_ID, Category_Name from  New_Item_Category where SubGroup_ID = '" + cboSubGroup.SelectedValue + "' and Group_ID = '" + cboGroup.SelectedValue + "' order By Category_Name");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control controls in panel1.Controls)
                {
                    if (controls is TextBox || controls is ComboBox || controls is DateTimePicker) controls.Text = string.Empty;
                }
                GlobalInfo.GlobalInfo.PopulateCombobox(cboGroup, "Group_ID", "Group_Name", "New_Item_Group", "Group_Name");

                //cboSubGroup.DataSource = null;
                //cboCategory.DataSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
