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
    public partial class New_Unit_Info : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        DataTable dataItems = null;
        public New_Unit_Info()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUnitId.Text) || txtUnitName.Text.Length == 0)
            {
                MessageBox.Show("New_Unit_Info", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Squery = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            int _UnitId = GlobalInfo.GlobalInfo.GetMaxID("New_Unit_Info", "Unit_ID", con);
            SqlTransaction trans = con.BeginTransaction(); cmd.Transaction = trans;
            try
            {
                if (btnSave.Text != "Update")
                {
                    Squery = @"insert into New_Unit_Info(Unit_ID,Unit_Name)
                    Values(@Unit_ID,@Unit_Name,@Unit_ShortCode)";
                    cmd.Parameters.AddWithValue("@Unit_ID", _UnitId);
                    success = "saved";

                }
                else
                {
                    Squery = @"update New_Unit_Info Set Unit_Name=@Unit_Name where Unit_ID=@Unit_ID";
                    cmd.Parameters.AddWithValue("@Unit_ID", txtUnitId.Text.Trim().ToUpper());
                    success = "updated";

                }
                cmd.Parameters.AddWithValue("@Unit_Name", txtUnitName.Text.Trim().ToUpper());
                

                cmd.CommandText = Squery;
                cmd.ExecuteNonQuery();
                trans.Commit();


                GlobalInfo.GlobalInfo.audit_trail("  New_Unit_Info Enty Form " + txtUnitName.Text, this.Name);
                MessageBox.Show($"{txtUnitName.Text} {success} successfully");
                btnRefresh_Click(sender, e);


            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
        }

        private void New_Unit_Info_Load(object sender, EventArgs e)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control controls in panel3.Controls)
                {
                    if (controls is TextBox || controls is ComboBox) controls.Text = string.Empty;
                }

                txtUnitId.Text = GlobalInfo.GlobalInfo.GetMaxID("New_Unit_Info", "Unit_ID").ToString();
                ExpUnitBind();
                LoadSearchGridView();
                btnSave.Text = "Save";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (e.ColumnIndex == btnGridSelect.Index)
                {

                    DataGridViewRow r1 = dgvUnit.Rows[e.RowIndex];
                    txtUnitId.Text = Convert.ToString(r1.Cells["Unit_ID"].Value);
                    txtUnitName.Text = Convert.ToString(r1.Cells["Unit_Name"].Value);
                    
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
            if (e.KeyCode == Keys.Enter) LoadSearchGridView();
        }

        private void LoadSearchGridView()
        {
            try
            {
                if (txtSearch.Text.Trim().Length == 0) return;
                DataRow[] dr = dataItems.Select("Unit_Name like'%" + txtSearch.Text + "%' ");
                int index = dataItems.Rows.IndexOf(dr[0]);
                dgvUnit.ClearSelection(); dgvUnit.Rows[index].Selected = true;
                dgvUnit.FirstDisplayedScrollingRowIndex = index;
                txtSearch.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ExpUnitBind()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {
                sqlQ = @"Select Unit_ID,Unit_Name from New_Unit_Info order By Unit_ID";
                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dgvUnit.DataSource = dataItems;
                foreach (DataGridViewColumn c in dgvUnit.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;

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
