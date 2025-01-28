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
    public partial class SalaryProcess : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        public SalaryProcess()
        {
            InitializeComponent();
        }

        private void SalaryProcess_Load(object sender, EventArgs e)
        {


            GlobalInfo.GlobalInfo.combo_add_with_Value(cboEmpID, @"SELECT Sys_ID, Emp_ID FROM Emp_official_Info ORDER BY Sys_ID");
            GlobalInfo.GlobalInfo.combo_add(cboDepart, @"Select Dept_Name from New_Department order by Dept_ID");

            GlobalInfo.GlobalInfo.combo_add(cboEmpType, @"SELECT Emp_Type FROM Emp_official_Info Group BY Emp_Type order By Emp_Type");

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            int daysInMonth = (int)(endDate - startDate).TotalDays + 1;
            int workingDays = daysInMonth == 31 ? 27 : daysInMonth == 30 ? 26 : 26;

            txtCalDay.Text = workingDays.ToString();

        }
      

        private void btnSalaryProcess_Click(object sender, EventArgs e)
        {
            string fromDate = dtpStartDate.Value.ToString("yyyy-MMM-dd");
            string toDate = dtpEndDate.Value.ToString("yyyy-MMM-dd");
         
            int empId = 0;
            if (cboEmpID.Text.Length > 0)
                empId = Convert.ToInt32(cboEmpID.SelectedValue.ToString());
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            if (conn.State == ConnectionState.Closed) conn.Open();
            cmd.Connection = conn;


            try
            {

                cmd.CommandText = "Exec SalaryProcess '"+ empId + "', '" + fromDate + "', '" + toDate + "', '" + cboEmpType.Text + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Salary data processed and saved successfully.");
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

        private void cboEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string selectedEmpId = cboEmpID.SelectedValue?.ToString();

            //    if (selectedEmpId == "MAAQ_IMS.GlobalInfo.GlobalInfo+AddValue") return;

            //    if (!string.IsNullOrEmpty(selectedEmpId))
            //    {
            //        string sqlQuery = $"SELECT Emp_Type FROM Emp_official_Info WHERE Emp_ID = '{selectedEmpId}'";
            //        string empType = MAAQ_IMS.GlobalInfo.GlobalInfo.GetSingleField(sqlQuery);
            //        cboEmpType.Text = empType;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error fetching employee type: " + ex.Message);
            //}
        }

        private void cboDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                string selectedDeptId = cboDepart.SelectedValue?.ToString();
                if (selectedDeptId == "MAAQ_IMS.GlobalInfo.GlobalInfo+AddValue") return;

                if (!string.IsNullOrEmpty(selectedDeptId))
                {
                    string sqlQuery = $"SELECT Sec_ID, Sec_Name FROM New_Section WHERE Dept_ID = {selectedDeptId} ORDER BY Sec_Name";
                    MAAQ_IMS.GlobalInfo.GlobalInfo.combo_add_with_Value(cboSection, sqlQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sections: " + ex.Message);
            }
        }

        private void cboSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedSectionId = cboSection.SelectedValue?.ToString();
                if (selectedSectionId == "MAAQ_IMS.GlobalInfo.GlobalInfo+AddValue") return;
                if (!string.IsNullOrEmpty(selectedSectionId))
                {
                    string sqlQuery = $"SELECT Sys_ID, Emp_ID FROM Emp_official_Info WHERE Sec_ID = {selectedSectionId} ORDER BY Sys_ID";
                    MAAQ_IMS.GlobalInfo.GlobalInfo.combo_add_with_Value(cboEmpID, sqlQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }
    }
}
