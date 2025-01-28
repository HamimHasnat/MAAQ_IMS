
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
    public partial class FrmBrandcs : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        DataTable dataItems = null;
        public FrmBrandcs()
        {
            InitializeComponent();
        }

        

   

        private void FrmBrandcs_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {

                btnRefresh_Click_1(sender, e);

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
                sqlQ = @"Select Brand_ID,Brand_Name from New_Brand_Info order By Brand_ID";
                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dgvBrand.DataSource = dataItems;
                foreach (DataGridViewColumn c in dgvBrand.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;

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
                DataRow[] dr = dataItems.Select("Brand_Name like'%" + txtSearch.Text + "%' ");
                int index = dataItems.Rows.IndexOf(dr[0]);
                dgvBrand.ClearSelection(); dgvBrand.Rows[index].Selected = true;
                dgvBrand.FirstDisplayedScrollingRowIndex = index;
                txtSearch.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrandId.Text) || txtBrandName.Text.Length == 0)
            {
                MessageBox.Show("New_Brand_Info", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Squery = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
                con.Open();
            int _BrandId = GlobalInfo.GlobalInfo.GetMaxID("New_Brand_Info", "Brand_ID", con);
            SqlTransaction trans = con.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                if (btnSave.Text != "Update")
                {
                    Squery = @"insert into New_Brand_Info(Brand_ID,Brand_Name)
                    Values(@Brand_ID,@Brand_Name)";
                    cmd.Parameters.AddWithValue("@Brand_ID", _BrandId);
                    success = "saved";

                }
                else
                {
                    Squery = @"update New_Brand_Info Set Brand_Name=@Brand_Name where Brand_ID=@Brand_ID";
                    cmd.Parameters.AddWithValue("@Brand_ID", txtBrandId.Text.Trim().ToUpper());
                    success = "updated";

                }
                cmd.Parameters.AddWithValue("@Brand_Name", txtBrandName.Text.Trim().ToUpper());


                cmd.CommandText = Squery;
                cmd.ExecuteNonQuery();
                trans.Commit();


                GlobalInfo.GlobalInfo.audit_trail(" New_Brand_Info Enty Form " + txtBrandName.Text, this.Name);
                MessageBox.Show($"{txtBrandName.Text} {success} successfully");
                btnRefresh_Click_1(sender, e);


            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (Control controls in panel3.Controls)
                {
                    if (controls is TextBox || controls is ComboBox) controls.Text = string.Empty;
                }

                txtBrandId.Text = GlobalInfo.GlobalInfo.GetMaxID("New_Brand_Info", "Brand_ID").ToString();
                ExpCatagoryBind();
                LoadSearchGridView();
                btnSave.Text = "Save";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadSearchGridView();
        }

        private void dgvBrand_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (e.ColumnIndex == btnGridSelect.Index)
                {

                    DataGridViewRow r1 = dgvBrand.Rows[e.RowIndex];
                    txtBrandId.Text = Convert.ToString(r1.Cells["Brand_ID"].Value);
                    txtBrandName.Text = Convert.ToString(r1.Cells["Brand_Name"].Value);

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
