namespace MAAQ_IMS.MasterEntry
{
    partial class New_Item_Entry
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtMaxLabelQty = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblMaxLabelQty = new System.Windows.Forms.Label();
            this.txtMinlabelQty = new System.Windows.Forms.TextBox();
            this.txtShadeNo = new System.Windows.Forms.TextBox();
            this.lblMinLabelqty = new System.Windows.Forms.Label();
            this.lblShadeNo = new System.Windows.Forms.Label();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.CboExpCatagory = new System.Windows.Forms.ComboBox();
            this.txtUniPrice = new System.Windows.Forms.TextBox();
            this.CboColor = new System.Windows.Forms.ComboBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtPCode = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.CboBrand = new System.Windows.Forms.ComboBox();
            this.CboUni = new System.Windows.Forms.ComboBox();
            this.CboCatagory = new System.Windows.Forms.ComboBox();
            this.CboSubGroup = new System.Windows.Forms.ComboBox();
            this.CboGroup = new System.Windows.Forms.ComboBox();
            this.lblArticle = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblExpCatagory = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPCode = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblItemId = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblSubGroup = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvItemEntry = new System.Windows.Forms.DataGridView();
            this.btnGridSelect = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.lblSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 27);
            this.panel3.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(51, 1);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(122, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(4, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtRemarks);
            this.panel2.Controls.Add(this.txtMaxLabelQty);
            this.panel2.Controls.Add(this.lblRemarks);
            this.panel2.Controls.Add(this.lblMaxLabelQty);
            this.panel2.Controls.Add(this.txtMinlabelQty);
            this.panel2.Controls.Add(this.txtShadeNo);
            this.panel2.Controls.Add(this.lblMinLabelqty);
            this.panel2.Controls.Add(this.lblShadeNo);
            this.panel2.Controls.Add(this.txtArticle);
            this.panel2.Controls.Add(this.txtVat);
            this.panel2.Controls.Add(this.CboExpCatagory);
            this.panel2.Controls.Add(this.txtUniPrice);
            this.panel2.Controls.Add(this.CboColor);
            this.panel2.Controls.Add(this.lblUnitPrice);
            this.panel2.Controls.Add(this.txtModel);
            this.panel2.Controls.Add(this.txtSize);
            this.panel2.Controls.Add(this.txtPCode);
            this.panel2.Controls.Add(this.txtItemName);
            this.panel2.Controls.Add(this.txtItemID);
            this.panel2.Controls.Add(this.CboBrand);
            this.panel2.Controls.Add(this.CboUni);
            this.panel2.Controls.Add(this.CboCatagory);
            this.panel2.Controls.Add(this.CboSubGroup);
            this.panel2.Controls.Add(this.CboGroup);
            this.panel2.Controls.Add(this.lblArticle);
            this.panel2.Controls.Add(this.lblVat);
            this.panel2.Controls.Add(this.lblExpCatagory);
            this.panel2.Controls.Add(this.lblColor);
            this.panel2.Controls.Add(this.lblModel);
            this.panel2.Controls.Add(this.lblSize);
            this.panel2.Controls.Add(this.lblPCode);
            this.panel2.Controls.Add(this.lblUnit);
            this.panel2.Controls.Add(this.lblBrand);
            this.panel2.Controls.Add(this.lblItemId);
            this.panel2.Controls.Add(this.lblItemName);
            this.panel2.Controls.Add(this.lblCatagory);
            this.panel2.Controls.Add(this.lblSubGroup);
            this.panel2.Controls.Add(this.lblGroup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 218);
            this.panel2.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::MAAQ_IMS.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(133, 157);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 23);
            this.btnRefresh.TabIndex = 43;
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
            this.btnSave.Location = new System.Drawing.Point(64, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 23);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(549, 166);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(122, 20);
            this.txtRemarks.TabIndex = 41;
            // 
            // txtMaxLabelQty
            // 
            this.txtMaxLabelQty.Location = new System.Drawing.Point(549, 135);
            this.txtMaxLabelQty.Name = "txtMaxLabelQty";
            this.txtMaxLabelQty.Size = new System.Drawing.Size(122, 20);
            this.txtMaxLabelQty.TabIndex = 40;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(474, 167);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 39;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblMaxLabelQty
            // 
            this.lblMaxLabelQty.AutoSize = true;
            this.lblMaxLabelQty.Location = new System.Drawing.Point(474, 140);
            this.lblMaxLabelQty.Name = "lblMaxLabelQty";
            this.lblMaxLabelQty.Size = new System.Drawing.Size(75, 13);
            this.lblMaxLabelQty.TabIndex = 38;
            this.lblMaxLabelQty.Text = "Max Label Qty";
            // 
            // txtMinlabelQty
            // 
            this.txtMinlabelQty.Location = new System.Drawing.Point(548, 106);
            this.txtMinlabelQty.Name = "txtMinlabelQty";
            this.txtMinlabelQty.Size = new System.Drawing.Size(122, 20);
            this.txtMinlabelQty.TabIndex = 37;
            // 
            // txtShadeNo
            // 
            this.txtShadeNo.Location = new System.Drawing.Point(549, 77);
            this.txtShadeNo.Name = "txtShadeNo";
            this.txtShadeNo.Size = new System.Drawing.Size(122, 20);
            this.txtShadeNo.TabIndex = 36;
            // 
            // lblMinLabelqty
            // 
            this.lblMinLabelqty.AutoSize = true;
            this.lblMinLabelqty.Location = new System.Drawing.Point(473, 110);
            this.lblMinLabelqty.Name = "lblMinLabelqty";
            this.lblMinLabelqty.Size = new System.Drawing.Size(72, 13);
            this.lblMinLabelqty.TabIndex = 35;
            this.lblMinLabelqty.Text = "Min Label Qty";
            // 
            // lblShadeNo
            // 
            this.lblShadeNo.AutoSize = true;
            this.lblShadeNo.Location = new System.Drawing.Point(474, 81);
            this.lblShadeNo.Name = "lblShadeNo";
            this.lblShadeNo.Size = new System.Drawing.Size(55, 13);
            this.lblShadeNo.TabIndex = 34;
            this.lblShadeNo.Text = "Shade No";
            // 
            // txtArticle
            // 
            this.txtArticle.Location = new System.Drawing.Point(549, 27);
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Size = new System.Drawing.Size(121, 20);
            this.txtArticle.TabIndex = 33;
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(549, 5);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(121, 20);
            this.txtVat.TabIndex = 32;
            // 
            // CboExpCatagory
            // 
            this.CboExpCatagory.DropDownWidth = 250;
            this.CboExpCatagory.FormattingEnabled = true;
            this.CboExpCatagory.Location = new System.Drawing.Point(549, 51);
            this.CboExpCatagory.Name = "CboExpCatagory";
            this.CboExpCatagory.Size = new System.Drawing.Size(121, 21);
            this.CboExpCatagory.TabIndex = 31;
            // 
            // txtUniPrice
            // 
            this.txtUniPrice.Location = new System.Drawing.Point(302, 167);
            this.txtUniPrice.Name = "txtUniPrice";
            this.txtUniPrice.Size = new System.Drawing.Size(122, 20);
            this.txtUniPrice.TabIndex = 30;
            // 
            // CboColor
            // 
            this.CboColor.DropDownWidth = 250;
            this.CboColor.FormattingEnabled = true;
            this.CboColor.Location = new System.Drawing.Point(301, 140);
            this.CboColor.Name = "CboColor";
            this.CboColor.Size = new System.Drawing.Size(123, 21);
            this.CboColor.TabIndex = 29;
            this.CboColor.SelectedIndexChanged += new System.EventHandler(this.CboColor_SelectedIndexChanged);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(234, 169);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 28;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(302, 110);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(122, 20);
            this.txtModel.TabIndex = 27;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(301, 84);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(123, 20);
            this.txtSize.TabIndex = 26;
            // 
            // txtPCode
            // 
            this.txtPCode.Location = new System.Drawing.Point(301, 61);
            this.txtPCode.Name = "txtPCode";
            this.txtPCode.Size = new System.Drawing.Size(123, 20);
            this.txtPCode.TabIndex = 25;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(88, 121);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(121, 20);
            this.txtItemName.TabIndex = 22;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(88, 93);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(121, 20);
            this.txtItemID.TabIndex = 21;
            // 
            // CboBrand
            // 
            this.CboBrand.DropDownWidth = 250;
            this.CboBrand.FormattingEnabled = true;
            this.CboBrand.Location = new System.Drawing.Point(302, 35);
            this.CboBrand.Name = "CboBrand";
            this.CboBrand.Size = new System.Drawing.Size(121, 21);
            this.CboBrand.TabIndex = 20;
            // 
            // CboUni
            // 
            this.CboUni.DropDownWidth = 250;
            this.CboUni.FormattingEnabled = true;
            this.CboUni.Location = new System.Drawing.Point(301, 8);
            this.CboUni.Name = "CboUni";
            this.CboUni.Size = new System.Drawing.Size(121, 21);
            this.CboUni.TabIndex = 19;
            // 
            // CboCatagory
            // 
            this.CboCatagory.DropDownWidth = 250;
            this.CboCatagory.FormattingEnabled = true;
            this.CboCatagory.Location = new System.Drawing.Point(88, 60);
            this.CboCatagory.Name = "CboCatagory";
            this.CboCatagory.Size = new System.Drawing.Size(121, 21);
            this.CboCatagory.TabIndex = 18;
            this.CboCatagory.SelectedIndexChanged += new System.EventHandler(this.CboCatagory_SelectedIndexChanged);
            // 
            // CboSubGroup
            // 
            this.CboSubGroup.DropDownWidth = 250;
            this.CboSubGroup.FormattingEnabled = true;
            this.CboSubGroup.Location = new System.Drawing.Point(88, 35);
            this.CboSubGroup.Name = "CboSubGroup";
            this.CboSubGroup.Size = new System.Drawing.Size(121, 21);
            this.CboSubGroup.TabIndex = 17;
            this.CboSubGroup.SelectedIndexChanged += new System.EventHandler(this.CboSubGroup_SelectedIndexChanged);
            // 
            // CboGroup
            // 
            this.CboGroup.DropDownWidth = 250;
            this.CboGroup.FormattingEnabled = true;
            this.CboGroup.Location = new System.Drawing.Point(88, 8);
            this.CboGroup.Name = "CboGroup";
            this.CboGroup.Size = new System.Drawing.Size(121, 21);
            this.CboGroup.TabIndex = 16;
            this.CboGroup.SelectedIndexChanged += new System.EventHandler(this.CboGroup_SelectedIndexChanged);
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Location = new System.Drawing.Point(473, 32);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(36, 13);
            this.lblArticle.TabIndex = 15;
            this.lblArticle.Text = "Article";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(473, 11);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(23, 13);
            this.lblVat.TabIndex = 14;
            this.lblVat.Text = "Vat";
            // 
            // lblExpCatagory
            // 
            this.lblExpCatagory.AutoSize = true;
            this.lblExpCatagory.Location = new System.Drawing.Point(473, 54);
            this.lblExpCatagory.Name = "lblExpCatagory";
            this.lblExpCatagory.Size = new System.Drawing.Size(70, 13);
            this.lblExpCatagory.TabIndex = 13;
            this.lblExpCatagory.Text = "Exp.Catagory";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(235, 148);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(235, 115);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(66, 13);
            this.lblModel.TabIndex = 11;
            this.lblModel.Text = "Model/Orgin";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(235, 87);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(60, 13);
            this.lblSize.TabIndex = 10;
            this.lblSize.Text = "Size/Width";
            // 
            // lblPCode
            // 
            this.lblPCode.AutoSize = true;
            this.lblPCode.Location = new System.Drawing.Point(234, 62);
            this.lblPCode.Name = "lblPCode";
            this.lblPCode.Size = new System.Drawing.Size(42, 13);
            this.lblPCode.TabIndex = 9;
            this.lblPCode.Text = "P.Code";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(234, 8);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unit";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(234, 33);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 7;
            this.lblBrand.Text = "Brand";
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(21, 93);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(41, 13);
            this.lblItemId.TabIndex = 4;
            this.lblItemId.Text = "Item ID";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(21, 118);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "Item Name";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(21, 67);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(49, 13);
            this.lblCatagory.TabIndex = 2;
            this.lblCatagory.Text = "Catagory";
            // 
            // lblSubGroup
            // 
            this.lblSubGroup.AutoSize = true;
            this.lblSubGroup.Location = new System.Drawing.Point(21, 43);
            this.lblSubGroup.Name = "lblSubGroup";
            this.lblSubGroup.Size = new System.Drawing.Size(58, 13);
            this.lblSubGroup.TabIndex = 1;
            this.lblSubGroup.Text = "Sub Group";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(21, 14);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Group";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 24);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Item Entry";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvItemEntry);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(794, 157);
            this.panel4.TabIndex = 2;
            // 
            // dgvItemEntry
            // 
            this.dgvItemEntry.AllowUserToAddRows = false;
            this.dgvItemEntry.AllowUserToDeleteRows = false;
            this.dgvItemEntry.AllowUserToResizeRows = false;
            this.dgvItemEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnGridSelect});
            this.dgvItemEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemEntry.Location = new System.Drawing.Point(0, 0);
            this.dgvItemEntry.Name = "dgvItemEntry";
            this.dgvItemEntry.ReadOnly = true;
            this.dgvItemEntry.RowHeadersWidth = 20;
            this.dgvItemEntry.Size = new System.Drawing.Size(794, 157);
            this.dgvItemEntry.TabIndex = 0;
            this.dgvItemEntry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemEntry_CellClick);
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
            // New_Item_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "New_Item_Entry";
            this.Text = "New_Item_Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.New_Item_Entry_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblExpCatagory;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPCode;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblSubGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboSubGroup;
        private System.Windows.Forms.ComboBox CboGroup;
        private System.Windows.Forms.ComboBox CboCatagory;
        private System.Windows.Forms.ComboBox CboUni;
        private System.Windows.Forms.ComboBox CboBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtPCode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUniPrice;
        private System.Windows.Forms.ComboBox CboColor;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.ComboBox CboExpCatagory;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblMaxLabelQty;
        private System.Windows.Forms.TextBox txtMinlabelQty;
        private System.Windows.Forms.TextBox txtShadeNo;
        private System.Windows.Forms.Label lblMinLabelqty;
        private System.Windows.Forms.Label lblShadeNo;
        private System.Windows.Forms.TextBox txtMaxLabelQty;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvItemEntry;
        private System.Windows.Forms.DataGridViewLinkColumn btnGridSelect;
    }
}