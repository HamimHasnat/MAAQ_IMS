namespace MAAQ_IMS.Reports
{
    partial class AllReport
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
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboSubGroup = new System.Windows.Forms.ComboBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chcDetails = new System.Windows.Forms.RadioButton();
            this.chcSummary = new System.Windows.Forms.RadioButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSubGroup = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.chcAllReport = new System.Windows.Forms.RadioButton();
            this.chcStock = new System.Windows.Forms.RadioButton();
            this.chcIssue = new System.Windows.Forms.RadioButton();
            this.chcGRNReport = new System.Windows.Forms.RadioButton();
            this.chcPo_Report = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1305, 612);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkDate);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.cboCategory);
            this.panel1.Controls.Add(this.cboSubGroup);
            this.panel1.Controls.Add(this.cboGroup);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblSubGroup);
            this.panel1.Controls.Add(this.lblGroup);
            this.panel1.Controls.Add(this.chcAllReport);
            this.panel1.Controls.Add(this.chcStock);
            this.panel1.Controls.Add(this.chcIssue);
            this.panel1.Controls.Add(this.chcGRNReport);
            this.panel1.Controls.Add(this.chcPo_Report);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 604);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(128, 245);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(103, 21);
            this.chkDate.TabIndex = 44;
            this.chkDate.Text = "Check Date";
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.Click += new System.EventHandler(this.chkDate_Click);
            // 
            // dtTo
            // 
            this.dtTo.Checked = false;
            this.dtTo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dtTo.CustomFormat = "d-MMM-yyyy";
            this.dtTo.Enabled = false;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(128, 297);
            this.dtTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(133, 22);
            this.dtTo.TabIndex = 43;
            // 
            // dtFrom
            // 
            this.dtFrom.Checked = false;
            this.dtFrom.CustomFormat = "dd-MMM-yyyy";
            this.dtFrom.Enabled = false;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(128, 269);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(133, 22);
            this.dtFrom.TabIndex = 42;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(41, 302);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 17);
            this.lblTo.TabIndex = 41;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(28, 274);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 17);
            this.lblFrom.TabIndex = 40;
            this.lblFrom.Text = "From";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(176, 380);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(128, 214);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(160, 24);
            this.cboCategory.TabIndex = 16;
            // 
            // cboSubGroup
            // 
            this.cboSubGroup.FormattingEnabled = true;
            this.cboSubGroup.Location = new System.Drawing.Point(128, 187);
            this.cboSubGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cboSubGroup.Name = "cboSubGroup";
            this.cboSubGroup.Size = new System.Drawing.Size(160, 24);
            this.cboSubGroup.TabIndex = 15;
            this.cboSubGroup.SelectedIndexChanged += new System.EventHandler(this.cboSubGroup_SelectedIndexChanged);
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(128, 160);
            this.cboGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(160, 24);
            this.cboGroup.TabIndex = 14;
            this.cboGroup.SelectedIndexChanged += new System.EventHandler(this.cboGroup_SelectedIndexChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(52, 380);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 28);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chcDetails);
            this.panel4.Controls.Add(this.chcSummary);
            this.panel4.Location = new System.Drawing.Point(55, 335);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 37);
            this.panel4.TabIndex = 1;
            // 
            // chcDetails
            // 
            this.chcDetails.AutoSize = true;
            this.chcDetails.Checked = true;
            this.chcDetails.Location = new System.Drawing.Point(4, 9);
            this.chcDetails.Margin = new System.Windows.Forms.Padding(4);
            this.chcDetails.Name = "chcDetails";
            this.chcDetails.Size = new System.Drawing.Size(72, 21);
            this.chcDetails.TabIndex = 11;
            this.chcDetails.TabStop = true;
            this.chcDetails.Text = "Details";
            this.chcDetails.UseVisualStyleBackColor = true;
            // 
            // chcSummary
            // 
            this.chcSummary.AutoSize = true;
            this.chcSummary.Location = new System.Drawing.Point(107, 4);
            this.chcSummary.Margin = new System.Windows.Forms.Padding(4);
            this.chcSummary.Name = "chcSummary";
            this.chcSummary.Size = new System.Drawing.Size(88, 21);
            this.chcSummary.TabIndex = 12;
            this.chcSummary.Text = "Summary";
            this.chcSummary.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(24, 214);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // lblSubGroup
            // 
            this.lblSubGroup.AutoSize = true;
            this.lblSubGroup.Location = new System.Drawing.Point(24, 190);
            this.lblSubGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubGroup.Name = "lblSubGroup";
            this.lblSubGroup.Size = new System.Drawing.Size(77, 17);
            this.lblSubGroup.TabIndex = 7;
            this.lblSubGroup.Text = "Sub Group";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(24, 160);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(48, 17);
            this.lblGroup.TabIndex = 5;
            this.lblGroup.Text = "Group";
            // 
            // chcAllReport
            // 
            this.chcAllReport.AutoSize = true;
            this.chcAllReport.Location = new System.Drawing.Point(41, 116);
            this.chcAllReport.Margin = new System.Windows.Forms.Padding(4);
            this.chcAllReport.Name = "chcAllReport";
            this.chcAllReport.Size = new System.Drawing.Size(91, 21);
            this.chcAllReport.TabIndex = 4;
            this.chcAllReport.Text = "All Report";
            this.chcAllReport.UseVisualStyleBackColor = true;
            // 
            // chcStock
            // 
            this.chcStock.AutoSize = true;
            this.chcStock.Location = new System.Drawing.Point(41, 87);
            this.chcStock.Margin = new System.Windows.Forms.Padding(4);
            this.chcStock.Name = "chcStock";
            this.chcStock.Size = new System.Drawing.Size(111, 21);
            this.chcStock.TabIndex = 3;
            this.chcStock.Text = "Stock Report";
            this.chcStock.UseVisualStyleBackColor = true;
            // 
            // chcIssue
            // 
            this.chcIssue.AutoSize = true;
            this.chcIssue.Location = new System.Drawing.Point(41, 59);
            this.chcIssue.Margin = new System.Windows.Forms.Padding(4);
            this.chcIssue.Name = "chcIssue";
            this.chcIssue.Size = new System.Drawing.Size(109, 21);
            this.chcIssue.TabIndex = 2;
            this.chcIssue.Text = "Issue Report";
            this.chcIssue.UseVisualStyleBackColor = true;
            // 
            // chcGRNReport
            // 
            this.chcGRNReport.AutoSize = true;
            this.chcGRNReport.Location = new System.Drawing.Point(41, 31);
            this.chcGRNReport.Margin = new System.Windows.Forms.Padding(4);
            this.chcGRNReport.Name = "chcGRNReport";
            this.chcGRNReport.Size = new System.Drawing.Size(107, 21);
            this.chcGRNReport.TabIndex = 1;
            this.chcGRNReport.Text = "GRN Report";
            this.chcGRNReport.UseVisualStyleBackColor = true;
            // 
            // chcPo_Report
            // 
            this.chcPo_Report.AutoSize = true;
            this.chcPo_Report.Checked = true;
            this.chcPo_Report.Location = new System.Drawing.Point(41, 2);
            this.chcPo_Report.Margin = new System.Windows.Forms.Padding(4);
            this.chcPo_Report.Name = "chcPo_Report";
            this.chcPo_Report.Size = new System.Drawing.Size(100, 21);
            this.chcPo_Report.TabIndex = 0;
            this.chcPo_Report.TabStop = true;
            this.chcPo_Report.Text = "PO_Report";
            this.chcPo_Report.UseVisualStyleBackColor = true;
            this.chcPo_Report.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chcPo_Report_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(404, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(897, 604);
            this.panel3.TabIndex = 2;
            // 
            // AllReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 756);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllReport";
            this.Text = "AllReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllReport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSubGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.RadioButton chcAllReport;
        private System.Windows.Forms.RadioButton chcStock;
        private System.Windows.Forms.RadioButton chcIssue;
        private System.Windows.Forms.RadioButton chcGRNReport;
        private System.Windows.Forms.RadioButton chcPo_Report;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton chcSummary;
        private System.Windows.Forms.RadioButton chcDetails;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboSubGroup;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.CheckBox chkDate;
    }
}