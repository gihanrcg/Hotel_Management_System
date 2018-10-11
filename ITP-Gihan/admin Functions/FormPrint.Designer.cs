//namespace AttendanceRecorder
//{
//    partial class FormPrint
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
//            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
//            this.ReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            ((System.ComponentModel.ISupportInitialize)(this.ReceiptBindingSource)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // reportViewer1
//            // 
//            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
//            reportDataSource1.Name = "ds";
//            reportDataSource1.Value = this.ReceiptBindingSource;
//            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
//            this.reportViewer1.LocalReport.ReportEmbeddedResource = "newHotel.rptReceipt.rdlc";
//            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
//            this.reportViewer1.Name = "reportViewer1";
//            this.reportViewer1.Size = new System.Drawing.Size(1016, 493);
//            this.reportViewer1.TabIndex = 0;
//            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
//            // 
//            // ReceiptBindingSource
//            // 
//            this.ReceiptBindingSource.DataSource = typeof(AttendanceRecorder.Receipt);
//            // 
//            // FormPrint
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1016, 493);
//            this.Controls.Add(this.reportViewer1);
//            this.Name = "FormPrint";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Print";
//            this.Load += new System.EventHandler(this.FormPrint_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.ReceiptBindingSource)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
//        private System.Windows.Forms.BindingSource ReceiptBindingSource;
//    }
//}