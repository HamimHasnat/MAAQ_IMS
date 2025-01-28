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
    public partial class SupplierEntry : Form
    {
        DataTable dataItems = null;
        public SupplierEntry()
        {
            InitializeComponent();
        }

        private void SupplierEntry_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                
                btnReset_Click(sender, e);
                GlobalInfo.GlobalInfo.combo_add_with_Value(cboCountry, "SELECT Country_ID, Country_Name  FROM Country_Entry ORDER BY Country_Name");
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
            if (string.IsNullOrEmpty(txtSupplierName.Text) || txtSupplierName.Text.Length == 0)
            {
                MessageBox.Show("Supplier Name is must.", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlQ = string.Empty, success = string.Empty;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalInfo.ConnectionInfo.GenerateConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (con.State == ConnectionState.Closed) con.Open();

            int _supplierId = GlobalInfo.GlobalInfo.GetMaxID("[Supplier_Info]", "SupplierID", con);
            SqlTransaction trans = con.BeginTransaction();
            cmd.Transaction = trans;

            try
            {
                if (btnSave.Text != "Update")
                {
                    sqlQ = "INSERT INTO Supplier_Info (SupplierID, CompanyName, Address, Country, City, ContactName, Phone) VALUES (@SupplierID, @CompanyName, @Address, @Country, @City, @ContactName, @Phone)";
                    cmd.Parameters.AddWithValue("@SupplierID", _supplierId);
                    success = "saved";
                }
                else
                {
                    sqlQ = "UPDATE Supplier_Info SET CompanyName=@CompanyName, Address=@Address, Country=@Country, City=@City, ContactName=@ContactName, Phone=@Phone WHERE Supplier_ID = @Supplier_ID";

                    //Only add the parameters for update if it's not already added
                    if (!cmd.Parameters.Contains("@CompanyName"))
                    {
                        cmd.Parameters.AddWithValue("@CompanyName", txtSupplierName.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Country", cboCountry.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@ContactName", txtContactPerson.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim().ToUpper());

                        cmd.Parameters.AddWithValue("@Supplier_ID", txtSupplierID.Text);  // Corrected this line
                        success = "updated";
                    }
                }

                // The common parameters for both insert and update
                cmd.Parameters.Clear(); // Clear existing parameters to avoid duplicates
                cmd.Parameters.AddWithValue("@Supplier_ID", _supplierId);
                cmd.Parameters.AddWithValue("@CompanyName", txtSupplierName.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Country", cboCountry.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@ContactName", txtContactPerson.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim().ToUpper());


                cmd.CommandText = sqlQ;
                cmd.ExecuteNonQuery();
                trans.Commit();
                GlobalInfo.GlobalInfo.audit_trail("Supplier_Info Form " + txtSupplierName.Text, this.Name);
                MessageBox.Show($"{txtSupplierName.Text} {success} successfully");
                btnReset_Click(sender, e);
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
            }
        }
        private void GetdataItems()
        {
            string sqlQ = string.Empty;
            Cursor = Cursors.WaitCursor;
            try
            {
                sqlQ = $"Select ROW_NUMBER()over(order by CompanyName) as SupplierID,CompanyName, Address, Country, City,ContactName, Phone from Supplier_Info order By CompanyName";
                dataItems = GlobalInfo.GlobalInfo.getDataTable(sqlQ);
                dgvSupplier.DataSource = dataItems;
                foreach (DataGridViewColumn c in dgvSupplier.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;
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

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (e.ColumnIndex == btnGridSelect.Index)
                {
                    DataGridViewRow r1 = dgvSupplier.Rows[e.RowIndex];
                    txtSupplierID.Text = Convert.ToString(r1.Cells["SupplierID"].Value);
                    txtSupplierName.Text = Convert.ToString(r1.Cells["CompanyName"].Value);
                    txtAddress.Text = Convert.ToString(r1.Cells["Address"].Value);
                    cboCountry.Text = Convert.ToString(r1.Cells["Country"].Value);
                    txtCity.Text = Convert.ToString(r1.Cells["City"].Value);
                    txtContactPerson.Text = Convert.ToString(r1.Cells["ContactName"].Value);
                    txtPhone.Text = Convert.ToString(r1.Cells["Phone"].Value);

                    btnSave.Text = "Update";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDataGridView()
        {

            try
            {
                if (txtSearch.Text.Trim().Length == 0) return;
                DataRow[] dr = dataItems.Select("Supplier_Name like'%" + txtSearch.Text + "%' or Address like '%" + txtSearch.Text + "%' or Country like'%" + txtSearch.Text + "%' or City like '%" + txtSearch.Text + "%' or Contact_Person like'%" + txtSearch.Text + "%' or Phone like '% ");
                int index = dataItems.Rows.IndexOf(dr[0]);
                dgvSupplier.ClearSelection(); dgvSupplier.Rows[index].Selected = true;
                dgvSupplier.FirstDisplayedScrollingRowIndex = index;
                txtSearch.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                txtSupplierID.Text = GlobalInfo.GlobalInfo.GetMaxID("[Supplier_Info]", "SupplierID").ToString();
                GetdataItems();
                LoadDataGridView();
                btnSave.Text = "Save";

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
    }
}
