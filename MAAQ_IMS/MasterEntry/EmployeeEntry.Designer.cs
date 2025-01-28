namespace MAAQ_IMS.MasterEntry
{
    partial class EmployeeEntry
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
            this.cboEmpStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.cboDesignation = new System.Windows.Forms.ComboBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtJoineddate = new System.Windows.Forms.DateTimePicker();
            this.txtMediAllow = new System.Windows.Forms.TextBox();
            this.txtHouseRent = new System.Windows.Forms.TextBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblBasic = new System.Windows.Forms.Label();
            this.lblHouseRent = new System.Windows.Forms.Label();
            this.lblMediAllow = new System.Windows.Forms.Label();
            this.lblJoinedDate = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSalaryInc = new System.Windows.Forms.DataGridView();
            this.btnAction = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryInc)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 576);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboEmpStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboDepartment);
            this.panel1.Controls.Add(this.cboDesignation);
            this.panel1.Controls.Add(this.txtEmpID);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dtJoineddate);
            this.panel1.Controls.Add(this.txtMediAllow);
            this.panel1.Controls.Add(this.txtHouseRent);
            this.panel1.Controls.Add(this.txtBasic);
            this.panel1.Controls.Add(this.txtGross);
            this.panel1.Controls.Add(this.txtEmpName);
            this.panel1.Controls.Add(this.lblGross);
            this.panel1.Controls.Add(this.lblBasic);
            this.panel1.Controls.Add(this.lblHouseRent);
            this.panel1.Controls.Add(this.lblMediAllow);
            this.panel1.Controls.Add(this.lblJoinedDate);
            this.panel1.Controls.Add(this.lblDepartment);
            this.panel1.Controls.Add(this.lblDesignation);
            this.panel1.Controls.Add(this.lblEmpName);
            this.panel1.Controls.Add(this.lblEmpId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 200);
            this.panel1.TabIndex = 0;
            // 
            // cboEmpStatus
            // 
            this.cboEmpStatus.FormattingEnabled = true;
            this.cboEmpStatus.Location = new System.Drawing.Point(745, 14);
            this.cboEmpStatus.Name = "cboEmpStatus";
            this.cboEmpStatus.Size = new System.Drawing.Size(159, 24);
            this.cboEmpStatus.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Emp Status";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(122, 97);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(159, 24);
            this.cboDepartment.TabIndex = 33;
            // 
            // cboDesignation
            // 
            this.cboDesignation.FormattingEnabled = true;
            this.cboDesignation.Location = new System.Drawing.Point(122, 70);
            this.cboDesignation.Name = "cboDesignation";
            this.cboDesignation.Size = new System.Drawing.Size(159, 24);
            this.cboDesignation.TabIndex = 32;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(120, 9);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(160, 22);
            this.txtEmpID.TabIndex = 31;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(724, 153);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 28);
            this.btnReport.TabIndex = 30;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(599, 153);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(467, 153);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(340, 153);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtJoineddate
            // 
            this.dtJoineddate.CustomFormat = "dd-MMM-yyyy";
            this.dtJoineddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtJoineddate.Location = new System.Drawing.Point(120, 126);
            this.dtJoineddate.Margin = new System.Windows.Forms.Padding(4);
            this.dtJoineddate.Name = "dtJoineddate";
            this.dtJoineddate.Size = new System.Drawing.Size(160, 22);
            this.dtJoineddate.TabIndex = 26;
            // 
            // txtMediAllow
            // 
            this.txtMediAllow.Location = new System.Drawing.Point(467, 93);
            this.txtMediAllow.Margin = new System.Windows.Forms.Padding(4);
            this.txtMediAllow.Name = "txtMediAllow";
            this.txtMediAllow.ReadOnly = true;
            this.txtMediAllow.Size = new System.Drawing.Size(160, 22);
            this.txtMediAllow.TabIndex = 18;
            // 
            // txtHouseRent
            // 
            this.txtHouseRent.Location = new System.Drawing.Point(467, 66);
            this.txtHouseRent.Margin = new System.Windows.Forms.Padding(4);
            this.txtHouseRent.Name = "txtHouseRent";
            this.txtHouseRent.ReadOnly = true;
            this.txtHouseRent.Size = new System.Drawing.Size(160, 22);
            this.txtHouseRent.TabIndex = 17;
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(467, 39);
            this.txtBasic.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.ReadOnly = true;
            this.txtBasic.Size = new System.Drawing.Size(160, 22);
            this.txtBasic.TabIndex = 16;
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(467, 12);
            this.txtGross.Margin = new System.Windows.Forms.Padding(4);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(160, 22);
            this.txtGross.TabIndex = 15;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(121, 41);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(160, 22);
            this.txtEmpName.TabIndex = 10;
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Location = new System.Drawing.Point(414, 16);
            this.lblGross.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(46, 17);
            this.lblGross.TabIndex = 9;
            this.lblGross.Text = "Gross";
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(415, 45);
            this.lblBasic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(42, 17);
            this.lblBasic.TabIndex = 8;
            this.lblBasic.Text = "Basic";
            // 
            // lblHouseRent
            // 
            this.lblHouseRent.AutoSize = true;
            this.lblHouseRent.Location = new System.Drawing.Point(374, 72);
            this.lblHouseRent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHouseRent.Name = "lblHouseRent";
            this.lblHouseRent.Size = new System.Drawing.Size(83, 17);
            this.lblHouseRent.TabIndex = 7;
            this.lblHouseRent.Text = "House Rent";
            // 
            // lblMediAllow
            // 
            this.lblMediAllow.AutoSize = true;
            this.lblMediAllow.Location = new System.Drawing.Point(331, 97);
            this.lblMediAllow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMediAllow.Name = "lblMediAllow";
            this.lblMediAllow.Size = new System.Drawing.Size(123, 17);
            this.lblMediAllow.TabIndex = 5;
            this.lblMediAllow.Text = "Medical Allowance";
            // 
            // lblJoinedDate
            // 
            this.lblJoinedDate.AutoSize = true;
            this.lblJoinedDate.Location = new System.Drawing.Point(29, 128);
            this.lblJoinedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoinedDate.Name = "lblJoinedDate";
            this.lblJoinedDate.Size = new System.Drawing.Size(84, 17);
            this.lblJoinedDate.TabIndex = 4;
            this.lblJoinedDate.Text = "Joined Date";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(29, 100);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(82, 17);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(29, 73);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(83, 17);
            this.lblDesignation.TabIndex = 2;
            this.lblDesignation.Text = "Designation";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(29, 44);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(77, 17);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Emp Name";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(29, 15);
            this.lblEmpId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(47, 17);
            this.lblEmpId.TabIndex = 0;
            this.lblEmpId.Text = "EmpId";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSalaryInc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 212);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 360);
            this.panel2.TabIndex = 1;
            // 
            // dgvSalaryInc
            // 
            this.dgvSalaryInc.AllowUserToAddRows = false;
            this.dgvSalaryInc.AllowUserToDeleteRows = false;
            this.dgvSalaryInc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryInc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnAction});
            this.dgvSalaryInc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalaryInc.Location = new System.Drawing.Point(0, 0);
            this.dgvSalaryInc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSalaryInc.Name = "dgvSalaryInc";
            this.dgvSalaryInc.ReadOnly = true;
            this.dgvSalaryInc.Size = new System.Drawing.Size(977, 360);
            this.dgvSalaryInc.TabIndex = 0;
            // 
            // btnAction
            // 
            this.btnAction.HeaderText = "Action";
            this.btnAction.Name = "btnAction";
            this.btnAction.ReadOnly = true;
            this.btnAction.Text = "Select";
            this.btnAction.UseColumnTextForLinkValue = true;
            // 
            // EmployeeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeEntry";
            this.Text = "EmployeeEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeEntry_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryInc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtJoineddate;
        private System.Windows.Forms.TextBox txtMediAllow;
        private System.Windows.Forms.TextBox txtHouseRent;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Label lblHouseRent;
        private System.Windows.Forms.Label lblMediAllow;
        private System.Windows.Forms.Label lblJoinedDate;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSalaryInc;
        private System.Windows.Forms.DataGridViewLinkColumn btnAction;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ComboBox cboDesignation;
        private System.Windows.Forms.ComboBox cboEmpStatus;
        private System.Windows.Forms.Label label1;
    }
}