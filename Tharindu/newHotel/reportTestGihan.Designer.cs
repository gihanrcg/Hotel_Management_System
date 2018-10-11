namespace AttendanceRecorder
{
    partial class reportTestGihan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.userbookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new AttendanceRecorder.hotelDataSet();
            this.userbookingTableAdapter = new AttendanceRecorder.hotelDataSetTableAdapters.userbookingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userbookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dataGihan";
            reportDataSource1.Value = this.userbookingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "newHotel.Gihan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1068, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // userbookingBindingSource
            // 
            this.userbookingBindingSource.DataMember = "userbooking";
            this.userbookingBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userbookingTableAdapter
            // 
            this.userbookingTableAdapter.ClearBeforeFill = true;
            // 
            // reportTestGihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 453);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportTestGihan";
            this.Text = "reportTestGihan";
            this.Load += new System.EventHandler(this.reportTestGihan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userbookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource userbookingBindingSource;
        private hotelDataSet hotelDataSet;
        private hotelDataSetTableAdapters.userbookingTableAdapter userbookingTableAdapter;
    }
}