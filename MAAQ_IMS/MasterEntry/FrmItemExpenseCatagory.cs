//using DevExpress.XtraCharts.Native;
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
    public partial class FrmItemExpenseCatagory : Form
    {
        [Obsolete]
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        DataTable dataItems = null;

        [Obsolete]
        public FrmItemExpenseCatagory()
        {
            InitializeComponent();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrEmpty(txtExpenseID.Text) || txtExpenseName.Text.Length == 0)
            {
                MessageBox.Show("Exp Catagory is must.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlQ = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            int _Expense_CategoryID = GlobalInfo.GlobalInfo.GetMaxID("New_Expense_Category", "Expense_CategoryID", con);
            SqlTransaction trans = con.BeginTransaction(); cmd.Transaction = trans;
            try
            {
                if (btnSave.Text != "Update")
                {

                    sqlQ = @"insert into New_Expense_Category(Expense_CategoryID,Expense_CategoryName)
                       Values(@Expense_CategoryID,@Expense_CategoryName)";
                      cmd.Parameters.AddWithValue("@Expense_CategoryID", _Expense_CategoryID);
                      success = "saved";
                }
                else
                {
                    sqlQ = $"UPDATE  New_Expense_Category SET Expense_CategoryName = @Expense_CategoryName where Expense_CategoryID = @Expense_CategoryID";
                     cmd.Parameters.AddWithValue("@Expense_CategoryID", txtExpenseID.Text);
                     success = "updated";
                }
                
                cmd.Parameters.AddWithValue("@Expense_CategoryName", txtExpenseName.Text.Trim().ToUpper());
                


                cmd.CommandText = sqlQ;
                cmd.ExecuteNonQuery();
                trans.Commit();


                GlobalInfo.GlobalInfo.audit_trail(" Exp Catagory Entry Form " + txtExpenseName.Text, this.Name);
                MessageBox.Show($"{txtExpenseName.Text} {success} successfully");
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


       

        private void FrmItemExpenseCatagory_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {

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

        private void ExpCatagoryBind()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {
                sqlQ = @"Select Expense_CategoryID,Expense_CategoryName from New_Expense_Category order By Expense_CategoryName";
                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dgvExpCatagory.DataSource = dataItems;
                foreach (DataGridViewColumn c in dgvExpCatagory.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;

            }
            catch ( Exception ex )
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
                foreach (Control controls in panel3.Controls)
                {
                    if (controls is TextBox || controls is ComboBox) controls.Text = string.Empty;
                }

                txtExpenseID.Text = GlobalInfo.GlobalInfo.GetMaxID("New_Expense_Category", "Expense_CategoryID").ToString();
                ExpCatagoryBind();
                LoadSearchGridView();
                btnSave.Text = "Save";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSearchGridView()
        {
            try
            {
                if (txtSearch.Text.Trim().Length == 0) return;
                DataRow[] dr = dataItems.Select("Expense_CategoryName like'%" + txtSearch.Text + "%");
                int index = dataItems.Rows.IndexOf(dr[0]);
                dgvExpCatagory.ClearSelection(); dgvExpCatagory.Rows[index].Selected = true;
                dgvExpCatagory.FirstDisplayedScrollingRowIndex = index;
                txtSearch.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadSearchGridView();
        }

        private void dgvExpCatagory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (e.ColumnIndex == btnGridSelect.Index)
                {
                    DataGridViewRow r1 = dgvExpCatagory.Rows[e.RowIndex];
                    txtExpenseID.Text = Convert.ToString(r1.Cells["Expense_CategoryID"].Value);
                    txtExpenseName.Text = Convert.ToString(r1.Cells["Expense_CategoryName"].Value);
                   
                    btnSave.Text = "Update";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
