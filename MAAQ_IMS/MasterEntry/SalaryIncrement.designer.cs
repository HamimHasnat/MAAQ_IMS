namespace MAAQ_IMS.MasterEntry
{
    partial class SalaryIncrement
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
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtJoineddate = new System.Windows.Forms.DateTimePicker();
            this.dtIncDate = new System.Windows.Forms.DateTimePicker();
            this.txtIncAmount = new System.Windows.Forms.TextBox();
            this.txtIncPercent = new System.Windows.Forms.TextBox();
            this.cboIncType = new System.Windows.Forms.ComboBox();
            this.lblIncAmt = new System.Windows.Forms.Label();
            this.lblIncPercent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMediAllow = new System.Windows.Forms.TextBox();
            this.txtHouseRent = new System.Windows.Forms.TextBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.cboEmpID = new System.Windows.Forms.ComboBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblBasic = new System.Windows.Forms.Label();
            this.lblHouseRent = new System.Windows.Forms.Label();
            this.lblIncType = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dtJoineddate);
            this.panel1.Controls.Add(this.dtIncDate);
            this.panel1.Controls.Add(this.txtIncAmount);
            this.panel1.Controls.Add(this.txtIncPercent);
            this.panel1.Controls.Add(this.cboIncType);
            this.panel1.Controls.Add(this.lblIncAmt);
            this.panel1.Controls.Add(this.lblIncPercent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMediAllow);
            this.panel1.Controls.Add(this.txtHouseRent);
            this.panel1.Controls.Add(this.txtBasic);
            this.panel1.Controls.Add(this.txtGross);
            this.panel1.Controls.Add(this.txtDesignation);
            this.panel1.Controls.Add(this.txtDepartment);
            this.panel1.Controls.Add(this.cboEmpID);
            this.panel1.Controls.Add(this.txtEmpName);
            this.panel1.Controls.Add(this.lblGross);
            this.panel1.Controls.Add(this.lblBasic);
            this.panel1.Controls.Add(this.lblHouseRent);
            this.panel1.Controls.Add(this.lblIncType);
            this.panel1.Controls.Add(this.lblMediAllow);
            this.panel1.Controls.Add(this.lblJoinedDate);
            this.panel1.Controls.Add(this.lblDepartment);
            this.panel1.Controls.Add(this.lblDesignation);
            this.panel1.Controls.Add(this.lblEmpName);
            this.panel1.Controls.Add(this.lblEmpId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 192);
            this.panel1.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(724, 153);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 28);
            this.btnReport.TabIndex = 30;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(599, 153);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(467, 153);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dtJoineddate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtJoineddate.Name = "dtJoineddate";
            this.dtJoineddate.Size = new System.Drawing.Size(160, 22);
            this.dtJoineddate.TabIndex = 26;
            // 
            // dtIncDate
            // 
            this.dtIncDate.CustomFormat = "dd-MMM-yyyy";
            this.dtIncDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIncDate.Location = new System.Drawing.Point(741, 53);
            this.dtIncDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtIncDate.Name = "dtIncDate";
            this.dtIncDate.Size = new System.Drawing.Size(160, 22);
            this.dtIncDate.TabIndex = 25;
            // 
            // txtIncAmount
            // 
            this.txtIncAmount.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtIncAmount.Location = new System.Drawing.Point(741, 108);
            this.txtIncAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIncAmount.Name = "txtIncAmount";
            this.txtIncAmount.Size = new System.Drawing.Size(160, 22);
            this.txtIncAmount.TabIndex = 24;
            this.txtIncAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIncAmount_KeyPress);
            // 
            // txtIncPercent
            // 
            this.txtIncPercent.BackColor = System.Drawing.Color.Bisque;
            this.txtIncPercent.Location = new System.Drawing.Point(741, 80);
            this.txtIncPercent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIncPercent.Name = "txtIncPercent";
            this.txtIncPercent.Size = new System.Drawing.Size(160, 22);
            this.txtIncPercent.TabIndex = 23;
            this.txtIncPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIncPercent_KeyPress);
            this.txtIncPercent.Leave += new System.EventHandler(this.txtIncPercent_Leave);
            // 
            // cboIncType
            // 
            this.cboIncType.FormattingEnabled = true;
            this.cboIncType.Location = new System.Drawing.Point(741, 22);
            this.cboIncType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboIncType.Name = "cboIncType";
            this.cboIncType.Size = new System.Drawing.Size(160, 24);
            this.cboIncType.TabIndex = 22;
            // 
            // lblIncAmt
            // 
            this.lblIncAmt.AutoSize = true;
            this.lblIncAmt.Location = new System.Drawing.Point(635, 112);
            this.lblIncAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncAmt.Name = "lblIncAmt";
            this.lblIncAmt.Size = new System.Drawing.Size(78, 17);
            this.lblIncAmt.TabIndex = 21;
            this.lblIncAmt.Text = "Inc Amount";
            // 
            // lblIncPercent
            // 
            this.lblIncPercent.AutoSize = true;
            this.lblIncPercent.Location = new System.Drawing.Point(635, 80);
            this.lblIncPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncPercent.Name = "lblIncPercent";
            this.lblIncPercent.Size = new System.Drawing.Size(79, 17);
            this.lblIncPercent.TabIndex = 20;
            this.lblIncPercent.Text = "Inc Percent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inc Date";
            // 
            // txtMediAllow
            // 
            this.txtMediAllow.Location = new System.Drawing.Point(441, 103);
            this.txtMediAllow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMediAllow.Name = "txtMediAllow";
            this.txtMediAllow.ReadOnly = true;
            this.txtMediAllow.Size = new System.Drawing.Size(160, 22);
            this.txtMediAllow.TabIndex = 18;
            // 
            // txtHouseRent
            // 
            this.txtHouseRent.Location = new System.Drawing.Point(441, 76);
            this.txtHouseRent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHouseRent.Name = "txtHouseRent";
            this.txtHouseRent.ReadOnly = true;
            this.txtHouseRent.Size = new System.Drawing.Size(160, 22);
            this.txtHouseRent.TabIndex = 17;
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(441, 49);
            this.txtBasic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.ReadOnly = true;
            this.txtBasic.Size = new System.Drawing.Size(160, 22);
            this.txtBasic.TabIndex = 16;
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(441, 22);
            this.txtGross.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(160, 22);
            this.txtGross.TabIndex = 15;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(121, 68);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(160, 22);
            this.txtDesignation.TabIndex = 14;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(120, 96);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(160, 22);
            this.txtDepartment.TabIndex = 12;
            // 
            // cboEmpID
            // 
            this.cboEmpID.FormattingEnabled = true;
            this.cboEmpID.Location = new System.Drawing.Point(121, 12);
            this.cboEmpID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEmpID.Name = "cboEmpID";
            this.cboEmpID.Size = new System.Drawing.Size(160, 24);
            this.cboEmpID.TabIndex = 11;
            this.cboEmpID.SelectedIndexChanged += new System.EventHandler(this.cboEmpID_SelectedIndexChanged);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(121, 41);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(160, 22);
            this.txtEmpName.TabIndex = 10;
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Location = new System.Drawing.Point(388, 26);
            this.lblGross.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(46, 17);
            this.lblGross.TabIndex = 9;
            this.lblGross.Text = "Gross";
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(389, 55);
            this.lblBasic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(42, 17);
            this.lblBasic.TabIndex = 8;
            this.lblBasic.Text = "Basic";
            // 
            // lblHouseRent
            // 
            this.lblHouseRent.AutoSize = true;
            this.lblHouseRent.Location = new System.Drawing.Point(348, 82);
            this.lblHouseRent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHouseRent.Name = "lblHouseRent";
            this.lblHouseRent.Size = new System.Drawing.Size(83, 17);
            this.lblHouseRent.TabIndex = 7;
            this.lblHouseRent.Text = "House Rent";
            // 
            // lblIncType
            // 
            this.lblIncType.AutoSize = true;
            this.lblIncType.Location = new System.Drawing.Point(635, 26);
            this.lblIncType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncType.Name = "lblIncType";
            this.lblIncType.Size = new System.Drawing.Size(66, 17);
            this.lblIncType.TabIndex = 6;
            this.lblIncType.Text = "Inc. Type";
            // 
            // lblMediAllow
            // 
            this.lblMediAllow.AutoSize = true;
            this.lblMediAllow.Location = new System.Drawing.Point(305, 107);
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
            this.panel2.Location = new System.Drawing.Point(4, 204);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 346);
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
            this.dgvSalaryInc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSalaryInc.Name = "dgvSalaryInc";
            this.dgvSalaryInc.ReadOnly = true;
            this.dgvSalaryInc.Size = new System.Drawing.Size(1059, 346);
            this.dgvSalaryInc.TabIndex = 0;
            this.dgvSalaryInc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryInc_CellContentClick);
            // 
            // btnAction
            // 
            this.btnAction.HeaderText = "Action";
            this.btnAction.Name = "btnAction";
            this.btnAction.ReadOnly = true;
            this.btnAction.Text = "Select";
            this.btnAction.UseColumnTextForLinkValue = true;
            // 
            // SalaryIncrement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SalaryIncrement";
            this.Text = "SalaryIncrement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalaryIncrement_Load);
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
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Label lblHouseRent;
        private System.Windows.Forms.Label lblIncType;
        private System.Windows.Forms.Label lblMediAllow;
        private System.Windows.Forms.Label lblJoinedDate;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboEmpID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblIncAmt;
        private System.Windows.Forms.Label lblIncPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMediAllow;
        private System.Windows.Forms.TextBox txtHouseRent;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.DateTimePicker dtJoineddate;
        private System.Windows.Forms.DateTimePicker dtIncDate;
        private System.Windows.Forms.TextBox txtIncAmount;
        private System.Windows.Forms.TextBox txtIncPercent;
        private System.Windows.Forms.ComboBox cboIncType;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvSalaryInc;
        private System.Windows.Forms.DataGridViewLinkColumn btnAction;
    }
}