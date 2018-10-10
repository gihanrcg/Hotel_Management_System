using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceRecorder
{
    public partial class Form1 : Form
    {
        EncryptAndDecrypt en = new EncryptAndDecrypt();

        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();

        private String loggedEmployeeID;


        public string employeeID
        {
            get { return txtEmployeeID.Text; }
            set { txtEmployeeID.Text = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(String username, String Jobrole, String employeeID)
        {
            InitializeComponent();
            this.lblLoggedas.Text = username + " : " + Jobrole;
            this.loggedEmployeeID = employeeID;

        }


        private Timer timerLeaveReq;

        public void initTimer()
        {
            timerLeaveReq = new Timer();
            timerLeaveReq.Tick += timerLeaveReq_Tick;
            timerLeaveReq.Interval = 1000;
            timerLeaveReq.Start();
        }

        void timerLeaveReq_Tick(object sender, EventArgs e)
        {
            

            using (DBConnect db = new DBConnect())
            {
                int count = 0;
                String q = "SELECT COUNT(id) FROM leaverequests";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    count = Int32.Parse(r[0].ToString());
                }
                if (count == 0)
                {
                    lblRequestCount.Visible = false;
                }
                else
                {
                    lblRequestCount.Visible = true;
                    lblRequestCount.Text = count.ToString();
                }
            }
            using (DBConnect db = new DBConnect())
            {
                int count = 0;
                String q = "select count(id) from employeenotification where employeeNo ='" + loggedEmployeeID + "'";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    count = Int32.Parse(r[0].ToString());
                }
                if (count == 0)
                {
                    imgNotification.Visible = false;
                    btnMyProfile.TextAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    imgNotification.Visible = true;
                    btnMyProfile.TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timerClock = new System.Timers.Timer();
            timerClock.Interval = 1000;
            timerClock.Elapsed += timerClock_Elapsed;
            timerClock.Start();

            imgNotification.Visible = false;
            lblRequestCount.Visible = false;
            initTimer();
            //DBConnect db = new DBConnect();
            //String q = "SELECT * FROM employee";
            //MySqlCommand cmd = new MySqlCommand(q, db.con);
            //MySqlDataReader r = cmd.ExecuteReader();


            //if (r.HasRows == true)
            //{
            //    while (r.Read())
            //        Console.WriteLine(r[1].ToString());
            //    namesCollection.Add(r[1].ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Data not found");
            //}
            //r.Close();
            //txtEmployeeName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //txtEmployeeName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtEmployeeName.AutoCompleteCustomSource = namesCollection; 

            //var textBox = new TextBox
            //{
            txtEmployeeName.AutoCompleteCustomSource = namesCollection;
            txtEmployeeName.AutoCompleteMode =
                AutoCompleteMode.SuggestAppend;
            txtEmployeeName.AutoCompleteSource =
                AutoCompleteSource.CustomSource;

            // };

            // Add the text box to the form.

            pnlWelcome.BringToFront();
            pnlEmployeeAttendance.Hide();
            pnlManageEmployee.Hide();
            pnlViewDetailsofCustomers.Hide();
            

        }

        private void timerClock_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            circularProgressBar1.Invoke((MethodInvoker)delegate
            {
                circularProgressBar1.Text = DateTime.Now.ToString("hh:mm:ss");
                circularProgressBar1.SubscriptText = DateTime.Now.ToString("tt");

            });
        }



        private void txtContactNoHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void txtContactNoMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void tileManageEmployee_Click(object sender, EventArgs e)
        {
            Console.WriteLine("testhjgvjgfh");
            pnlManageEmployee.BringToFront();
            pnlEmployeeAttendance.Hide();
            pnlManageEmployee.Show();
            pnlViewDetailsofCustomers.Hide();
            pnlWelcome.Hide();

            List<String> jobs = new List<string>();

            DBConnect db = new DBConnect();

            String q = "select type from employeesalarydetails";
            MySqlCommand cmd = new MySqlCommand(q, db.con);
            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                jobs.Add(r[0].ToString());
            }

            comboJobRole.DataSource = jobs;

        }

        private void tileEmployeeAttendance_Click(object sender, EventArgs e)
        {
            pnlEmployeeAttendance.BringToFront();
            pnlWelcome.Hide();
            pnlEmployeeAttendance.Show();
            pnlManageEmployee.Hide();
            pnlViewDetailsofCustomers.Hide();

        }

        private void tileDetailsofCurrentCustomer_Click(object sender, EventArgs e)
        {
            pnlViewDetailsofCustomers.BringToFront();
            pnlWelcome.Hide();
            pnlEmployeeAttendance.Hide();
            pnlManageEmployee.Hide();
            pnlViewDetailsofCustomers.Show();

            DBConnect db = new DBConnect();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (ValidationManageEmployeeAdd())
            {
                using (DBConnect db = new DBConnect())
                {

                    try
                    {
                        byte[] imageBt = null;
                        FileStream fstream = new FileStream(this.txtpicpath.Text, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fstream);
                        imageBt = br.ReadBytes((int)fstream.Length);

                        DialogResult d = MessageBox.Show("Are you sure want to add this Employee..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        if (d == DialogResult.Yes)
                        {

                            DateTime dt = txtDatetime.Value;
                            String date = dt.ToString("yyyy-MM-dd");
                            Console.WriteLine(en.EncryptString("1234"));
                            String q = "insert into employee(name,nic,dob,address,contactHome,contactMobile,jobRole,image,password,changedBy) values ('" + txtEmployeeName.Text + "','" + txtEmployeeNIC.Text + "','" + date + "','" + txtEmployeeAddress.Text + "','" + txtContactNoHome.Text + "','" + txtContactNoMobile.Text + "','" + comboJobRole.Text + "',@IMG,'" + en.EncryptString("1234") + "','" + this.loggedEmployeeID + "')";


                            MySqlCommand cmd = new MySqlCommand(q, db.con);
                            cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                            cmd.ExecuteNonQuery();



                            String q1 = "SELECT * FROM employee WHERE name ='" + txtEmployeeName.Text + "'";
                            MySqlCommand cmd1 = new MySqlCommand(q1, db.con);
                            MySqlDataReader r = cmd1.ExecuteReader();

                            while (r.Read())
                            {
                                txtEmployeeID.Text = r[0].ToString();

                            }



                            MessageBox.Show("Employee Inserted Succesfully", "Done..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }


                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.StackTrace);
                    }
                } 
            }
        }

        public void setEmployeeID(String id)
        {
            this.txtEmployeeID.Text = id;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect db = new DBConnect();
                String q = "SELECT * FROM employee WHERE employeeNo ='" + txtEmployeeID.Text + "'";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        txtEmployeeName.Text = r[1].ToString();

                        txtEmployeeNIC.Text = r[2].ToString();

                        String date = r[3].ToString();
                        txtDatetime.Value = Convert.ToDateTime(date);

                        txtEmployeeAddress.Text = r[4].ToString();

                        txtContactNoHome.Text = r[5].ToString();

                        txtContactNoMobile.Text = r[6].ToString();

                        comboJobRole.SelectedItem = r[7].ToString();

                        byte[] img = (byte[])(r[8]);

                        if (img == null)
                        {
                            picEmployeePicture.Image = null;
                        }
                        else
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            picEmployeePicture.Image = System.Drawing.Image.FromStream(mstream);
                        }

                    }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Clear();

            txtEmployeeName.Clear();

            txtEmployeeNIC.Clear();

            txtDatetime.Value = DateTime.Now;

            txtEmployeeAddress.Clear();

            txtContactNoHome.Clear();

            txtContactNoMobile.Clear();

            comboJobRole.SelectedItem = "";

            picEmployeePicture.Image = null;

            txtpicpath.Clear();
            errorProvider1.Clear();
        }


        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (true)
            {
                DBConnect db = new DBConnect();

                try
                {
                    byte[] imageBt = null;
                    FileStream fstream = new FileStream(this.picEmployeePicture.ImageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    imageBt = br.ReadBytes((int)fstream.Length);

                    DateTime dt = txtDatetime.Value;
                    String date = dt.ToString("yyyy-MM-dd");

                    DialogResult d = MessageBox.Show("Are you sure you want to Update this Employee..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        String q = "UPDATE employee SET name='" + txtEmployeeName.Text + "',nic = '" + txtEmployeeNIC.Text + "',dob ='" + date + "',address='" + txtEmployeeAddress.Text + "',contactHome='" + txtContactNoHome.Text + "',contactMobile='" + txtContactNoMobile.Text + "',jobRole='" + comboJobRole.Text + "',image=@IMG,changedBy='" + this.loggedEmployeeID + "' WHERE employeeNo='" + txtEmployeeID.Text + "'";
                        Console.WriteLine(q);
                        MySqlCommand cmd = new MySqlCommand(q, db.con);
                        cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Updated Succesfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.StackTrace);
                } 
            }

        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text != "")
            {
                DBConnect db = new DBConnect();

                try
                {


                    DialogResult d = MessageBox.Show("Are you sure you want to Delete this Employee..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        String q = "DELETE FROM employee WHERE employeeNo='" + txtEmployeeID.Text + "'";
                        Console.WriteLine(q);
                        MySqlCommand cmd = new MySqlCommand(q, db.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Deleted Succesfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear_Click(null, null);
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("First search for the employee that you want to remove..!","No employees", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png)";

            if (d.ShowDialog() == DialogResult.OK)
            {
                String picpath = d.FileName.ToString();
                txtpicpath.Text = picpath;
                picpath = txtpicpath.Text;
                picEmployeePicture.ImageLocation = picpath;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text != null && txtEmployeeID.Text != "")
            {
                EmployeeIDPrint id = new EmployeeIDPrint(txtEmployeeID.Text);
                id.Show();

            }
            else
            {
                MessageBox.Show("Please Add the Employee or Search for the Employee. Anyway Employee ID test box should be filled with a valid Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanBarcode f = new ScanBarcode(this);
            f.Show();

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text.Length == 8)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to Logout from " + lblLoggedas.Text + "...?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (d == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Hide();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv.Visible = true;
            dgv.DataSource = GetEmployeeAttendence();
        }

        private DataTable GetEmployeeAttendence()
        {
            DataTable dt = new DataTable();
            DBConnect db = new DBConnect();

            String q = "select a.No,e.employeeNo as 'Employee ID',e.name as 'Name',a.date as 'Date',a.inTime as 'IN Time',a.outTime as 'Out Time',TIMEDIFF(a.outTime,a.inTime) as 'Time Worked'  from employee_attendance a, employee e where e.employeeNo = a.employeeNo";
            MySqlCommand cmd = new MySqlCommand(q, db.con);
            MySqlDataReader reader = cmd.ExecuteReader();


            dt.Load(reader);
            return dt;




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddposition_Click(object sender, EventArgs e)
        {

        }

        private void comboJobRole_MouseClick(object sender, MouseEventArgs e)
        {
            List<String> jobs = new List<string>();

            DBConnect db = new DBConnect();

            String q = "select type from employeesalarydetails";
            MySqlCommand cmd = new MySqlCommand(q, db.con);
            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                jobs.Add(r[0].ToString());
            }

            comboJobRole.DataSource = jobs;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ManageEmployeePositions pos = new ManageEmployeePositions();
            pos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmpNo.Focus();
        }

        private void txtEmpNo_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpNo.Text.Length == 8)
            {
                btnFindAttendence.Focus();
                btnFindAttendence.BackColor = Color.Blue;
            }
        }

        private void btnFindAttendence_Click(object sender, EventArgs e)
        {
            if (txtFromDate.Value > txttoDate.Value)
            {
                MessageBox.Show("Check your dates again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                dgv.DataSource = viewAttendenceFiltered();
            }
        }

        private DataTable viewAttendenceFiltered()
        {
            DataTable dt = new DataTable();
            DBConnect db = new DBConnect();

            String q = "select No as 'Record ID', date as 'Date',inTime as 'IN Time',outTime as 'Out Time',TIMEDIFF(outTime,inTime) as 'Time Worked',remarks as 'Remarks'  from employee_attendance  where  employeeNo ='" + txtEmpNo.Text + "' and date >= '" + txtFromDate.Value.ToString("yyyy-MM-dd") + "' and date <= '" + txttoDate.Value.ToString("yyyy-MM-dd") + "'";
            MySqlCommand cmd = new MySqlCommand(q, db.con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                dt.Load(reader);
                return dt;
            }
            else
            {
                MessageBox.Show("No data found");
                return null;
            }
        }

        private void dgv_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                txtRemark.Text = dgv.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void btnUpdateRemark_Click(object sender, EventArgs e)
        {

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfile f = new EmployeeProfile(loggedEmployeeID);
            f.Show();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            ManageRooms r = new ManageRooms();
            r.Show();
        }

        private void pnlViewDetailsofCustomers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tileEmployeeLeaveRequests_Click(object sender, EventArgs e)
        {
            pnlLeaveRequests.BringToFront();
            dgvLeaverequests.DataSource = loadLeaveRequests();
        }


        private DataTable loadLeaveRequests()
        {
            DBConnect db = new DBConnect();
            DataTable dt = new DataTable();

            String q = "SELECT l.id, e.employeeNo, e.name,l.leaveType, l.FromDate, l.toDate, l.fromTime, l.toTime, l.halfdayTime, l.reason,e.jobRole FROM leaverequests l , employee e WHERE l.employeeNo = e.employeeNo";
            MySqlCommand cmd = new MySqlCommand(q, db.con);
            MySqlDataReader r = cmd.ExecuteReader();
            dt.Load(r);

            return dt;

        }

        private void dgvLeaverequests_MouseClick(object sender, MouseEventArgs e)
        {
            txtLeaveId.Text = dgvLeaverequests.SelectedRows[0].Cells[0].Value.ToString();
            txtEmpIDLeave.Text = dgvLeaverequests.SelectedRows[0].Cells[1].Value.ToString();
            txtEmpNameLeave.Text = dgvLeaverequests.SelectedRows[0].Cells[2].Value.ToString();
            txtLeaveType.Text = dgvLeaverequests.SelectedRows[0].Cells[3].Value.ToString();
            
                    String dateFrom =dgvLeaverequests.SelectedRows[0].Cells[4].Value.ToString();
                    int index = dateFrom.IndexOf(" ");
                    if (index > 0)
                    {
                        dateFrom = dateFrom.Substring(0, index);
                        txtDateFromLeave.Text = dateFrom;
                    }

                    String dateto = dgvLeaverequests.SelectedRows[0].Cells[5].Value.ToString();
                    int index1 = dateto.IndexOf(" ");
                    if (index1 > 0)
                    {
                        dateto = dateto.Substring(0, index1);
                        txtDateToLeave.Text = dateto;
                    }
            
            
            
            
            
            txtTimeFromLeave.Text = dgvLeaverequests.SelectedRows[0].Cells[6].Value.ToString();
            txtTimetoLeave.Text = dgvLeaverequests.SelectedRows[0].Cells[7].Value.ToString();
            // txtLeaveId.Text = dgvLeaverequests.SelectedRows[0].Cells[8].Value.ToString();
            txtReason.Text = dgvLeaverequests.SelectedRows[0].Cells[9].Value.ToString();
            txtempPositionLeave.Text = dgvLeaverequests.SelectedRows[0].Cells[10].Value.ToString();

        }

        private void pnlLeaveRequests_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

            if (!txtEmpIDLeave.Text.Equals(""))
            {
                DialogResult d = MessageBox.Show("Are you sure want to approve this leave request..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    using (DBConnect db = new DBConnect())
                    {
                        String q = null;
                        if (txtLeaveType.Text.Equals("Casual Leave 1+ days"))
                        {
                            String[] dateFrom = txtDateFromLeave.Text.Split('/');
                            String[] dateTo = txtDateToLeave.Text.Split('/');

                            DateTime from = new DateTime(Int32.Parse(dateFrom[2]), Int32.Parse(dateFrom[0]), Int32.Parse(dateFrom[1]));
                            DateTime to = new DateTime(Int32.Parse(dateTo[2]), Int32.Parse(dateTo[0]), Int32.Parse(dateTo[1]));

                            int noOfDays = (to - from).Days + 1;

                            q = "update leavesremaining set casual = casual - " + noOfDays + " where employeeNo = '" + txtEmpIDLeave.Text + "'";
                        }
                        else if (txtLeaveType.Text.Equals("Casual Leave One Day"))
                        {
                            q = "update leavesremaining set casual = casual - 1 where employeeNo = '" + txtEmpIDLeave.Text + "'";
                        }
                        else if (txtLeaveType.Text.Equals("Half Day"))
                        {
                            q = "update leavesremaining set half = half - 1 where employeeNo = '" + txtEmpIDLeave.Text + "'";
                        }
                        else if (txtLeaveType.Text.Equals("Medical Leave"))
                        {
                            q = "update leavesremaining set medical = medical - 1 where employeeNo = '" + txtEmpIDLeave.Text + "'";
                        }
                        else if (txtLeaveType.Text.Equals("Short Leave"))
                        {
                            q = "update leavesremaining set short = short - 1 where employeeNo = '" + txtEmpIDLeave.Text + "'";
                        }

                        MySqlCommand cmd = new MySqlCommand(q, db.con);
                        cmd.ExecuteNonQuery();

                    }
                    using (DBConnect db = new DBConnect())
                    {
                        String q2 = "delete from leaverequests where employeeNo = '" + txtEmpIDLeave.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(q2, db.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Leave approved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    using (DBConnect db = new DBConnect())
                    {
                        String q = "insert into employeenotification(employeeNo,type,message) values('" + txtEmpIDLeave.Text + "','LeaveApproved','Your leave request to the date " + txtDateFromLeave.Text + " has been approved by " + lblLoggedas.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(q, db.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Leave approved and a notification has been sent to " + txtEmpNameLeave.Text + " ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    dgvLeaverequests.DataSource = loadLeaveRequests();

                } ValidationManageEmployeeAdd(); 
            }
    
        }

        private bool ValidationManageEmployeeAdd()
        {

            bool result = false;
            if (String.IsNullOrEmpty(txtEmployeeName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmployeeName, "Name is required");
            }
            else if (String.IsNullOrEmpty(txtEmployeeNIC.Text) || !(txtEmployeeNIC.Text.Length == 10 || txtEmployeeNIC.Text.Length == 12))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmployeeNIC, "NIC should have either 12 characters or 10");
            }              


            else if(((DateTime.Compare(txtDatetime.Value,DateTime.Now)) > 0))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtDatetime, "Invalid Birthdate");
            }
            else if (((dateDiffYears(txtDatetime.Value, DateTime.Now)) < 15 )|| ((dateDiffYears(txtDatetime.Value, DateTime.Now)) > 59))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtDatetime, "Employee should be atleast 14 years old");
            }
            else if (String.IsNullOrEmpty(txtEmployeeAddress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmployeeAddress, "Address Cannot be empty");
            }
            else if (txtContactNoMobile.Text.Length != 10 || !Regex.Match(txtContactNoMobile.Text, "[0-9]{10}").Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtContactNoMobile, "Mobile number should have 10 numbers");
            }
            else if (String.IsNullOrEmpty(comboJobRole.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboJobRole, "Please selecct a job role");
            }
            else if (String.IsNullOrEmpty(txtpicpath.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboJobRole, "Please selecct a job role");
            }
           
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }


        private int dateDiffYears(DateTime From, DateTime To)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);

            DateTime a = From;
            DateTime b =  To;

            TimeSpan span = b - a;
            // Because we start at year 1 for the Gregorian
            // calendar, we must subtract a year here.
            int years = (zeroTime + span).Year - 1;

            // 1, where my other algorithm resulted in 0.
            return years;
        }

        private void dgvLeaverequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void imgNotification_Click(object sender, EventArgs e)
        {
            EmployeeNotifications f = new EmployeeNotifications(loggedEmployeeID);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnRejected_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void comboJobRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton21_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmReceptionist f = new frmReceptionist(loggedEmployeeID);
            f.Show();
            this.Close();

        }

    }
}
