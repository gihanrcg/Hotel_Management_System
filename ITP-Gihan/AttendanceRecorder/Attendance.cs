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
    public partial class Attendance : MetroFramework.Forms.MetroForm
    {
        public String employeeID;
        private String employeeName;
        DBConnect db = new DBConnect();
        private String scanType;
        private String date;
        private String time;


        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            scanType = "IN";

            AttendanceScanBarcode f = new AttendanceScanBarcode(this);
            
            f.Show();
            f.FormClosed += AttendanceScanBarcodeClosedIN;
            
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

        }

        private void AttendanceScanBarcodeClosedIN(object sender, FormClosedEventArgs e)
        {
            try
            {
              

                String q = "SELECT name FROM employee WHERE employeeNo='" + employeeID + "'";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    employeeName = r["name"].ToString();

                }
                this.date = DateTime.Now.ToString("yyyy-MM-dd");
                this.time = DateTime.Now.ToString("HH:MM:ss");
                //MessageBox.Show(time);
               AutoClosingMessageBoxes.Show("User : " + employeeName + "-IN- On " + date + " At " + time, scanType, 5000);
                String qu = "INSERT INTO employee_attendance(employeeNo,name,date,inTime) VALUES('" + employeeID + "','" + employeeName + "','" + date + "','" + time + "')";

                //String qu = "INSERT INTO `employee_attendance`( `employeeNo`, `name`, `date`, `inTime`, `outTime`, `timeWorked`)VALUES('x','xx','xxx','xxxx','xxxxx','xxxxxx')";
                //MessageBox.Show(qu);
                MySqlCommand cmd1 = new MySqlCommand(qu, db.con);
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                
            }

        }
    }
}
