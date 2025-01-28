using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MAAQ_IMS.MasterEntry
{
  
    public partial class NewLoanEntry : Form
    {

        public NewLoanEntry()
        {
            InitializeComponent();
        }
        private void NewLoanEntry_Load(object sender, EventArgs e)
        { 
            GlobalInfo.GlobalInfo.combo_add_with_Value(cboEmpID, @"SELECT  Sys_ID, Emp_ID FROM Emp_official_Info ORDER BY Sys_ID");
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpName.Text) || txtEmpName.Text.Length == 0)
            {
                MessageBox.Show("Employee  Name is must.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlQ = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            int _loanId = GlobalInfo.GlobalInfo.GetMaxID("New_Loan_Entry", "Loan_ID", con);
            SqlTransaction trans = con.BeginTransaction(); cmd.Transaction = trans;
            try
            {
                if (btnSave.Text != "Update")
                {
                    sqlQ = $"INSERT INTO New_Loan_Entry(Loan_ID,Emp_ID,Emp_Name,Dept_ID,Gross_Amt,Loan_Amt,Payable_Month,Interest,Effect_Date,Loan_Balance,Monthly_Deduction,Interest_Amt,Flat_Interest,Average_Deduction) VALUES ('"+ _loanId + "','"+cboEmpID.SelectedValue+"','"+txtEmpName.Text+ "','" + Convert.ToInt32(txtHiddenDepartmentId.Text) + "','" + Convert.ToDecimal(txtGrossAmt.Text) + "','" + Convert.ToDecimal(txtLoanAmt.Text) + "','" + Convert.ToDecimal(txtPayableMonth.Text) + "','" + Convert.ToDecimal(txtInterest.Text) + "','" + Convert.ToDateTime(dtpEffectDate.Text).ToString("dd-MMM-yyyy") + "','" + 0.00 + "','" + 0.00 + "','" + 0.00 + "','" + 0.00 + "','" + 0.00 + "')";
                    success = "Saved";
                }
                else
                {
                    sqlQ = $"UPDATE  New_Loan_Entry SET Loan_ID = @Loan_ID,Emp_ID = @Emp_ID,Emp_Name = @Emp_Name,Dept_ID = @Dept_ID,Gross_Amt = @Gross_Amt,Loan_Amt = @Loan_Amt,Payable_Month = @Payable_Month,Interest = @Interest,Effect_Date = @Effect_Date,Loan_Balance = @Loan_Balance,Monthly_Deduction = @Monthly_Deduction,Interest_Amt = @Interest_Amt,Flat_Interest = @Flat_Interest,Average_Deduction = @Average_Deduction where Loan_ID = @Loan_ID";
                    cmd.Parameters.AddWithValue("@Loan_ID", txtLoanID.Text);
                    success = "updated";
                }


                cmd.CommandText = sqlQ;
                cmd.ExecuteNonQuery();
                trans.Commit();
                GlobalInfo.GlobalInfo.audit_trail("Loan Entry Form " + cboEmpID.Text, Name);

                MessageBox.Show($"{cboEmpID.Text} {success} successfully");
                btnReset_Click(sender, e);

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
        private void GetdataItems()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {
                //int _empId = 0; /*_empId = 0, _deptId = 0*/
                //if (cboEmpID.Text != "--Select--")
                //    _empId = Convert.ToInt32(cboEmpID.SelectedValue.ToString());
               

                //if (cboEmpName.Text != "--Select--" && !string.IsNullOrWhiteSpace(cboEmpID.Text))
                //    _empId = Convert.ToInt32(cboEmpName.SelectedValue.ToString());

                //if (cboDept.Text != "--Select--" && !string.IsNullOrWhiteSpace(cboDept.Text))
                //    _deptId = Convert.ToInt32(cboDept.SelectedValue.ToString());


                //                sqlQ = @"SELECT IE.Item_ID,IG.Group_Name, SG.SubGroup_Name, IC.Category_Name,  IE.Item_Name, UI.Unit_Name, IE.Item_PCode, BI.Brand_Name, IE.Item_Size_Width, IE.Item_Model_Origin, CI.Color_Name,IE.Item_Article, EC.Expense_CategoryName, IE.Item_ShadeNo, IE.Item_Unit_Price, IE.Item_Vat,IE.Item_MinLQ,ie.Item_MaxLQ, IE.Item_Remarks 
                //FROM New_Item_Entry IE INNER JOIN New_Brand_Info BI ON BI.Brand_ID = IE.Brand_ID INNER JOIN New_Color_Info CI ON IE.Color_ID = CI.Color_ID INNER JOIN New_Expense_Category EC ON IE.ExpCategory_ID = EC.Expense_CategoryID INNER JOIN New_Item_Category IC ON IE.Category_ID = IC.Category_ID INNER JOIN New_Item_Group IG ON IE.Group_ID = IG.Group_ID INNER JOIN New_Item_SubGroup SG ON IE.SubGroup_ID = SG.SubGroup_ID INNER JOIN New_Unit_Info UI ON IE.Unit_ID = UI.Unit_ID";

                //dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);

                //dgvLoan.DataSource = dataItems;
                //foreach (DataGridViewColumn c in dgvLoan.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SqlConnection con = new SqlConnection(GlobalInfo.ConnectionInfo.GenerateConnectionString());
            if (con.State == ConnectionState.Closed) con.Open();
            SqlTransaction trans = con.BeginTransaction();
            try
            {
                if (txtLoanID.Text.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand("Delete from  New_Loan_Entry where Loan_ID = @Loan_ID", con);
                    cmd.Parameters.AddWithValue("@Loan_ID", txtLoanID.Text);
                    cmd.Transaction = trans;
                    cmd.ExecuteNonQuery();
                    trans.Commit();
                    GlobalInfo.GlobalInfo.audit_trail($"Loan Entry Form  deleted: " + cboEmpID.Text, this.Name);
                    MessageBox.Show($"{cboEmpID.Text} deleted successfully");
                    btnReset_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                con.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control controls in panel1.Controls)
                {
                    if (controls is TextBox || controls is ComboBox) controls.Text = string.Empty;
                }

                txtLoanID.Text = GlobalInfo.GlobalInfo.GetMaxID("New_Loan_Entry", "Loan_ID").ToString();

                GetdataItems();
                LoadDataGridView();
                btnSave.Text = "Save";
                cboEmpID.DataSource = null;              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //or Color_Name like'%" + txtSearch.Text + "%' or Item_Article like '%" + txtSearch.Text + "%' or Expense_CategoryName like '%" + txtSearch.Text + "%' or Item_Remarks like '%" + txtSearch.Text + "%'
        private void LoadDataGridView()
        {
            try
            {

                if (txtSearch.Text.Trim().Length == 0) return;

                //DataRow[] dr = dataItems.Select("Loan_ID like '%" + txtSearch.Text + "%' or Emp_UnitName like '%" + txtSearch.Text + "%' or Emp_Name like'%" + txtSearch.Text + "%' or  Dept_Name like '%" + txtSearch.Text + "%' or Gross_Amt like'%" + txtSearch.Text + "%' or Loan_Amt like '%" + txtSearch.Text + "%' or Payable_Month like '%" + txtSearch.Text + "%' or Interest like '%" + txtSearch.Text + "%' or Effect_Date like '%" + txtSearch.Text + "%' ");

                //int index = dataItems.Rows.IndexOf(dr[0]);
                //dgvLoan.ClearSelection(); dgvLoan.Rows[index].Selected = true;
                //dgvLoan.FirstDisplayedScrollingRowIndex = index;
                //txtSearch.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (e.RowIndex < 0)
                    return;
                {
                    DataGridViewRow r1 = dgvLoan.Rows[e.RowIndex];
                    txtLoanID.Text = Convert.ToString(r1.Cells["Loan_ID"].Value);
                    //cboEmpUnit.Text = Convert.ToString(r1.Cells["Emp_UnitName"].Value);
                    cboEmpID.Text = Convert.ToString(r1.Cells["Emp_Name"].Value);
                   // cboDept.Text = Convert.ToString(r1.Cells["Dept_Name"].Value);
                    txtGrossAmt.Text = Convert.ToString(r1.Cells["Gross_Amt"].Value);

                    txtLoanAmt.Text = Convert.ToString(r1.Cells["Loan_Amt"].Value);
                    txtPayableMonth.Text = Convert.ToString(r1.Cells["Payable_Month"].Value);
                    txtInterest.Text = Convert.ToString(r1.Cells["Interest"].Value);
                    //txtEffectDate.Text = Convert.ToString(r1.Cells["Effect_Date"].Value);

                    btnSave.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadDataGridView();
        }

        

        private void cboEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GlobalInfo.GlobalInfo.getComboDataValidaty(cboEmpID) == false) return;
            try
            {
                string _sqlQ = @"SELECT E.Emp_ID, E.Emp_Name, E.Joined_Date, E.Gross, E.Desig_ID, D.Dept_Name, T.Desig_Name, E.Dept_ID
FROM Emp_official_Info AS E INNER JOIN New_Department AS D ON E.Dept_ID = D.Dept_ID INNER JOIN New_Designation AS T ON E.Desig_ID = T.Desig_ID WHERE (E.Sys_ID = N'" + cboEmpID.SelectedValue+"') ";
                DataTable _dt = GlobalInfo.GlobalInfo.getDataTable(_sqlQ);
                if(_dt.Rows.Count>0)
                {
                    foreach(DataRow r in _dt.Rows)
                    {
                        txtHiddenDepartmentId.Text = Convert.ToString(r["Dept_ID"]);
                        txtDepartment.Text = Convert.ToString(r["Dept_Name"]);
                        txtDesignation.Text = Convert.ToString(r["Desig_Name"]);
                        txtEmpName.Text = Convert.ToString(r["Emp_Name"]);
                        txtGrossAmt.Text = Convert.ToString(r["Gross"]);
                        txtJoinDate.Text = Convert.ToDateTime(r["Joined_Date"]).ToString("dd-MMM-yyyy");
                    }
                }_dt.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                decimal loanAmt = Convert.ToDecimal(txtLoanAmt.Text);
                int installmentNo = Convert.ToInt32(txtPayableMonth.Text);

                decimal interestPercent = Convert.ToDecimal(txtInterest.Text); ;
                decimal monthlyInstallmentLoanamt = Math.Round(loanAmt / installmentNo, 2);
                decimal balance = loanAmt;
                decimal interestAmt = 0;// loanAmt * interestPercent / installmentNo / 100;
                decimal totalInterest = interestAmt;
                decimal flatInterest = 0.00m;

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Installment Number", typeof(int));
                dataTable.Columns.Add("Month-Year", typeof(string));
                dataTable.Columns.Add("Loan Amt", typeof(decimal));
                dataTable.Columns.Add("Balalnce Amt", typeof(decimal));
                dataTable.Columns.Add("Monthly Installment", typeof(decimal));
                dataTable.Columns.Add("Interest Amt", typeof(decimal));
                dataTable.Columns.Add("Flat Interest", typeof(decimal));
                dataTable.Columns.Add("Monthly Deduction", typeof(decimal));
                string _montYear = dtpEffectDate.Value.ToString("MMM-yyyy");

                int _sl = 1;
                while (_sl <= installmentNo)
                {
                    balance = Math.Round(loanAmt - monthlyInstallmentLoanamt, 2);
                    interestAmt = Math.Round(loanAmt * interestPercent / installmentNo / 100, 2);
                    totalInterest += interestAmt;


                    dataTable.Rows.Add(_sl, _montYear, loanAmt, balance, monthlyInstallmentLoanamt, interestAmt, flatInterest, monthlyInstallmentLoanamt);
                    //Next Row
                    loanAmt = Math.Round(loanAmt - monthlyInstallmentLoanamt, 2);
                    _montYear = dtpEffectDate.Value.AddMonths(_sl).ToString("MMM-yyyy");
                    _sl++;
                }
                flatInterest = Math.Round(totalInterest / installmentNo, 2);
                monthlyInstallmentLoanamt = monthlyInstallmentLoanamt + flatInterest;
                dgvLoan.Rows.Clear();
                foreach (DataRow r in dataTable.Rows)
                {
                    dgvLoan.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], flatInterest, monthlyInstallmentLoanamt);
                }
                _getTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { this.Cursor = Cursors.Default; }

        }
        void _getTotal()
        {
            decimal _totPrinAmt = 0, _totIntAmt = 0, _totPrinIntAmt = 0;
            foreach(DataGridViewRow r in dgvLoan.Rows)
            {
                _totPrinAmt += Convert.ToDecimal(r.Cells[txtGridMonthLoan.Index].Value);
                _totIntAmt += Convert.ToDecimal(r.Cells[txtGridIntAmt.Index].Value);
                _totPrinIntAmt += Convert.ToDecimal(r.Cells[txtGridMonthlyDeduct.Index].Value);
            }
            lblIntAmt.Text = _totIntAmt.ToString();lblPrinAmt.Text = _totPrinAmt.ToString();lblprinIntAmt.Text = _totPrinIntAmt.ToString();
        }




    }
}
