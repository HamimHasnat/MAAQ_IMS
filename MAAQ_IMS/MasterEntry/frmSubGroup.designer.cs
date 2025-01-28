namespace MAAQ_IMS.MasterEntry
{
    partial class frmSubGroup
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGridSelect = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CboGroup = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSubGroupShortCode = new System.Windows.Forms.TextBox();
            this.txtSubGroupName = new System.Windows.Forms.TextBox();
            this.txtSubGroupID = new System.Windows.Forms.TextBox();
            this.lblGroupID = new System.Windows.Forms.Label();
            this.lblSubGroupShortCode = new System.Windows.Forms.Label();
            this.lblSubGroupName = new System.Windows.Forms.Label();
            this.lblSubGroupID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHead = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 306F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 346F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1039, 439);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(309, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(727, 341);
            this.panel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnGridSelect});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(727, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnGridSelect
            // 
            this.btnGridSelect.HeaderText = "Action";
            this.btnGridSelect.Name = "btnGridSelect";
            this.btnGridSelect.ReadOnly = true;
            this.btnGridSelect.Text = "Select";
            this.btnGridSelect.UseColumnTextForLinkValue = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CboGroup);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.txtSubGroupShortCode);
            this.panel3.Controls.Add(this.txtSubGroupName);
            this.panel3.Controls.Add(this.txtSubGroupID);
            this.panel3.Controls.Add(this.lblGroupID);
            this.panel3.Controls.Add(this.lblSubGroupShortCode);
            this.panel3.Controls.Add(this.lblSubGroupName);
            this.panel3.Controls.Add(this.lblSubGroupID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 341);
            this.panel3.TabIndex = 2;
            // 
            // CboGroup
            // 
            this.CboGroup.DropDownWidth = 250;
            this.CboGroup.FormattingEnabled = true;
            this.CboGroup.Location = new System.Drawing.Point(156, 36);
            this.CboGroup.Name = "CboGroup";
            this.CboGroup.Size = new System.Drawing.Size(121, 21);
            this.CboGroup.TabIndex = 13;
            this.CboGroup.SelectedIndexChanged += new System.EventHandler(this.CboGroup_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::MAAQ_IMS.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(204, 107);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::MAAQ_IMS.Properties.Resources.save_2;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(137, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSubGroupShortCode
            // 
            this.txtSubGroupShortCode.Location = new System.Drawing.Point(156, 78);
            this.txtSubGroupShortCode.Name = "txtSubGroupShortCode";
            this.txtSubGroupShortCode.Size = new System.Drawing.Size(121, 20);
            this.txtSubGroupShortCode.TabIndex = 8;
            // 
            // txtSubGroupName
            // 
            this.txtSubGroupName.Location = new System.Drawing.Point(156, 58);
            this.txtSubGroupName.Name = "txtSubGroupName";
            this.txtSubGroupName.Size = new System.Drawing.Size(121, 20);
            this.txtSubGroupName.TabIndex = 7;
            // 
            // txtSubGroupID
            // 
            this.txtSubGroupID.Location = new System.Drawing.Point(156, 13);
            this.txtSubGroupID.Name = "txtSubGroupID";
            this.txtSubGroupID.ReadOnly = true;
            this.txtSubGroupID.Size = new System.Drawing.Size(121, 20);
            this.txtSubGroupID.TabIndex = 6;
            // 
            // lblGroupID
            // 
            this.lblGroupID.AutoSize = true;
            this.lblGroupID.Location = new System.Drawing.Point(33, 36);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(39, 13);
            this.lblGroupID.TabIndex = 5;
            this.lblGroupID.Text = "Group ";
            // 
            // lblSubGroupShortCode
            // 
            this.lblSubGroupShortCode.AutoSize = true;
            this.lblSubGroupShortCode.Location = new System.Drawing.Point(32, 83);
            this.lblSubGroupShortCode.Name = "lblSubGroupShortCode";
            this.lblSubGroupShortCode.Size = new System.Drawing.Size(114, 13);
            this.lblSubGroupShortCode.TabIndex = 4;
            this.lblSubGroupShortCode.Text = "Sub Group Short Code";
            // 
            // lblSubGroupName
            // 
            this.lblSubGroupName.AutoSize = true;
            this.lblSubGroupName.Location = new System.Drawing.Point(32, 59);
            this.lblSubGroupName.Name = "lblSubGroupName";
            this.lblSubGroupName.Size = new System.Drawing.Size(89, 13);
            this.lblSubGroupName.TabIndex = 3;
            this.lblSubGroupName.Text = "Sub Group Name";
            // 
            // lblSubGroupID
            // 
            this.lblSubGroupID.AutoSize = true;
            this.lblSubGroupID.Location = new System.Drawing.Point(32, 17);
            this.lblSubGroupID.Name = "lblSubGroupID";
            this.lblSubGroupID.Size = new System.Drawing.Size(72, 13);
            this.lblSubGroupID.TabIndex = 2;
            this.lblSubGroupID.Text = "Sub Group ID";
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 39);
            this.panel2.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(860, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(920, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.lblHead);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 41);
            this.panel1.TabIndex = 0;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(335, 4);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(204, 31);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Item Sub Group";
            // 
            // frmSubGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSubGroup";
            this.Text = "frmSubGroup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSubGroup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSubGroupShortCode;
        private System.Windows.Forms.TextBox txtSubGroupName;
        private System.Windows.Forms.TextBox txtSubGroupID;
        private System.Windows.Forms.Label lblGroupID;
        private System.Windows.Forms.Label lblSubGroupShortCode;
        private System.Windows.Forms.Label lblSubGroupName;
        private System.Windows.Forms.Label lblSubGroupID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox CboGroup;
        private System.Windows.Forms.DataGridViewLinkColumn btnGridSelect;
    }
}