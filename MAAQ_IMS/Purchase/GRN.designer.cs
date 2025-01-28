namespace MAAQ_IMS.Purchase
{
    partial class GRN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRN));
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblmpoNo = new System.Windows.Forms.Label();
            this.txtMPONO = new System.Windows.Forms.TextBox();
            this.cboSupplierName = new System.Windows.Forms.ComboBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblPoType = new System.Windows.Forms.Label();
            this.txtPOtype = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.cboPayMode = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvGRNpandding = new System.Windows.Forms.DataGridView();
            this.txtGridSelect = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cboDevMode = new System.Windows.Forms.ComboBox();
            this.lblPayMode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvGRNDetails = new System.Windows.Forms.DataGridView();
            this.Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGridItemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Size_Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGridPoQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGridAlreadyRcvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGridBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRN_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRNValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBalValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGrnQty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrow = new System.Windows.Forms.Label();
            this.lbltotalrows = new System.Windows.Forms.Label();
            this.lblGrnValue = new System.Windows.Forms.Label();
            this.lblBalQty = new System.Windows.Forms.Label();
            this.lblTotalvalue = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDevl = new System.Windows.Forms.Label();
            this.lblCurrancy = new System.Windows.Forms.Label();
            this.lblConETDdate = new System.Windows.Forms.Label();
            this.lblMPODate = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkModify = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGRNno = new System.Windows.Forms.ComboBox();
            this.btnApproveToProcced = new System.Windows.Forms.Button();
            this.dtInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtConEtddate = new System.Windows.Forms.TextBox();
            this.txtETDdate = new System.Windows.Forms.TextBox();
            this.txtMPODate = new System.Windows.Forms.TextBox();
            this.btncopybalQty = new System.Windows.Forms.Button();
            this.txtGrnNo = new System.Windows.Forms.TextBox();
            this.lblGRNNO = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.lblbillNo = new System.Windows.Forms.Label();
            this.lblinvoiceDate = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblETDdate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRNpandding)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRNDetails)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::MAAQ_IMS.Properties.Resources.save_2;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(64, 114);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblmpoNo);
            this.panel1.Controls.Add(this.txtMPONO);
            this.panel1.Controls.Add(this.cboSupplierName);
            this.panel1.Controls.Add(this.lblSupplierName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 146);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(209, 64);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblmpoNo
            // 
            this.lblmpoNo.AutoSize = true;
            this.lblmpoNo.Location = new System.Drawing.Point(16, 42);
            this.lblmpoNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmpoNo.Name = "lblmpoNo";
            this.lblmpoNo.Size = new System.Drawing.Size(64, 17);
            this.lblmpoNo.TabIndex = 3;
            this.lblmpoNo.Text = "MPO NO";
            // 
            // txtMPONO
            // 
            this.txtMPONO.Location = new System.Drawing.Point(132, 33);
            this.txtMPONO.Margin = new System.Windows.Forms.Padding(4);
            this.txtMPONO.Name = "txtMPONO";
            this.txtMPONO.Size = new System.Drawing.Size(160, 22);
            this.txtMPONO.TabIndex = 2;
            // 
            // cboSupplierName
            // 
            this.cboSupplierName.DropDownWidth = 200;
            this.cboSupplierName.FormattingEnabled = true;
            this.cboSupplierName.Location = new System.Drawing.Point(132, 6);
            this.cboSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.cboSupplierName.Name = "cboSupplierName";
            this.cboSupplierName.Size = new System.Drawing.Size(160, 24);
            this.cboSupplierName.TabIndex = 1;
            this.cboSupplierName.SelectedIndexChanged += new System.EventHandler(this.cboSupplierName_SelectedIndexChanged);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(16, 12);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(101, 17);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblPoType
            // 
            this.lblPoType.AutoSize = true;
            this.lblPoType.Location = new System.Drawing.Point(11, 86);
            this.lblPoType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoType.Name = "lblPoType";
            this.lblPoType.Size = new System.Drawing.Size(64, 17);
            this.lblPoType.TabIndex = 36;
            this.lblPoType.Text = "PO Type";
            // 
            // txtPOtype
            // 
            this.txtPOtype.Location = new System.Drawing.Point(125, 81);
            this.txtPOtype.Margin = new System.Windows.Forms.Padding(4);
            this.txtPOtype.Name = "txtPOtype";
            this.txtPOtype.ReadOnly = true;
            this.txtPOtype.Size = new System.Drawing.Size(136, 22);
            this.txtPOtype.TabIndex = 35;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(309, 34);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(83, 17);
            this.lblRate.TabIndex = 34;
            this.lblRate.Text = "Rate 1 USD";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(397, 30);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(136, 22);
            this.txtRate.TabIndex = 33;
            // 
            // cboPayMode
            // 
            this.cboPayMode.Enabled = false;
            this.cboPayMode.FormattingEnabled = true;
            this.cboPayMode.Location = new System.Drawing.Point(397, 82);
            this.cboPayMode.Margin = new System.Windows.Forms.Padding(4);
            this.cboPayMode.Name = "cboPayMode";
            this.cboPayMode.Size = new System.Drawing.Size(136, 24);
            this.cboPayMode.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvGRNpandding);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 158);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 330);
            this.panel2.TabIndex = 1;
            // 
            // dgvGRNpandding
            // 
            this.dgvGRNpandding.AllowUserToAddRows = false;
            this.dgvGRNpandding.AllowUserToDeleteRows = false;
            this.dgvGRNpandding.AllowUserToResizeRows = false;
            this.dgvGRNpandding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGRNpandding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRNpandding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtGridSelect});
            this.dgvGRNpandding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGRNpandding.Location = new System.Drawing.Point(0, 0);
            this.dgvGRNpandding.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGRNpandding.Name = "dgvGRNpandding";
            this.dgvGRNpandding.ReadOnly = true;
            this.dgvGRNpandding.RowHeadersWidth = 20;
            this.dgvGRNpandding.Size = new System.Drawing.Size(332, 330);
            this.dgvGRNpandding.TabIndex = 0;
            this.dgvGRNpandding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGRNpandding_CellClick);
            // 
            // txtGridSelect
            // 
            this.txtGridSelect.HeaderText = "Action";
            this.txtGridSelect.Name = "txtGridSelect";
            this.txtGridSelect.ReadOnly = true;
            this.txtGridSelect.Text = "Select";
            this.txtGridSelect.UseColumnTextForLinkValue = true;
            this.txtGridSelect.Width = 53;
            // 
            // cboDevMode
            // 
            this.cboDevMode.Enabled = false;
            this.cboDevMode.FormattingEnabled = true;
            this.cboDevMode.Location = new System.Drawing.Point(397, 55);
            this.cboDevMode.Margin = new System.Windows.Forms.Padding(4);
            this.cboDevMode.Name = "cboDevMode";
            this.cboDevMode.Size = new System.Drawing.Size(136, 24);
            this.cboDevMode.TabIndex = 29;
            // 
            // lblPayMode
            // 
            this.lblPayMode.AutoSize = true;
            this.lblPayMode.Location = new System.Drawing.Point(309, 86);
            this.lblPayMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayMode.Name = "lblPayMode";
            this.lblPayMode.Size = new System.Drawing.Size(71, 17);
            this.lblPayMode.TabIndex = 28;
            this.lblPayMode.Text = "Pay Mode";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvGRNDetails);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(344, 158);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1456, 330);
            this.panel3.TabIndex = 2;
            // 
            // dgvGRNDetails
            // 
            this.dgvGRNDetails.AllowUserToAddRows = false;
            this.dgvGRNDetails.AllowUserToDeleteRows = false;
            this.dgvGRNDetails.AllowUserToResizeRows = false;
            this.dgvGRNDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGRNDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRNDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category_Name,
            this.Item_ID,
            this.txtGridItemname,
            this.Item_Article,
            this.Color_Name,
            this.Item_Size_Width,
            this.Unit_Name,
            this.Unit_Price,
            this.txtGridPoQty,
            this.txtGridAlreadyRcvd,
            this.txtGridBalance,
            this.GRN_Qty,
            this.GRNValue});
            this.dgvGRNDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGRNDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvGRNDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGRNDetails.Name = "dgvGRNDetails";
            this.dgvGRNDetails.RowHeadersWidth = 20;
            this.dgvGRNDetails.Size = new System.Drawing.Size(1456, 330);
            this.dgvGRNDetails.TabIndex = 0;
            this.dgvGRNDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGRNDetails_CellContentClick);
            this.dgvGRNDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGRNDetails_CellEndEdit);
            this.dgvGRNDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvGRNDetails_KeyDown);
            // 
            // Category_Name
            // 
            this.Category_Name.HeaderText = "Category_Name";
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.ReadOnly = true;
            this.Category_Name.Width = 139;
            // 
            // Item_ID
            // 
            this.Item_ID.HeaderText = "Item_ID";
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.ReadOnly = true;
            this.Item_ID.Width = 84;
            // 
            // txtGridItemname
            // 
            this.txtGridItemname.HeaderText = "Item Name";
            this.txtGridItemname.Name = "txtGridItemname";
            this.txtGridItemname.ReadOnly = true;
            this.txtGridItemname.Width = 104;
            // 
            // Item_Article
            // 
            this.Item_Article.HeaderText = "Item_Article";
            this.Item_Article.Name = "Item_Article";
            this.Item_Article.ReadOnly = true;
            this.Item_Article.Width = 110;
            // 
            // Color_Name
            // 
            this.Color_Name.HeaderText = "Color_Name";
            this.Color_Name.Name = "Color_Name";
            this.Color_Name.ReadOnly = true;
            this.Color_Name.Width = 115;
            // 
            // Item_Size_Width
            // 
            this.Item_Size_Width.HeaderText = "Item_Size_Width";
            this.Item_Size_Width.Name = "Item_Size_Width";
            this.Item_Size_Width.ReadOnly = true;
            this.Item_Size_Width.Width = 142;
            // 
            // Unit_Name
            // 
            this.Unit_Name.HeaderText = "Unit_Name";
            this.Unit_Name.Name = "Unit_Name";
            this.Unit_Name.ReadOnly = true;
            this.Unit_Name.Width = 107;
            // 
            // Unit_Price
            // 
            this.Unit_Price.HeaderText = "Unit_Price";
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            this.Unit_Price.Width = 102;
            // 
            // txtGridPoQty
            // 
            this.txtGridPoQty.HeaderText = "PO QTY";
            this.txtGridPoQty.Name = "txtGridPoQty";
            this.txtGridPoQty.ReadOnly = true;
            this.txtGridPoQty.Width = 90;
            // 
            // txtGridAlreadyRcvd
            // 
            this.txtGridAlreadyRcvd.HeaderText = "Already Rcvd";
            this.txtGridAlreadyRcvd.Name = "txtGridAlreadyRcvd";
            this.txtGridAlreadyRcvd.ReadOnly = true;
            this.txtGridAlreadyRcvd.Width = 121;
            // 
            // txtGridBalance
            // 
            this.txtGridBalance.HeaderText = "Balance";
            this.txtGridBalance.Name = "txtGridBalance";
            this.txtGridBalance.ReadOnly = true;
            this.txtGridBalance.Width = 88;
            // 
            // GRN_Qty
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GRN_Qty.DefaultCellStyle = dataGridViewCellStyle1;
            this.GRN_Qty.HeaderText = "GRN_Qty";
            this.GRN_Qty.Name = "GRN_Qty";
            this.GRN_Qty.Width = 98;
            // 
            // GRNValue
            // 
            this.GRNValue.HeaderText = "GRN Value";
            this.GRNValue.Name = "GRNValue";
            this.GRNValue.ReadOnly = true;
            this.GRNValue.Width = 108;
            // 
            // cboCurrency
            // 
            this.cboCurrency.Enabled = false;
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.Location = new System.Drawing.Point(397, 2);
            this.cboCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(136, 24);
            this.cboCurrency.TabIndex = 27;
            // 
            // panel4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.lblBalValue);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblGrnQty);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblrow);
            this.panel4.Controls.Add(this.lbltotalrows);
            this.panel4.Controls.Add(this.lblGrnValue);
            this.panel4.Controls.Add(this.lblBalQty);
            this.panel4.Controls.Add(this.lblTotalvalue);
            this.panel4.Controls.Add(this.lblTotalQty);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 496);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1796, 54);
            this.panel4.TabIndex = 3;
            // 
            // lblBalValue
            // 
            this.lblBalValue.AutoSize = true;
            this.lblBalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBalValue.Location = new System.Drawing.Point(635, 26);
            this.lblBalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalValue.Name = "lblBalValue";
            this.lblBalValue.Size = new System.Drawing.Size(26, 19);
            this.lblBalValue.TabIndex = 19;
            this.lblBalValue.Text = "00";
            this.lblBalValue.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total Bal Value :";
            // 
            // lblGrnQty
            // 
            this.lblGrnQty.AutoSize = true;
            this.lblGrnQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrnQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrnQty.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGrnQty.Location = new System.Drawing.Point(1041, 10);
            this.lblGrnQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrnQty.Name = "lblGrnQty";
            this.lblGrnQty.Size = new System.Drawing.Size(26, 19);
            this.lblGrnQty.TabIndex = 17;
            this.lblGrnQty.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(912, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total GRN Qty:";
            // 
            // lblrow
            // 
            this.lblrow.AutoSize = true;
            this.lblrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblrow.Location = new System.Drawing.Point(97, 11);
            this.lblrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrow.Name = "lblrow";
            this.lblrow.Size = new System.Drawing.Size(26, 19);
            this.lblrow.TabIndex = 15;
            this.lblrow.Text = "00";
            // 
            // lbltotalrows
            // 
            this.lbltotalrows.AutoSize = true;
            this.lbltotalrows.Location = new System.Drawing.Point(12, 11);
            this.lbltotalrows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalrows.Name = "lbltotalrows";
            this.lbltotalrows.Size = new System.Drawing.Size(86, 17);
            this.lbltotalrows.TabIndex = 14;
            this.lbltotalrows.Text = "Total Rows :";
            // 
            // lblGrnValue
            // 
            this.lblGrnValue.AutoSize = true;
            this.lblGrnValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrnValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGrnValue.Location = new System.Drawing.Point(1041, 31);
            this.lblGrnValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrnValue.Name = "lblGrnValue";
            this.lblGrnValue.Size = new System.Drawing.Size(26, 19);
            this.lblGrnValue.TabIndex = 13;
            this.lblGrnValue.Text = "00";
            // 
            // lblBalQty
            // 
            this.lblBalQty.AutoSize = true;
            this.lblBalQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalQty.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBalQty.Location = new System.Drawing.Point(635, 9);
            this.lblBalQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalQty.Name = "lblBalQty";
            this.lblBalQty.Size = new System.Drawing.Size(26, 19);
            this.lblBalQty.TabIndex = 12;
            this.lblBalQty.Text = "00";
            // 
            // lblTotalvalue
            // 
            this.lblTotalvalue.AutoSize = true;
            this.lblTotalvalue.Location = new System.Drawing.Point(912, 31);
            this.lblTotalvalue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalvalue.Name = "lblTotalvalue";
            this.lblTotalvalue.Size = new System.Drawing.Size(123, 17);
            this.lblTotalvalue.TabIndex = 11;
            this.lblTotalvalue.Text = "Total GRN Value :";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Location = new System.Drawing.Point(505, 7);
            this.lblTotalQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(94, 17);
            this.lblTotalQty.TabIndex = 10;
            this.lblTotalQty.Text = "Total Bal Qty:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::MAAQ_IMS.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(155, 113);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 28);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblDevl
            // 
            this.lblDevl.AutoSize = true;
            this.lblDevl.Location = new System.Drawing.Point(309, 59);
            this.lblDevl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevl.Name = "lblDevl";
            this.lblDevl.Size = new System.Drawing.Size(72, 17);
            this.lblDevl.TabIndex = 26;
            this.lblDevl.Text = "Dev.Mode";
            // 
            // lblCurrancy
            // 
            this.lblCurrancy.AutoSize = true;
            this.lblCurrancy.Location = new System.Drawing.Point(309, 7);
            this.lblCurrancy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrancy.Name = "lblCurrancy";
            this.lblCurrancy.Size = new System.Drawing.Size(65, 17);
            this.lblCurrancy.TabIndex = 25;
            this.lblCurrancy.Text = "Currancy";
            // 
            // lblConETDdate
            // 
            this.lblConETDdate.AutoSize = true;
            this.lblConETDdate.Location = new System.Drawing.Point(11, 63);
            this.lblConETDdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConETDdate.Name = "lblConETDdate";
            this.lblConETDdate.Size = new System.Drawing.Size(104, 17);
            this.lblConETDdate.TabIndex = 23;
            this.lblConETDdate.Text = "CON.ETD Date";
            // 
            // lblMPODate
            // 
            this.lblMPODate.AutoSize = true;
            this.lblMPODate.Location = new System.Drawing.Point(11, 12);
            this.lblMPODate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMPODate.Name = "lblMPODate";
            this.lblMPODate.Size = new System.Drawing.Size(73, 17);
            this.lblMPODate.TabIndex = 19;
            this.lblMPODate.Text = "MPO Date";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chkModify);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.cboGRNno);
            this.panel5.Controls.Add(this.btnApproveToProcced);
            this.panel5.Controls.Add(this.dtInvoiceDate);
            this.panel5.Controls.Add(this.txtConEtddate);
            this.panel5.Controls.Add(this.txtETDdate);
            this.panel5.Controls.Add(this.txtMPODate);
            this.panel5.Controls.Add(this.btncopybalQty);
            this.panel5.Controls.Add(this.txtGrnNo);
            this.panel5.Controls.Add(this.lblGRNNO);
            this.panel5.Controls.Add(this.txtRemarks);
            this.panel5.Controls.Add(this.lblRemarks);
            this.panel5.Controls.Add(this.txtBillNo);
            this.panel5.Controls.Add(this.lblbillNo);
            this.panel5.Controls.Add(this.lblinvoiceDate);
            this.panel5.Controls.Add(this.txtInvoiceNo);
            this.panel5.Controls.Add(this.lblInvoiceNo);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.lblPoType);
            this.panel5.Controls.Add(this.txtPOtype);
            this.panel5.Controls.Add(this.lblRate);
            this.panel5.Controls.Add(this.txtRate);
            this.panel5.Controls.Add(this.cboPayMode);
            this.panel5.Controls.Add(this.cboDevMode);
            this.panel5.Controls.Add(this.lblPayMode);
            this.panel5.Controls.Add(this.cboCurrency);
            this.panel5.Controls.Add(this.lblDevl);
            this.panel5.Controls.Add(this.lblCurrancy);
            this.panel5.Controls.Add(this.lblConETDdate);
            this.panel5.Controls.Add(this.lblETDdate);
            this.panel5.Controls.Add(this.lblMPODate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(344, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1456, 146);
            this.panel5.TabIndex = 4;
            // 
            // chkModify
            // 
            this.chkModify.AutoSize = true;
            this.chkModify.Location = new System.Drawing.Point(829, 71);
            this.chkModify.Margin = new System.Windows.Forms.Padding(4);
            this.chkModify.Name = "chkModify";
            this.chkModify.Size = new System.Drawing.Size(102, 21);
            this.chkModify.TabIndex = 60;
            this.chkModify.Text = "ModifyGRN";
            this.chkModify.UseVisualStyleBackColor = true;
            this.chkModify.CheckedChanged += new System.EventHandler(this.chkModify_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(825, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "GRN NO";
            this.label1.Visible = false;
            // 
            // cboGRNno
            // 
            this.cboGRNno.DropDownWidth = 200;
            this.cboGRNno.FormattingEnabled = true;
            this.cboGRNno.Location = new System.Drawing.Point(909, 38);
            this.cboGRNno.Margin = new System.Windows.Forms.Padding(4);
            this.cboGRNno.Name = "cboGRNno";
            this.cboGRNno.Size = new System.Drawing.Size(160, 24);
            this.cboGRNno.TabIndex = 58;
            this.cboGRNno.Visible = false;
            this.cboGRNno.SelectedIndexChanged += new System.EventHandler(this.cboGRNno_SelectedIndexChanged_1);
            // 
            // btnApproveToProcced
            // 
            this.btnApproveToProcced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnApproveToProcced.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproveToProcced.Location = new System.Drawing.Point(267, 113);
            this.btnApproveToProcced.Margin = new System.Windows.Forms.Padding(4);
            this.btnApproveToProcced.Name = "btnApproveToProcced";
            this.btnApproveToProcced.Size = new System.Drawing.Size(129, 28);
            this.btnApproveToProcced.TabIndex = 56;
            this.btnApproveToProcced.Text = "Procced To Approve";
            this.btnApproveToProcced.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApproveToProcced.UseVisualStyleBackColor = false;
            this.btnApproveToProcced.Click += new System.EventHandler(this.btnApproveToProcced_Click);
            // 
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.CustomFormat = "dd-MMM-yyyy";
            this.dtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInvoiceDate.Location = new System.Drawing.Point(668, 34);
            this.dtInvoiceDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(135, 22);
            this.dtInvoiceDate.TabIndex = 55;
            // 
            // txtConEtddate
            // 
            this.txtConEtddate.Location = new System.Drawing.Point(125, 54);
            this.txtConEtddate.Margin = new System.Windows.Forms.Padding(4);
            this.txtConEtddate.Name = "txtConEtddate";
            this.txtConEtddate.ReadOnly = true;
            this.txtConEtddate.Size = new System.Drawing.Size(136, 22);
            this.txtConEtddate.TabIndex = 54;
            // 
            // txtETDdate
            // 
            this.txtETDdate.Location = new System.Drawing.Point(125, 28);
            this.txtETDdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtETDdate.Name = "txtETDdate";
            this.txtETDdate.ReadOnly = true;
            this.txtETDdate.Size = new System.Drawing.Size(136, 22);
            this.txtETDdate.TabIndex = 53;
            // 
            // txtMPODate
            // 
            this.txtMPODate.Location = new System.Drawing.Point(125, 2);
            this.txtMPODate.Margin = new System.Windows.Forms.Padding(4);
            this.txtMPODate.Name = "txtMPODate";
            this.txtMPODate.ReadOnly = true;
            this.txtMPODate.Size = new System.Drawing.Size(136, 22);
            this.txtMPODate.TabIndex = 52;
            // 
            // btncopybalQty
            // 
            this.btncopybalQty.ForeColor = System.Drawing.Color.Blue;
            this.btncopybalQty.Image = ((System.Drawing.Image)(resources.GetObject("btncopybalQty.Image")));
            this.btncopybalQty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncopybalQty.Location = new System.Drawing.Point(499, 112);
            this.btncopybalQty.Margin = new System.Windows.Forms.Padding(4);
            this.btncopybalQty.Name = "btncopybalQty";
            this.btncopybalQty.Size = new System.Drawing.Size(161, 28);
            this.btncopybalQty.TabIndex = 51;
            this.btncopybalQty.Text = "Copy Balance Qty";
            this.btncopybalQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncopybalQty.UseVisualStyleBackColor = true;
            // 
            // txtGrnNo
            // 
            this.txtGrnNo.Location = new System.Drawing.Point(911, 6);
            this.txtGrnNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrnNo.Name = "txtGrnNo";
            this.txtGrnNo.ReadOnly = true;
            this.txtGrnNo.Size = new System.Drawing.Size(136, 22);
            this.txtGrnNo.TabIndex = 50;
            // 
            // lblGRNNO
            // 
            this.lblGRNNO.AutoSize = true;
            this.lblGRNNO.Location = new System.Drawing.Point(828, 11);
            this.lblGRNNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGRNNO.Name = "lblGRNNO";
            this.lblGRNNO.Size = new System.Drawing.Size(64, 17);
            this.lblGRNNO.TabIndex = 49;
            this.lblGRNNO.Text = "GRN NO";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRemarks.Location = new System.Drawing.Point(668, 85);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(136, 43);
            this.txtRemarks.TabIndex = 46;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(572, 85);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(64, 17);
            this.lblRemarks.TabIndex = 45;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtBillNo
            // 
            this.txtBillNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBillNo.Location = new System.Drawing.Point(668, 59);
            this.txtBillNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(136, 22);
            this.txtBillNo.TabIndex = 43;
            // 
            // lblbillNo
            // 
            this.lblbillNo.AutoSize = true;
            this.lblbillNo.Location = new System.Drawing.Point(573, 63);
            this.lblbillNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbillNo.Name = "lblbillNo";
            this.lblbillNo.Size = new System.Drawing.Size(48, 17);
            this.lblbillNo.TabIndex = 42;
            this.lblbillNo.Text = "Bill No";
            // 
            // lblinvoiceDate
            // 
            this.lblinvoiceDate.AutoSize = true;
            this.lblinvoiceDate.Location = new System.Drawing.Point(573, 36);
            this.lblinvoiceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinvoiceDate.Name = "lblinvoiceDate";
            this.lblinvoiceDate.Size = new System.Drawing.Size(86, 17);
            this.lblinvoiceDate.TabIndex = 40;
            this.lblinvoiceDate.Text = "Invoice Date";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInvoiceNo.Location = new System.Drawing.Point(668, 7);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(136, 22);
            this.txtInvoiceNo.TabIndex = 39;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(573, 10);
            this.lblInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(74, 17);
            this.lblInvoiceNo.TabIndex = 38;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // lblETDdate
            // 
            this.lblETDdate.AutoSize = true;
            this.lblETDdate.Location = new System.Drawing.Point(11, 39);
            this.lblETDdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblETDdate.Name = "lblETDdate";
            this.lblETDdate.Size = new System.Drawing.Size(70, 17);
            this.lblETDdate.TabIndex = 20;
            this.lblETDdate.Text = "ETD Date";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1804, 554);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // GRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GRN";
            this.Text = "GRN-Goods Receive Note";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GRN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRNpandding)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRNDetails)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblmpoNo;
        private System.Windows.Forms.TextBox txtMPONO;
        private System.Windows.Forms.ComboBox cboSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblPoType;
        private System.Windows.Forms.TextBox txtPOtype;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.ComboBox cboPayMode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvGRNpandding;
        private System.Windows.Forms.DataGridViewLinkColumn txtGridSelect;
        private System.Windows.Forms.ComboBox cboDevMode;
        private System.Windows.Forms.Label lblPayMode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvGRNDetails;
        private System.Windows.Forms.ComboBox cboCurrency;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDevl;
        private System.Windows.Forms.Label lblCurrancy;
        private System.Windows.Forms.Label lblConETDdate;
        private System.Windows.Forms.Label lblETDdate;
        private System.Windows.Forms.Label lblMPODate;
        private System.Windows.Forms.Label lblrow;
        private System.Windows.Forms.Label lbltotalrows;
        private System.Windows.Forms.Label lblGrnValue;
        private System.Windows.Forms.Label lblBalQty;
        private System.Windows.Forms.Label lblTotalvalue;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label lblbillNo;
        private System.Windows.Forms.Label lblinvoiceDate;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtGrnNo;
        private System.Windows.Forms.Label lblGRNNO;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btncopybalQty;
        private System.Windows.Forms.Label lblBalValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGrnQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConEtddate;
        private System.Windows.Forms.TextBox txtETDdate;
        private System.Windows.Forms.TextBox txtMPODate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGridItemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Size_Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGridPoQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGridAlreadyRcvd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGridBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRN_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNValue;
        private System.Windows.Forms.DateTimePicker dtInvoiceDate;
        private System.Windows.Forms.Button btnApproveToProcced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGRNno;
        private System.Windows.Forms.CheckBox chkModify;
    }
}