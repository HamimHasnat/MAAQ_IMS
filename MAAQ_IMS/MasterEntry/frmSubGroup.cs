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
    public partial class frmSubGroup : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        DataTable dataItems = null;
        public frmSubGroup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubGroupName.Text) || txtSubGroupName.Text.Length == 0)
            {
                MessageBox.Show("Item Sub Group is must.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlQ = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            int _subgroupId = GlobalInfo.GlobalInfo.GetMaxID("New_Item_SubGroup", "SubGroup_ID", con);
            SqlTransaction trans = con.BeginTransaction(); cmd.Transaction = trans;
            try
            {
                if (btnSave.Text != "Update")
                {

                    sqlQ = $"INSERT INTO New_Item_SubGroup(SubGroup_ID, SubGroup_Name, SubGroup_ShortCode,Group_ID) VALUES (@SubGroup_ID,@SubGroup_Name,@SubGroup_ShortCode,@Group_ID)";
                    cmd.Parameters.AddWithValue("@SubGroup_ID", _subgroupId);

                    success = "saved";
                }
                else
                {
                    sqlQ = $"UPDATE  New_Item_SubGroup SET SubGroup_Name = @SubGroup_Name, SubGroup_ShortCode = @SubGroup_ShortCode,Group_ID = @Group_ID where SubGroup_ID = @SubGroup_ID";
                    cmd.Parameters.AddWithValue("@SubGroup_ID", txtSubGroupID.Text);
                    success = "updated";
                }
                
                cmd.Parameters.AddWithValue("@SubGroup_Name", txtSubGroupName.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@SubGroup_ShortCode", txtSubGroupShortCode.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Group_ID", CboGroup.SelectedValue);
                cmd.CommandText = sqlQ;
                cmd.ExecuteNonQuery();
                trans.Commit();
                GlobalInfo.GlobalInfo.audit_trail("Item SubGroup Entry Form " + txtSubGroupName.Text, this.Name);

                MessageBox.Show($"{txtSubGroupName.Text} {success} successfully");
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

        private void frmSubGroup_Load(object sender, EventArgs e)
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
                GlobalInfo.GlobalInfo.PopulateCombobox(CboGroup, "Group_ID", "Group_Name", "New_Item_Group", "Group_Name");
                txtSubGroupID.Text = GlobalInfo.GlobalInfo.GetMaxID("New_Item_SubGroup", "SubGroup_ID").ToString();
                ItemSubCatagoryBind();
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

                    DataGridViewRow r1 = dataGridView1.Rows[e.RowIndex];
                    
                    txtSubGroupID.Text = Convert.ToString(r1.Cells["SubGroup_ID"].Value);
                    txtSubGroupName.Text = Convert.ToString(r1.Cells["SubGroup_Name"].Value);
                    txtSubGroupShortCode.Text = Convert.ToString(r1.Cells["SubGroup_ShortCode"].Value);
                    CboGroup.Text = Convert.ToString(r1.Cells["Group_Name"].Value);
                    
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
                DataRow[] dr = dataItems.Select("Category_Name like'%" + txtSearch.Text + "%");
                int index = dataItems.Rows.IndexOf(dr[0]);
                dataGridView1.ClearSelection(); dataGridView1.Rows[index].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = index;
                txtSearch.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ItemSubCatagoryBind()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {
                sqlQ = $"Select  convert(varchar,isg.SubGroup_ID)SubGroup_ID,ig.Group_Name,Group_Name,isg.SubGroup_Name,isg.SubGroup_ShortCode from New_Item_SubGroup isg inner join New_Item_Group ig on ig.Group_ID=isg.Group_ID order By isg.SubGroup_ID";
                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dataGridView1.DataSource = dataItems;
                foreach (DataGridViewColumn c in dataGridView1.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;
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

        private void CboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

