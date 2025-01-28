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
    public partial class New_Item_Entry : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        DataTable dataItems = null;
        public New_Item_Entry()
        {
            InitializeComponent();
        }

        private void New_Item_Entry_Load(object sender, EventArgs e)
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
                foreach(Control controls in panel2.Controls)
                {
                    if (controls is TextBox || controls is ComboBox) controls.Text = string.Empty;
                }
                GlobalInfo.GlobalInfo.PopulateCombobox(CboGroup, "Group_ID", "Group_Name", "New_Item_Group", "Group_Name");

                
                GlobalInfo.GlobalInfo.PopulateCombobox(CboBrand, "Brand_ID", "Brand_Name", "New_Brand_Info", "Brand_Name");
                GlobalInfo.GlobalInfo.PopulateCombobox(CboColor, "Color_ID", "Color_Name", "New_Color_Info", "Color_Name");
                GlobalInfo.GlobalInfo.PopulateCombobox(CboUni, "Unit_ID", "Unit_Name", "New_Unit_Info", "Unit_Name");
                GlobalInfo.GlobalInfo.PopulateCombobox(CboExpCatagory, "Expense_CategoryID", "Expense_CategoryName", "New_Expense_Category", "Expense_CategoryName");


                txtItemID.Text = GlobalInfo.GlobalInfo.GetMaxID("New_Item_Entry", "Item_ID").ToString();
                ItemEntrygridViewBind();
                LoadSearchGridView();
                CboSubGroup.DataSource = null;
                CboCatagory.DataSource = null;
                btnSave.Text = "Save";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ItemEntrygridViewBind()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {
                sqlQ = $" declare @Item_ID int='"+txtItemID.Text+"' " +
                    @"select IG.Group_Name,SG.SubGroup_Name,IC.Category_Name, IE.Item_ID,IE.Item_Name,UI.Unit_Name,IE.Item_PCode,BI.Brand_Name,IE.Item_Size_Width,IE.Item_Model_Orgin,CI.Color_Name,IE.Item_Unit_Prize,IE.Item_Vat,IE.Item_Article,Ec.Expense_CategoryName,IE.Item_ShadeNo,IE.Item_MinLQ,IE.Item_MaxLQ,IE.Item_Remarks from New_Item_Entry IE inner Join New_Brand_Info BI on IE.Brand_ID = BI.Brand_ID inner Join New_Color_Info CI On IE.Color_ID = CI.Color_ID inner Join New_Expense_Category EC On IE.ExpCatagory_ID = EC.Expense_CategoryID
                       inner Join New_Item_Category IC On IE.Catagory_ID = IC.Category_ID inner Join New_Item_Group IG on IE.Group_ID = IG.Group_ID inner Join New_Item_SubGroup SG on IE.SubGroup_ID = SG.SubGroup_ID and ie.Group_ID = sg.Group_ID inner Join New_Unit_Info UI on IE.Unit_ID = UI.Unit_ID";

                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dgvItemEntry.DataSource = dataItems;
                foreach (DataGridViewColumn c in dgvItemEntry.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadSearchGridView();

        }
        private void LoadSearchGridView()
        {
            try
            {
                if (txtSearch.Text.Trim().Length == 0) return;
                DataRow[] dr = dataItems.Select("Group_Name like'%" + txtSearch.Text + "%' or Item_Name like '%" + txtSearch.Text + "%' or Expense_CategoryName like '%" + txtSearch.Text + "%'  or Item_Article like '%" + txtSearch.Text + "%'  or Unit_Name like '%" + txtSearch.Text + "%' or SubGroup_Name like '%" + txtSearch.Text + "%' or Category_Name like '%" + txtSearch.Text + "%' or Brand_Name like '%" + txtSearch.Text + "%' ");
                int index = dataItems.Rows.IndexOf(dr[0]);
                dgvItemEntry.ClearSelection(); dgvItemEntry.Rows[index].Selected = true;
                dgvItemEntry.FirstDisplayedScrollingRowIndex = index;
                txtSearch.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text) || txtItemName.Text.Length == 0)
            {
                MessageBox.Show("New Item Entry is must.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlQ = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            int _itemID = GlobalInfo.GlobalInfo.GetMaxID("New_Item_Entry", "Item_ID", con);
            SqlTransaction trans = con.BeginTransaction(); cmd.Transaction = trans;
            try
            {
                if (btnSave.Text != "Update")
                {

                    sqlQ = $"INSERT INTO New_Item_Entry(Item_ID,Item_Name,Group_ID,SubGroup_ID,Catagory_ID,Unit_ID,Brand_ID,Color_ID,ExpCatagory_ID,Item_PCode,Item_Size_Width,Item_Model_Orgin,Item_Unit_Prize,Item_Vat,Item_Article,Item_ShadeNo,Item_MinLQ,Item_MaxLQ,Item_Remarks)Values(@Item_ID,@Item_Name,@Group_ID,@SubGroup_ID,@Catagory_ID,@Unit_ID,@Brand_ID,@Color_ID,@ExpCatagory_ID,@Item_PCode,@Item_Size_Width,@Item_Model_Orgin,@Item_Unit_Prize,@Item_Vat,@Item_Article,@Item_ShadeNo,@Item_MinLQ,@Item_MaxLQ,@Item_Remarks)";
                    cmd.Parameters.AddWithValue("@Item_ID", _itemID);

                    success = "saved";
                }
                else
                {
                    sqlQ = $@"UPDATE  New_Item_Entry SET Group_ID = @Group_ID,SubGroup_ID = @SubGroup_ID,Catagory_ID = @Catagory_ID,Item_Name = @Item_Name,Unit_ID=@Unit_ID,Item_PCode=@Item_PCode,Brand_ID=@Brand_ID,Item_Size_Width=@Item_Size_Width,Item_Model_Orgin=@Item_Model_Orgin,Color_ID=@Color_ID,Item_Unit_Prize=@Item_Unit_Prize,Item_Vat=@Item_Vat,Item_Article=@Item_Article,ExpCatagory_ID=@ExpCatagory_ID,Item_ShadeNo=@Item_ShadeNo,Item_MinLQ=@Item_MinLQ,Item_MaxLQ=@Item_MaxLQ,Item_Remarks=@Item_Remarks  where Item_ID =@Item_ID";
                    cmd.Parameters.AddWithValue("@Item_ID", txtItemID.Text);
                    success = "updated";
                }
                cmd.Parameters.AddWithValue("@Item_Name", txtItemName.Text.Trim().ToUpper());
                
                cmd.Parameters.AddWithValue("@Group_ID", CboGroup.SelectedValue);
                cmd.Parameters.AddWithValue("@SubGroup_ID", CboSubGroup.SelectedValue);
                cmd.Parameters.AddWithValue("@Catagory_ID", CboCatagory.SelectedValue);
                cmd.Parameters.AddWithValue("@Unit_ID", CboUni.SelectedValue);
                cmd.Parameters.AddWithValue("@Brand_ID", CboBrand.SelectedValue);
                cmd.Parameters.AddWithValue("@Color_ID", CboColor.SelectedValue);
                cmd.Parameters.AddWithValue("@ExpCatagory_ID", CboExpCatagory.SelectedValue);
                cmd.Parameters.AddWithValue("@Item_PCode", txtPCode.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Item_Size_Width", txtSize.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Item_Model_Orgin", txtModel.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Item_Unit_Prize", txtUniPrice.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Item_Vat", txtVat.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Item_Article", txtArticle.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Item_ShadeNo", txtShadeNo.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Item_MinLQ", txtMinlabelQty.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Item_MaxLQ", txtMaxLabelQty.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Item_Remarks", txtRemarks.Text.Trim().ToUpper());

                cmd.CommandText = sqlQ;
                cmd.ExecuteNonQuery();
                trans.Commit();
                GlobalInfo.GlobalInfo.audit_trail("Item SubGroup Entry Form " + txtItemName.Text, this.Name);

                MessageBox.Show($"{txtItemName.Text} {success} successfully");
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

        private void CboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboGroup.Text.ToString() != "--Select--")
            {
                int groupId = Convert.ToInt32(CboGroup.SelectedValue.ToString());
              
                GlobalInfo.GlobalInfo.PopulateCombobox(CboSubGroup, "SubGroup_ID", "SubGroup_Name", "New_Item_SubGroup", "Group_ID", groupId, "SubGroup_Name");
               
            }
            
        }

        private void dgvItemEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (e.ColumnIndex == btnGridSelect.Index)
                {

                    DataGridViewRow r1 = dgvItemEntry.Rows[e.RowIndex];

                    CboGroup.Text = Convert.ToString(r1.Cells["Group_Name"].Value);
                    CboSubGroup.Text = Convert.ToString(r1.Cells["SubGroup_Name"].Value);
                    CboCatagory.Text = Convert.ToString(r1.Cells["Category_Name"].Value);
                    txtItemID.Text = Convert.ToString(r1.Cells["Item_ID"].Value);
                    txtItemName.Text = Convert.ToString(r1.Cells["Item_Name"].Value);
                    CboUni.Text = Convert.ToString(r1.Cells["Unit_Name"].Value);
                    CboBrand.Text = Convert.ToString(r1.Cells["Brand_Name"].Value);
                    txtPCode.Text = Convert.ToString(r1.Cells["Item_PCode"].Value);
                    txtSize.Text = Convert.ToString(r1.Cells["Item_Size_Width"].Value);
                    txtModel.Text = Convert.ToString(r1.Cells["Item_Model_Orgin"].Value);
                    CboColor.Text = Convert.ToString(r1.Cells["Color_Name"].Value);
                    txtUniPrice.Text = Convert.ToString(r1.Cells["Item_Unit_Prize"].Value);
                    txtVat.Text = Convert.ToString(r1.Cells["Item_Vat"].Value);
                    txtArticle.Text = Convert.ToString(r1.Cells["Item_Article"].Value);
                    CboExpCatagory.Text = Convert.ToString(r1.Cells["Expense_CategoryName"].Value);
                    txtShadeNo.Text = Convert.ToString(r1.Cells["Item_ShadeNo"].Value);
                    txtMinlabelQty.Text = Convert.ToString(r1.Cells["Item_MinLQ"].Value);
                    txtMaxLabelQty.Text = Convert.ToString(r1.Cells["Item_MaxLQ"].Value);
                    txtRemarks.Text = Convert.ToString(r1.Cells["Item_Remarks"].Value);


                    btnSave.Text = "Update";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CboSubGroup_SelectedIndexChanged(object sender, EventArgs e)

        {
            try
            {
                
                CboCatagory.Text = string.Empty;
                if (GlobalInfo.GlobalInfo.getComboDataValidaty(CboSubGroup) == false) return;
                GlobalInfo.GlobalInfo.combo_add_with_Value(CboCatagory, $"Select Category_ID, Category_Name from  New_Item_Category where SubGroup_ID = '" + CboSubGroup.SelectedValue + "' and Group_ID = '" + CboGroup.SelectedValue + "' order By Category_Name");

            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message, "Error");
            }
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
