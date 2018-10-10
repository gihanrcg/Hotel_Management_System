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
    public partial class billPrint : Form
    {
        public billPrint()
        {
            InitializeComponent();
        }

        private void billPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelDataSet.rooms);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
