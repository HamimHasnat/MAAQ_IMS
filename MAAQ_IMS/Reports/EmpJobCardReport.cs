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
    public partial class EmpJobCardReport : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        
        public EmpJobCardReport()
        {
            InitializeComponent();
        }

        private void EmpJobCardReport_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                GlobalInfo.GlobalInfo.combo_add_with_Value(cboEmpID, "select Sys_ID, Emp_ID  from Emp_official_Info order by Len(Emp_ID), Emp_ID");
                dtpFrom.Value = DateTime.Now.AddDays(-(DateTime.Now.Day-1));
                dtTo.Value = DateTime.Now;
                //dtFrom.Text = "";
                //dtTo.Text = "";

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
        
        private void btnPreview_Click(object sender, EventArgs e)
        {
            string sqlQ = string.Empty,
            _sdate = "1900-01-01", _edate = "1900-01-01", _mdate = "1900-01-01";
            string empID= "";
            if (cboEmpID.Text.Length > 0) empID = cboEmpID.SelectedValue.ToString();
            if ( dtpFrom.Text.Length > 0) _sdate = Convert.ToDateTime(dtpFrom.Text).ToString("dd-MMM-yyyy");
            if ( dtTo.Text.Length > 0) _edate = Convert.ToDateTime(dtTo.Text).ToString("dd-MMM-yyyy");

            if (chkPresent.Checked)
            {
                sqlQ = "Exec sp_GetAttendanceData '" + empID + "','" + _sdate + "', '" + _edate + "', 'P'";
                GlobalInfo.GlobalInfo._ReportViewSamePage(sqlQ, new Reports.rptPresent(),crystalReportViewer1);
            }
            else if (chkAbsent.Checked)
            {
                sqlQ = "Exec sp_GetAttendanceData '" + empID + "','" + _sdate + "','" + _edate + "', 'A'";
                GlobalInfo.GlobalInfo._ReportViewSamePage(sqlQ, new Reports.rptPresent(), crystalReportViewer1);
            }
            else if (chkDailyAtt.Checked)
            {
                sqlQ = "Exec sp_GetAttendanceData '" + empID + "','" + _sdate + "','" + _edate + "', 'both'";
                GlobalInfo.GlobalInfo._ReportViewSamePage(sqlQ, new Reports.rptPresent(), crystalReportViewer1);
            }
            else if (chkOTSummary.Checked)
            {
                sqlQ = "Exec sp_GetOTSummary_Report '" + empID + "','" + _sdate + "', '" + _edate + "','ot'";
                GlobalInfo.GlobalInfo._ReportViewSamePage(sqlQ, new Reports.rptOTSummary(), crystalReportViewer1);
            }
            else if (chkOTDetails.Checked)
            {
                sqlQ = "Exec sp_GetOTDetails '" + empID + "','" + _sdate + "','" + _edate + "' ";

                GlobalInfo.GlobalInfo._ReportViewSamePage(sqlQ, new Reports.rptOTDetails(), crystalReportViewer1);
            }
            else if (chkAttRegister.Checked)
            {
                sqlQ = "Exec sp_GetAttendanceRegister '" + empID + "','" + _sdate + "','" + _edate + "' ";

                GlobalInfo.GlobalInfo._ReportViewSamePage(sqlQ, new Reports.AttRegister(), crystalReportViewer1);

            }

            else if(chkDAOT.Checked)
            {
                sqlQ = "Exec sp_GetJobCardData_Report '" + empID + "','" + _sdate + "', '" + _edate + "', 'att'";
                GlobalInfo.GlobalInfo._ReportViewSamePage(sqlQ, new Reports.DailyOT_Attendance(), crystalReportViewer1);
            }
            else if (ChkJobCard.Checked)
            {
                sqlQ = "Exec sp_rptJobCard '" + empID + "','" + _sdate + "', '" + _edate + "'";
                GlobalInfo.GlobalInfo._ReportViewSamePage(sqlQ, new Reports.rptJobCard(), crystalReportViewer1);
            }
            else if (ChkLeaveRegister.Checked)
            {
                sqlQ = "Exec sp_GetLeaveRegisterReport '" + empID + "','" + _sdate + "', '" + _edate + "'";
                GlobalInfo.GlobalInfo._ReportViewSamePage(sqlQ, new Reports.Leave_Balance_Register(), crystalReportViewer1);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cboEmpID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }     
    }
}
