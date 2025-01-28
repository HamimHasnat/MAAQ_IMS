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
    public partial class New_Color_Info : Form
    {
        string connectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
        DataTable dataItems = null;
        public New_Color_Info()
        {
            InitializeComponent();
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
                DataRow[] dr = dataItems.Select("Color_Name like'%" + txtSearch.Text + "%' ");
                int index = dataItems.Rows.IndexOf(dr[0]);
                dgvColor.ClearSelection(); dgvColor.Rows[index].Selected = true;
                dgvColor.FirstDisplayedScrollingRowIndex = index;
                txtSearch.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void New_Color_Info_Load(object sender, EventArgs e)
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

        private void dgvColor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvColor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (e.ColumnIndex == btnGridSelect.Index)
                {

                    DataGridViewRow r1 = dgvColor.Rows[e.RowIndex];
                    txtColorID.Text = Convert.ToString(r1.Cells["Color_ID"].Value);
                    txtColorName.Text = Convert.ToString(r1.Cells["Color_Name"].Value);
                   
                    btnSave.Text = "Update";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                txtColorID.Text = GlobalInfo.GlobalInfo.GetMaxID("New_Color_Info", "Color_ID").ToString();
                ColorDataBing();
                LoadSearchGridView();
                btnSave.Text = "Save";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ColorDataBing()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {
                sqlQ = @"Select Color_ID,Color_Name from New_Color_Info order By Color_ID";
                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dgvColor.DataSource = dataItems;
                foreach (DataGridViewColumn c in dgvColor.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtColorID.Text) || txtColorName.Text.Length == 0)
            {
                MessageBox.Show("New_Color_Info", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Squery = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            int _ColorID = GlobalInfo.GlobalInfo.GetMaxID("New_Color_Info", "Color_ID", con);
            SqlTransaction trans = con.BeginTransaction(); cmd.Transaction = trans;
            try
            {
                if (btnSave.Text != "Update")
                {
                    Squery = @"insert into New_Color_Info(Color_ID,Color_Name )
                    Values(@Color_ID,@Color_Name)";
                    cmd.Parameters.AddWithValue("@Color_ID", _ColorID);
                    success = "saved";

                }
                else
                {
                    Squery = @"update New_Color_Info Set Color_Name=@Color_Name where Color_ID=@Color_ID";
                    cmd.Parameters.AddWithValue("@Color_ID", txtColorID.Text.Trim().ToUpper());
                    success = "updated";

                }
                cmd.Parameters.AddWithValue("@Color_Name", txtColorName.Text.Trim().ToUpper());
                

                cmd.CommandText = Squery;
                cmd.ExecuteNonQuery();
                trans.Commit();


                GlobalInfo.GlobalInfo.audit_trail(" New_Brand_Info Enty Form " + txtColorName.Text, this.Name);
                MessageBox.Show($"{txtColorName.Text} {success} successfully");
                btnRefresh_Click(sender, e);


            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}
