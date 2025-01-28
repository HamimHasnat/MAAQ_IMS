using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAAQ_IMS.MasterEntry
{
    public partial class Daily_Attendance : Form
    {
        DataTable dataItems = null;
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        SqlConnection con = new SqlConnection();
        public Daily_Attendance()
        {
            InitializeComponent();
        }

        private void Daily_Attendance_Load(object sender, EventArgs e)
        {

            dtpAtt.ValueChanged += dtpAtt_ValueChanged;
            con = new SqlConnection(connectionString);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            string sqlQ = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            
            SqlTransaction trans = con.BeginTransaction();
            cmd.Transaction = trans;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string _status = "P";
                if(rdbHP.Checked==true) _status = "H";
                if (rdbWP.Checked == true) _status = "W";
                 cmd.CommandText = ("sp_DataProcess");
                cmd.CommandType = CommandType.StoredProcedure;
                //string formattedDate = dtpAtt.Value.Date.ToString("YYYY-MM-DD");
                //DateTime formattedDate = Convert.ToDateTime("yyyy-MMM-dd");
                cmd.Parameters.AddWithValue("@AttDate", Convert.ToDateTime(dtpAtt.Value).ToString("yyyy-MM-dd"));
                

                cmd.Parameters.AddWithValue("@Status", _status);
                cmd.ExecuteNonQuery();
                trans.Commit();
                MessageBox.Show("Attendance process successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _loadProcessData();

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
    
        void _loadProcessData()
        {
            try
            {
                string _sql = @"SELECT e.Emp_ID,E.Emp_Name,D.Dept_Name,DG.Desig_Name,E.Joined_Date, Att_Date, Att_Status,convert(time, In_Time)In_Time, convert(time,Out_Time)Out_Time, Working_Hour, E.OT, Total_HR, Total_Min FROM Daily_Attendance da Inner join Emp_official_Info E on da.Emp_ID =E.Emp_ID Inner join New_Department D on e.Dept_ID = D.Dept_ID 
Inner join New_Designation DG on e.Desig_ID = DG.Desig_ID where (Att_Date='" + dtpAtt.Text+ "') order by LEN(E.Emp_ID),Emp_ID";
                dgvAtt.DataSource = GlobalInfo.GlobalInfo.getDataTable(_sql);
            }
            catch (Exception)
            {  }
        }

        private void dtpAtt_ValueChanged(object sender, EventArgs e)
        {
            _loadProcessData();
            //RetrieveAttendance(dtpAtt.Value.Date); 
        }
        private void RetrieveAttendance(DateTime selectedDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Emp_Att_Raw_Data WHERE Att_Date = @AttDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AttDate", selectedDate);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvAtt.DataSource = dataTable;
            }
        }
    }
}
