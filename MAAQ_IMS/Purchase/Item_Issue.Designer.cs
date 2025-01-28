namespace MAAQ_IMS.Purchase
{
    partial class Item_Issue
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
            this.cboIssueID = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIssueID = new System.Windows.Forms.TextBox();
            this.lblMPO = new System.Windows.Forms.Label();
            this.chcModifyIssue = new System.Windows.Forms.CheckBox();
            this.cboSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnApproveToProcced = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboItemCatagory = new System.Windows.Forms.ComboBox();
            this.lblItemCatagory = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.cboSubgroup = new System.Windows.Forms.ComboBox();
            this.lblSubGroup = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblrow = new System.Windows.Forms.Label();
            this.lbltotalrows = new System.Windows.Forms.Label();
            this.lblIssuePrice = new System.Windows.Forms.Label();
            this.lblIssueQty = new System.Windows.Forms.Label();
            this.lblTotalvalue = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvIssuedetails = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvmasterIssue = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedetails)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmasterIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 535);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboIssueID);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIssueID);
            this.panel1.Controls.Add(this.lblMPO);
            this.panel1.Controls.Add(this.chcModifyIssue);
            this.panel1.Controls.Add(this.cboSection);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.cboDepartment);
            this.panel1.Controls.Add(this.lblDepartment);
            this.panel1.Controls.Add(this.dtpIssueDate);
            this.panel1.Controls.Add(this.lblIssueDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(223, 527);
            this.panel1.TabIndex = 0;
            // 
            // cboIssueID
            // 
            this.cboIssueID.FormattingEnabled = true;
            this.cboIssueID.Location = new System.Drawing.Point(86, 202);
            this.cboIssueID.Name = "cboIssueID";
            this.cboIssueID.Size = new System.Drawing.Size(121, 21);
            this.cboIssueID.TabIndex = 22;
            this.cboIssueID.Visible = false;
            this.cboIssueID.SelectedIndexChanged += new System.EventHandler(this.cboIssueID_SelectedIndexChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(86, 132);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(120, 54);
            this.txtRemarks.TabIndex = 1;
            this.txtRemarks.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Remarks";
            // 
            // txtIssueID
            // 
            this.txtIssueID.BackColor = System.Drawing.Color.Bisque;
            this.txtIssueID.Location = new System.Drawing.Point(86, 41);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.Size = new System.Drawing.Size(120, 20);
            this.txtIssueID.TabIndex = 18;
            // 
            // lblMPO
            // 
            this.lblMPO.AutoSize = true;
            this.lblMPO.Location = new System.Drawing.Point(16, 49);
            this.lblMPO.Name = "lblMPO";
            this.lblMPO.Size = new System.Drawing.Size(46, 13);
            this.lblMPO.TabIndex = 17;
            this.lblMPO.Text = "Issue ID";
            // 
            // chcModifyIssue
            // 
            this.chcModifyIssue.AutoSize = true;
            this.chcModifyIssue.Location = new System.Drawing.Point(114, 6);
            this.chcModifyIssue.Name = "chcModifyIssue";
            this.chcModifyIssue.Size = new System.Drawing.Size(85, 17);
            this.chcModifyIssue.TabIndex = 14;
            this.chcModifyIssue.Text = "Modify Issue";
            this.chcModifyIssue.UseVisualStyleBackColor = true;
//            this.chcModifyIssue.CheckedChanged += new System.EventHandler(this.chcModifyIssue_CheckedChanged);
            // 
            // cboSection
            // 
            this.cboSection.FormattingEnabled = true;
            this.cboSection.Location = new System.Drawing.Point(86, 107);
            this.cboSection.Name = "cboSection";
            this.cboSection.Size = new System.Drawing.Size(120, 21);
            this.cboSection.TabIndex = 13;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(16, 107);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(43, 13);
            this.lblSection.TabIndex = 11;
            this.lblSection.Text = "Section";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(86, 85);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(120, 21);
            this.cboDepartment.TabIndex = 10;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(16, 88);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Department";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(86, 64);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(102, 20);
            this.dtpIssueDate.TabIndex = 5;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(16, 68);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(58, 13);
            this.lblIssueDate.TabIndex = 2;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnApproveToProcced);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.cboItemCatagory);
            this.panel2.Controls.Add(this.lblItemCatagory);
            this.panel2.Controls.Add(this.btnIssue);
            this.panel2.Controls.Add(this.cboSubgroup);
            this.panel2.Controls.Add(this.lblSubGroup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(234, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 178);
            this.panel2.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.Location = new System.Drawing.Point(8, 127);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApproveToProcced
            // 
            this.btnApproveToProcced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnApproveToProcced.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproveToProcced.Location = new System.Drawing.Point(96, 150);
            this.btnApproveToProcced.Name = "btnApproveToProcced";
            this.btnApproveToProcced.Size = new System.Drawing.Size(97, 23);
            this.btnApproveToProcced.TabIndex = 13;
            this.btnApproveToProcced.Text = "Procced To Approve";
            this.btnApproveToProcced.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApproveToProcced.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Image = global::MAAQ_IMS.Properties.Resources.save_2;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(8, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Bisque;
            this.txtSearch.Location = new System.Drawing.Point(83, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(106, 20);
            this.txtSearch.TabIndex = 11;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(7, 56);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search";
            // 
            // cboItemCatagory
            // 
            this.cboItemCatagory.DropDownWidth = 205;
            this.cboItemCatagory.FormattingEnabled = true;
            this.cboItemCatagory.Location = new System.Drawing.Point(83, 27);
            this.cboItemCatagory.Name = "cboItemCatagory";
            this.cboItemCatagory.Size = new System.Drawing.Size(106, 21);
            this.cboItemCatagory.TabIndex = 8;
            this.cboItemCatagory.SelectedIndexChanged += new System.EventHandler(this.cboItemCatagory_SelectedIndexChanged);
            // 
            // lblItemCatagory
            // 
            this.lblItemCatagory.AutoSize = true;
            this.lblItemCatagory.Location = new System.Drawing.Point(7, 32);
            this.lblItemCatagory.Name = "lblItemCatagory";
            this.lblItemCatagory.Size = new System.Drawing.Size(72, 13);
            this.lblItemCatagory.TabIndex = 6;
            this.lblItemCatagory.Text = "Item Catagory";
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(96, 120);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(97, 23);
            this.btnIssue.TabIndex = 5;
            this.btnIssue.Text = "Add to Issue";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // cboSubgroup
            // 
            this.cboSubgroup.DropDownWidth = 250;
            this.cboSubgroup.FormattingEnabled = true;
            this.cboSubgroup.Location = new System.Drawing.Point(83, 5);
            this.cboSubgroup.Name = "cboSubgroup";
            this.cboSubgroup.Size = new System.Drawing.Size(106, 21);
            this.cboSubgroup.TabIndex = 1;
            this.cboSubgroup.SelectedIndexChanged += new System.EventHandler(this.cboSubgroup_SelectedIndexChanged);
            // 
            // lblSubGroup
            // 
            this.lblSubGroup.AutoSize = true;
            this.lblSubGroup.Location = new System.Drawing.Point(7, 9);
            this.lblSubGroup.Name = "lblSubGroup";
            this.lblSubGroup.Size = new System.Drawing.Size(58, 13);
            this.lblSubGroup.TabIndex = 0;
            this.lblSubGroup.Text = "Sub Group";
            // 
            // panel4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.lblrow);
            this.panel4.Controls.Add(this.lbltotalrows);
            this.panel4.Controls.Add(this.lblIssuePrice);
            this.panel4.Controls.Add(this.lblIssueQty);
            this.panel4.Controls.Add(this.lblTotalvalue);
            this.panel4.Controls.Add(this.lblTotalQty);
            this.panel4.Controls.Add(this.btnReport);
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(234, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 34);
            this.panel4.TabIndex = 3;
            // 
            // lblrow
            // 
            this.lblrow.AutoSize = true;
            this.lblrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblrow.Location = new System.Drawing.Point(509, 11);
            this.lblrow.Name = "lblrow";
            this.lblrow.Size = new System.Drawing.Size(21, 15);
            this.lblrow.TabIndex = 9;
            this.lblrow.Text = "00";
            // 
            // lbltotalrows
            // 
            this.lbltotalrows.AutoSize = true;
            this.lbltotalrows.Location = new System.Drawing.Point(445, 11);
            this.lbltotalrows.Name = "lbltotalrows";
            this.lbltotalrows.Size = new System.Drawing.Size(67, 13);
            this.lbltotalrows.TabIndex = 8;
            this.lbltotalrows.Text = "Total Rows :";
            // 
            // lblIssuePrice
            // 
            this.lblIssuePrice.AutoSize = true;
            this.lblIssuePrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIssuePrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIssuePrice.Location = new System.Drawing.Point(394, 18);
            this.lblIssuePrice.Name = "lblIssuePrice";
            this.lblIssuePrice.Size = new System.Drawing.Size(21, 15);
            this.lblIssuePrice.TabIndex = 7;
            this.lblIssuePrice.Text = "00";
            // 
            // lblIssueQty
            // 
            this.lblIssueQty.AutoSize = true;
            this.lblIssueQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIssueQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueQty.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIssueQty.Location = new System.Drawing.Point(394, 5);
            this.lblIssueQty.Name = "lblIssueQty";
            this.lblIssueQty.Size = new System.Drawing.Size(21, 15);
            this.lblIssueQty.TabIndex = 6;
            this.lblIssueQty.Text = "00";
            // 
            // lblTotalvalue
            // 
            this.lblTotalvalue.AutoSize = true;
            this.lblTotalvalue.Location = new System.Drawing.Point(297, 18);
            this.lblTotalvalue.Name = "lblTotalvalue";
            this.lblTotalvalue.Size = new System.Drawing.Size(92, 13);
            this.lblTotalvalue.TabIndex = 5;
            this.lblTotalvalue.Text = "Total Issue Price :";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Location = new System.Drawing.Point(318, 4);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(53, 13);
            this.lblTotalQty.TabIndex = 4;
            this.lblTotalQty.Text = "Total Qty:";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(206, 6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(61, 23);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(74, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Row";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.dgvIssuedetails);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(234, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(730, 301);
            this.panel5.TabIndex = 4;
            // 
            // dgvIssuedetails
            // 
            this.dgvIssuedetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuedetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssuedetails.Location = new System.Drawing.Point(0, 0);
            this.dgvIssuedetails.Name = "dgvIssuedetails";
            this.dgvIssuedetails.Size = new System.Drawing.Size(730, 301);
            this.dgvIssuedetails.TabIndex = 0;
            this.dgvIssuedetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssuedetails_CellEndEdit);
            this.dgvIssuedetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvIssuedetails_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvmasterIssue);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(446, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 178);
            this.panel3.TabIndex = 2;
            // 
            // dgvmasterIssue
            // 
            this.dgvmasterIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmasterIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmasterIssue.Location = new System.Drawing.Point(0, 0);
            this.dgvmasterIssue.Name = "dgvmasterIssue";
            this.dgvmasterIssue.Size = new System.Drawing.Size(518, 178);
            this.dgvmasterIssue.TabIndex = 0;
            // 
            // Item_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 535);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Item_Issue";
            this.Text = "Item_Issue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Item_Issue_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedetails)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmasterIssue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIssueID;
        private System.Windows.Forms.Label lblMPO;
        private System.Windows.Forms.CheckBox chcModifyIssue;
        private System.Windows.Forms.ComboBox cboSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnApproveToProcced;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cboItemCatagory;
        private System.Windows.Forms.Label lblItemCatagory;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.ComboBox cboSubgroup;
        private System.Windows.Forms.Label lblSubGroup;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblrow;
        private System.Windows.Forms.Label lbltotalrows;
        private System.Windows.Forms.Label lblIssuePrice;
        private System.Windows.Forms.Label lblIssueQty;
        private System.Windows.Forms.Label lblTotalvalue;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvIssuedetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvmasterIssue;
        private System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboIssueID;
    }
}