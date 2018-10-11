namespace Kitchen_Management_Sysytem
{
    partial class frmMenu
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
            this.dtgMenu = new System.Windows.Forms.DataGridView();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnPrintMenu = new System.Windows.Forms.Button();
            this.pnlFoodMenu = new System.Windows.Forms.Panel();
            this.btnDisplayMenu = new System.Windows.Forms.Button();
            this.btnOrderFood = new System.Windows.Forms.Button();
            this.pnlOrderFood = new System.Windows.Forms.Panel();
            this.lblOrderFood = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.lblMenuId = new System.Windows.Forms.Label();
            this.lblPortion = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.cmbPortion = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtMenuId = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.nudQtyOrder = new System.Windows.Forms.NumericUpDown();
            this.lblQtyOrder = new System.Windows.Forms.Label();
            this.txtPricePerPortion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).BeginInit();
            this.pnlFoodMenu.SuspendLayout();
            this.pnlOrderFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMenu
            // 
            this.dtgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMenu.Location = new System.Drawing.Point(114, 77);
            this.dtgMenu.Name = "dtgMenu";
            this.dtgMenu.RowTemplate.Height = 24;
            this.dtgMenu.Size = new System.Drawing.Size(658, 462);
            this.dtgMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(364, 19);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(106, 39);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // btnPrintMenu
            // 
            this.btnPrintMenu.Location = new System.Drawing.Point(321, 561);
            this.btnPrintMenu.Name = "btnPrintMenu";
            this.btnPrintMenu.Size = new System.Drawing.Size(227, 61);
            this.btnPrintMenu.TabIndex = 2;
            this.btnPrintMenu.Text = "Print Menu";
            this.btnPrintMenu.UseVisualStyleBackColor = true;
            // 
            // pnlFoodMenu
            // 
            this.pnlFoodMenu.Controls.Add(this.dtgMenu);
            this.pnlFoodMenu.Controls.Add(this.lblMenu);
            this.pnlFoodMenu.Controls.Add(this.btnPrintMenu);
            this.pnlFoodMenu.Location = new System.Drawing.Point(304, 1);
            this.pnlFoodMenu.Name = "pnlFoodMenu";
            this.pnlFoodMenu.Size = new System.Drawing.Size(855, 642);
            this.pnlFoodMenu.TabIndex = 3;
            // 
            // btnDisplayMenu
            // 
            this.btnDisplayMenu.Location = new System.Drawing.Point(43, 78);
            this.btnDisplayMenu.Name = "btnDisplayMenu";
            this.btnDisplayMenu.Size = new System.Drawing.Size(227, 61);
            this.btnDisplayMenu.TabIndex = 3;
            this.btnDisplayMenu.Text = "Display Menu";
            this.btnDisplayMenu.UseVisualStyleBackColor = true;
            this.btnDisplayMenu.Click += new System.EventHandler(this.btnDisplayMenu_Click);
            // 
            // btnOrderFood
            // 
            this.btnOrderFood.Location = new System.Drawing.Point(43, 235);
            this.btnOrderFood.Name = "btnOrderFood";
            this.btnOrderFood.Size = new System.Drawing.Size(227, 61);
            this.btnOrderFood.TabIndex = 4;
            this.btnOrderFood.Text = "Order";
            this.btnOrderFood.UseVisualStyleBackColor = true;
            this.btnOrderFood.Click += new System.EventHandler(this.btnOrderFood_Click);
            // 
            // pnlOrderFood
            // 
            this.pnlOrderFood.Controls.Add(this.txtPricePerPortion);
            this.pnlOrderFood.Controls.Add(this.lblQtyOrder);
            this.pnlOrderFood.Controls.Add(this.nudQtyOrder);
            this.pnlOrderFood.Controls.Add(this.btnAddOrder);
            this.pnlOrderFood.Controls.Add(this.txtMenuId);
            this.pnlOrderFood.Controls.Add(this.lblItem);
            this.pnlOrderFood.Controls.Add(this.cmbPortion);
            this.pnlOrderFood.Controls.Add(this.cmbMenu);
            this.pnlOrderFood.Controls.Add(this.lblPrice);
            this.pnlOrderFood.Controls.Add(this.lblPortion);
            this.pnlOrderFood.Controls.Add(this.lblMenuId);
            this.pnlOrderFood.Controls.Add(this.txtCustId);
            this.pnlOrderFood.Controls.Add(this.lblCustId);
            this.pnlOrderFood.Controls.Add(this.lblOrderFood);
            this.pnlOrderFood.Location = new System.Drawing.Point(305, 3);
            this.pnlOrderFood.Name = "pnlOrderFood";
            this.pnlOrderFood.Size = new System.Drawing.Size(852, 636);
            this.pnlOrderFood.TabIndex = 5;
            // 
            // lblOrderFood
            // 
            this.lblOrderFood.AutoSize = true;
            this.lblOrderFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderFood.Location = new System.Drawing.Point(345, 40);
            this.lblOrderFood.Name = "lblOrderFood";
            this.lblOrderFood.Size = new System.Drawing.Size(234, 46);
            this.lblOrderFood.TabIndex = 0;
            this.lblOrderFood.Text = "Order Food";
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(269, 149);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(85, 17);
            this.lblCustId.TabIndex = 1;
            this.lblCustId.Text = "Customer ID";
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(547, 149);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(120, 22);
            this.txtCustId.TabIndex = 2;
            // 
            // lblMenuId
            // 
            this.lblMenuId.AutoSize = true;
            this.lblMenuId.Location = new System.Drawing.Point(269, 251);
            this.lblMenuId.Name = "lblMenuId";
            this.lblMenuId.Size = new System.Drawing.Size(60, 17);
            this.lblMenuId.TabIndex = 3;
            this.lblMenuId.Text = "Menu ID";
            // 
            // lblPortion
            // 
            this.lblPortion.AutoSize = true;
            this.lblPortion.Location = new System.Drawing.Point(269, 303);
            this.lblPortion.Name = "lblPortion";
            this.lblPortion.Size = new System.Drawing.Size(53, 17);
            this.lblPortion.TabIndex = 4;
            this.lblPortion.Text = "Portion";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(269, 411);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(114, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price per Portion";
            // 
            // cmbMenu
            // 
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(546, 198);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(121, 24);
            this.cmbMenu.TabIndex = 7;
            // 
            // cmbPortion
            // 
            this.cmbPortion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortion.FormattingEnabled = true;
            this.cmbPortion.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cmbPortion.Location = new System.Drawing.Point(546, 300);
            this.cmbPortion.Name = "cmbPortion";
            this.cmbPortion.Size = new System.Drawing.Size(121, 24);
            this.cmbPortion.TabIndex = 8;
            this.cmbPortion.SelectedIndexChanged += new System.EventHandler(this.cmbPortion_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(269, 198);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(73, 17);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Menu Item";
            // 
            // txtMenuId
            // 
            this.txtMenuId.Location = new System.Drawing.Point(546, 251);
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.ReadOnly = true;
            this.txtMenuId.Size = new System.Drawing.Size(120, 22);
            this.txtMenuId.TabIndex = 10;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(320, 533);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(227, 61);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // nudQtyOrder
            // 
            this.nudQtyOrder.Location = new System.Drawing.Point(546, 358);
            this.nudQtyOrder.Name = "nudQtyOrder";
            this.nudQtyOrder.Size = new System.Drawing.Size(120, 22);
            this.nudQtyOrder.TabIndex = 11;
            // 
            // lblQtyOrder
            // 
            this.lblQtyOrder.AutoSize = true;
            this.lblQtyOrder.Location = new System.Drawing.Point(269, 358);
            this.lblQtyOrder.Name = "lblQtyOrder";
            this.lblQtyOrder.Size = new System.Drawing.Size(30, 17);
            this.lblQtyOrder.TabIndex = 12;
            this.lblQtyOrder.Text = "Qty";
            // 
            // txtPricePerPortion
            // 
            this.txtPricePerPortion.Location = new System.Drawing.Point(546, 411);
            this.txtPricePerPortion.Name = "txtPricePerPortion";
            this.txtPricePerPortion.ReadOnly = true;
            this.txtPricePerPortion.Size = new System.Drawing.Size(120, 22);
            this.txtPricePerPortion.TabIndex = 13;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 645);
            this.Controls.Add(this.btnDisplayMenu);
            this.Controls.Add(this.btnOrderFood);
            this.Controls.Add(this.pnlOrderFood);
            this.Controls.Add(this.pnlFoodMenu);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).EndInit();
            this.pnlFoodMenu.ResumeLayout(false);
            this.pnlFoodMenu.PerformLayout();
            this.pnlOrderFood.ResumeLayout(false);
            this.pnlOrderFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnPrintMenu;
        private System.Windows.Forms.Panel pnlFoodMenu;
        private System.Windows.Forms.Button btnDisplayMenu;
        private System.Windows.Forms.Button btnOrderFood;
        private System.Windows.Forms.Panel pnlOrderFood;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TextBox txtMenuId;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox cmbPortion;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPortion;
        private System.Windows.Forms.Label lblMenuId;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblOrderFood;
        private System.Windows.Forms.TextBox txtPricePerPortion;
        private System.Windows.Forms.Label lblQtyOrder;
        private System.Windows.Forms.NumericUpDown nudQtyOrder;
    }
}