namespace AttendanceRecorder
{
    partial class ManageBar
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
            this.dgvBarManage = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.ComboBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtStockID = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDownloadToExcel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBarManage
            // 
            this.dgvBarManage.AllowUserToAddRows = false;
            this.dgvBarManage.AllowUserToDeleteRows = false;
            this.dgvBarManage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarManage.BackgroundColor = System.Drawing.Color.White;
            this.dgvBarManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarManage.Location = new System.Drawing.Point(60, 266);
            this.dgvBarManage.MultiSelect = false;
            this.dgvBarManage.Name = "dgvBarManage";
            this.dgvBarManage.ReadOnly = true;
            this.dgvBarManage.RowTemplate.Height = 24;
            this.dgvBarManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarManage.Size = new System.Drawing.Size(1059, 455);
            this.dgvBarManage.TabIndex = 0;
            this.dgvBarManage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarManage_CellContentClick);
            this.dgvBarManage.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBarManage_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Volume";
            // 
            // txtVolume
            // 
            this.txtVolume.FormattingEnabled = true;
            this.txtVolume.Items.AddRange(new object[] {
            "1L",
            "500 ML",
            "1.5 L",
            "100 ML"});
            this.txtVolume.Location = new System.Drawing.Point(751, 157);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(181, 24);
            this.txtVolume.TabIndex = 2;
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Liquor\t",
            "Beverage"});
            this.txtType.Location = new System.Drawing.Point(414, 162);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(196, 24);
            this.txtType.TabIndex = 3;
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(414, 98);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(196, 22);
            this.txtBrandName.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(751, 99);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(181, 22);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtStockID
            // 
            this.txtStockID.AutoSize = true;
            this.txtStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockID.Location = new System.Drawing.Point(166, 94);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(78, 24);
            this.txtStockID.TabIndex = 1;
            this.txtStockID.Text = "Stock ID";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmployee.Image = global::AttendanceRecorder.Properties.Resources.icons8_plus_30;
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(255, 204);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(191, 56);
            this.btnAddEmployee.TabIndex = 42;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::AttendanceRecorder.Properties.Resources.icons8_update_30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(515, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 56);
            this.button1.TabIndex = 42;
            this.button1.Text = "Update ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::AttendanceRecorder.Properties.Resources.icons8_trash_30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(751, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 56);
            this.button2.TabIndex = 42;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDownloadToExcel
            // 
            this.btnDownloadToExcel.Location = new System.Drawing.Point(969, 218);
            this.btnDownloadToExcel.Name = "btnDownloadToExcel";
            this.btnDownloadToExcel.Size = new System.Drawing.Size(150, 42);
            this.btnDownloadToExcel.TabIndex = 43;
            this.btnDownloadToExcel.Text = "Download to Excel";
            this.btnDownloadToExcel.UseVisualStyleBackColor = true;
            this.btnDownloadToExcel.Click += new System.EventHandler(this.btnDownloadToExcel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(969, 97);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 52);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ManageBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDownloadToExcel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStockID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBarManage);
            this.Name = "ManageBar";
            this.Text = "Manage Bar";
            this.Load += new System.EventHandler(this.ManageBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBarManage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtVolume;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label txtStockID;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDownloadToExcel;
        private System.Windows.Forms.Button btnClear;
    }
}