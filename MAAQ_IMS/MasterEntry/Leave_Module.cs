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

namespace MAAQ_IMS.MasterEntry
{
    public partial class Leave_Module : Form
    {
        DataTable dataItems = null;
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        SqlConnection con = new SqlConnection();
        public Leave_Module()
        {
            InitializeComponent();

        }

        private void Leave_Module_Load(object sender, EventArgs e)
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
            try
            {
                cmd.CommandText = @"INSERT INTO Leave_Master (Emp_ID, FromDate, ToDate, Leave_Name, Total_Days, Remarks) 
                                VALUES ('" + cboEmpID.SelectedValue + "','" + Convert.ToDateTime(dtpFromDate.Text).ToString("dd-MMM-yyyy") + "','" + Convert.ToDateTime(dtpToDate.Text).ToString("dd-MMM-yyyy") + "','" + cboLeavetype.Text + "','" + txtTotalDays.Text + "','" + txtRemarks.Text + "')";
                cmd.ExecuteNonQuery();

                DateTime startDate = dtpFromDate.Value.Date;
                DateTime endDate = dtpToDate.Value.Date;
                //Validation
                if (endDate < startDate)
                {
                    MessageBox.Show("To Date cannot be earlier than From Date.");
                    return;
                }
                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    //velidation
                    cmd.CommandText = "SELECT COUNT(*) FROM Leave_Details WHERE Emp_ID = '" + cboEmpID.SelectedValue + "' AND Leave_Date = '" + date.ToString("yyyy-MM-dd") + "' AND (Leave_Name = 'SL' OR Leave_Name = 'CL' OR Leave_Name = 'EL')";
                    int existingLeaveCount = (int)
                        cmd.ExecuteScalar();

                    if (existingLeaveCount > 0)
                    {
                        MessageBox.Show("An employee cannot take different types of leave on the same date.");
                        return;
                    }
                    //insert_to_Leave_Enjoy
                    cmd.CommandText = @"INSERT INTO Leave_Details (Emp_ID, Leave_Date, Leave_Name) 
                                VALUES ('" + cboEmpID.SelectedValue + "','" + date.ToString("yyyy-MM-dd") + "','" + cboLeavetype.Text + "')";
                    cmd.ExecuteNonQuery();

                    // update da
                    cmd.CommandText = "Update Daily_Attendance Set Att_Status = '" + cboLeavetype.Text + "'" + " WHERE Emp_ID = '" + cboEmpID.SelectedValue + "' And Att_Date='" + date.ToString("yyyy-MM-dd") + "'";
                    cmd.ExecuteNonQuery();
                }
                // update leave balance
                cmd.CommandText = "Update Leave_Balance Set Enjoyed =Enjoyed+'" + Convert.ToInt32(txtTotalDays.Text) + "' WHERE Emp_ID = '" + cboEmpID.SelectedValue + "' And Year ='" + Convert.ToInt64(endDate.Year) + "' And Leave_Name='" + cboLeavetype.Text + "' ";
                cmd.ExecuteNonQuery();
                trans.Commit();
                MessageBox.Show("Data Saved successfully.");
                cboEmpID_SelectedIndexChanged( sender,  e);

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

   
    }
}

