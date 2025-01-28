namespace MAAQ_IMS.MasterEntry
{
    partial class Daily_Attendance
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
            this.dgvAtt = new System.Windows.Forms.DataGridView();
            this.dgvta = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbWP = new System.Windows.Forms.RadioButton();
            this.rdbHP = new System.Windows.Forms.RadioButton();
            this.rdbRP = new System.Windows.Forms.RadioButton();
            this.dtpAtt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvta)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1462, 685);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvAtt);
            this.panel4.Controls.Add(this.dgvta);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(227, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1231, 669);
            this.panel4.TabIndex = 2;
            // 
            // dgvAtt
            // 
            this.dgvAtt.AllowUserToAddRows = false;
            this.dgvAtt.AllowUserToDeleteRows = false;
            this.dgvAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtt.Location = new System.Drawing.Point(0, 0);
            this.dgvAtt.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAtt.Name = "dgvAtt";
            this.dgvAtt.ReadOnly = true;
            this.dgvAtt.Size = new System.Drawing.Size(1231, 669);
            this.dgvAtt.TabIndex = 1;
//            this.dgvAtt.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtt_CellEndEdit);
            // 
            // dgvta
            // 
            this.dgvta.AllowUserToAddRows = false;
            this.dgvta.AllowUserToDeleteRows = false;
            this.dgvta.AllowUserToResizeRows = false;
            this.dgvta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvta.Location = new System.Drawing.Point(0, 0);
            this.dgvta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvta.Name = "dgvta";
            this.dgvta.ReadOnly = true;
            this.dgvta.RowHeadersWidth = 20;
            this.dgvta.Size = new System.Drawing.Size(1231, 669);
            this.dgvta.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.rdbWP);
            this.panel3.Controls.Add(this.rdbHP);
            this.panel3.Controls.Add(this.rdbRP);
            this.panel3.Controls.Add(this.dtpAtt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 669);
            this.panel3.TabIndex = 2;
            // 
            // rdbWP
            // 
            this.rdbWP.AutoSize = true;
            this.rdbWP.Location = new System.Drawing.Point(12, 93);
            this.rdbWP.Name = "rdbWP";
            this.rdbWP.Size = new System.Drawing.Size(144, 21);
            this.rdbWP.TabIndex = 20;
            this.rdbWP.Text = "Weekend Process";
            this.rdbWP.UseVisualStyleBackColor = true;
            // 
            // rdbHP
            // 
            this.rdbHP.AutoSize = true;
            this.rdbHP.Location = new System.Drawing.Point(12, 66);
            this.rdbHP.Name = "rdbHP";
            this.rdbHP.Size = new System.Drawing.Size(131, 21);
            this.rdbHP.TabIndex = 19;
            this.rdbHP.Text = "Holiday Process";
            this.rdbHP.UseVisualStyleBackColor = true;
            // 
            // rdbRP
            // 
            this.rdbRP.AutoSize = true;
            this.rdbRP.Checked = true;
            this.rdbRP.Location = new System.Drawing.Point(12, 39);
            this.rdbRP.Name = "rdbRP";
            this.rdbRP.Size = new System.Drawing.Size(134, 21);
            this.rdbRP.TabIndex = 18;
            this.rdbRP.TabStop = true;
            this.rdbRP.Text = "Regular Process";
            this.rdbRP.UseVisualStyleBackColor = true;
            // 
            // dtpAtt
            // 
            this.dtpAtt.CustomFormat = "dd-MMM-yyyy";
            this.dtpAtt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAtt.Location = new System.Drawing.Point(76, 135);
            this.dtpAtt.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAtt.Name = "dtpAtt";
            this.dtpAtt.Size = new System.Drawing.Size(117, 22);
            this.dtpAtt.TabIndex = 17;
            this.dtpAtt.ValueChanged += new System.EventHandler(this.dtpAtt_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Att-Date";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::MAAQ_IMS.Properties.Resources.save_2;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(92, 178);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 28);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Process";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Daily_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 685);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Daily_Attendance";
            this.Text = "Data Process";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Daily_Attendance_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvta)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAtt;
        private System.Windows.Forms.DataGridView dgvAtt;
        private System.Windows.Forms.RadioButton rdbWP;
        private System.Windows.Forms.RadioButton rdbHP;
        private System.Windows.Forms.RadioButton rdbRP;
    }
}