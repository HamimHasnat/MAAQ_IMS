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
    public partial class frmItemGroup : Form
    {
        DataTable dataItems = null;
        public frmItemGroup()
        {
            InitializeComponent();
        }

        private void ItemGroup_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
               
                btnReset_Click(sender, e);
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtGroupName.Text) || txtGroupName.Text.Length == 0)
            {
                MessageBox.Show("Item  Group is must.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlQ = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            int _groupId =GlobalInfo.GlobalInfo.GetMaxID("New_Item_Group", "Group_ID", con);
            SqlTransaction trans = con.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                if (btnSave.Text != "Update")
                {
                    
                    sqlQ = $"INSERT INTO New_Item_Group(Group_ID, Group_Name, Group_ShortCode) VALUES (@Group_ID,@Group_Name,@Group_ShortCode)";
                    cmd.Parameters.AddWithValue("@Group_ID", _groupId);
                    success = "saved";
                }
                else
                {
                    sqlQ = $"UPDATE  New_Item_Group SET Group_Name = @Group_Name, Group_ShortCode = @Group_ShortCode where Group_ID = @Group_ID";
                    cmd.Parameters.AddWithValue("@Group_ID", txtGroupID.Text);
                    success = "updated";
                }
                cmd.Parameters.AddWithValue("@Group_Name", txtGroupName.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Group_ShortCode", txtGroupShortCode.Text.Trim().ToUpper());
               
               
                cmd.CommandText = sqlQ;
                cmd.ExecuteNonQuery();
                trans.Commit();


                GlobalInfo.GlobalInfo.audit_trail("Item Group Entry Form " + txtGroupName.Text, this.Name);
                MessageBox.Show($"{txtGroupName.Text} {success} successfully");
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
                sqlQ = $"Select Group_ID,Group_Name,Group_ShortCode from New_Item_Group order By  Group_ID";
                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dgvItemGroup.DataSource = dataItems;
                foreach (DataGridViewColumn c in dgvItemGroup.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                Cursor = Cursors.Default;
               
            }
           
        }

        private void dgvItemGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (e.ColumnIndex == btnGridSelect.Index)
                {
                    DataGridViewRow r1 = dgvItemGroup.Rows[e.RowIndex];
                    txtGroupID.Text = Convert.ToString(r1.Cells["Group_ID"].Value);
                    txtGroupName.Text = Convert.ToString(r1.Cells["Group_Name"].Value);
                    txtGroupShortCode.Text = Convert.ToString(r1.Cells["Group_ShortCode"].Value);
                    btnSave.Text = "Update";
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadDataGridView()
        {
           
            try
            {
                if (txtSearch.Text.Trim().Length == 0) return;
                DataRow[] dr = dataItems.Select("Group_Name like'%" + txtSearch.Text + "%' or Group_ShortCode like '%" + txtSearch.Text + "%'  ");
                int index = dataItems.Rows.IndexOf(dr[0]);
                dgvItemGroup.ClearSelection(); dgvItemGroup.Rows[index].Selected = true;
                dgvItemGroup.FirstDisplayedScrollingRowIndex = index;
                txtSearch.SelectAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                     
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SqlConnection con = new SqlConnection(ConnectionInfo.GenerateConnectionString());
            if (con.State == ConnectionState.Closed) con.Open();
            SqlTransaction trans = con.BeginTransaction();
            try
            {
                if (txtGroupID.Text.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand("Delete from  New_Item_Group where Group_ID = @Group_ID", con);
                    cmd.Parameters.AddWithValue("@Group_ID", txtGroupID.Text);
                    cmd.Transaction = trans;
                    cmd.ExecuteNonQuery();
                    trans.Commit();
                    GlobalInfo.GlobalInfo.audit_trail($"ItemGroup Entry Form  deleted: " + txtGroupName.Text, this.Name);
                    MessageBox.Show($"{txtGroupName.Text} deleted successfully");
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
                foreach(Control controls in panel1.Controls)
                {
                   if (controls is TextBox || controls is ComboBox) controls.Text = string.Empty;
                }

                txtGroupID.Text = GlobalInfo.GlobalInfo.GetMaxID("New_Item_Group", "Group_ID").ToString();
                GetdataItems();
                LoadDataGridView();
                btnSave.Text = "Save";
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadDataGridView();
        }

        private void dgvItemGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
