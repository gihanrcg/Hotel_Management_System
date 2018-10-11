using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;

namespace AttendanceRecorder
{
    public partial class ManoriViewer : Form
    {
        private string p;

        public ManoriViewer()
        {
            InitializeComponent();
        }

        public ManoriViewer(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
            InitializeComponent();
        }

        private void ManoriViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tempbill' table. You can move, or remove it, as needed.
            this.tempbillTableAdapter.Fill(this.hotelDataSet.tempbill);
            ReportParameterCollection reportParams = new ReportParameterCollection();
            reportParams.Add(new ReportParameter("TotalBill",p));
            this.reportViewer1.LocalReport.SetParameters(reportParams);
            this.reportViewer1.RefreshReport();
        }
    }
}
