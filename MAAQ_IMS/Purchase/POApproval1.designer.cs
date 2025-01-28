namespace MAAQ_IMS.Purchase
{
    partial class POApproval1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblmpoNo = new System.Windows.Forms.Label();
            this.txtMPONO = new System.Windows.Forms.TextBox();
            this.cboSupplierName = new System.Windows.Forms.ComboBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAppPending = new System.Windows.Forms.DataGridView();
            this.txtGridSelect = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMpoDetails = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblrow = new System.Windows.Forms.Label();
            this.lbltotalrows = new System.Windows.Forms.Label();
            this.lblvalue = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblTotalvalue = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblPoType = new System.Windows.Forms.Label();
            this.txtPOtype = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.cboPayMode = new System.Windows.Forms.ComboBox();
            this.cboDevMode = new System.Windows.Forms.ComboBox();
            this.lblPayMode = new System.Windows.Forms.Label();
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.lblDevl = new System.Windows.Forms.Label();
            this.lblCurrancy = new System.Windows.Forms.Label();
            this.dtConEtddate = new System.Windows.Forms.DateTimePicker();
            this.lblConETDdate = new System.Windows.Forms.Label();
            this.dtETDDATE = new System.Windows.Forms.DateTimePicker();
            this.dtMPODate = new System.Windows.Forms.DateTimePicker();
            this.lblETDdate = new System.Windows.Forms.Label();
            this.lblMPODate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppPending)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMpoDetails)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblmpoNo);
            this.panel1.Controls.Add(this.txtMPONO);
            this.panel1.Controls.Add(this.cboSupplierName);
            this.panel1.Controls.Add(this.lblSupplierName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 119);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 

            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(157, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblmpoNo
            // 
            this.lblmpoNo.AutoSize = true;
            this.lblmpoNo.Location = new System.Drawing.Point(12, 34);
            this.lblmpoNo.Name = "lblmpoNo";
            this.lblmpoNo.Size = new System.Drawing.Size(50, 13);
            this.lblmpoNo.TabIndex = 3;
            this.lblmpoNo.Text = "MPO NO";
            // 
            // txtMPONO
            // 
            this.txtMPONO.Location = new System.Drawing.Point(99, 27);
            this.txtMPONO.Name = "txtMPONO";
            this.txtMPONO.Size = new System.Drawing.Size(121, 20);
            this.txtMPONO.TabIndex = 2;
            // 
            // cboSupplierName
            // 
            this.cboSupplierName.DropDownWidth = 200;
            this.cboSupplierName.FormattingEnabled = true;
            this.cboSupplierName.Location = new System.Drawing.Point(99, 5);
            this.cboSupplierName.Name = "cboSupplierName";
            this.cboSupplierName.Size = new System.Drawing.Size(121, 21);
            this.cboSupplierName.TabIndex = 1;
            this.cboSupplierName.SelectedIndexChanged += new System.EventHandler(this.cboSupplierName_SelectedIndexChanged);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(12, 10);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(76, 13);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAppPending);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 269);
            this.panel2.TabIndex = 1;
            // 
            // dgvAppPending
            // 
            this.dgvAppPending.AllowUserToAddRows = false;
            this.dgvAppPending.AllowUserToDeleteRows = false;
            this.dgvAppPending.AllowUserToResizeRows = false;
            this.dgvAppPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAppPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtGridSelect});
            this.dgvAppPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppPending.Location = new System.Drawing.Point(0, 0);
            this.dgvAppPending.Name = "dgvAppPending";
            this.dgvAppPending.ReadOnly = true;
            this.dgvAppPending.RowHeadersWidth = 20;
            this.dgvAppPending.Size = new System.Drawing.Size(249, 269);
            this.dgvAppPending.TabIndex = 0;
            this.dgvAppPending.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppPending_CellClick);
            // 
            // txtGridSelect
            // 
            this.txtGridSelect.HeaderText = "Action";
            this.txtGridSelect.Name = "txtGridSelect";
            this.txtGridSelect.ReadOnly = true;
            this.txtGridSelect.Text = "Select";
            this.txtGridSelect.UseColumnTextForLinkValue = true;
            this.txtGridSelect.Width = 43;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvMpoDetails);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 269);
            this.panel3.TabIndex = 2;
            // 
            // dgvMpoDetails
            // 
            this.dgvMpoDetails.AllowUserToAddRows = false;
            this.dgvMpoDetails.AllowUserToDeleteRows = false;
            this.dgvMpoDetails.AllowUserToResizeRows = false;
            this.dgvMpoDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMpoDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMpoDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMpoDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvMpoDetails.Name = "dgvMpoDetails";
            this.dgvMpoDetails.ReadOnly = true;
            this.dgvMpoDetails.RowHeadersWidth = 20;
            this.dgvMpoDetails.Size = new System.Drawing.Size(669, 269);
            this.dgvMpoDetails.TabIndex = 0;
            // 
            // panel4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.lblrow);
            this.panel4.Controls.Add(this.lbltotalrows);
            this.panel4.Controls.Add(this.lblvalue);
            this.panel4.Controls.Add(this.lblQty);
            this.panel4.Controls.Add(this.lblTotalvalue);
            this.panel4.Controls.Add(this.lblTotalQty);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 403);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(924, 44);
            this.panel4.TabIndex = 3;
            // 
            // lblrow
            // 
            this.lblrow.AutoSize = true;
            this.lblrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblrow.Location = new System.Drawing.Point(73, 9);
            this.lblrow.Name = "lblrow";
            this.lblrow.Size = new System.Drawing.Size(21, 15);
            this.lblrow.TabIndex = 15;
            this.lblrow.Text = "00";
            // 
            // lbltotalrows
            // 
            this.lbltotalrows.AutoSize = true;
            this.lbltotalrows.Location = new System.Drawing.Point(9, 9);
            this.lbltotalrows.Name = "lbltotalrows";
            this.lbltotalrows.Size = new System.Drawing.Size(67, 13);
            this.lbltotalrows.TabIndex = 14;
            this.lbltotalrows.Text = "Total Rows :";
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblvalue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblvalue.Location = new System.Drawing.Point(476, 23);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(21, 15);
            this.lblvalue.TabIndex = 13;
            this.lblvalue.Text = "00";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQty.Location = new System.Drawing.Point(476, 10);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(21, 15);
            this.lblQty.TabIndex = 12;
            this.lblQty.Text = "00";
            // 
            // lblTotalvalue
            // 
            this.lblTotalvalue.AutoSize = true;
            this.lblTotalvalue.Location = new System.Drawing.Point(400, 23);
            this.lblTotalvalue.Name = "lblTotalvalue";
            this.lblTotalvalue.Size = new System.Drawing.Size(67, 13);
            this.lblTotalvalue.TabIndex = 11;
            this.lblTotalvalue.Text = "Total Value :";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Location = new System.Drawing.Point(400, 9);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(53, 13);
            this.lblTotalQty.TabIndex = 10;
            this.lblTotalQty.Text = "Total Qty:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cboUsers);
            this.panel5.Controls.Add(this.label1);
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
            this.panel5.Controls.Add(this.dtConEtddate);
            this.panel5.Controls.Add(this.lblConETDdate);
            this.panel5.Controls.Add(this.dtETDDATE);
            this.panel5.Controls.Add(this.dtMPODate);
            this.panel5.Controls.Add(this.lblETDdate);
            this.panel5.Controls.Add(this.lblMPODate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(258, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(669, 119);
            this.panel5.TabIndex = 4;
            // 
            // cboUsers
            // 
            this.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(557, 7);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(103, 21);
            this.cboUsers.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Approved By";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(107, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Approve";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::MAAQ_IMS.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(196, 93);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblPoType
            // 
            this.lblPoType.AutoSize = true;
            this.lblPoType.Location = new System.Drawing.Point(8, 70);
            this.lblPoType.Name = "lblPoType";
            this.lblPoType.Size = new System.Drawing.Size(49, 13);
            this.lblPoType.TabIndex = 36;
            this.lblPoType.Text = "PO Type";
            // 
            // txtPOtype
            // 
            this.txtPOtype.Location = new System.Drawing.Point(94, 68);
            this.txtPOtype.Name = "txtPOtype";
            this.txtPOtype.Size = new System.Drawing.Size(103, 20);
            this.txtPOtype.TabIndex = 35;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(240, 31);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(65, 13);
            this.lblRate.TabIndex = 34;
            this.lblRate.Text = "Rate 1 USD";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(325, 24);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(103, 20);
            this.txtRate.TabIndex = 33;
            // 
            // cboPayMode
            // 
            this.cboPayMode.FormattingEnabled = true;
            this.cboPayMode.Location = new System.Drawing.Point(325, 67);
            this.cboPayMode.Name = "cboPayMode";
            this.cboPayMode.Size = new System.Drawing.Size(103, 21);
            this.cboPayMode.TabIndex = 30;
            // 
            // cboDevMode
            // 
            this.cboDevMode.FormattingEnabled = true;
            this.cboDevMode.Location = new System.Drawing.Point(325, 45);
            this.cboDevMode.Name = "cboDevMode";
            this.cboDevMode.Size = new System.Drawing.Size(103, 21);
            this.cboDevMode.TabIndex = 29;
            // 
            // lblPayMode
            // 
            this.lblPayMode.AutoSize = true;
            this.lblPayMode.Location = new System.Drawing.Point(240, 67);
            this.lblPayMode.Name = "lblPayMode";
            this.lblPayMode.Size = new System.Drawing.Size(55, 13);
            this.lblPayMode.TabIndex = 28;
            this.lblPayMode.Text = "Pay Mode";
            // 
            // cboCurrency
            // 
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.Location = new System.Drawing.Point(325, 2);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(103, 21);
            this.cboCurrency.TabIndex = 27;
            // 
            // lblDevl
            // 
            this.lblDevl.AutoSize = true;
            this.lblDevl.Location = new System.Drawing.Point(240, 52);
            this.lblDevl.Name = "lblDevl";
            this.lblDevl.Size = new System.Drawing.Size(57, 13);
            this.lblDevl.TabIndex = 26;
            this.lblDevl.Text = "Dev.Mode";
            // 
            // lblCurrancy
            // 
            this.lblCurrancy.AutoSize = true;
            this.lblCurrancy.Location = new System.Drawing.Point(240, 6);
            this.lblCurrancy.Name = "lblCurrancy";
            this.lblCurrancy.Size = new System.Drawing.Size(49, 13);
            this.lblCurrancy.TabIndex = 25;
            this.lblCurrancy.Text = "Currancy";
            // 
            // dtConEtddate
            // 
            this.dtConEtddate.CustomFormat = "dd-MMM-yyyy";
            this.dtConEtddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtConEtddate.Location = new System.Drawing.Point(94, 47);
            this.dtConEtddate.Name = "dtConEtddate";
            this.dtConEtddate.Size = new System.Drawing.Size(102, 20);
            this.dtConEtddate.TabIndex = 24;
            // 
            // lblConETDdate
            // 
            this.lblConETDdate.AutoSize = true;
            this.lblConETDdate.Location = new System.Drawing.Point(8, 51);
            this.lblConETDdate.Name = "lblConETDdate";
            this.lblConETDdate.Size = new System.Drawing.Size(81, 13);
            this.lblConETDdate.TabIndex = 23;
            this.lblConETDdate.Text = "CON.ETD Date";
            // 
            // dtETDDATE
            // 
            this.dtETDDATE.CustomFormat = "dd-MMM-yyyy";
            this.dtETDDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtETDDATE.Location = new System.Drawing.Point(94, 26);
            this.dtETDDATE.Name = "dtETDDATE";
            this.dtETDDATE.Size = new System.Drawing.Size(102, 20);
            this.dtETDDATE.TabIndex = 22;
            // 
            // dtMPODate
            // 
            this.dtMPODate.CustomFormat = "dd-MMM-yyyy";
            this.dtMPODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMPODate.Location = new System.Drawing.Point(94, 5);
            this.dtMPODate.Name = "dtMPODate";
            this.dtMPODate.Size = new System.Drawing.Size(102, 20);
            this.dtMPODate.TabIndex = 21;
            // 
            // lblETDdate
            // 
            this.lblETDdate.AutoSize = true;
            this.lblETDdate.Location = new System.Drawing.Point(8, 32);
            this.lblETDdate.Name = "lblETDdate";
            this.lblETDdate.Size = new System.Drawing.Size(55, 13);
            this.lblETDdate.TabIndex = 20;
            this.lblETDdate.Text = "ETD Date";
            // 
            // lblMPODate
            // 
            this.lblMPODate.AutoSize = true;
            this.lblMPODate.Location = new System.Drawing.Point(8, 10);
            this.lblMPODate.Name = "lblMPODate";
            this.lblMPODate.Size = new System.Drawing.Size(57, 13);
            this.lblMPODate.TabIndex = 19;
            this.lblMPODate.Text = "MPO Date";
            // 
            // POApproval1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "POApproval1";
            this.Text = "MPO Approval";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POApproval1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppPending)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMpoDetails)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAppPending;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvMpoDetails;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblrow;
        private System.Windows.Forms.Label lbltotalrows;
        private System.Windows.Forms.Label lblvalue;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblTotalvalue;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cboSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblmpoNo;
        private System.Windows.Forms.TextBox txtMPONO;
        private System.Windows.Forms.DateTimePicker dtETDDATE;
        private System.Windows.Forms.DateTimePicker dtMPODate;
        private System.Windows.Forms.Label lblETDdate;
        private System.Windows.Forms.Label lblMPODate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.ComboBox cboPayMode;
        private System.Windows.Forms.ComboBox cboDevMode;
        private System.Windows.Forms.Label lblPayMode;
        private System.Windows.Forms.ComboBox cboCurrency;
        private System.Windows.Forms.Label lblDevl;
        private System.Windows.Forms.Label lblCurrancy;
        private System.Windows.Forms.DateTimePicker dtConEtddate;
        private System.Windows.Forms.Label lblConETDdate;
        private System.Windows.Forms.Label lblPoType;
        private System.Windows.Forms.TextBox txtPOtype;
        private System.Windows.Forms.DataGridViewLinkColumn txtGridSelect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.Label label1;
    }
}