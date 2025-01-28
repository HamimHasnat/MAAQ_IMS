using System;

using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace MAAQ_IMS.Purchase
{
    public partial class Emp_Job_Card : Form
    {

        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        CheckBox headerbox = null;
        bool isHeadercheckboxclicked = false;
        public Emp_Job_Card()
        {
            InitializeComponent();
           
        }
        
        private void Emp_Job_Card_Load(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.combo_add_with_Value(cboEmpID, @"SELECT  Sys_ID, Emp_ID FROM Emp_official_Info ORDER BY Sys_ID");
            dgvEmpJobCard.CellEndEdit += dgvEmpJobCard_CellEndEdit;


            dgvEmpJobCard.ReadOnly = false;
            dgvEmpJobCard.Columns["txtGridInTime"].ReadOnly = false;
            dgvEmpJobCard.Columns["txtGridOutTime"].ReadOnly = false;
            dgvEmpJobCard.Columns["txtGridAttStatus"].ReadOnly = false;
            //txtGridAttStatus.ReadOnly = true;
            txtGridAttStatus.MaxDropDownItems = 4;
            txtGridAttStatus.Items.Add("P");
            txtGridAttStatus.Items.Add("W");
            txtGridAttStatus.Items.Add("A");
            txtGridAttStatus.Items.Add("H");
            //DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
            //statusColumn.Name = "txtGridAttStatus";
            //statusColumn.HeaderText = "Att Status";
            //statusColumn.DataSource = new string[] { "P", "H", "A", "W" }; 
            //statusColumn.DataPropertyName = "Att_Status"; 
            //dgvEmpJobCard.Columns.Add(statusColumn);
        }
    

        private void cboEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GlobalInfo.GlobalInfo.getComboDataValidaty(cboEmpID) == false) return;
        try
        {
                //int selectedRowCount = 0;
                string empID = cboEmpID.SelectedValue.ToString();
            string _sqlQ = @"SELECT E.Emp_ID, E.Emp_Name, D.Dept_Name, S.Sec_Name, DG.Desig_Name, convert(date,E.Joined_Date)Joined_Date, E.OT FROM Emp_official_Info E INNER JOIN New_Department D ON D.Dept_ID = E.Dept_ID INNER JOIN New_Section S ON S.Sec_ID = E.Sec_ID INNER JOIN New_Designation DG ON DG.Desig_ID = E.Desig_ID   WHERE E.Sys_ID = @Emp_ID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(_sqlQ, con);
                cmd.Parameters.AddWithValue("@Emp_ID", empID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable DataTable = new DataTable();
                adapter.Fill(DataTable);

                if (DataTable.Rows.Count > 0)
                 {
                    DataRow row = DataTable.Rows[0];
                    txtEmpName.Text = row["Emp_Name"].ToString();
                    txtDepartment.Text = row["Dept_Name"].ToString();
                    txtDesignation.Text = row["Desig_Name"].ToString();
                    txtSection.Text = row["Sec_Name"].ToString();
                    txtJoinDate.Text = row["Joined_Date"].ToString();
                     txtOT.Text = row["OT"].ToString();
                    //string sqlQ = "SELECT Att_Date, Att_Status, convert(time,In_Time) In_Time, convert(time,Out_Time)Out_Time, Working_Hour, OT,Total_HR,Total_Min FROM Daily_Attendance WHERE Emp_ID = @Emp_ID AND Att_Date BETWEEN @FromDate AND @ToDate";
                    //SqlCommand cmd2 = new SqlCommand(sqlQ, con);
                    //cmd2.Parameters.AddWithValue("@Emp_ID", empID);
                    //cmd2.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                    //cmd2.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date.AddDays(1).AddSeconds(-1));
                    //SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    //txtGridAttDate.DataPropertyName = "Att_Date";
                    //txtGridAttStatus.DataPropertyName = "Att_Status";
                    //txtGridInTime.DataPropertyName = "In_Time";
                    //txtGridOutTime.DataPropertyName = "Out_Time";
                    //txtGridWH.DataPropertyName = "Working_Hour";
                    //txtGridOT.DataPropertyName = "OT";
                    //txtGridTotalHR.DataPropertyName = "Total_HR";
                    //txtGridTotalMin.DataPropertyName = "Total_Min";
                    //dgvEmpJobCard.DataSource = dt;
                    string sqlQ = @"SELECT Att_Date, Att_Status, Convert(time,In_Time)In_Time, Convert(time,Out_Time)Out_Time, Working_Hour, OT, Total_HR, Total_Min " +
            "FROM Daily_Attendance " +
            "WHERE Emp_ID = '" + cboEmpID.SelectedValue + "' AND Att_Date BETWEEN '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpTo.Value.ToString("yyyy-MM-dd") + "' " +
            "ORDER BY Att_Date";
                    DataTable _dt = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                    if (_dt.Rows.Count > 0)
                    {
                        foreach (DataRow r in _dt.Rows)
                        {
                                txtGridAttDate.DataPropertyName = "Att_Date";
                                txtGridAttStatus.DataPropertyName = "Att_Status";
                                txtGridInTime.DataPropertyName = "In_Time";
                                txtGridOutTime.DataPropertyName = "Out_Time";

                                txtGridWH.DataPropertyName = "Working_Hour";
                                txtGridOT.DataPropertyName = "OT";
                                txtGridTotalHR.DataPropertyName = "Total_HR";
                                txtGridTotalMin.DataPropertyName = "Total_Min";

                                dgvEmpJobCard.DataSource = _dt;
                                dgvEmpJobCard.Show();

                                //dgvEmpJobCard.Rows.Add(r["Att_Date"], r["Att_Status"], r["In_Time"], r["Out_Time"], r["Working_Hour"], r["OT"], r["Total_HR"], r["Total_Min"]);
                                //selectedRowCount++;
                            }

                    }
                    _getTotal();
                }
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        }
        private void _getTotal()
        {
            decimal _totOff = 0, _totPresent = 0, _totAbsent = 0, _totLeave = 0, _totDays = 0, _totHR = 0, _totOT = 0;

            foreach (DataGridViewRow row in dgvEmpJobCard.Rows)
            {
                decimal workingHour = Convert.ToDecimal(row.Cells["txtGridWH"].Value);
                decimal totalHR = Convert.ToDecimal(row.Cells["txtGridTotalHR"].Value);
                decimal ot = Convert.ToDecimal(row.Cells["txtGridOT"].Value);
                string attStatus = row.Cells["txtGridAttStatus"].Value.ToString();

                switch (attStatus)
                {
                    case "P":
                        _totPresent += 1;
                        break;
                    case "A":
                        _totAbsent += 1;
                        break;
                    default:
                        break;
                }

                _totDays += 1;
                _totHR += totalHR;
                _totOT += ot;
            }

            // Calculate other totals based on the gathered data
            _totLeave = _totDays - (_totPresent + _totAbsent);
            _totOff = _totDays - _totPresent;

            // Display the totals
            lblOff.Text = _totOff.ToString();
            lblPresent.Text = _totPresent.ToString();
            lblAbsent.Text = _totAbsent.ToString();
            lblLeave.Text = _totLeave.ToString();
            lblDays.Text = _totDays.ToString();

            // Update labels for sum of txtGridOT and txtGridWH
            lblOT.Text = Math.Round(_totOT, 2).ToString();
            lblHR.Text = Math.Round(_totHR, 2).ToString();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                dgvEmpJobCard.DataSource = null;
                txtEmpName.Text = null;
                txtDepartment.Text = null;
                txtDesignation.Text = null;
                txtSection.Text = null;
                txtJoinDate.Text = null;
                txtOT.Text = null;
                cboEmpID.Text = null;

                lblOff.Text = null;
                lblPresent.Text = null;
                lblOT.Text = null;
                lblAbsent.Text = null;
                lblLeave.Text = null;
                lblDays.Text = null;
                lblHR.Text = null;
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

        private void dgvEmpJobCard_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvEmpJobCard.Rows[e.RowIndex];
                    string attStatus = row.Cells["txtGridAttStatus"].Value.ToString();

                   
                    row.Cells["txtGridInTime"].ReadOnly = false;
                    row.Cells["txtGridOutTime"].ReadOnly = false;

                    
                    if (attStatus == "A")
                    {
                        row.Cells["txtGridInTime"].Value = "00:00";
                        row.Cells["txtGridOutTime"].Value = "00:00";
                        row.Cells["txtGridWH"].Value = "00";
                        row.Cells["txtGridOT"].Value = "00";
                        row.Cells["txtGridTotalHR"].Value = "00";
                        row.Cells["txtGridTotalMin"].Value = "00";
                    }
                    else if (attStatus == "H") 
                    {
                        
                        string inTimeValue = row.Cells["txtGridInTime"].Value.ToString();
                        string outTimeValue = row.Cells["txtGridOutTime"].Value.ToString();

                        TimeSpan workingHours = TimeSpan.Parse(outTimeValue).Subtract(TimeSpan.Parse(inTimeValue));
                        decimal workingHoursDecimal = (decimal)workingHours.TotalHours;
                        decimal ot = 0;
                        if (workingHoursDecimal > 8)
                        {
                            ot = workingHoursDecimal - 8;
                            workingHoursDecimal = 8;
                        }
                        row.Cells["txtGridWH"].Value = workingHoursDecimal;
                        row.Cells["txtGridOT"].Value = Math.Round(ot,2);
                        decimal totalHR = workingHoursDecimal + ot;
                        row.Cells["txtGridTotalHR"].Value = Math.Round(totalHR,2);
                        row.Cells["txtGridTotalMin"].Value = Math.Round(totalHR * 60,2);
                    }
                    else if(attStatus == "W")
                    {
                        string inTimeValue = row.Cells["txtGridInTime"].Value.ToString();
                        string outTimeValue = row.Cells["txtGridOutTime"].Value.ToString();

                        TimeSpan workingHours = TimeSpan.Parse(outTimeValue).Subtract(TimeSpan.Parse(inTimeValue));
                        decimal workingHoursDecimal = (decimal)workingHours.TotalHours;
                        decimal ot = 0; 

                        row.Cells["txtGridWH"].Value = "00";
                        row.Cells["txtGridOT"].Value = Math.Round(workingHoursDecimal + ot,2);
                        row.Cells["txtGridTotalHR"].Value = "00";
                        row.Cells["txtGridTotalMin"].Value = "00";
                    }
                }

                _getTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update with this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            SqlConnection con = new SqlConnection(GlobalInfo.ConnectionInfo.GenerateConnectionString());
            SqlCommand cmd = null;
            SqlTransaction transaction = null;

            try
            {
                con.Open();
                transaction = con.BeginTransaction();

                foreach (DataGridViewRow row in dgvEmpJobCard.Rows)
                {
                    string attDate = row.Cells["txtGridAttDate"].Value.ToString();
                    string empID = cboEmpID.SelectedValue.ToString();
                    string inTime = row.Cells["txtGridInTime"].Value.ToString();
                    string outTime = row.Cells["txtGridOutTime"].Value.ToString();
                    string attStatus = row.Cells["txtGridAttStatus"].Value.ToString();
                    decimal workingHours = Convert.ToDecimal(row.Cells["txtGridWH"].Value);
                    decimal ot = Convert.ToDecimal(row.Cells["txtGridOT"].Value);

                    
                    string updateQuery = @"UPDATE Daily_Attendance  SET In_Time = @InTime, Out_Time = @OutTime, Att_Status = @AttStatus, Working_Hour = @WorkingHour, OT = @OT  WHERE Emp_ID = @EmpID AND Att_Date = @AttDate";

                    cmd = new SqlCommand(updateQuery, con, transaction);
                    cmd.Parameters.AddWithValue("@InTime", inTime);
                    cmd.Parameters.AddWithValue("@OutTime", outTime);
                    cmd.Parameters.AddWithValue("@AttStatus", attStatus);
                    cmd.Parameters.AddWithValue("@WorkingHour", workingHours);
                    cmd.Parameters.AddWithValue("@OT", ot);
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    cmd.Parameters.AddWithValue("@AttDate", attDate);

                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Database Updated successfully.");
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();

                MessageBox.Show($"Error Updating Database: {ex.Message}");
            }
            finally
            {
                if (cmd != null)
                    cmd.Dispose();

                if (transaction != null)
                    transaction.Dispose();

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
               
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = true;

               
                Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
                Microsoft.Office.Interop.Excel._Worksheet worksheet = workbook.ActiveSheet;

               
                for (int i = 1; i < dgvEmpJobCard.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvEmpJobCard.Columns[i - 1].HeaderText;
                }
                
                for (int i = 0; i < dgvEmpJobCard.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvEmpJobCard.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvEmpJobCard.Rows[i].Cells[j].Value.ToString();
                    }
                }

                
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FileName = "EmpJobCardData.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Data exported successfully.");
                }
                else
                {
                    workbook.Close(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data to Excel: {ex.Message}");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportShow Rl = new frmReportShow();
                Rl.Show();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Exec sp_rptJobCard  '" + cboEmpID.SelectedValue + "' ", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, cmd.CommandText);
                    Reports.rptJobCard cry = new Reports.rptJobCard();
                    cry.SetDataSource(ds.Tables[0]);
                    Rl.crystalReportViewer1.ReportSource = cry;
                    Rl.crystalReportViewer1.Refresh();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmdsalary_Click(object sender, EventArgs e)
        {
            string fromDate = dtpFrom.Value.ToString("yyyy-MMM-dd");
            string toDate = dtpTo.Value.ToString("yyyy-MMM-dd");
            string empType = cboEmpType.Text.Trim();
            int empId = 0;

            if (cboEmpID.Text.Length > 0)
                empId = Convert.ToInt32(cboEmpID.SelectedValue);

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                cmd.Connection = conn;

                StringBuilder sqlQuery = new StringBuilder("SELECT * FROM Salary_Sheet WHERE Processed_Month = @Month AND Processed_Year = @Year");

                if (!string.IsNullOrEmpty(empType) && empId > 0)
                {
                    sqlQuery.Append(" AND Emp_Type = @EmpType AND Emp_ID = @EmpID");
                    cmd.Parameters.AddWithValue("@EmpType", empType);
                    cmd.Parameters.AddWithValue("@EmpID", empId);
                }
                else if (!string.IsNullOrEmpty(empType))
                {
                    sqlQuery.Append(" AND Emp_Type = @EmpType");
                    cmd.Parameters.AddWithValue("@EmpType", empType);
                }
                else if (empId > 0)
                {
                    sqlQuery.Append(" AND Emp_ID = @EmpID");
                    cmd.Parameters.AddWithValue("@EmpID", empId);
                }

                cmd.CommandText = sqlQuery.ToString();
                cmd.Parameters.AddWithValue("@Month", dtpFrom.Value.ToString("MMMM"));
                cmd.Parameters.AddWithValue("@Year", dtpFrom.Value.Year);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    frmReportShow reportForm = new frmReportShow();
                    Reports.rptSalarySheet salaryReport = new Reports.rptSalarySheet();
                    salaryReport.SetDataSource(dt);

                    string reportHeader = $"For the month of {dtpFrom.Value.ToString("MMMM yyyy")}";

                    try
                    {
                        // Set the parameter value if it exists in the report
                        if (salaryReport.ParameterFields["ReportHeader"] != null)
                        {
                            salaryReport.SetParameterValue("ReportHeader", reportHeader);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error setting report parameter: " + ex.Message);
                    }

                    reportForm.crystalReportViewer1.ReportSource = salaryReport;
                    reportForm.crystalReportViewer1.Refresh();

                    reportForm.Show();
                }
                else
                {
                    MessageBox.Show("No data available for the selected criteria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }



        //private void ProcessSalaryDataTable(DataTable dt)
        //{
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        int totalWorkDays = Convert.ToInt32(row["Total_Work_Days"]);
        //        int holidayDays = Convert.ToInt32(row["Holiday_Days"]);
        //        int leaveDays = Convert.ToInt32(row["Leave_Days"]);
        //        int absentDays = Convert.ToInt32(row["Absent_Days"]);

        //        // Calculate Attendance Bonus eligibility
        //        bool isEligibleForBonus = (totalWorkDays + holidayDays) >= 26 && leaveDays == 0 && absentDays == 0;
        //        row["Attendance_Bonus"] = isEligibleForBonus ? 500 : 0;

        //        // Calculate Absent Amount based on the number of absent days
        //        decimal basicSalary = Convert.ToDecimal(row["Basic"]);
        //        decimal absentAmount = basicSalary / 30 * absentDays;
        //        row["Absent_Amount"] = absentAmount;

        //        // Calculate Total Deductions
        //        decimal totalDeductions = Convert.ToDecimal(row["Lunch_Deduction"]) +
        //                                  absentAmount +
        //                                  Convert.ToDecimal(row["Advance"]) +
        //                                  Convert.ToDecimal(row["Loan"]) +
        //                                  Convert.ToDecimal(row["PF"]) +
        //                                  Convert.ToDecimal(row["Other_Deductions"]);
        //        row["Total_Deductions"] = totalDeductions;

        //        // Calculate Payable Amount
        //        decimal payableWages = Convert.ToDecimal(row["Payable_Wages"]);
        //        decimal payableAmount = payableWages - totalDeductions;
        //        row["Payable_Amount"] = payableAmount;
        //    }
        //}
        //private void DisplaySalaryReport(DataTable dt)
        //{
        //    frmReportShow reportForm = new frmReportShow();
        //    reportForm.Show();

        //    Reports.rptSalarySheet salaryReport = new Reports.rptSalarySheet();
        //    salaryReport.SetDataSource(dt);

        //    reportForm.crystalReportViewer1.ReportSource = salaryReport;
        //    reportForm.crystalReportViewer1.Refresh();
        //}
        private void chkEmpStatus_Click(object sender, EventArgs e)
        {
            cboEmpID.Visible = !chkEmptype.Checked;
            cboEmpType.Visible = chkEmptype.Checked;
            cboEmpType.Location = cboEmpID.Location;

            if (chkEmptype.Checked)
            {
                GlobalInfo.GlobalInfo.combo_add(cboEmpType, "SELECT DISTINCT Emp_Type FROM Emp_official_Info");
            }


        }


    }
}
