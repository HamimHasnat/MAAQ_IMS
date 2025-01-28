using MAAQ_IMS.GlobalInfo;
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
    public partial class EmployeeEntry : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        DataTable dataItems = null;
        public EmployeeEntry()
        {
            InitializeComponent();
        }

        private void EmployeeEntry_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                //GlobalInfo.GlobalInfo.combo_add_with_Value(cboDepartment, "SELECT Supp_ID, Supplier_Name FROM [Supplier_Info] ORDER BY Supplier_Name");
                EmpStatus();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control controls in panel2.Controls)
                {
                    if (controls is TextBox || controls is ComboBox) controls.Text = string.Empty;
                }
               


                txtEmpID.Text = GlobalInfo.GlobalInfo.GetMaxID("Emp_official_Info", "Emp_ID").ToString();
                //ItemEntrygridViewBind();
                //LoadSearchGridView();
                //CboSubGroup.DataSource = null;
                //CboCatagory.DataSource = null;
                btnSave.Text = "Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpName.Text) || txtEmpName.Text.Length == 0)
            {
                MessageBox.Show("Emp Name is must.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlQ = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            int _empId = GlobalInfo.GlobalInfo.GetMaxID("Emp_official_Info", "Emp_ID", con);
            SqlTransaction trans = con.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                if (btnSave.Text != "Update")
                {

                    sqlQ = $"INSERT INTO  Employee_Info( Sys_ID, Emp_ID, Emp_Name, Desig_Name, Dept_Name, Joined_Date, Grosss, Basic, HouseRent, MedicalAllow, Emp_Status) VALUES ( @SysID, @Emp_ID, @Emp_Name, @Desig_Name, @Dept_Name, @Joined_Date, @Grosss,@Basic, @HouseRent, @MedicalAllow, @Emp_Status)";
                    cmd.Parameters.AddWithValue("@Emp_ID", _empId);
                    success = "saved";
                }
                else
                {
                    sqlQ = $"UPDATE  Employee_Info SET Sys_ID=@Sys_ID, Emp_ID=@Emp_ID, Emp_Name=@Emp_Name, Desig_Name=@Desig_Name, Dept_Name=@Dept_Name, Joined_Date=@Joined_Date, Grosss=@Grosss, Basic=@Basic, HouseRent=@HouseRent, MedicalAllow=@MedicalAllow, Emp_Status=@Emp_Status";
                    cmd.Parameters.AddWithValue("@Emp_ID", txtEmpID.Text);
                    success = "updated";
                }
                cmd.Parameters.AddWithValue("@Emp_Name", txtEmpName.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Desig_Name", cboDesignation.SelectedValue);
                cmd.Parameters.AddWithValue("@Dept_Name", cboDepartment.SelectedValue);
                cmd.Parameters.AddWithValue("@Joined_Date", dtJoineddate.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Grosss", txtGross.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Basic", txtBasic.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@HouseRent", txtHouseRent.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@MedicalAllow", txtMediAllow.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Emp_Status",cboEmpStatus.SelectedValue);

                cmd.CommandText = sqlQ;
                cmd.ExecuteNonQuery();
                trans.Commit();


                GlobalInfo.GlobalInfo.audit_trail("Item Group Entry Form " + txtEmpName.Text, this.Name);
                MessageBox.Show($"{txtEmpName.Text} {success} successfully");
                btnRefresh_Click(sender, e);

            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); con.Dispose();
            }
        }
        private void EmpStatus()
        {
            cboEmpStatus.Items.Add("Live");
            cboEmpStatus.Items.Add("Quit");
            cboEmpStatus.Items.Add("Left");
            
        }
    }
}
