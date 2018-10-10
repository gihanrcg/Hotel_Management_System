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
using System.Threading;
using System.Net;

namespace AttendanceRecorder
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        EncryptAndDecrypt en = new EncryptAndDecrypt();

        public Login()
        {
            InitializeComponent();
            txtEmployeeID.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBConnect db = new DBConnect())
                {
                    

                    String q = "SELECT * FROM employee WHERE employeeNo  ='" + txtEmployeeID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    MySqlDataReader r = cmd.ExecuteReader();

                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            String user = r["name"].ToString();
                            String password = r["password"].ToString();
                            Console.WriteLine(password);
                            String jobRole = r["jobRole"].ToString();
                            Console.WriteLine(jobRole);
                            Console.WriteLine();
                            if (en.EncryptString(txtpassword.Text).Equals(password))
                            {
                                if (jobRole.Equals("Manager"))
                                {
                                    Form1 f = new Form1(user, jobRole, txtEmployeeID.Text);
                                    f.Show();
                                    this.Hide();
                                }
                                else if(jobRole.Equals("Receptionist")){
                                    frmReceptionist f = new frmReceptionist(txtEmployeeID.Text);
                                    f.Show();
                                    this.Hide();

                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Password. Please check and try again", "Sorry..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }


                    }
                    else
                    {

                        MessageBox.Show("Incorrect Username. Please check and try again", "Sorry..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    } 
                }
                using (DBConnect db = new DBConnect())
                {
                     IPHostEntry host;
            String myIp = "";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    myIp = ip.ToString();
                   // MessageBox.Show(myIp);
                }
            }

            String q = "INSERT INTO `userip`(`employeeNo`, `ip`) VALUES ('" + txtEmployeeID.Text + "','" + myIp + "') ON DUPLICATE KEY UPDATE ip = '"+myIp+"'";
            MySqlCommand cmd = new MySqlCommand(q, db.con);
            cmd.ExecuteNonQuery();
                }

            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.StackTrace); 
               
            }
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

 







    }
}
