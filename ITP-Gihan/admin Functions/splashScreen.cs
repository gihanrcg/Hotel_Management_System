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
    public partial class splashScreen : MetroFramework.Forms.MetroForm
    {
        int progress = 0;

        public splashScreen()
        {
            try
            {
                DBConnect db = new DBConnect();
            }
            catch (Exception)
            {

                DialogResult d = MessageBox.Show("Database connection failed. Make sure your database server is up and running", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Retry)
                {
                    Application.Restart();
                    Environment.Exit(10);
                }
                else if(d == DialogResult.Cancel)   
                {
                    Environment.Exit(10);
                 
                }
            }
            InitializeComponent();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled =true;
            timer1.Interval = 30;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
                Login f = new Login();
                f.Show();
            }
         
            metroProgressSpinner1.Value = progress;
            metroProgressBar1.Value = progress;
          
         
            metroLabel1.Text= "Loading...  " + progress + "%";
        }


    }
}
