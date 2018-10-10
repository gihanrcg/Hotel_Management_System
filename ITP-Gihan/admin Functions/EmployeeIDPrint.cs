using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Printing;


namespace AttendanceRecorder
{
    public partial class EmployeeIDPrint : MetroFramework.Forms.MetroForm
    {
        public EmployeeIDPrint(String employeeNo)
        {
            InitializeComponent();
            lblEmployeeID.Text = employeeNo;
        }




        private void EmployeeIDPrint_Load(object sender, EventArgs e)
        {

            try
            {
                DBConnect db = new DBConnect();
                String q = "SELECT * FROM employee WHERE employeeNo ='" + lblEmployeeID.Text + "'";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        //lblEmployeeName.Text = r[1].ToString();

                        //txtEmployeeNIC.Text = r[2].ToString();

                        //String date = r[3].ToString();
                        //txtDatetime.Value = Convert.ToDateTime(date);

                        //txtEmployeeAddress.Text = r[4].ToString();

                        //txtContactNoHome.Text = r[5].ToString();

                        //txtContactNoMobile.Text = r[6].ToString();

                        //comboJobRole.SelectedItem = r[7].ToString();

                        lblEmployeeName.Text = r[1].ToString();

                        byte[] img = (byte[])(r[8]);

                        if (img == null)
                        {
                            picEmployeepic.Image = null;
                        }
                        else
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            picEmployeepic.Image = System.Drawing.Image.FromStream(mstream);
                        }

                    }


                    Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    picBarcode.Image = barcode.Draw(lblEmployeeID.Text, 25);
                }
                else
                {
                    MessageBox.Show("No records found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {


                Console.WriteLine(ex.StackTrace);
            }



        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeID_Click(object sender, EventArgs e)
        {

        }

        Bitmap bmp;
        Point p;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            this.Hide();
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            bmp = new Bitmap(width, height);

            this.DrawToBitmap(bmp, bounds);
            p = new Point(100, 100);

            Graphics mg = Graphics.FromImage(bmp);
            printPreviewDialog1.ShowDialog();
            //Graphics g = this.CreateGraphics();



            //bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            //Graphics mg = Graphics.FromImage(bmp);
            ////mg.CopyFromScreen(SystemInformation.WorkingArea.X, SystemInformation.WorkingArea.Y,0,0, this.Size);
            //mg.CopyFromScreen()
            
            //printPreviewDialog1.ShowDialog();

            //PrintDocument pd = new PrintDocument();
            //pd.PrintPage += new PrintPageEventHandler(PrintImage);
            //pd.Print();
        }

        private void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            bmp = new Bitmap(width, height);

            this.DrawToBitmap(bmp, bounds);
            p = new Point(100, 100);
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, p);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void picBarcode_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void picEmployeepic_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
