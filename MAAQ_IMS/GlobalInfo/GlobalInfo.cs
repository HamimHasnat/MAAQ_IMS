using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAAQ_IMS.GlobalInfo
{
    class GlobalInfo
    {
        static DataRow dr;
        //GET DATATABLE
        public static DataTable getDataTable(string SQLquery)
        {
            DataTable sqlDT = new DataTable();
            SqlConnection sqlCon = new SqlConnection(ConnectionInfo.GenerateConnectionString());
            try
            {

                //if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
                SqlDataAdapter sqlDA = new SqlDataAdapter(SQLquery, sqlCon);
                sqlDT.Reset();
                sqlDA.SelectCommand.CommandTimeout = 0;
                sqlDA.Fill(sqlDT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            return sqlDT;
        }

  
        public static void _ReportView(string sqlQuery, CrystalDecisions.CrystalReports.Engine.ReportDocument report)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionInfo.GenerateConnectionString());
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = conn;
                Cmd.CommandText = sqlQuery;

                frmReportShow MyReport = new frmReportShow();
                //Reports.rptProductsAll report = new Reports.rptProductsAll();
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
                adapter.SelectCommand.CommandTimeout = 0;
                adapter.Fill(table);
                report.SetDataSource(table);
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                MyReport.crystalReportViewer1.ReportSource = report;
                MyReport.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void _ReportViewSamePage(string sqlQuery, CrystalDecisions.CrystalReports.Engine.ReportDocument report,CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewer)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionInfo.GenerateConnectionString());
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = conn;
                Cmd.CommandText = sqlQuery;

               
                //Reports.rptProductsAll report = new Reports.rptProductsAll();
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
                adapter.SelectCommand.CommandTimeout = 0;
                adapter.Fill(table);
                report.SetDataSource(table);
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                rptViewer.ReportSource = report;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void combo_add_with_Value(ComboBox cbo, string SqlQuery)
        {
            try
            {
                ArrayList array = new ArrayList();
                DataTable dt = new DataTable();
                dt = getDataTable(SqlQuery); cbo.DataSource = null;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        array.Add(new AddValue(row[0].ToString(), row[1].ToString()));
                    }
                    cbo.DataSource = array;
                    cbo.DisplayMember = "Display";
                    cbo.ValueMember = "Value";

                }
                cbo.Text = string.Empty;
            }
            catch { }
        }  

        public static Boolean getComboDataValidaty(ComboBox cbo)
        {
            Boolean _getData = false;
            try
            {
                if (cbo.SelectedValue == null || Convert.ToString(cbo.SelectedValue).Length == 0 || Convert.ToString(cbo.Text.Trim()).Length == 0 || Convert.ToString(cbo.SelectedValue).Contains("GlobalInfo") == true || Convert.ToString(cbo.Text).Contains("GlobalInfo") == true)
                    _getData = false;
                else _getData = true;
            }
            catch (Exception)
            { _getData = false; }
            finally { }
            return _getData;
        }



        public static void PopulateCombobox(ComboBox cbo, string valueField, string displayField, string tableName, string orderField)
        {
            SqlConnection con = new SqlConnection(ConnectionInfo.GenerateConnectionString());
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand($"Select {valueField} , {displayField} from {tableName} order By {orderField}", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select--" };
                dt.Rows.InsertAt(dr, 0);
                cbo.ValueMember = valueField;
                cbo.DisplayMember = displayField;
                cbo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
        }
        public static void PopulateCombobox(ComboBox cbo, string valueField, string displayField, string tableName, string filterField_1, int filterBy_1, string orderField)
        {
            SqlConnection con = new SqlConnection(ConnectionInfo.GenerateConnectionString());
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand cmd = new SqlCommand($"Select {valueField} , {displayField} from {tableName} Where {filterField_1} = {filterBy_1}  order By {orderField}", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select--" };
                dt.Rows.InsertAt(dr, 0);
                cbo.ValueMember = valueField;
                cbo.DisplayMember = displayField;
                cbo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
        }






        public static void PopulateCombobox(ComboBox cbo, string valueField, string displayField, string tableName, string filterField_1, int filterBy_1, string filterField_2, int filterBy_2, string orderField)
        {
            SqlConnection con = new SqlConnection(ConnectionInfo.GenerateConnectionString());
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand cmd = new SqlCommand($"Select {valueField} , {displayField} from {tableName} Where {filterField_1} = {filterBy_1} and {filterField_2} = {filterBy_2} order By {orderField}", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select--" };
                dt.Rows.InsertAt(dr, 0);
                cbo.ValueMember = valueField;
                cbo.DisplayMember = displayField;
                cbo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
        }



        public class AddValue
        {
            private string m_Display;
            private string m_Value;
            public AddValue(string Value, string Display)
            {
                m_Display = Display;
                m_Value = Value;
            }
            public string Display
            {
                get { return m_Display; }
            }
            public string Value
            {
                get { return m_Value; }
            }
        }

        [Obsolete]
        public static void combo_add(ComboBox field, string sql)
        {
            try
            {
                if (sql == "") return;
                field.Text = string.Empty;
                field.Items.Clear();
                DataSet ds = new DataSet();
                ds = getDataset(sql);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    field.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        [Obsolete]
        public static DataSet getDataset(string sqlQuery)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlQuery == "") return null;
                SqlConnection conn = new SqlConnection(ConnectionInfo.GenerateConnectionString());
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlQuery;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.SelectCommand.CommandTimeout = 0;
                da.Fill(ds);
                conn.Close(); conn.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return ds;

        }

        [Obsolete]
        public static string GetSingleField(string SqlQuery)
        {
            string _getData = string.Empty;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionInfo.GenerateConnectionString();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = conn;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                Cmd.CommandText = SqlQuery;
                _getData = Convert.ToString(Cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return _getData;
        }

        [Obsolete]
        public static string AUTO_GENERATE_GRN_ID(string Group)
        {
            if (Group.Length >= 3) Group = "GRN-" + Group.Substring(0, 3); else Group = "";
            string GRN_ID = "";
            if (Group.Length == 7)
            {
                Group += "-" + DateTime.Now.Date.ToString("yyMMdd");
                GRN_ID = Group + GetSingleField("SELECT  RIGHT('00000000' + CONVERT(NVARCHAR(10), ISNULL(MAX(convert(integer,SUBSTRING( GRN_ID,13,LEN( GRN_ID)))),0)+1),3) FROM    GRN_DETAILS  WHERE  GRN_ID LIKE '%" + Group + "%'");
            }
            return GRN_ID;
        }

        [Obsolete]
        public static string AUTO_GENERATE_SUPPLIER_PO(string Group)
        {
            int i = 0;

            if (Group.Length >= 3) Group = "CW-PO-" + Group.Substring(0, 3) + "-"; else Group = "";
            string PO_ID = "";
            if (Group.Length == 10)
            {
                PO_ID = GetSingleField("SELECT '" + Group + "'+  CONVERT(NVARCHAR(50), ISNULL(MAX(convert(integer,RIGHT(MPO_ID,LEN(MPO_ID)-10))),0)+1 )  FROM  PO_SUPPLIER_PRIMARY WHERE (MPO_ID LIKE '%" + Group + "%')");
            }
            return PO_ID;
        }

        [Obsolete]
        public static void audit_trail(string purpose, string formname)
        {
            string hostName = Dns.GetHostName();
            string ip = Dns.GetHostByName(hostName).AddressList[0].ToString();

            SqlConnection conn = new SqlConnection(); conn.ConnectionString = ConnectionInfo.GenerateConnectionString();
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand Cmd = new SqlCommand(); Cmd.Connection = conn;
            SqlTransaction trans = conn.BeginTransaction(); Cmd.Transaction = trans;
            try
            {
                Cmd.CommandText = "INSERT INTO AUDIT_TRAIL    (TDATE, USER_ID, PURPOSE, FORM_NAME, USER_IP) " +
                    " VALUES     (GETDATE(),'" + GlobalVariable.USER_ID + "','" + purpose + "','" + formname + "','" + ip + "')";
                Cmd.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); trans.Rollback();
            }
            finally
            {
                conn.Close(); conn.Dispose();
            }
        }

        [Obsolete]
        public static int GetMaxID(string tableName, string maxIdFieldName)
        {
            int maxID = 0;
            SqlConnection con = new SqlConnection(ConnectionInfo.GenerateConnectionString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            try
            {

                string sqlQ = $"Select ISNULL(MAX({maxIdFieldName}),0)+1   from {tableName}";
                cmd.CommandText = sqlQ;
                cmd.CommandTimeout = 0;
                maxID = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
            }
            return maxID;

        }
        public static int GetMaxID(string tableName, string maxIdFieldName, SqlConnection con)
        {
            int maxID = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {

                string sqlQ = $"Select ISNULL(MAX({maxIdFieldName}),0)+1   from {tableName}";
                cmd.CommandText = sqlQ;
                maxID = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return maxID;

        }

        public static int GetMaxID(string tableName, string maxIdFieldName, SqlConnection con, SqlTransaction trans)
        {
            int maxID = 0;
           
           
            try
            {

                string sqlQ = $"Select ISNULL(MAX({maxIdFieldName}),0)+1   from {tableName}";
               SqlCommand  cmd = new SqlCommand(sqlQ, con, trans);
                maxID = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return maxID;

        }


        public static void isFormOpened(string openFrmName, Form frmNew)
        {
            Boolean isExist = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == openFrmName)
                {
                    Application.OpenForms[openFrmName].Show();
                    isExist = true; break;
                }
            }
            if (isExist == false) frmNew.Show();
        }

        public static void numericonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back) e.Handled = false;
        }

        internal static DataTable getDataTable(string sqlQuery, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
