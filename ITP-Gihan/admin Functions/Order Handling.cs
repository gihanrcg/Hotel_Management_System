using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_Management_Sysytem
{
    public partial class frmOrderHandling : Form
    {
        DBConnect db = new DBConnect();
        public frmOrderHandling()
        {
            InitializeComponent();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            
       }
    }
}
