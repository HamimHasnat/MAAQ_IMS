namespace MAAQ_IMS.Reports
{
    partial class EmpJobCardReport
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
            this.chkAttRegister = new System.Windows.Forms.RadioButton();
            this.chkOTDetails = new System.Windows.Forms.RadioButton();
            this.ChkJobCard = new System.Windows.Forms.RadioButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.chkDAOT = new System.Windows.Forms.RadioButton();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cboEmpID = new System.Windows.Forms.ComboBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.chkOTSummary = new System.Windows.Forms.RadioButton();
            this.chkDailyAtt = new System.Windows.Forms.RadioButton();
            this.chkAbsent = new System.Windows.Forms.RadioButton();
            this.chkPresent = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ChkLeaveRegister = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 585);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChkLeaveRegister);
            this.panel1.Controls.Add(this.chkAttRegister);
            this.panel1.Controls.Add(this.chkOTDetails);
            this.panel1.Controls.Add(this.ChkJobCard);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.chkDAOT);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.cboEmpID);
            this.panel1.Controls.Add(this.lblEmpID);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.chkOTSummary);
            this.panel1.Controls.Add(this.chkDailyAtt);
            this.panel1.Controls.Add(this.chkAbsent);
            this.panel1.Controls.Add(this.chkPresent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 579);
            this.panel1.TabIndex = 0;
            // 
            // chkAttRegister
            // 
            this.chkAttRegister.AutoSize = true;
            this.chkAttRegister.Location = new System.Drawing.Point(31, 140);
            this.chkAttRegister.Name = "chkAttRegister";
            this.chkAttRegister.Size = new System.Drawing.Size(122, 17);
            this.chkAttRegister.TabIndex = 72;
            this.chkAttRegister.Text = "Attendance Register\r\n";
            this.chkAttRegister.UseVisualStyleBackColor = true;
            // 
            // chkOTDetails
            // 
            this.chkOTDetails.AutoSize = true;
            this.chkOTDetails.Location = new System.Drawing.Point(30, 93);
            this.chkOTDetails.Name = "chkOTDetails";
            this.chkOTDetails.Size = new System.Drawing.Size(110, 17);
            this.chkOTDetails.TabIndex = 71;
            this.chkOTDetails.Text = "OT Report Details";
            this.chkOTDetails.UseVisualStyleBackColor = true;
            // 
            // ChkJobCard
            // 
            this.ChkJobCard.AutoSize = true;
            this.ChkJobCard.Location = new System.Drawing.Point(31, 165);
            this.ChkJobCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkJobCard.Name = "ChkJobCard";
            this.ChkJobCard.Size = new System.Drawing.Size(120, 17);
            this.ChkJobCard.TabIndex = 70;
            this.ChkJobCard.TabStop = true;
            this.ChkJobCard.Text = "Employee\'s JobCard";
            this.ChkJobCard.UseVisualStyleBackColor = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd-MMM-yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(86, 294);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(102, 20);
            this.dtpFrom.TabIndex = 69;
            this.dtpFrom.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // chkDAOT
            // 
            this.chkDAOT.AutoSize = true;
            this.chkDAOT.Location = new System.Drawing.Point(31, 116);
            this.chkDAOT.Name = "chkDAOT";
            this.chkDAOT.Size = new System.Drawing.Size(141, 17);
            this.chkDAOT.TabIndex = 51;
            this.chkDAOT.Text = "Monthly OT & Attendance\r\n";
            this.chkDAOT.UseVisualStyleBackColor = true;
            // 
            // dtTo
            // 
            this.dtTo.Checked = false;
            this.dtTo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dtTo.CustomFormat = "d-MMM-yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(86, 319);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(101, 20);
            this.dtTo.TabIndex = 49;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(29, 323);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 47;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(26, 300);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 46;
            this.lblFrom.Text = "From";
            // 
            // cboEmpID
            // 
            this.cboEmpID.FormattingEnabled = true;
            this.cboEmpID.Location = new System.Drawing.Point(86, 244);
            this.cboEmpID.Name = "cboEmpID";
            this.cboEmpID.Size = new System.Drawing.Size(102, 21);
            this.cboEmpID.TabIndex = 35;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(28, 246);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(42, 13);
            this.lblEmpID.TabIndex = 34;
            this.lblEmpID.Text = "Emp ID";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(124, 346);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(44, 346);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // chkOTSummary
            // 
            this.chkOTSummary.AutoSize = true;
            this.chkOTSummary.Location = new System.Drawing.Point(31, 71);
            this.chkOTSummary.Name = "chkOTSummary";
            this.chkOTSummary.Size = new System.Drawing.Size(121, 17);
            this.chkOTSummary.TabIndex = 3;
            this.chkOTSummary.Text = "OT Report Summary";
            this.chkOTSummary.UseVisualStyleBackColor = true;
            // 
            // chkDailyAtt
            // 
            this.chkDailyAtt.AutoSize = true;
            this.chkDailyAtt.Location = new System.Drawing.Point(31, 48);
            this.chkDailyAtt.Name = "chkDailyAtt";
            this.chkDailyAtt.Size = new System.Drawing.Size(106, 17);
            this.chkDailyAtt.TabIndex = 2;
            this.chkDailyAtt.Text = "Daily Attendance";
            this.chkDailyAtt.UseVisualStyleBackColor = true;
            // 
            // chkAbsent
            // 
            this.chkAbsent.AutoSize = true;
            this.chkAbsent.Location = new System.Drawing.Point(31, 25);
            this.chkAbsent.Name = "chkAbsent";
            this.chkAbsent.Size = new System.Drawing.Size(58, 17);
            this.chkAbsent.TabIndex = 1;
            this.chkAbsent.Text = "Absent";
            this.chkAbsent.UseVisualStyleBackColor = true;
            // 
            // chkPresent
            // 
            this.chkPresent.AutoSize = true;
            this.chkPresent.Checked = true;
            this.chkPresent.Location = new System.Drawing.Point(31, 2);
            this.chkPresent.Name = "chkPresent";
            this.chkPresent.Size = new System.Drawing.Size(61, 17);
            this.chkPresent.TabIndex = 0;
            this.chkPresent.TabStop = true;
            this.chkPresent.Text = "Present";
            this.chkPresent.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.crystalReportViewer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(221, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 579);
            this.panel3.TabIndex = 2;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(804, 579);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ChkLeaveRegister
            // 
            this.ChkLeaveRegister.AutoSize = true;
            this.ChkLeaveRegister.Location = new System.Drawing.Point(31, 186);
            this.ChkLeaveRegister.Margin = new System.Windows.Forms.Padding(2);
            this.ChkLeaveRegister.Name = "ChkLeaveRegister";
            this.ChkLeaveRegister.Size = new System.Drawing.Size(114, 17);
            this.ChkLeaveRegister.TabIndex = 73;
            this.ChkLeaveRegister.TabStop = true;
            this.ChkLeaveRegister.Text = "Leave Registration";
            this.ChkLeaveRegister.UseVisualStyleBackColor = true;
            // 
            // EmpJobCardReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmpJobCardReport";
            this.Text = "EmpJobCardReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmpJobCardReport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.RadioButton chkOTSummary;
        private System.Windows.Forms.RadioButton chkDailyAtt;
        private System.Windows.Forms.RadioButton chkAbsent;
        private System.Windows.Forms.RadioButton chkPresent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboEmpID;
        private System.Windows.Forms.Label lblEmpID;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.RadioButton chkDAOT;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.RadioButton ChkJobCard;
        private System.Windows.Forms.RadioButton chkOTDetails;
        private System.Windows.Forms.RadioButton chkAttRegister;
        private System.Windows.Forms.RadioButton ChkLeaveRegister;
    } 
}