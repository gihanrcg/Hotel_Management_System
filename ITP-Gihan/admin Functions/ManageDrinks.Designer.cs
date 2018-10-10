namespace AttendanceRecorder
{
    partial class ManageDrinks
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
           
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.employeeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactHomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
    
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.nicDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactHomeDataGridViewTextBoxColumn,
            this.contactMobileDataGridViewTextBoxColumn,
            this.jobRoleDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.changedByDataGridViewTextBoxColumn,
            this.changedAtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
          
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
   
            // 
            // employeeTableAdapter
            // 
      
            // 
            // employeeNoDataGridViewTextBoxColumn
            // 
            this.employeeNoDataGridViewTextBoxColumn.DataPropertyName = "employeeNo";
            this.employeeNoDataGridViewTextBoxColumn.HeaderText = "employeeNo";
            this.employeeNoDataGridViewTextBoxColumn.Name = "employeeNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // nicDataGridViewTextBoxColumn
            // 
            this.nicDataGridViewTextBoxColumn.DataPropertyName = "nic";
            this.nicDataGridViewTextBoxColumn.HeaderText = "nic";
            this.nicDataGridViewTextBoxColumn.Name = "nicDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactHomeDataGridViewTextBoxColumn
            // 
            this.contactHomeDataGridViewTextBoxColumn.DataPropertyName = "contactHome";
            this.contactHomeDataGridViewTextBoxColumn.HeaderText = "contactHome";
            this.contactHomeDataGridViewTextBoxColumn.Name = "contactHomeDataGridViewTextBoxColumn";
            // 
            // contactMobileDataGridViewTextBoxColumn
            // 
            this.contactMobileDataGridViewTextBoxColumn.DataPropertyName = "contactMobile";
            this.contactMobileDataGridViewTextBoxColumn.HeaderText = "contactMobile";
            this.contactMobileDataGridViewTextBoxColumn.Name = "contactMobileDataGridViewTextBoxColumn";
            // 
            // jobRoleDataGridViewTextBoxColumn
            // 
            this.jobRoleDataGridViewTextBoxColumn.DataPropertyName = "jobRole";
            this.jobRoleDataGridViewTextBoxColumn.HeaderText = "jobRole";
            this.jobRoleDataGridViewTextBoxColumn.Name = "jobRoleDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // changedByDataGridViewTextBoxColumn
            // 
            this.changedByDataGridViewTextBoxColumn.DataPropertyName = "changedBy";
            this.changedByDataGridViewTextBoxColumn.HeaderText = "changedBy";
            this.changedByDataGridViewTextBoxColumn.Name = "changedByDataGridViewTextBoxColumn";
            // 
            // changedAtDataGridViewTextBoxColumn
            // 
            this.changedAtDataGridViewTextBoxColumn.DataPropertyName = "changedAt";
            this.changedAtDataGridViewTextBoxColumn.HeaderText = "changedAt";
            this.changedAtDataGridViewTextBoxColumn.Name = "changedAtDataGridViewTextBoxColumn";
            // 
            // ManageDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 391);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageDrinks";
            this.Text = "ManageDrinks";
            this.Load += new System.EventHandler(this.ManageDrinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
          
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
      
        private System.Windows.Forms.BindingSource employeeBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactHomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedAtDataGridViewTextBoxColumn;
    }
}