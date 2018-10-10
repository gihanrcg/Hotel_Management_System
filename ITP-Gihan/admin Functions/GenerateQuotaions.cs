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
    public partial class GenerateQuotaions : Form
    {
        public GenerateQuotaions()
        {
            InitializeComponent();
        }

        private void GenerateQuotaions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDAtaSet.hallbook' table. You can move, or remove it, as needed.
            //this.hallbookTableAdapter.Fill(this.hotelDAtaSet.hallbook);

           this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {


            //try
            //{
            //    using (DBConnect df = new DBConnect()) {

            //        hallbookBindingSource.DataSource=df.


            //    }
            //}
            //catch (Exception ex)
            //{


            //}


            //this.hallbookTableAdapter.Fill(this.hotelDAtaSet.hallbook, textBox1.Text);
            //this.reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.hallbookTableAdapter.Fill(this.hotelDAtaSet.hallbook);
            this.reportViewer1.RefreshReport();
        }
    }
}
