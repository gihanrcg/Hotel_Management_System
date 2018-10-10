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

namespace AttendanceRecorder
{
    public partial class EmployeeProfile : Form
    {

        String employeeID = null;
        String password = null;

        public EmployeeProfile(String EmployeeID)
        {
            this.employeeID = EmployeeID;
            InitializeComponent();
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            
            DBConnect db = new DBConnect();

            String q = "Select name,nic,address,contactHome,contactMobile,image,password from employee where employeeNo = '" + employeeID + "'";
            MySqlCommand cmd = new MySqlCommand(q, db.con);

            MySqlDataReader r = cmd.ExecuteReader();
            lblShortLeaveDate.Visible = false;
            txtShortLeaveDate.Visible = false;
            try
            {
                while (r.Read())
                {
                    txtEmployeeID.Text = employeeID;
                    txtName.Text = r[0].ToString();
                    txtNic.Text = r[1].ToString();
                    txtAddress.Text = r[2].ToString();
                    txtHome.Text = r[3].ToString();
                    txtMobile.Text = r[4].ToString();
                    password = r[6].ToString();
                    byte[] img = (byte[])(r[5]);

                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(img);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            pnlMyprofile.BringToFront();
            dgvMyAttendance.DataSource = loadMyattenceWithoutFilter();     





        }

        private DataTable loadMyattenceWithoutFilter() {

            DataTable dt = new DataTable();
            String today = DateTime.Now.ToString("yyyy-MM-dd");

            DBConnect db = new DBConnect();

            String qu = "select date as 'Date',inTime as 'IN Time',outTime as 'Out Time',TIMEDIFF(outTime,inTime) as 'Time Worked'  from employee_attendance where date='" + today + "' and employeeNo = '" + employeeID + "'";
            MySqlCommand c = new MySqlCommand(qu, db.con);
            MySqlDataReader reader = c.ExecuteReader();
            dt.Load(reader);
            return dt; 

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword(employeeID, password);
            f.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {           
            if ((txtMobile.Text .Length == 10) && (txtAddress.Text != ""))
            {
                DialogResult d = MessageBox.Show("Are you sure you want to update details...?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    DBConnect db = new DBConnect();
                    String q = "update employee set address = '" + txtAddress.Text + "',contactHome = '" + txtHome.Text + "',contactMobile='" + txtMobile.Text + "' where employeeNo ='" + employeeID + "'";
                    MySqlCommand cmd = new MySqlCommand(q,db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details updated successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mobile no or Address does not meet correct requirements","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ////this.Close();
            //Login l = new Login();
            //l.Show();
            //this.Hide();
            
        }

        private void btnMyAttendence_Click(object sender, EventArgs e)
        {
            pnlMyattendence.Show();
            pnlMyprofile.Hide();
            pnlrequestLeave.Hide();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            pnlMyprofile.Show();
            pnlMyattendence.Hide();
            pnlrequestLeave.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvMyAttendance.DataSource = loadAttendenceWithFilters();
        }
        private DataTable loadAttendenceWithFilters()
        {
            DataTable dt = new DataTable();
            String from = txtFrom.Value.ToString("yyyy-MM-dd");
            String to = txtTo.Value.ToString("yyyy-MM-dd");

            DBConnect db = new DBConnect();

            String qu = "select date as 'Date',inTime as 'IN Time',outTime as 'Out Time',TIMEDIFF(outTime,inTime) as 'Time Worked'  from employee_attendance where date >= '"+from+"' and date <= '"+to+"' and employeeNo = '" + employeeID + "'";
            MySqlCommand c = new MySqlCommand(qu, db.con);
            MySqlDataReader reader = c.ExecuteReader();
            dt.Load(reader);
            return dt; 
        }

        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword(employeeID, password);
            f.Show();
        }

        private void EmployeeProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnRequestLeave_Click(object sender, EventArgs e)
        {
            pnlrequestLeave.Show();
            pnlMyprofile.Hide();
            pnlMyattendence.Hide();
        }

        private void pnlrequestLeave_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Casual Leave 1+ days"))
            {
                lblhalfDayTime.Visible = false;
                cmbHalfdayType.Visible = false;
                lblDateTo.Visible = true;
                lblDatefrom.Visible = true;
                txtDateTo.Visible = true;
                txtDateFrom.Visible = true;
                txtDateFrom.Format = DateTimePickerFormat.Short;
                txtDateTo.Format = DateTimePickerFormat.Short;
                txtDateFrom.ShowUpDown = false; txtDateTo.ShowUpDown = false;
                lblShortLeaveDate.Visible = false;
                txtShortLeaveDate.Visible = false;
            }
            else if (comboBox1.Text.Equals("Casual Leave One Day"))
            {
                lblhalfDayTime.Visible = false;
                cmbHalfdayType.Visible = false;
                lblDateTo.Visible = false;
                lblDatefrom.Visible = true;
                txtDateTo.Visible = false;
                txtDateFrom.Visible = true;
                txtDateFrom.Format = DateTimePickerFormat.Short;
                txtDateTo.Format = DateTimePickerFormat.Short;
                txtDateFrom.ShowUpDown = false; txtDateTo.ShowUpDown = false;
                lblShortLeaveDate.Visible = false;
                txtShortLeaveDate.Visible = false;
                
            }
            else if (comboBox1.Text.Equals("Half Day")) 
            {
                lblhalfDayTime.Visible = true;
                cmbHalfdayType.Visible = true;
                lblDateTo.Visible = false;
                lblDatefrom.Visible = true;
                txtDateTo.Visible = false;
                txtDateFrom.Visible = true;
                txtDateFrom.Format = DateTimePickerFormat.Short;
                txtDateTo.Format = DateTimePickerFormat.Short;
                txtDateFrom.ShowUpDown = false; txtDateTo.ShowUpDown = false;
                lblShortLeaveDate.Visible = false;
                txtShortLeaveDate.Visible = false;
            }
            else if (comboBox1.Text.Equals("Medical Leave"))
            {
                lblhalfDayTime.Visible = false;
                cmbHalfdayType.Visible = false;
                lblDateTo.Visible = false;
                lblDatefrom.Visible = true;
                txtDateTo.Visible = false;
                txtDateFrom.Visible = true;
                txtDateFrom.Format = DateTimePickerFormat.Short;
                txtDateTo.Format = DateTimePickerFormat.Short;
                txtDateFrom.ShowUpDown = false; txtDateTo.ShowUpDown = false;
                lblShortLeaveDate.Visible = false;
                txtShortLeaveDate.Visible = false;
            }
            else if (comboBox1.Text.Equals("Short Leave"))
            {
                lblhalfDayTime.Visible = false;
                cmbHalfdayType.Visible = false; 
                lblDateTo.Visible = true;
                lblDatefrom.Visible = true;
                txtDateTo.Visible = true;
                txtDateFrom.Visible = true;
                txtDateFrom.Format = DateTimePickerFormat.Time;
                txtDateFrom.ShowUpDown = true; txtDateTo.ShowUpDown = true;
                txtDateTo.Format = DateTimePickerFormat.Time;
                
                txtShortLeaveDate.Format = DateTimePickerFormat.Short;
                lblShortLeaveDate.Visible = true;
                txtShortLeaveDate.Visible = true;
            
            }
        }

        private void btnLeaverequest_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("Are you sure you want to request this leave...?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {

                using (DBConnect db = new DBConnect())
                {
                    String q = null;
                    if (comboBox1.Text.Equals("Casual Leave 1+ days"))
                    {
                        q = "INSERT INTO `leaverequests`(`employeeNo`, `leaveType`, `FromDate`, `toDate`, `reason`) VALUES ('" + this.employeeID + "','" + comboBox1.Text + "','" + txtDateFrom.Value.ToString("yyyy-MM-dd") + "','" + txtDateTo.Value.ToString("yyyy-MM-dd") + "','" + txtReason.Text + "')";

                    }
                    else if (comboBox1.Text.Equals("Casual Leave One Day"))
                    {
                        q = "INSERT INTO `leaverequests`(`employeeNo`, `leaveType`, `FromDate`,`reason`) VALUES ('" + this.employeeID + "','" + comboBox1.Text + "','" + txtDateFrom.Value.ToString("yyyy-MM-dd") + "','" + txtReason.Text + "')";
                    }
                    else if (comboBox1.Text.Equals("Half Day"))
                    {

                        q = "INSERT INTO `leaverequests`(`employeeNo`, `leaveType`, `FromDate`, `halfdayTime`, `reason`) VALUES ('" + this.employeeID + "','" + comboBox1.Text + "','" + txtDateFrom.Value.ToString("yyyy-MM-dd") + "','" + cmbHalfdayType.Text + "','" + txtReason.Text + "')";
                    }
                    else if (comboBox1.Text.Equals("Medical Leave"))
                    {
                        q = "INSERT INTO `leaverequests`(`employeeNo`, `leaveType`, `FromDate`,`reason`) VALUES ('" + this.employeeID + "','" + comboBox1.Text + "','" + txtDateFrom.Value.ToString("yyyy-MM-dd") + "','" + txtReason.Text + "')";
                    }
                    else if (comboBox1.Text.Equals("Short Leave"))
                    {


                        q = "INSERT INTO `leaverequests`(`employeeNo`, `leaveType`, `FromDate`, `fromTime`, `toTime`, `reason`) VALUES ('" + this.employeeID + "','" + comboBox1.Text + "','" + txtShortLeaveDate.Value.ToString("yyyy-MM-dd") + "','" + txtDateFrom.Value.ToString("HH:mm") + "','" + txtDateTo.Value.ToString("HH:mm") + "','" + txtReason.Text + "')";

                    }

                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Leave requested successfully.Please wait for the response", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
