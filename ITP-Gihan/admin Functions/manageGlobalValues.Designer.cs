namespace AttendanceRecorder
{
    partial class manageGlobalValues
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
            this.dgvGlobal = new System.Windows.Forms.DataGridView();
            this.txtGlobal = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlobal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGlobal
            // 
            this.dgvGlobal.AllowUserToAddRows = false;
            this.dgvGlobal.AllowUserToDeleteRows = false;
            this.dgvGlobal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGlobal.BackgroundColor = System.Drawing.Color.White;
            this.dgvGlobal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlobal.Location = new System.Drawing.Point(23, 133);
            this.dgvGlobal.MultiSelect = false;
            this.dgvGlobal.Name = "dgvGlobal";
            this.dgvGlobal.ReadOnly = true;
            this.dgvGlobal.RowTemplate.Height = 24;
            this.dgvGlobal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGlobal.Size = new System.Drawing.Size(424, 269);
            this.dgvGlobal.TabIndex = 0;
            this.dgvGlobal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvGlobal_MouseClick);
            // 
            // txtGlobal
            // 
            this.txtGlobal.Location = new System.Drawing.Point(145, 69);
            this.txtGlobal.Multiline = true;
            this.txtGlobal.Name = "txtGlobal";
            this.txtGlobal.Size = new System.Drawing.Size(208, 46);
            this.txtGlobal.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(359, 69);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 46);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(53, 77);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(64, 25);
            this.txtID.TabIndex = 3;
            this.txtID.Text = "label1";
            // 
            // manageGlobalValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 431);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtGlobal);
            this.Controls.Add(this.dgvGlobal);
            this.Name = "manageGlobalValues";
            this.Text = "Manage Global Values";
            this.Load += new System.EventHandler(this.manageGlobalValues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlobal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGlobal;
        private System.Windows.Forms.TextBox txtGlobal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label txtID;
    }
}