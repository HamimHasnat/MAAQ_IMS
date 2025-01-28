using MAAQ_IMS.Reports;
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
    public partial class SalaryIncrement : Form
    {
        DataTable dataItems = null;
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        SqlConnection con = new SqlConnection();
        public SalaryIncrement()
        {
            InitializeComponent();
        }

        private void SalaryIncrement_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                GlobalInfo.GlobalInfo.combo_add_with_Value(cboEmpID, "select Sys_ID, Emp_ID  from Emp_official_Info order by Len(Emp_ID), Emp_ID");

                GlobalInfo.GlobalInfo.combo_add_with_Value(cboIncType, @"SELECT  Type_ID, Type_Name
                FROM New_Inc_Type ORDER BY Len(Type_ID),Type_ID");
                btnRefresh_Click(sender, e);
                dgvSalaryInc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void cboEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (GlobalInfo.GlobalInfo.getComboDataValidaty(cboEmpID) == false) return;
            
            try
            {
                string _sqlQ = @"SELECT  E.Sys_ID, E.Emp_ID, E.Emp_Name, D.Dept_Name,DG.Desig_Name,E.Gross,Basic,House_Rent,Medical_Allow,E.Joined_Date,E.OT
FROM Emp_official_Info E Inner join New_Department D on D.Dept_ID = E.Dept_ID
Inner Join New_Designation DG on DG.Desig_ID = E.Desig_ID WHERE (Sys_ID = N'" + cboEmpID.SelectedValue + "') ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(_sqlQ, connection))
                {
                    cmd.Parameters.AddWithValue("@Sys_ID", cboEmpID.SelectedValue);
                    connection.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            txtDepartment.Text = Convert.ToString(r["Dept_Name"]);
                            txtDesignation.Text = Convert.ToString(r["Desig_Name"]);
                            txtEmpName.Text = Convert.ToString(r["Emp_Name"]);
                            txtGross.Text = Convert.ToString(r["Gross"]);
                            dtJoineddate.Text = Convert.ToDateTime(r["Joined_Date"]).ToString("dd-MMM-yyyy");
                            txtBasic.Text = Convert.ToString(r["Basic"]);
                            txtHouseRent.Text = Convert.ToString(r["House_Rent"]);
                            txtMediAllow.Text = Convert.ToString(r["Medical_Allow"]);
                            dgvSalaryInc.DataSource = null;
                            cboEmpID.Text = "-Select-";
                            cboIncType.Text = "-Select-";
                        }
                    }
                }
                _sqlQ = @"select Sys_ID, Increment_Date, Increment_Amt, Increment_Type, Old_Gross, Old_Basic, Old_HouseRent, Old_MediAllow, New_Gross, New_Basic, New_HouseRent, New_MediAllow from Emp_Salary_Increment WHERE (Sys_ID ='" + cboEmpID.SelectedValue + "') ORDER BY Increment_Date";
                dgvSalaryInc.DataSource = GlobalInfo.GlobalInfo.getDataTable(_sqlQ);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void  btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboEmpID.Text) || cboEmpID.Text.Length == 0)
            {
                MessageBox.Show("Employee  ID is must.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboIncType.Text.Length == 0)
            {
                MessageBox.Show("Inc. Type is required.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning); cboIncType.Focus();
                return;
            }
            if (Convert.ToDecimal(txtIncAmount.Text) <= 0)
            {
                MessageBox.Show("Inc. Amt. is required.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlQ = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            SqlTransaction trans = con.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                double oldBasic = Convert.ToDouble(txtBasic.Text),
                _newBasic = Convert.ToDouble(txtBasic.Text) + Convert.ToDouble(txtIncAmount.Text),
                _newGross = 0, _newHouseRent = 0, _NewMA = 1450;
                _newHouseRent = Math.Round(_newBasic * 0.5, 2);
                _newGross = _newBasic + _newHouseRent + _NewMA;
                if (btnSave.Text != "Update")
                {
                    cmd.CommandText = @"INSERT INTO Emp_Salary_Increment ( Sys_ID, Increment_Date,  Increment_Amt, Increment_Type, Old_Gross, Old_Basic, Old_HouseRent, Old_MediAllow,  New_Gross,New_Basic,New_HouseRent,  New_MediAllow) VALUES ('" + cboEmpID.SelectedValue + "','" + dtIncDate.Text + "','" + txtIncAmount.Text + "','" + cboIncType.Text + "','" + txtGross.Text + "','" + txtBasic.Text + "','" + txtHouseRent.Text + "','" + txtMediAllow.Text + "','" + _newGross + "','" + _newBasic + "','" + _newHouseRent + "','" + _NewMA + "')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = @"UPDATE Emp_official_Info SET Gross ='" + _newGross + "', Basic ='" + _newBasic + "', House_Rent ='" + _newHouseRent + "', Medical_Allow ='" + _NewMA + "' WHERE   (Sys_ID = '" + cboEmpID.SelectedValue + "')";
                    cmd.ExecuteNonQuery();
                    success = "Saved";
                }
                else
                {
                    cmd.CommandText = @"UPDATE  Emp_Salary_Increment SET  Increment_Date = '" + dtIncDate.Text + "',Increment_Amt = '" + txtIncAmount.Text + "',Increment_Type ='" + cboIncType.Text + "',Old_Gross= '" + txtGross.Text + "',New_Gross='" + _newGross + "',Old_Basic='" + txtBasic.Text + "',New_Basic='" + _newBasic + "',Old_HouseRent='" + txtHouseRent.Text + "',New_HouseRent='" + _newHouseRent + "',Old_MediAllow='" + txtMediAllow.Text + "',New_MediAllow='" + _NewMA + "' WHERE Sys_ID = '" + cboEmpID.SelectedValue + "'";
                    cmd.ExecuteNonQuery();
                    success = "updated";
                }
                trans.Commit();
                MessageBox.Show("Data Saved successfully.");
                btnRefresh_Click(sender, e);
                //cboEmpID_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); con.Dispose(); this.Cursor = Cursors.Default; }
        }

        private void txtIncPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalInfo.GlobalInfo.numericonly(sender, e);
        }

        private void txtIncAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalInfo.GlobalInfo.numericonly(sender, e);
        }

        private void txtIncPercent_Leave(object sender, EventArgs e)
        {
            try
            {
                double _incAmt = Math.Round(Convert.ToDouble(txtBasic.Text) * Convert.ToDouble(txtIncPercent.Text) / 100, 0);
                txtIncAmount.Text = _incAmt.ToString();
            }
            catch (Exception ex)    
            { MessageBox.Show(ex.Message); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control controls in panel1.Controls)
                {
                    if (controls is TextBox) controls.Text = string.Empty;
                }
                cboIncType.Text = null;
                txtIncPercent.Text = "0";
                txtIncAmount.Text = "0";
                dgvSalaryInc.DataSource = null;
                btnSave.Text = "Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSalaryInc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex != btnAction.Index)
                    return;
                {
                    DataGridViewRow r1 = dgvSalaryInc.Rows[e.RowIndex];
                    cboIncType.Text = Convert.ToString(r1.Cells["Increment_Type"].Value);
                    //txtIncPercent.Text = Convert.ToString(r1.Cells["Increment_Percent"].Value);
                    txtIncAmount.Text = Convert.ToString(r1.Cells["Increment_Amt"].Value);
                    dtIncDate.Text = Convert.ToString(r1.Cells["Increment_Date"].Value);
                    btnSave.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    SqlCommand cmd = new SqlCommand("Exec sp_SalaryInc  '" + cboEmpID.SelectedValue + "' ", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, cmd.CommandText);
                    CrySalaryInc cry = new CrySalaryInc();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
           
            SqlConnection con = new SqlConnection(GlobalInfo.ConnectionInfo.GenerateConnectionString());

            if (con.State == ConnectionState.Closed) con.Open();
            SqlTransaction trans = con.BeginTransaction();

            try
            {
                if (dgvSalaryInc.SelectedRows.Count > 0) 
                {
                    
                    DataGridViewRow selectedRow = dgvSalaryInc.SelectedRows[0];

                    int Sys_ID = Convert.ToInt32(selectedRow.Cells["Sys_ID"].Value);
                    DateTime incrementDate = Convert.ToDateTime(selectedRow.Cells["Increment_Date"].Value);
                    string incrementType = Convert.ToString(selectedRow.Cells["Increment_Type"].Value);

                    decimal incrementAmt = Convert.ToDecimal(selectedRow.Cells["Increment_Amt"].Value);

                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM Emp_Salary_Increment WHERE Sys_ID = @Sys_ID AND Increment_Date = @Increment_Date AND Increment_Type = @Increment_Type", con, trans);
                    deleteCmd.Parameters.AddWithValue("@Sys_ID", Sys_ID);
                    deleteCmd.Parameters.AddWithValue("@Increment_Date", incrementDate);
                    deleteCmd.Parameters.AddWithValue("@Increment_Type", incrementType);
                    deleteCmd.ExecuteNonQuery();

                    double NewBasic = Convert.ToDouble(txtBasic.Text),
                     _oldBasic = Convert.ToDouble(NewBasic) - Convert.ToDouble(incrementAmt),
                    _oldGross = 0, _oldHouseRent = 0, _oldMA = 1450;
                    _oldHouseRent = Math.Round(_oldBasic * 0.5, 2);
                    _oldGross = _oldBasic + _oldHouseRent + _oldMA;

                    SqlCommand restoreCmd = new SqlCommand("UPDATE Emp_official_Info SET Grosss='" + _oldGross + "',Basic='"+ _oldBasic + "',HouseRent='" + _oldHouseRent + "',MedicalAllow ='"+ _oldMA + "' WHERE Sys_ID = @Sys_ID", con, trans);
                    restoreCmd.Parameters.AddWithValue("@Sys_ID", Sys_ID);
                    
                    restoreCmd.ExecuteNonQuery();

                    
                    trans.Commit();

                    MessageBox.Show("Data Deleted successfully.");

                    
                    btnRefresh_Click(sender, e);
                    cboEmpID_SelectedIndexChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                Cursor = Cursors.Default;
            }

        }
    }
}
