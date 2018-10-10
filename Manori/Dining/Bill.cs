using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dining
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }
        //    // TODO: This line of code loads data into the 'hotelDataSet.tempbill' table. You can move, or remove it, as needed.
        //    this.tempbillTableAdapter.Fill(this.hotelDataSet.tempbill);
        //    this.reportViewer1.RefreshReport();
        //}

        private void tempbillBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
