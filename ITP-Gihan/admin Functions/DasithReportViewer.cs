using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceRecorder
{
    public partial class DasithReportViewer : Form
    {
        public DasithReportViewer()
        {
            InitializeComponent();
        }

        private void DasithReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DasithDataSet.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.DasithDataSet.stock);

            this.reportViewer1.RefreshReport();
        }
    }
}
