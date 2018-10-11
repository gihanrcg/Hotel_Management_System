namespace AttendanceRecorder
{
    partial class frmOrderHandling
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
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnDiscardOrders = new System.Windows.Forms.Button();
            this.pnlOrderHandling = new System.Windows.Forms.Panel();
            this.dtgViewOrders = new System.Windows.Forms.DataGridView();
            this.lblOrderHandling = new System.Windows.Forms.Label();
            this.pnlOrderHandling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(21, 43);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(196, 101);
            this.btnViewOrders.TabIndex = 2;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnDiscardOrders
            // 
            this.btnDiscardOrders.Location = new System.Drawing.Point(21, 245);
            this.btnDiscardOrders.Name = "btnDiscardOrders";
            this.btnDiscardOrders.Size = new System.Drawing.Size(196, 101);
            this.btnDiscardOrders.TabIndex = 3;
            this.btnDiscardOrders.Text = "Discard Orders";
            this.btnDiscardOrders.UseVisualStyleBackColor = true;
            // 
            // pnlOrderHandling
            // 
            this.pnlOrderHandling.BackColor = System.Drawing.Color.Violet;
            this.pnlOrderHandling.Controls.Add(this.dtgViewOrders);
            this.pnlOrderHandling.Controls.Add(this.lblOrderHandling);
            this.pnlOrderHandling.Location = new System.Drawing.Point(267, 3);
            this.pnlOrderHandling.Name = "pnlOrderHandling";
            this.pnlOrderHandling.Size = new System.Drawing.Size(795, 676);
            this.pnlOrderHandling.TabIndex = 4;
            // 
            // dtgViewOrders
            // 
            this.dtgViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewOrders.Location = new System.Drawing.Point(51, 127);
            this.dtgViewOrders.Name = "dtgViewOrders";
            this.dtgViewOrders.RowTemplate.Height = 24;
            this.dtgViewOrders.Size = new System.Drawing.Size(681, 482);
            this.dtgViewOrders.TabIndex = 2;
            // 
            // lblOrderHandling
            // 
            this.lblOrderHandling.AutoSize = true;
            this.lblOrderHandling.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderHandling.Location = new System.Drawing.Point(305, 27);
            this.lblOrderHandling.Name = "lblOrderHandling";
            this.lblOrderHandling.Size = new System.Drawing.Size(222, 32);
            this.lblOrderHandling.TabIndex = 0;
            this.lblOrderHandling.Text = "Order Handling";
            this.lblOrderHandling.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmOrderHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1062, 677);
            this.Controls.Add(this.pnlOrderHandling);
            this.Controls.Add(this.btnDiscardOrders);
            this.Controls.Add(this.btnViewOrders);
            this.Name = "frmOrderHandling";
            this.Text = "Order Handling";
            this.pnlOrderHandling.ResumeLayout(false);
            this.pnlOrderHandling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnDiscardOrders;
        private System.Windows.Forms.Panel pnlOrderHandling;
        private System.Windows.Forms.Label lblOrderHandling;
        private System.Windows.Forms.DataGridView dtgViewOrders;
    }
}