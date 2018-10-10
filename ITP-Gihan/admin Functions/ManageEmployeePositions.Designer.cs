namespace AttendanceRecorder
{
    partial class ManageEmployeePositions
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
            this.dgvEmployeePositions = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcasualLeaves = new System.Windows.Forms.NumericUpDown();
            this.txtMedicalLeaves = new System.Windows.Forms.NumericUpDown();
            this.txtShortLeaves = new System.Windows.Forms.NumericUpDown();
            this.txtHalfDays = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcasualLeaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicalLeaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShortLeaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHalfDays)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeePositions
            // 
            this.dgvEmployeePositions.AllowUserToAddRows = false;
            this.dgvEmployeePositions.AllowUserToDeleteRows = false;
            this.dgvEmployeePositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeePositions.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dgvEmployeePositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeePositions.Location = new System.Drawing.Point(22, 152);
            this.dgvEmployeePositions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmployeePositions.MultiSelect = false;
            this.dgvEmployeePositions.Name = "dgvEmployeePositions";
            this.dgvEmployeePositions.ReadOnly = true;
            this.dgvEmployeePositions.RowTemplate.Height = 24;
            this.dgvEmployeePositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeePositions.Size = new System.Drawing.Size(797, 467);
            this.dgvEmployeePositions.TabIndex = 0;
            this.dgvEmployeePositions.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeePositions_CellValueChanged);
            this.dgvEmployeePositions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvEmployeePositions_MouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(127, 118);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add position";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(172, 40);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(193, 20);
            this.txtPosition.TabIndex = 2;
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(442, 40);
            this.txtBasic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(196, 20);
            this.txtBasic.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(317, 119);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 28);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update position";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(22, 119);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 29);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(508, 119);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 28);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete position";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(763, 24);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(124, 40);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Basic Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Casual Leaves";
            // 
            // txtcasualLeaves
            // 
            this.txtcasualLeaves.Location = new System.Drawing.Point(205, 74);
            this.txtcasualLeaves.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcasualLeaves.Name = "txtcasualLeaves";
            this.txtcasualLeaves.Size = new System.Drawing.Size(44, 20);
            this.txtcasualLeaves.TabIndex = 9;
            // 
            // txtMedicalLeaves
            // 
            this.txtMedicalLeaves.Location = new System.Drawing.Point(345, 74);
            this.txtMedicalLeaves.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMedicalLeaves.Name = "txtMedicalLeaves";
            this.txtMedicalLeaves.Size = new System.Drawing.Size(44, 20);
            this.txtMedicalLeaves.TabIndex = 9;
            // 
            // txtShortLeaves
            // 
            this.txtShortLeaves.Location = new System.Drawing.Point(476, 74);
            this.txtShortLeaves.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShortLeaves.Name = "txtShortLeaves";
            this.txtShortLeaves.Size = new System.Drawing.Size(44, 20);
            this.txtShortLeaves.TabIndex = 9;
            // 
            // txtHalfDays
            // 
            this.txtHalfDays.Location = new System.Drawing.Point(590, 74);
            this.txtHalfDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHalfDays.Name = "txtHalfDays";
            this.txtHalfDays.Size = new System.Drawing.Size(44, 20);
            this.txtHalfDays.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Medical Leaves";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Short Leaves";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Half Days";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 24);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 89);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(665, 118);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(155, 29);
            this.btnExportToExcel.TabIndex = 11;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // ManageEmployeePositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 629);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtHalfDays);
            this.Controls.Add(this.txtShortLeaves);
            this.Controls.Add(this.txtMedicalLeaves);
            this.Controls.Add(this.txtcasualLeaves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBasic);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvEmployeePositions);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageEmployeePositions";
            this.Text = "EmployeePositions";
            this.Load += new System.EventHandler(this.EmployeePositions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcasualLeaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicalLeaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShortLeaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHalfDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeePositions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtcasualLeaves;
        private System.Windows.Forms.NumericUpDown txtMedicalLeaves;
        private System.Windows.Forms.NumericUpDown txtShortLeaves;
        private System.Windows.Forms.NumericUpDown txtHalfDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}