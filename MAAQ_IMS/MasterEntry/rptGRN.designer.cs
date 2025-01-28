namespace MAAQ_IMS.MasterEntry
{
    partial class rptGRN
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
            this.btnShow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvGRN = new System.Windows.Forms.DataGridView();
            this.txtGridReport = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.CboSupplierName = new System.Windows.Forms.ComboBox();
            this.chkGrnDate = new System.Windows.Forms.CheckBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtGRNNO = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblGRNNO = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRN)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(112, 180);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 28);
            this.btnShow.TabIndex = 25;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 363F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvGRN);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(367, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(696, 509);
            this.panel4.TabIndex = 2;
            // 
            // dgvGRN
            // 
            this.dgvGRN.AllowUserToAddRows = false;
            this.dgvGRN.AllowUserToDeleteRows = false;
            this.dgvGRN.AllowUserToResizeRows = false;
            this.dgvGRN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtGridReport});
            this.dgvGRN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGRN.Location = new System.Drawing.Point(0, 0);
            this.dgvGRN.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGRN.Name = "dgvGRN";
            this.dgvGRN.ReadOnly = true;
            this.dgvGRN.RowHeadersWidth = 20;
            this.dgvGRN.Size = new System.Drawing.Size(696, 509);
            this.dgvGRN.TabIndex = 0;
            this.dgvGRN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMPO_CellClick);
            // 
            // txtGridReport
            // 
            this.txtGridReport.HeaderText = "Report";
            this.txtGridReport.Name = "txtGridReport";
            this.txtGridReport.ReadOnly = true;
            this.txtGridReport.Text = "Report";
            this.txtGridReport.ToolTipText = "Report";
            this.txtGridReport.UseColumnTextForLinkValue = true;
            this.txtGridReport.Width = 57;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtTo);
            this.panel3.Controls.Add(this.dtFrom);
            this.panel3.Controls.Add(this.CboSupplierName);
            this.panel3.Controls.Add(this.chkGrnDate);
            this.panel3.Controls.Add(this.lblTo);
            this.panel3.Controls.Add(this.lblFrom);
            this.panel3.Controls.Add(this.lblSupplierName);
            this.panel3.Controls.Add(this.txtGRNNO);
            this.panel3.Controls.Add(this.btnShow);
            this.panel3.Controls.Add(this.lblSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.lblGRNNO);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 509);
            this.panel3.TabIndex = 2;
            // 
            // dtTo
            // 
            this.dtTo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dtTo.CustomFormat = "d-MMM-yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(109, 123);
            this.dtTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(133, 22);
            this.dtTo.TabIndex = 35;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd-MMM-yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(109, 95);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(133, 22);
            this.dtFrom.TabIndex = 34;
            // 
            // CboSupplierName
            // 
            this.CboSupplierName.FormattingEnabled = true;
            this.CboSupplierName.Location = new System.Drawing.Point(109, 11);
            this.CboSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.CboSupplierName.Name = "CboSupplierName";
            this.CboSupplierName.Size = new System.Drawing.Size(203, 24);
            this.CboSupplierName.TabIndex = 33;
            // 
            // chkGrnDate
            // 
            this.chkGrnDate.AutoSize = true;
            this.chkGrnDate.Location = new System.Drawing.Point(109, 74);
            this.chkGrnDate.Margin = new System.Windows.Forms.Padding(4);
            this.chkGrnDate.Name = "chkGrnDate";
            this.chkGrnDate.Size = new System.Drawing.Size(95, 21);
            this.chkGrnDate.TabIndex = 32;
            this.chkGrnDate.Text = "GRN Date";
            this.chkGrnDate.UseVisualStyleBackColor = true;
            this.chkGrnDate.CheckedChanged += new System.EventHandler(this.chkGrnDate_CheckedChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(76, 129);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 17);
            this.lblTo.TabIndex = 31;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(63, 101);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 17);
            this.lblFrom.TabIndex = 30;
            this.lblFrom.Text = "From";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(0, 14);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(101, 17);
            this.lblSupplierName.TabIndex = 29;
            this.lblSupplierName.Text = "SuppIier Name";
            // 
            // txtGRNNO
            // 
            this.txtGRNNO.Location = new System.Drawing.Point(109, 44);
            this.txtGRNNO.Margin = new System.Windows.Forms.Padding(4);
            this.txtGRNNO.Name = "txtGRNNO";
            this.txtGRNNO.Size = new System.Drawing.Size(184, 22);
            this.txtGRNNO.TabIndex = 26;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(39, 153);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(107, 150);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 22);
            this.txtSearch.TabIndex = 9;
            // 
            // lblGRNNO
            // 
            this.lblGRNNO.AutoSize = true;
            this.lblGRNNO.Location = new System.Drawing.Point(35, 44);
            this.lblGRNNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGRNNO.Name = "lblGRNNO";
            this.lblGRNNO.Size = new System.Drawing.Size(64, 17);
            this.lblGRNNO.TabIndex = 14;
            this.lblGRNNO.Text = "GRN NO";
            // 
            // rptGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rptGRN";
            this.Text = "rptGRN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptGRN_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRN)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvGRN;
        private System.Windows.Forms.DataGridViewLinkColumn txtGridReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblGRNNO;
        private System.Windows.Forms.TextBox txtGRNNO;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.ComboBox CboSupplierName;
        private System.Windows.Forms.CheckBox chkGrnDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblSupplierName;
    }
}