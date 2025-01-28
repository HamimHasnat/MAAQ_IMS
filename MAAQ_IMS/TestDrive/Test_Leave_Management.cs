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

namespace MAAQ_IMS.TestDrive
{
    public partial class Test_Leave_Management : Form
    {
        DataTable dataItems = null;
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        SqlConnection con = new SqlConnection();
        public Test_Leave_Management()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboEmpID.Text) || cboEmpID.Text.Length == 0)
            {
                MessageBox.Show("Employee ID is required.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboLeavetype.Text.Length == 0)
            {
                MessageBox.Show("Leave Type is required.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLeavetype.Focus();
                return;
            }
            this.Cursor = Cursors.WaitCursor;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlTransaction trans = con.BeginTransaction();
            cmd.Transaction = trans;

            // Check if the selected leave type is SL, CL, or EL
            if (cboLeavetype.Text == "SL" || cboLeavetype.Text == "CL" || cboLeavetype.Text == "EL")
            {
                DateTime fromDate = dtpFromDate.Value.Date;
                DateTime toDate = dtpToDate.Value.Date;

               

                try
                {
                    con.Open();

                    for (DateTime date = fromDate; date <= toDate; date = date.AddDays(1))
                    {
                        cmd.CommandText = "SELECT COUNT(*) FROM Leave_Details WHERE Emp_ID = @EmpID AND Leave_Date = @LeaveDate AND Leave_Name IN ('SL', 'CL', 'EL')";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@EmpID", cboEmpID.SelectedValue);
                        cmd.Parameters.AddWithValue("@LeaveDate", date.ToString("yyyy-MM-dd"));
                        int leaveCount = (int)cmd.ExecuteScalar();

                        if (leaveCount > 0)
                        {
                            MessageBox.Show("You cannot take leave for Sick Leave (SL), Casual Leave (CL), or Earned Leave (EL) on the same day.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Proceed with leave insertion if validation passes
                    // Your existing code here...
                    cmd.CommandText = @"INSERT INTO Leave_Master (Emp_ID, FromDate, ToDate, Leave_Name, Total_Days, Remarks) 
                            VALUES (@EmpID, @FromDate, @ToDate, @LeaveName, @TotalDays, @Remarks)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@EmpID", cboEmpID.SelectedValue);
                    cmd.Parameters.AddWithValue("@FromDate", fromDate.ToString("dd-MMM-yyyy"));
                    cmd.Parameters.AddWithValue("@ToDate", toDate.ToString("dd-MMM-yyyy"));
                    cmd.Parameters.AddWithValue("@LeaveName", cboLeavetype.Text);
                    cmd.Parameters.AddWithValue("@TotalDays", txtTotalDays.Text);
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
                    cmd.ExecuteNonQuery();

                    for (DateTime date = fromDate; date <= toDate; date = date.AddDays(1))
                    {
                        cmd.CommandText = @"INSERT INTO Leave_Details (Emp_ID, Leave_Date, Leave_Name) 
                        VALUES (@EmpID, @LeaveDate, @LeaveName)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@EmpID", cboEmpID.SelectedValue);
                        cmd.Parameters.AddWithValue("@LeaveDate", date.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@LeaveName", cboLeavetype.Text);
                        cmd.ExecuteNonQuery();

                        // update da
                        cmd.CommandText = "Update Daily_Attendance Set Att_Status = @LeaveName WHERE Emp_ID = @EmpID And Att_Date=@AttDate";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@LeaveName", cboLeavetype.Text);
                        cmd.Parameters.AddWithValue("@EmpID", cboEmpID.SelectedValue);
                        cmd.Parameters.AddWithValue("@AttDate", date.ToString("yyyy-MM-dd"));
                        cmd.ExecuteNonQuery();
                    }

                    // update leave balance
                    cmd.CommandText = "Update Leave_Balance Set Enjoyed =Enjoyed+@TotalDays WHERE Emp_ID = @EmpID And Year = @Year And Leave_Name= @LeaveName";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@TotalDays", Convert.ToInt32(txtTotalDays.Text));
                    cmd.Parameters.AddWithValue("@EmpID", cboEmpID.SelectedValue);
                    cmd.Parameters.AddWithValue("@Year", Convert.ToInt64(toDate.Year));
                    cmd.Parameters.AddWithValue("@LeaveName", cboLeavetype.Text);
                    cmd.ExecuteNonQuery();
                    trans.Commit();
                    MessageBox.Show("Data Saved successfully.");
                    cboEmpID_SelectedIndexChanged(sender, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
            else
            {
                // Proceed with leave insertion for other leave types
                DateTime fromDate = dtpFromDate.Value.Date;
                DateTime toDate = dtpToDate.Value.Date;

                //SqlConnection con = new SqlConnection();
                //con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
               

                try
                {
                    con.Open();

                    // Insert leave records
                    cmd.CommandText = @"INSERT INTO Leave_Master (Emp_ID, FromDate, ToDate, Leave_Name, Total_Days, Remarks) 
                            VALUES (@EmpID, @FromDate, @ToDate, @LeaveName, @TotalDays, @Remarks)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@EmpID", cboEmpID.SelectedValue);
                    cmd.Parameters.AddWithValue("@FromDate", fromDate.ToString("dd-MMM-yyyy"));
                    cmd.Parameters.AddWithValue("@ToDate", toDate.ToString("dd-MMM-yyyy"));
                    cmd.Parameters.AddWithValue("@LeaveName", cboLeavetype.Text);
                    cmd.Parameters.AddWithValue("@TotalDays", txtTotalDays.Text);
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
                    cmd.ExecuteNonQuery();

                    // Insert leave details
                    for (DateTime date = fromDate; date <= toDate; date = date.AddDays(1))
                    {
                        cmd.CommandText = @"INSERT INTO Leave_Details (Emp_ID, Leave_Date, Leave_Name) 
                        VALUES (@EmpID, @LeaveDate, @LeaveName)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@EmpID", cboEmpID.SelectedValue);
                        cmd.Parameters.AddWithValue("@LeaveDate", date.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@LeaveName", cboLeavetype.Text);
                        cmd.ExecuteNonQuery();

                        // Update daily attendance
                        cmd.CommandText = "Update Daily_Attendance Set Att_Status = @LeaveName WHERE Emp_ID = @EmpID And Att_Date=@AttDate";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@LeaveName", cboLeavetype.Text);
                        cmd.Parameters.AddWithValue("@EmpID", cboEmpID.SelectedValue);
                        cmd.Parameters.AddWithValue("@AttDate", date.ToString("yyyy-MM-dd"));
                        cmd.ExecuteNonQuery();
                    }

                    // Update leave balance
                    cmd.CommandText = "Update Leave_Balance Set Enjoyed =Enjoyed+@TotalDays WHERE Emp_ID = @EmpID And Year = @Year And Leave_Name= @LeaveName";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@TotalDays", Convert.ToInt32(txtTotalDays.Text));
                    cmd.Parameters.AddWithValue("@EmpID", cboEmpID.SelectedValue);
                    cmd.Parameters.AddWithValue("@Year", Convert.ToInt64(toDate.Year));
                    cmd.Parameters.AddWithValue("@LeaveName", cboLeavetype.Text);
                    cmd.ExecuteNonQuery();
                    trans.Commit();
                    MessageBox.Show("Data Saved successfully.");
                    cboEmpID_SelectedIndexChanged(sender, e);
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
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void cboEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                string sqlQ = $"SELECT Leave_Name, Leave_Days, Enjoyed, Balance FROM Leave_Balance where Emp_ID = '" + cboEmpID.SelectedValue + "' ";

                string sqlQde = $"SELECT     Leave_Name,FromDate, ToDate, Total_Days, Remarks FROM Leave_Master where Emp_ID = '" + cboEmpID.SelectedValue + "' order by FromDate asc ";

                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dataGridView1.DataSource = dataItems;
                foreach (DataGridViewColumn c in dataGridView1.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;

                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQde);
                dgvLeaveHistory.DataSource = dataItems;
                foreach (DataGridViewColumn c in dgvLeaveHistory.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;

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

        private void Test_Leave_Management_Load(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            try
            {

                GlobalInfo.GlobalInfo.combo_add_with_Value(cboEmpID, "select Sys_ID, Emp_ID  from Emp_official_Info order by Len(Emp_ID), Emp_ID");
                GlobalInfo.GlobalInfo.combo_add_with_Value(cboLeavetype, "Select LeaveTypeID, LeaveType_Name from New_LeaveType order by LeaveTypeID");
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

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalDays();
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalDays();
        }
        private void CalculateTotalDays()
        {
            TimeSpan totalDays = Convert.ToDateTime(dtpToDate.Text) - Convert.ToDateTime(dtpFromDate.Text);
            txtTotalDays.Text = Convert.ToString(totalDays.Days + 1);
        }
    }
}
