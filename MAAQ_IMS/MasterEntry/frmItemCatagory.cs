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
    public partial class frmItemCatagory : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        DataTable dataItems = null;
        public frmItemCatagory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCatagoryName.Text) || txtCatagoryName.Text.Length == 0)
            {
                MessageBox.Show("Item  Category is must.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlQ = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            int _categoryId = GlobalInfo.GlobalInfo.GetMaxID("New_Item_Category", "Category_ID", con);
            SqlTransaction trans = con.BeginTransaction(); cmd.Transaction = trans;
            try
            {
                if (btnSave.Text != "Update")
                {

                    sqlQ = $"INSERT INTO New_Item_Category(Category_ID,Group_ID,SubGroup_ID, Category_Name, Category_ShortCode) VALUES (@Category_ID,@Group_ID,@SubGroup_ID,@Category_Name,@Category_ShortCode)";
                    cmd.Parameters.AddWithValue("@Category_ID", _categoryId);

                    success = "saved";
                }
                else
                {
                    sqlQ = $"UPDATE  New_Item_Category SET Group_ID = @Group_ID,SubGroup_ID = @SubGroup_ID, Category_Name = @Category_Name, Category_ShortCode = @Category_ShortCode where Category_ID = @Category_ID";
                    cmd.Parameters.AddWithValue("@Category_ID", txtCatagoryID.Text);
                    success = "updated";
                }
                cmd.Parameters.AddWithValue("@Group_ID", CboGroup.SelectedValue);
                cmd.Parameters.AddWithValue("@SubGroup_ID", CboSubGroup.SelectedValue);
                cmd.Parameters.AddWithValue("@Category_Name", txtCatagoryName.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Category_ShortCode", txtCatagoryShortCode.Text.Trim().ToUpper());
                cmd.CommandText = sqlQ;
                cmd.ExecuteNonQuery();
                trans.Commit();
                GlobalInfo.GlobalInfo.audit_trail("Item Category Entry Form " + txtCatagoryName.Text, this.Name);

                MessageBox.Show($"{txtCatagoryName.Text} {success} successfully");
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
          

       private void frmItemCatagory_Load(object sender, EventArgs e)
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
                txtCatagoryID.Text = GlobalInfo.GlobalInfo.GetMaxID("New_Item_Category", "Category_ID").ToString();
                ItemCatagoryBind();
                LoadSearchGridView();
                btnSave.Text = "Save";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ddlItemCatagory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if( e.ColumnIndex == btnGridSelect.Index ) 
                {
                  
                    DataGridViewRow r1 = dgvItemCatagory.Rows[e.RowIndex];
                    txtCatagoryID.Text = Convert.ToString(r1.Cells["Category_ID"].Value);
                    CboGroup.Text = Convert.ToString(r1.Cells["Group_Name"].Value);
                    CboSubGroup.Text = Convert.ToString(r1.Cells["SubGroup_Name"].Value);
                    txtCatagoryName.Text = Convert.ToString(r1.Cells["Category_Name"].Value);
                    txtCatagoryShortCode.Text = Convert.ToString(r1.Cells["Category_ShortCode"].Value);
                    
                    btnSave.Text = "Update";

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadSearchGridView();
        }

        private void ItemCatagoryBind()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {
                int _groupId = 0, _subGroupId = 0;
                if (CboGroup.Text != "--Select--")
                    _groupId = Convert.ToInt32(CboGroup.SelectedValue.ToString());

                if (CboSubGroup.Text != "--Select--" && !string.IsNullOrWhiteSpace(CboSubGroup.Text))
                    _subGroupId = Convert.ToInt32(CboSubGroup.SelectedValue.ToString());

                int tt = _subGroupId;
                int ii = 0;


                sqlQ =$"Select convert(varchar,ic.Category_ID)Category_ID,ig.Group_Name,isg.SubGroup_Name,ic.Category_Name,ic.Category_ShortCode from New_Item_Group ig inner join New_Item_SubGroup as isg on ig.Group_ID = isg.Group_ID inner join New_Item_Category ic on isg.Group_ID = ic.Group_ID and isg.SubGroup_ID = ic.SubGroup_ID where ic.Group_ID = case when {_groupId} > 0 then  {_groupId} else ic.Group_ID end and ic.SubGroup_ID = case when {_subGroupId} > 0 then {_subGroupId} else ic.SubGroup_ID end order By ic.Category_ID";
                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dgvItemCatagory.DataSource = dataItems;
                foreach (DataGridViewColumn c in dgvItemCatagory.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;
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
    

        private void LoadSearchGridView()
        {
            try
            {
                if (txtSearch.Text.Trim().Length == 0) return;
                DataRow[] dr = dataItems.Select("Category_Name like'%" + txtSearch.Text + "%'  ");
                int index = dataItems.Rows.IndexOf(dr[0]);
                dgvItemCatagory.ClearSelection(); dgvItemCatagory.Rows[index].Selected = true;
                dgvItemCatagory.FirstDisplayedScrollingRowIndex = index;
                txtSearch.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (CboGroup.Text.ToString() != "--Select--")
                {
                    int groupId = Convert.ToInt32(CboGroup.SelectedValue.ToString());
                    GlobalInfo.GlobalInfo.PopulateCombobox(CboSubGroup, "SubGroup_ID", "SubGroup_Name", "New_Item_SubGroup", "Group_ID", groupId, "SubGroup_Name");
                }
            }

        }

        private void CboSubGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
