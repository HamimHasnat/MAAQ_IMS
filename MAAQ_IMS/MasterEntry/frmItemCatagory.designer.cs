namespace MAAQ_IMS.MasterEntry
{
    partial class frmItemCatagory
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvItemCatagory = new System.Windows.Forms.DataGridView();
            this.btnGridSelect = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.CboSubGroup = new System.Windows.Forms.ComboBox();
            this.CboGroup = new System.Windows.Forms.ComboBox();
            this.txtCatagoryShortCode = new System.Windows.Forms.TextBox();
            this.txtCatagoryName = new System.Windows.Forms.TextBox();
            this.txtCatagoryID = new System.Windows.Forms.TextBox();
            this.lblSubGroup = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblCatagoryShortCode = new System.Windows.Forms.Label();
            this.lblCatagoryName = new System.Windows.Forms.Label();
            this.lblCatagoryID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemCatagory)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1046, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvItemCatagory);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(290, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(753, 354);
            this.panel4.TabIndex = 2;
            // 
            // dgvItemCatagory
            // 
            this.dgvItemCatagory.AllowUserToAddRows = false;
            this.dgvItemCatagory.AllowUserToDeleteRows = false;
            this.dgvItemCatagory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemCatagory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemCatagory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnGridSelect});
            this.dgvItemCatagory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemCatagory.Location = new System.Drawing.Point(0, 0);
            this.dgvItemCatagory.Name = "dgvItemCatagory";
            this.dgvItemCatagory.ReadOnly = true;
            this.dgvItemCatagory.RowHeadersWidth = 20;
            this.dgvItemCatagory.Size = new System.Drawing.Size(753, 354);
            this.dgvItemCatagory.TabIndex = 0;
            this.dgvItemCatagory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ddlItemCatagory_CellClick);
            // 
            // btnGridSelect
            // 
            this.btnGridSelect.HeaderText = "Action";
            this.btnGridSelect.Name = "btnGridSelect";
            this.btnGridSelect.ReadOnly = true;
            this.btnGridSelect.Text = "Select";
            this.btnGridSelect.UseColumnTextForLinkValue = true;
            this.btnGridSelect.Width = 43;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.CboSubGroup);
            this.panel3.Controls.Add(this.CboGroup);
            this.panel3.Controls.Add(this.txtCatagoryShortCode);
            this.panel3.Controls.Add(this.txtCatagoryName);
            this.panel3.Controls.Add(this.txtCatagoryID);
            this.panel3.Controls.Add(this.lblSubGroup);
            this.panel3.Controls.Add(this.lblGroup);
            this.panel3.Controls.Add(this.lblCatagoryShortCode);
            this.panel3.Controls.Add(this.lblCatagoryName);
            this.panel3.Controls.Add(this.lblCatagoryID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 354);
            this.panel3.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::MAAQ_IMS.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(193, 156);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::MAAQ_IMS.Properties.Resources.save_2;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(121, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CboSubGroup
            // 
            this.CboSubGroup.DropDownWidth = 250;
            this.CboSubGroup.FormattingEnabled = true;
            this.CboSubGroup.Location = new System.Drawing.Point(121, 77);
            this.CboSubGroup.Name = "CboSubGroup";
            this.CboSubGroup.Size = new System.Drawing.Size(147, 21);
            this.CboSubGroup.TabIndex = 13;
            this.CboSubGroup.SelectedIndexChanged += new System.EventHandler(this.CboSubGroup_SelectedIndexChanged);
            // 
            // CboGroup
            // 
            this.CboGroup.DropDownWidth = 250;
            this.CboGroup.FormattingEnabled = true;
            this.CboGroup.Location = new System.Drawing.Point(121, 50);
            this.CboGroup.Name = "CboGroup";
            this.CboGroup.Size = new System.Drawing.Size(147, 21);
            this.CboGroup.TabIndex = 12;
            this.CboGroup.SelectedIndexChanged += new System.EventHandler(this.CboGroup_SelectedIndexChanged);
            // 
            // txtCatagoryShortCode
            // 
            this.txtCatagoryShortCode.Location = new System.Drawing.Point(121, 130);
            this.txtCatagoryShortCode.Name = "txtCatagoryShortCode";
            this.txtCatagoryShortCode.Size = new System.Drawing.Size(145, 20);
            this.txtCatagoryShortCode.TabIndex = 9;
            // 
            // txtCatagoryName
            // 
            this.txtCatagoryName.Location = new System.Drawing.Point(121, 104);
            this.txtCatagoryName.Name = "txtCatagoryName";
            this.txtCatagoryName.Size = new System.Drawing.Size(146, 20);
            this.txtCatagoryName.TabIndex = 8;
            // 
            // txtCatagoryID
            // 
            this.txtCatagoryID.Location = new System.Drawing.Point(121, 23);
            this.txtCatagoryID.Name = "txtCatagoryID";
            this.txtCatagoryID.ReadOnly = true;
            this.txtCatagoryID.Size = new System.Drawing.Size(146, 20);
            this.txtCatagoryID.TabIndex = 7;
            // 
            // lblSubGroup
            // 
            this.lblSubGroup.AutoSize = true;
            this.lblSubGroup.Location = new System.Drawing.Point(17, 76);
            this.lblSubGroup.Name = "lblSubGroup";
            this.lblSubGroup.Size = new System.Drawing.Size(61, 13);
            this.lblSubGroup.TabIndex = 6;
            this.lblSubGroup.Text = "Sub Group ";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(17, 50);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 5;
            this.lblGroup.Text = "Group";
            // 
            // lblCatagoryShortCode
            // 
            this.lblCatagoryShortCode.AutoSize = true;
            this.lblCatagoryShortCode.Location = new System.Drawing.Point(17, 129);
            this.lblCatagoryShortCode.Name = "lblCatagoryShortCode";
            this.lblCatagoryShortCode.Size = new System.Drawing.Size(105, 13);
            this.lblCatagoryShortCode.TabIndex = 4;
            this.lblCatagoryShortCode.Text = "Catagory Short Code";
            // 
            // lblCatagoryName
            // 
            this.lblCatagoryName.AutoSize = true;
            this.lblCatagoryName.Location = new System.Drawing.Point(17, 107);
            this.lblCatagoryName.Name = "lblCatagoryName";
            this.lblCatagoryName.Size = new System.Drawing.Size(80, 13);
            this.lblCatagoryName.TabIndex = 3;
            this.lblCatagoryName.Text = "Catagory Name";
            // 
            // lblCatagoryID
            // 
            this.lblCatagoryID.AutoSize = true;
            this.lblCatagoryID.Location = new System.Drawing.Point(17, 23);
            this.lblCatagoryID.Name = "lblCatagoryID";
            this.lblCatagoryID.Size = new System.Drawing.Size(60, 13);
            this.lblCatagoryID.TabIndex = 2;
            this.lblCatagoryID.Text = "CatagoryID";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(1040, 81);
            this.panel1.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(625, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(668, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Item Catagory";
            // 
            // frmItemCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmItemCatagory";
            this.Text = "frmItemCatagory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmItemCatagory_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemCatagory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblCatagoryShortCode;
        private System.Windows.Forms.Label lblCatagoryName;
        private System.Windows.Forms.Label lblCatagoryID;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItemCatagory;
        private System.Windows.Forms.TextBox txtCatagoryShortCode;
        private System.Windows.Forms.TextBox txtCatagoryName;
        private System.Windows.Forms.TextBox txtCatagoryID;
        private System.Windows.Forms.Label lblSubGroup;
        private System.Windows.Forms.DataGridViewLinkColumn btnGridSelect;
        private System.Windows.Forms.ComboBox CboSubGroup;
        private System.Windows.Forms.ComboBox CboGroup;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
    }
}