namespace AttendanceRecorder
{
    partial class GenerateQuotaions
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hallbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDAtaSet = new AttendanceRecorder.hotelDAtaSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hallbookTableAdapter = new AttendanceRecorder.hotelDAtaSetTableAdapters.hallbookTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hallbookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDAtaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // hallbookBindingSource
            // 
            this.hallbookBindingSource.DataMember = "hallbook";
            this.hallbookBindingSource.DataSource = this.hotelDAtaSet;
            // 
            // hotelDAtaSet
            // 
            this.hotelDAtaSet.DataSetName = "hotelDAtaSet";
            this.hotelDAtaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.hallbookBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "newHotel.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(888, 412);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // hallbookTableAdapter
            // 
            this.hallbookTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 28);
            this.textBox1.TabIndex = 2;
            // 
            // GenerateQuotaions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 482);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GenerateQuotaions";
            this.Text = "GenerateQuotaions";
            this.Load += new System.EventHandler(this.GenerateQuotaions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hallbookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDAtaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hallbookBindingSource;
        private hotelDAtaSet hotelDAtaSet;
        private hotelDAtaSetTableAdapters.hallbookTableAdapter hallbookTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}