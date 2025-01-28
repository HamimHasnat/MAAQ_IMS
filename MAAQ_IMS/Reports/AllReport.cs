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
    public partial class AllReport : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        DataTable dataItems = null;
        public AllReport()
        {
            InitializeComponent();
        }

        private void chcPo_Report_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void AllReport_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                dtFrom.Text = "";
                dtTo.Text = "";

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

        
        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroup.Text.ToString() != "--Select--")
            {
                int groupId = Convert.ToInt32(cboGroup.SelectedValue.ToString());

                GlobalInfo.GlobalInfo.PopulateCombobox(cboSubGroup, "SubGroup_ID", "SubGroup_Name", "New_Item_SubGroup", "Group_ID", groupId, "SubGroup_Name");

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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string sqlQ = string.Empty, _sdate = "1900-01-01", _edate = "1900-01-01";
            int catagoryId = 0;

            if (cboCategory.Text.Length > 0) catagoryId = Convert.ToInt32(cboCategory.SelectedValue);
            if (chkDate.Checked && dtFrom.Text.Length > 0) _sdate = Convert.ToDateTime(dtFrom.Text).ToString("dd-MMM-yyyy");
            if (chkDate.Checked && dtTo.Text.Length > 0) _edate = Convert.ToDateTime(dtTo.Text).ToString("dd-MMM-yyyy");



            if (chcPo_Report.Checked && chcDetails.Checked)
            {
                        sqlQ = "Exec sp_rptPoDetails  '" + catagoryId + "', '" + _sdate + "', '" + _edate + "'," + chkDate.Checked + "";
                        GlobalInfo.GlobalInfo._ReportView(sqlQ, new Reports.Purchase_Order()); 
            }
            else if (chcGRNReport.Checked && chcDetails.Checked)
            {
                sqlQ = "Exec sp_rptGRNdetails  '" + catagoryId + "', '" + _edate + "', '" + _sdate + "'";
                GlobalInfo.GlobalInfo._ReportView(sqlQ, new Reports.rptGRNDetails());
            }
            else if (chcIssue.Checked && chcDetails.Checked)
            {
                sqlQ = "Exec sp_issuedetails  '" + catagoryId + "', '" + _edate + "', '" + _sdate + "'";
                GlobalInfo.GlobalInfo._ReportView(sqlQ, new Reports.CryRptIssue());
            }
            else if (chcStock.Checked && chcDetails.Checked)

            {
                sqlQ = "Exec sp_ItemStockissuerpt'" + catagoryId + "', '" + _edate + "', '" + _sdate + "'";
                GlobalInfo.GlobalInfo._ReportView(sqlQ, new Reports.rptItemStock());

            }
            else if(chcAllReport.Checked && chcDetails.Checked)
            {
                sqlQ = "Exec sp_alldetails  '" + catagoryId + "', '" + _edate + "', '" + _sdate + "'";
                GlobalInfo.GlobalInfo._ReportView(sqlQ, new Reports.AllDetails());
            }
            else if(chcPo_Report.Checked && chcSummary.Checked)
            {
                //sqlQ = "Exec sp_rptPoDetails  '" + catagoryId + "', '" + _edate + "', '" + _sdate + "'";
                //GlobalInfo.GlobalInfo._ReportView(sqlQ, new Reports.rptPOSummary());

                sqlQ = "Exec sp_rptPoDetails_Summery  '" + catagoryId + "', '" + _sdate + "', '" + _edate + "'," + chkDate.Checked + "";
                GlobalInfo.GlobalInfo._ReportView(sqlQ, new Reports.rptPOSummary());
            }
            else if (chcGRNReport.Checked && chcSummary.Checked)
            {
               

                sqlQ = "Exec sp_rptGRNdetails  '" + catagoryId + "', '" + _sdate + "', '" + _edate + "'," + chkDate.Checked + "";
                GlobalInfo.GlobalInfo._ReportView(sqlQ, new Reports.rptGRNSummary());
            }
            else if (chcIssue.Checked && chcSummary.Checked)
            {


                //sqlQ = "Exec sp_rptIssueDetails_Summery  '" + catagoryId + "', '" + _sdate + "', '" + _edate + "'," + chkDate.Checked + "";
                sqlQ = "Exec sp_issuedetails  '" + catagoryId + "', '" + _sdate + "', '" + _edate + "'," + chkDate.Checked + "";
                GlobalInfo.GlobalInfo._ReportView(sqlQ, new Reports.rptIssueSummary());
            }
            else if (chcStock.Checked && chcSummary.Checked)
            {


                //sqlQ = "Exec sp_rptIssueDetails_Summery  '" + catagoryId + "', '" + _sdate + "', '" + _edate + "'," + chkDate.Checked + "";
                sqlQ = "Exec sp_ItemStockissuerpt  '" + catagoryId + "', '" + _sdate + "', '" + _edate + "'," + chkDate.Checked + "";
                GlobalInfo.GlobalInfo._ReportView(sqlQ, new Reports.CryStockSummary());
            }



        }

        private void chkDate_Click(object sender, EventArgs e)
        {
            if(chkDate.Checked ==  true)
                {
                dtFrom.Enabled = true;
                dtTo.Enabled = true;
            }
            else
            {
                dtFrom.Enabled = false;
                dtTo.Enabled = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
