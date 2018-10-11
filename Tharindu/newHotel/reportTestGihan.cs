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
    public partial class reportTestGihan : Form
    {
        public reportTestGihan()
        {
            InitializeComponent();
        }

        private void reportTestGihan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.userbooking' table. You can move, or remove it, as needed.
            this.userbookingTableAdapter.Fill(this.hotelDataSet.userbooking);

            this.reportViewer1.RefreshReport();
        }
    }
}
