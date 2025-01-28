using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAAQ_IMS.MasterEntry
{
    public partial class Time_Attendance : Form
    {
        public Time_Attendance()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

      
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string fName = openFileDialog1.FileName;
            txtexcelName.Text = fName;
            DataTable dt = LoadDataFromExcel(fName);
            dgvta.DataSource = dt;
            Cursor = Cursors.Default;
        }

        private DataTable LoadDataFromExcel(string FileName)
        {
            DataTable RetVal = new DataTable();
            try
            {
                string connString = "";
                string strFileType = Path.GetExtension(FileName).ToLower();
                string path = FileName;
                if (strFileType.Trim() == ".xls")
                {
                    
                    connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=YES;\"";
                }
                else if (strFileType.Trim() == ".xlsx")
                {
                    connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1\";";
                }

                System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection(connString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                DataTable Sheets = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
                string sht = string.Empty;
                foreach (DataRow dr in Sheets.Rows)
                {
                    sht = dr[2].ToString().Replace("'", ""); break;
                   
                }
               
                string query = "SELECT * FROM [" + sht + "]";
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, conn);
                System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(cmd);

                da.Fill(RetVal);
               
                da.Dispose();
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return RetVal;
        }


        private void btnSave_Click(object sender, EventArgs e)
        { 
           if (MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            SqlConnection Conn = new SqlConnection(GlobalInfo.ConnectionInfo.GenerateConnectionString());

            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }

            SqlCommand cmd = new SqlCommand();
            SqlTransaction SqlTrans = Conn.BeginTransaction();
            cmd.Transaction = SqlTrans;
            cmd.Connection = Conn;

            try
            {
                Cursor = Cursors.WaitCursor;

                foreach (DataGridViewRow row in dgvta.Rows)
                {
                    // Ensure the row has at least 4 cells (or the required number of cells)
                    if (row.Cells.Count >= 3)
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(row.Cells[1].Value)))
                        {
                            cmd.CommandText = "INSERT INTO Emp_Att_Raw_Data(Emp_ID, Att_Date, Att_Time) " +
                                " VALUES (@Emp_ID, @Att_Date, @Att_Time)";

                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Emp_ID", row.Cells[0].Value);
                            cmd.Parameters.AddWithValue("@Att_Date", row.Cells[1].Value);
                            cmd.Parameters.AddWithValue("@Att_Time", row.Cells[2].Value);
                           

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Row does not contain the expected number of cells.");
                    }
                }

                SqlTrans.Commit();
                MessageBox.Show("Save successfully.");

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Dispose();
                Conn.Close();
                Cursor = Cursors.Default;
            }
        }

        private void Time_Attendance_Load(object sender, EventArgs e)
        {

        }
    }
            
}
