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
    public partial class customizeReport : Form
    {

        int order = 1;
        double total = 0;
        public customizeReport()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtRequirement.Text) && !String.IsNullOrEmpty(txtPrice.Text)) {
                Receipt obj = new Receipt() { Id = order++, Requirements = txtRequirement.Text, Price = Convert.ToDouble(txtPrice.Text), Quantity = Convert.ToInt32(txtQuantity.Text) };
                total += obj.Price * obj.Quantity;
                receiptBindingSource.Add(obj);
                receiptBindingSource.MoveLast();
                txtRequirement.Text = String.Empty;
                txtTotal.Text = String.Format("{0}$",total);
            }


        }

        private void customizeReport_Load(object sender, EventArgs e)
        {
            receiptBindingSource.DataSource = new List<Receipt>();//Init Empty List

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Receipt obj = receiptBindingSource.Current as Receipt;
            if (obj != null) {
                total -= obj.Price * obj.Quantity;
                txtTotal.Text = String.Format("{0}$", total);
            }
            receiptBindingSource.RemoveCurrent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using(FormPrint frm = new FormPrint(receiptBindingSource.DataSource as List<Receipt>,String.Format("{0}$", total),DateTime.Now.ToString("MM/dd/yyyy"))){
            
            frm.ShowDialog();
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
