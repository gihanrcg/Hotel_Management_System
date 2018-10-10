namespace AttendanceRecorder
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.pnlViewInventory = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteItems = new System.Windows.Forms.Button();
            this.dtgInventory = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblInventory = new System.Windows.Forms.Label();
            this.pnlInsertInventory = new System.Windows.Forms.Panel();
            this.btnConfirmInsert = new System.Windows.Forms.Button();
            this.lblProductType = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblInsertItems = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.pnlUpdateInventory = new System.Windows.Forms.Panel();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.btnConfirmUpdate = new System.Windows.Forms.Button();
            this.nudQtyUpdate = new System.Windows.Forms.NumericUpDown();
            this.lblUpdateQty = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblUpdateItemName = new System.Windows.Forms.Label();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.lblUpdateItemCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewInventory = new System.Windows.Forms.Button();
            this.btnUpdateItems = new System.Windows.Forms.Button();
            this.btnInsertItems = new System.Windows.Forms.Button();
            this.pnlCover = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunningOut = new System.Windows.Forms.Button();
            this.pnlRunningOut = new System.Windows.Forms.Panel();
            this.lblRunningItems = new System.Windows.Forms.Label();
            this.dtgRunningOut = new System.Windows.Forms.DataGridView();
            this.lblRunningOut = new System.Windows.Forms.Label();
            this.btnConfirmDeduct = new System.Windows.Forms.Button();
            this.nudAddorDeduct = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlViewInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventory)).BeginInit();
            this.pnlInsertInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.pnlUpdateInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyUpdate)).BeginInit();
            this.pnlCover.SuspendLayout();
            this.pnlRunningOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRunningOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddorDeduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewInventory
            // 
            this.pnlViewInventory.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlViewInventory.Controls.Add(this.lblSearch);
            this.pnlViewInventory.Controls.Add(this.txtSearch);
            this.pnlViewInventory.Controls.Add(this.btnDeleteItems);
            this.pnlViewInventory.Controls.Add(this.dtgInventory);
            this.pnlViewInventory.Controls.Add(this.lblInventory);
            this.pnlViewInventory.Location = new System.Drawing.Point(303, 1);
            this.pnlViewInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlViewInventory.Name = "pnlViewInventory";
            this.pnlViewInventory.Size = new System.Drawing.Size(1117, 656);
            this.pnlViewInventory.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(683, 123);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(73, 20);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(773, 124);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 22);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDeleteItems
            // 
            this.btnDeleteItems.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteItems.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItems.Location = new System.Drawing.Point(413, 538);
            this.btnDeleteItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteItems.Name = "btnDeleteItems";
            this.btnDeleteItems.Size = new System.Drawing.Size(196, 101);
            this.btnDeleteItems.TabIndex = 8;
            this.btnDeleteItems.Text = "Delete Items";
            this.btnDeleteItems.UseVisualStyleBackColor = false;
            this.btnDeleteItems.Click += new System.EventHandler(this.btnDeleteItems_Click);
            // 
            // dtgInventory
            // 
            this.dtgInventory.AllowUserToAddRows = false;
            this.dtgInventory.BackgroundColor = System.Drawing.Color.White;
            this.dtgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dtgInventory.Location = new System.Drawing.Point(35, 176);
            this.dtgInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgInventory.Name = "dtgInventory";
            this.dtgInventory.RowTemplate.Height = 24;
            this.dtgInventory.Size = new System.Drawing.Size(993, 345);
            this.dtgInventory.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(424, 37);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(177, 35);
            this.lblInventory.TabIndex = 0;
            this.lblInventory.Text = "Inventory";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlInsertInventory
            // 
            this.pnlInsertInventory.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlInsertInventory.Controls.Add(this.btnConfirmInsert);
            this.pnlInsertInventory.Controls.Add(this.lblProductType);
            this.pnlInsertInventory.Controls.Add(this.cmbProductType);
            this.pnlInsertInventory.Controls.Add(this.lblQuantity);
            this.pnlInsertInventory.Controls.Add(this.lblProductName);
            this.pnlInsertInventory.Controls.Add(this.txtProductName);
            this.pnlInsertInventory.Controls.Add(this.lblInsertItems);
            this.pnlInsertInventory.Controls.Add(this.label4);
            this.pnlInsertInventory.Controls.Add(this.cmbUnit);
            this.pnlInsertInventory.Controls.Add(this.nudQty);
            this.pnlInsertInventory.Location = new System.Drawing.Point(304, 0);
            this.pnlInsertInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInsertInventory.Name = "pnlInsertInventory";
            this.pnlInsertInventory.Size = new System.Drawing.Size(1119, 660);
            this.pnlInsertInventory.TabIndex = 6;
            // 
            // btnConfirmInsert
            // 
            this.btnConfirmInsert.BackColor = System.Drawing.Color.Gray;
            this.btnConfirmInsert.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmInsert.Location = new System.Drawing.Point(496, 482);
            this.btnConfirmInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmInsert.Name = "btnConfirmInsert";
            this.btnConfirmInsert.Size = new System.Drawing.Size(179, 85);
            this.btnConfirmInsert.TabIndex = 10;
            this.btnConfirmInsert.Text = "Add";
            this.btnConfirmInsert.UseVisualStyleBackColor = false;
            this.btnConfirmInsert.Click += new System.EventHandler(this.btnConfirmInsert_Click);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(383, 224);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(161, 25);
            this.lblProductType.TabIndex = 6;
            this.lblProductType.Text = "Product Type";
            // 
            // cmbProductType
            // 
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.cmbProductType.Location = new System.Drawing.Point(572, 224);
            this.cmbProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(169, 26);
            this.cmbProductType.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(383, 306);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(108, 25);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(383, 133);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(171, 25);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(572, 134);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(169, 26);
            this.txtProductName.TabIndex = 1;
            // 
            // lblInsertItems
            // 
            this.lblInsertItems.AutoSize = true;
            this.lblInsertItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertItems.Location = new System.Drawing.Point(491, 27);
            this.lblInsertItems.Name = "lblInsertItems";
            this.lblInsertItems.Size = new System.Drawing.Size(172, 32);
            this.lblInsertItems.TabIndex = 0;
            this.lblInsertItems.Text = "Insert Items";
            this.lblInsertItems.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unit";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "kg",
            "nos",
            "litres"});
            this.cmbUnit.Location = new System.Drawing.Point(573, 390);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(169, 26);
            this.cmbUnit.TabIndex = 13;
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(573, 313);
            this.nudQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(167, 26);
            this.nudQty.TabIndex = 14;
            // 
            // pnlUpdateInventory
            // 
            this.pnlUpdateInventory.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlUpdateInventory.Controls.Add(this.label3);
            this.pnlUpdateInventory.Controls.Add(this.nudAddorDeduct);
            this.pnlUpdateInventory.Controls.Add(this.btnConfirmDeduct);
            this.pnlUpdateInventory.Controls.Add(this.lblItemCount);
            this.pnlUpdateInventory.Controls.Add(this.btnConfirmUpdate);
            this.pnlUpdateInventory.Controls.Add(this.nudQtyUpdate);
            this.pnlUpdateInventory.Controls.Add(this.lblUpdateQty);
            this.pnlUpdateInventory.Controls.Add(this.txtItemCode);
            this.pnlUpdateInventory.Controls.Add(this.lblUpdateItemName);
            this.pnlUpdateInventory.Controls.Add(this.cmbItemName);
            this.pnlUpdateInventory.Controls.Add(this.lblUpdateItemCode);
            this.pnlUpdateInventory.Controls.Add(this.label1);
            this.pnlUpdateInventory.Location = new System.Drawing.Point(303, 0);
            this.pnlUpdateInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUpdateInventory.Name = "pnlUpdateInventory";
            this.pnlUpdateInventory.Size = new System.Drawing.Size(1120, 660);
            this.pnlUpdateInventory.TabIndex = 11;
            this.pnlUpdateInventory.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUpdateInventory_Paint);
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Location = new System.Drawing.Point(916, 180);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(0, 17);
            this.lblItemCount.TabIndex = 11;
            // 
            // btnConfirmUpdate
            // 
            this.btnConfirmUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnConfirmUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmUpdate.Location = new System.Drawing.Point(183, 456);
            this.btnConfirmUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmUpdate.Name = "btnConfirmUpdate";
            this.btnConfirmUpdate.Size = new System.Drawing.Size(196, 101);
            this.btnConfirmUpdate.TabIndex = 10;
            this.btnConfirmUpdate.Text = "Add";
            this.btnConfirmUpdate.UseVisualStyleBackColor = false;
            this.btnConfirmUpdate.Click += new System.EventHandler(this.btnConfirmUpdate_Click);
            // 
            // nudQtyUpdate
            // 
            this.nudQtyUpdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtyUpdate.Location = new System.Drawing.Point(589, 315);
            this.nudQtyUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQtyUpdate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQtyUpdate.Name = "nudQtyUpdate";
            this.nudQtyUpdate.ReadOnly = true;
            this.nudQtyUpdate.Size = new System.Drawing.Size(283, 26);
            this.nudQtyUpdate.TabIndex = 6;
            // 
            // lblUpdateQty
            // 
            this.lblUpdateQty.AutoSize = true;
            this.lblUpdateQty.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateQty.Location = new System.Drawing.Point(109, 315);
            this.lblUpdateQty.Name = "lblUpdateQty";
            this.lblUpdateQty.Size = new System.Drawing.Size(227, 23);
            this.lblUpdateQty.TabIndex = 5;
            this.lblUpdateQty.Text = "Remaining Quantity";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(589, 256);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(281, 26);
            this.txtItemCode.TabIndex = 4;
            // 
            // lblUpdateItemName
            // 
            this.lblUpdateItemName.AutoSize = true;
            this.lblUpdateItemName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateItemName.Location = new System.Drawing.Point(109, 172);
            this.lblUpdateItemName.Name = "lblUpdateItemName";
            this.lblUpdateItemName.Size = new System.Drawing.Size(322, 23);
            this.lblUpdateItemName.TabIndex = 3;
            this.lblUpdateItemName.Text = "Item to Update (Item Name)";
            // 
            // cmbItemName
            // 
            this.cmbItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(589, 175);
            this.cmbItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(281, 26);
            this.cmbItemName.TabIndex = 2;
            this.cmbItemName.SelectedIndexChanged += new System.EventHandler(this.cmbItemName_SelectedIndexChanged_1);
            this.cmbItemName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbItemName_MouseClick);
            // 
            // lblUpdateItemCode
            // 
            this.lblUpdateItemCode.AutoSize = true;
            this.lblUpdateItemCode.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateItemCode.Location = new System.Drawing.Point(109, 247);
            this.lblUpdateItemCode.Name = "lblUpdateItemCode";
            this.lblUpdateItemCode.Size = new System.Drawing.Size(313, 23);
            this.lblUpdateItemCode.TabIndex = 1;
            this.lblUpdateItemCode.Text = "Item to Update (Item Code)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Inventory";
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.BackColor = System.Drawing.Color.DimGray;
            this.btnViewInventory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInventory.Location = new System.Drawing.Point(43, 49);
            this.btnViewInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(196, 101);
            this.btnViewInventory.TabIndex = 6;
            this.btnViewInventory.Text = "View Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = false;
            this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateItems.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItems.Location = new System.Drawing.Point(43, 399);
            this.btnUpdateItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.Size = new System.Drawing.Size(196, 101);
            this.btnUpdateItems.TabIndex = 7;
            this.btnUpdateItems.Text = "Update Items";
            this.btnUpdateItems.UseVisualStyleBackColor = false;
            this.btnUpdateItems.Click += new System.EventHandler(this.btnUpdateItems_Click);
            // 
            // btnInsertItems
            // 
            this.btnInsertItems.BackColor = System.Drawing.Color.DimGray;
            this.btnInsertItems.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertItems.Location = new System.Drawing.Point(43, 224);
            this.btnInsertItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertItems.Name = "btnInsertItems";
            this.btnInsertItems.Size = new System.Drawing.Size(196, 101);
            this.btnInsertItems.TabIndex = 9;
            this.btnInsertItems.Text = "Insert Items";
            this.btnInsertItems.UseVisualStyleBackColor = false;
            this.btnInsertItems.Click += new System.EventHandler(this.btnInsertItems_Click);
            // 
            // pnlCover
            // 
            this.pnlCover.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlCover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCover.BackgroundImage")));
            this.pnlCover.Controls.Add(this.label2);
            this.pnlCover.Location = new System.Drawing.Point(308, 6);
            this.pnlCover.Name = "pnlCover";
            this.pnlCover.Size = new System.Drawing.Size(1110, 651);
            this.pnlCover.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inventory Management";
            // 
            // btnRunningOut
            // 
            this.btnRunningOut.BackColor = System.Drawing.Color.Red;
            this.btnRunningOut.Location = new System.Drawing.Point(74, 577);
            this.btnRunningOut.Name = "btnRunningOut";
            this.btnRunningOut.Size = new System.Drawing.Size(137, 62);
            this.btnRunningOut.TabIndex = 16;
            this.btnRunningOut.Text = "Running Out of...";
            this.btnRunningOut.UseVisualStyleBackColor = false;
            this.btnRunningOut.Click += new System.EventHandler(this.btnRunningOut_Click);
            // 
            // pnlRunningOut
            // 
            this.pnlRunningOut.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlRunningOut.Controls.Add(this.lblRunningItems);
            this.pnlRunningOut.Controls.Add(this.dtgRunningOut);
            this.pnlRunningOut.Controls.Add(this.lblRunningOut);
            this.pnlRunningOut.Location = new System.Drawing.Point(307, 5);
            this.pnlRunningOut.Name = "pnlRunningOut";
            this.pnlRunningOut.Size = new System.Drawing.Size(1113, 654);
            this.pnlRunningOut.TabIndex = 1;
            // 
            // lblRunningItems
            // 
            this.lblRunningItems.AutoSize = true;
            this.lblRunningItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningItems.ForeColor = System.Drawing.Color.Red;
            this.lblRunningItems.Location = new System.Drawing.Point(316, 121);
            this.lblRunningItems.Name = "lblRunningItems";
            this.lblRunningItems.Size = new System.Drawing.Size(0, 20);
            this.lblRunningItems.TabIndex = 2;
            // 
            // dtgRunningOut
            // 
            this.dtgRunningOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRunningOut.Location = new System.Drawing.Point(319, 160);
            this.dtgRunningOut.Name = "dtgRunningOut";
            this.dtgRunningOut.RowTemplate.Height = 24;
            this.dtgRunningOut.Size = new System.Drawing.Size(587, 335);
            this.dtgRunningOut.TabIndex = 1;
            // 
            // lblRunningOut
            // 
            this.lblRunningOut.AutoSize = true;
            this.lblRunningOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningOut.Location = new System.Drawing.Point(488, 36);
            this.lblRunningOut.Name = "lblRunningOut";
            this.lblRunningOut.Size = new System.Drawing.Size(186, 32);
            this.lblRunningOut.TabIndex = 0;
            this.lblRunningOut.Text = "Running Out";
            // 
            // btnConfirmDeduct
            // 
            this.btnConfirmDeduct.BackColor = System.Drawing.Color.DimGray;
            this.btnConfirmDeduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmDeduct.Location = new System.Drawing.Point(468, 456);
            this.btnConfirmDeduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmDeduct.Name = "btnConfirmDeduct";
            this.btnConfirmDeduct.Size = new System.Drawing.Size(196, 101);
            this.btnConfirmDeduct.TabIndex = 12;
            this.btnConfirmDeduct.Text = "Deduct";
            this.btnConfirmDeduct.UseVisualStyleBackColor = false;
            this.btnConfirmDeduct.Click += new System.EventHandler(this.btnConfirmDeduct_Click);
            // 
            // nudAddorDeduct
            // 
            this.nudAddorDeduct.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAddorDeduct.Location = new System.Drawing.Point(589, 375);
            this.nudAddorDeduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAddorDeduct.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAddorDeduct.Name = "nudAddorDeduct";
            this.nudAddorDeduct.Size = new System.Drawing.Size(283, 26);
            this.nudAddorDeduct.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Add/Deduct Quantity";
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1436, 673);
            this.Controls.Add(this.btnRunningOut);
            this.Controls.Add(this.btnInsertItems);
            this.Controls.Add(this.btnUpdateItems);
            this.Controls.Add(this.btnViewInventory);
            this.Controls.Add(this.pnlRunningOut);
            this.Controls.Add(this.pnlCover);
            this.Controls.Add(this.pnlInsertInventory);
            this.Controls.Add(this.pnlUpdateInventory);
            this.Controls.Add(this.pnlViewInventory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.pnlViewInventory.ResumeLayout(false);
            this.pnlViewInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventory)).EndInit();
            this.pnlInsertInventory.ResumeLayout(false);
            this.pnlInsertInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.pnlUpdateInventory.ResumeLayout(false);
            this.pnlUpdateInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyUpdate)).EndInit();
            this.pnlCover.ResumeLayout(false);
            this.pnlCover.PerformLayout();
            this.pnlRunningOut.ResumeLayout(false);
            this.pnlRunningOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRunningOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddorDeduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlViewInventory;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.DataGridView dtgInventory;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.Button btnUpdateItems;
        private System.Windows.Forms.Button btnDeleteItems;
        private System.Windows.Forms.Button btnInsertItems;
        private System.Windows.Forms.Panel pnlInsertInventory;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblInsertItems;
        private System.Windows.Forms.Button btnConfirmInsert;
        private System.Windows.Forms.Panel pnlUpdateInventory;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblUpdateItemName;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.Label lblUpdateItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label lblUpdateQty;
        private System.Windows.Forms.NumericUpDown nudQtyUpdate;
        private System.Windows.Forms.Button btnConfirmUpdate;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlCover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlRunningOut;
        private System.Windows.Forms.Button btnRunningOut;
        private System.Windows.Forms.DataGridView dtgRunningOut;
        private System.Windows.Forms.Label lblRunningOut;
        private System.Windows.Forms.Label lblRunningItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAddorDeduct;
        private System.Windows.Forms.Button btnConfirmDeduct;
    }
}