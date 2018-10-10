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

namespace AttendanceRecorder
{
    public partial class AttendenceRecorder : MetroFramework.Forms.MetroForm
    {
        public String employeeId;

        public AttendenceRecorder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                ScanBarcodeForAttendence scan = new ScanBarcodeForAttendence(this);
                scan.FormClosed += scan_FormClosedIN;
                scan.Show();
              
            }
           
        }

        private void scan_FormClosedIN(object sender, FormClosedEventArgs e)
        {
            String employeeID = employeeId;
            String EmployeeName = null;
            {

                DBConnect d = new DBConnect();
                String query = "Select name from employee where employeeNo = '" + employeeID + "'";
                MySqlCommand c = new MySqlCommand(query, d.con);
                MySqlDataReader r = c.ExecuteReader();

                while (r.Read())
                {
                    EmployeeName = r[0].ToString();
                }

            }

            DBConnect db = new DBConnect();
            String date = DateTime.Now.ToString("yyyy-MM-dd");
            String time = DateTime.Now.ToString("HH:mm");

            String q = "INSERT INTO employee_attendance(employeeNo,date,inTime) VALUES('" + employeeID + "','" + date + "','" + time + "')";
            MySqlCommand cmd = new MySqlCommand(q, db.con);
            cmd.ExecuteNonQuery();
            AutoClosingMessageBoxes.Show(EmployeeName + " IN " + date + " " + time, "Done",2000);
     


        }
        
        private void btnOut_Click(object sender, EventArgs e)
        {
                      {
                ScanBarcodeForAttendence scan = new ScanBarcodeForAttendence(this);
                scan.FormClosed += scan_FormClosedOut;
                scan.Show();
              
            }


                

            
         
              
            
        }

        private void scan_FormClosedOut(object sender, FormClosedEventArgs e)
        {
            String employeeID = employeeId;
            String EmployeeName = null;
            {

                DBConnect d = new DBConnect();
                String query = "Select name from employee where employeeNo = '" + employeeID + "'";
                MySqlCommand c = new MySqlCommand(query, d.con);
                MySqlDataReader r = c.ExecuteReader();

                while (r.Read())
                {
                    EmployeeName = r[0].ToString();
                }

            }

            DBConnect db = new DBConnect();
            String date = DateTime.Now.ToString("yyyy-MM-dd");
            String time = DateTime.Now.ToString("HH:mm");

            String q = "update employee_attendance SET outTime = '" + time + "' where employeeNo = '" + employeeID + "' and date = '" + date + "'";
            MySqlCommand cmd = new MySqlCommand(q, db.con);
            cmd.ExecuteNonQuery();

            AutoClosingMessageBoxes.Show(EmployeeName + " OUT " + date + " " + time, "Done", 2000);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ScanBarcodeForAttendence scan = new ScanBarcodeForAttendence(this);
            scan.Show();
        }
    }
}
