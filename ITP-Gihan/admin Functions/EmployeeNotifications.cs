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
    public partial class EmployeeNotifications : Form
    {
        String employeeID = null;
        String notificationID = null;
        
        public EmployeeNotifications()
        {
            InitializeComponent();

        }

        public EmployeeNotifications(String employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
        }

        private void EmployeeNotifications_Load(object sender, EventArgs e)
        {
            dgvNotifications.DataSource = loadNotifications();
        }
        private DataTable loadNotifications() {
           
            DataTable dt = new DataTable();
            using (DBConnect db = new DBConnect())
            {
                String q = "select id,message from employeenotification where employeeNo='" + this.employeeID + "'";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();
                dt.Load(r);
                return dt;
            }

        
        }

        private void dgvNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBConnect db = new DBConnect())
            {
                DialogResult d  = MessageBox.Show("Are you sure you want to delete this notification..?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    string q = "DELETE FROM `employeenotification` WHERE id = '" + dgvNotifications.CurrentRow.Cells[1].Value.ToString() + "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    dgvNotifications.DataSource = loadNotifications(); 
                }
                
            }
        }

        private void EmployeeNotifications_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void EmployeeNotifications_MouseClick(object sender, MouseEventArgs e)
        {
            notificationID = dgvNotifications.CurrentRow.Cells[0].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
