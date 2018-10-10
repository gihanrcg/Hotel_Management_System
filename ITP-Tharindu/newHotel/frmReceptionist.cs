using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AttendanceRecorder
{
    public partial class frmReceptionist : Form
    {

        String gender = "";
        String gender1 = "";

        String panelToLoad = null;
        String cusIDToUpdate = null;

        //String panelToLoad1 = null;
        public frmReceptionist()
        {


            InitializeComponent();

        }
        public frmReceptionist(String p, String cusID)
        {
            this.cusIDToUpdate = cusID;

            this.panelToLoad = p;
            InitializeComponent();
            //pnlRoombooking.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (panelToLoad == "roomBooking")
            {
                pnlRoombooking.BringToFront();

            }
            else if (panelToLoad == "hallbooking")
            {

                pnlHallbooking.BringToFront();
            }
            else
            {
                pnlNavigation.Show();
                pnlMain.Show();
                pnlCancelReservation.Hide();
                pnlHallbooking.Hide();
                pnlWelcome1.Hide();
                pnlWelcome2.Hide();
                pnlRoombooking.Hide();

            }
            rbMale.Checked = true;


        }

        private void btnRoombook_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            pnlCancelReservation.Hide();
            pnlHallbooking.Hide();
            pnlWelcome1.Hide();
            pnlWelcome2.Hide();
            pnlRoombooking.Show();
            loadpackages();
        }

        private void btnHallbook_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            pnlCancelReservation.Hide();
            pnlHallbooking.Show();
            pnlWelcome1.Hide();
            pnlWelcome2.Hide();
            pnlRoombooking.Hide();
        }

        private void btnBooknow_Click(object sender, EventArgs e)
        {

            DBConnect db = new DBConnect();

            try
            {


                if (rbMale.Checked)
                {
                    gender = "Male";
                }
                if (rbFemale.Checked)
                {
                    gender = "Female";
                }

                DialogResult d = MessageBox.Show("Are you sure you want to confirm the booking...?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {

                    String sql = "Insert into userbooking(MrMs,f_name,l_name,gender,nic_pass,address,mobile,email) values ('" + cmbMrMrs.Text + "','" + txtFirstname.Text + "','" + txtLastname.Text + "','" + gender + "','" + txtNic.Text + "','" + txtAddress.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "')";
                    MySqlCommand cmnd = new MySqlCommand(sql, db.con);
                    cmnd.ExecuteNonQuery();


                    String sql3 = "select cusId from userbooking where f_name='" + txtFirstname.Text + "' and l_name='" + txtLastname.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql3, db.con);
                    MySqlDataReader r = cmd.ExecuteReader();

                    String cusId = null;
                    while (r.Read())
                    {
                        cusId = r[0].ToString();
                    }
                    db.con.Close();

                    DBConnect c = new DBConnect();
                    String sql1 = "Insert into roombook(cusId,chk_in,chk_out,noOfrooms,noOfadults,noOfchild,roomType) values ('" + cusId + "','" + chkinDate.Value.ToString("yyyy-MM-dd") + "','" + chkoutDate.Value.ToString("yyyy-MM-dd") + "','" + txtNoofrooms.Text + "','" + txtNoofadults.Text + "','" + txtNoofchild.Text + "','" + cmbPackage.Text + "')";
                    MySqlCommand cmnd1 = new MySqlCommand(sql1, c.con);
                    cmnd1.ExecuteNonQuery();



                    MessageBox.Show("Booking Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {
                    MessageBox.Show("Booking cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }





            }
            catch (Exception x)
            {

                Console.WriteLine(x.Message);


            }




        }


        private void update(String cusID, String MrMsr, String fname, String lname, String genderr, String nic, String addressr, String mobiler, String emailr, String chkin, String chkout, String noofroomsr, String noofadultsr, String noofchildr, String roomtyper)
        {
            //try
            //{
            //    DialogResult d = MessageBox.Show("Are you sure you want to update this position..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (d.Equals(DialogResult.Yes))
            //    {
            //        DBConnect db = new DBConnect();
            //        String q = "update userbooking set MrMs='" + MrMsr + "',f_name ='" + fname + "',l_name='" + lname + "',gender='" + genderr + "',nic_pass='" + nic + "',address='" + addressr + "',mobile='" + mobiler + "',email='" + emailr + "'";
            //        MySqlCommand cmd = new MySqlCommand(q, db.con);
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //        String sql3 = "select cusId from userbooking where f_name='" + txtFirstname.Text + "' and l_name='" + txtLastname.Text + "'";
            //        MySqlCommand cmd5 = new MySqlCommand(sql3, db.con);
            //        MySqlDataReader r = cmd5.ExecuteReader();

            //        String cusId = null;
            //        while (r.Read())
            //        {
            //            cusId = r[0].ToString();
            //        }
            //        db.con.Close();

            //        DBConnect c = new DBConnect();


            //        String q1 = "update roombook set chk_in ='" + chkin + "',chk_out='" + chkout + "',noOfroomsr='" + noofroomsr + "',noOfadults='" + noofadultsr + "',noOfchild='" + noofchildr + "',roomType='" + roomtyper + "'";
            //        MySqlCommand cmd6 = new MySqlCommand(q1, db.con);
            //        cmd6.ExecuteNonQuery();
            //        MessageBox.Show("updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //    }
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("already added");
            //}


            DialogResult d = MessageBox.Show("Are you sure you want to Update this position..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d.Equals(DialogResult.Yes))
            {

                DBConnect db = new DBConnect();

                String q = "update userbooking set MrMs='" + cmbMrMrs.Text + "',f_name ='" + txtFirstname.Text + "',l_name='" + txtLastname.Text + "',gender='" + gender + "',nic_pass='" + txtNic.Text + "',address='" + txtAddress.Text + "',mobile='" + txtMobile.Text + "',email='" + txtEmail.Text + "' where cusId = '" + cusID + "' ; update roombook set chk_in ='" + chkinDate.Value.ToString("yyyy-MM-dd") + "',chk_out='" + chkoutDate.Value.ToString("yyyy-MM-dd") + "',noOfrooms='" + txtNoofrooms.Text + "',noOfadults='" + txtNoofadults + "',noOfchild='" + txtNoofchild.Text + "',roomType='" + cmbPackage.Text + "' where cusId = '" + cusID + "'";
                MySqlCommand cmd7 = new MySqlCommand(q, db.con);
                cmd7.ExecuteNonQuery();
                MessageBox.Show(" updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }


        private void updateh(String cusID, String MrMsr, String fname, String lname, String genderr, String nic, String addressr, String mobiler, String emailr, String chkin, String chkout, String noofroomsr, String noofadultsr, String noofchildr, String roomtyper)
        {



            DialogResult d = MessageBox.Show("Are you sure you want to Update this position..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d.Equals(DialogResult.Yes))
            {

                DBConnect db = new DBConnect();

                String q = "update userbooking set MrMs='" + cmbMrMrs.Text + "',f_name ='" + txtFirstname.Text + "',l_name='" + txtLastname.Text + "',gender='" + gender + "',nic_pass='" + txtNic.Text + "',address='" + txtAddress.Text + "',mobile='" + txtMobile.Text + "',email='" + txtEmail.Text + "' where cusId = '" + cusID + "' ; update roombook set chk_in ='" + chkinDate.Value.ToString("yyyy-MM-dd") + "',chk_out='" + chkoutDate.Value.ToString("yyyy-MM-dd") + "',noOfrooms='" + txtNoofrooms.Text + "',noOfadults='" + txtNoofadults + "',noOfchild='" + txtNoofchild.Text + "',roomType='" + cmbPackage.Text + "' where cusId = '" + cusID + "'";
                MySqlCommand cmd7 = new MySqlCommand(q, db.con);
                cmd7.ExecuteNonQuery();
                MessageBox.Show(" updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }


        private void btnCancelreservation_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            pnlCancelReservation.Show();
            pnlHallbooking.Hide();
            pnlWelcome1.Hide();
            pnlWelcome2.Hide();
            pnlRoombooking.Hide();
        }

        private void pnlRoombooking_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            availabil a = new availabil("availability");
            a.Show();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMrMrs.SelectedItem = null;
            cmbPackage.SelectedItem = null;
            txtAddress.Clear();
            txtEmail.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtMobile.Clear();
            txtNic.Clear();
            txtNoofadults.Clear();
            txtNoofchild.Clear();
            txtNoofrooms.Clear();



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Environment.Exit(10);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update(this.cusIDToUpdate, cmbMrMrs.Text, txtFirstname.Text, txtLastname.Text, gender, txtNic.Text, txtAddress.Text, txtMobile.Text, txtEmail.Text, chkinDate.Value.ToString("yyyy-MM-dd"), chkoutDate.Value.ToString("yyyy-MM-dd"), txtNoofrooms.Text, txtNoofadults.Text, txtNoofchild.Text, cmbPackage.Text);
        }

        private void btnHallDetails_Click(object sender, EventArgs e)
        {
            availabil a = new availabil("Halldetails");
            a.Show();


        }

        private void btnCustomerdetail_Click(object sender, EventArgs e)
        {
            availabil a = new availabil("pnlCustomerdetails");
            a.Show();
            this.Hide();

        }

        private void pnlHallbooking_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbPackage_MouseClick(object sender, MouseEventArgs e)
        {
            loadpackages();
        }

        private void loadpackages()
        {
            DBConnect db = new DBConnect();
            List<string> l = new List<string>();

            String q = "Select roomType from rooms";
            MySqlCommand cmd = new MySqlCommand(q, db.con);
            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                l.Add(r[0].ToString());
            }

            cmbPackage.DataSource = l;
        }


        private void btnHbook_Click(object sender, EventArgs e)
        {
            if (Validation())
            {

                DBConnect dt = new DBConnect();

                try
                {

                    if (rbMale.Checked)
                    {
                        gender1 = "Male";
                    }
                    if (rbFemale.Checked)
                    {
                        gender1 = "Female";
                    }



                    DialogResult d = MessageBox.Show("Are you sure you want to confirm the booking...?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (d == DialogResult.Yes)
                    {

                        String sql5 = "Insert into userbooking(MrMs,f_name,l_name,gender,nic_pass,address,mobile,email) values ('" + cmbMrMsH.Text + "','" + txtFirstnamehall.Text + "','" + txtLastnameHall.Text + "','" + gender1 + "','" + txtNIChall.Text + "','" + txtAddresshall.Text + "','" + txtMobilehall.Text + "','" + txtEmailhall.Text + "')";
                        MySqlCommand cmnd = new MySqlCommand(sql5, dt.con);
                        cmnd.ExecuteNonQuery();


                        String sql6 = "select cusId from userbooking where f_name='" + txtFirstname.Text + "' and l_name='" + txtLastname.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(sql6, dt.con);
                        MySqlDataReader f = cmd.ExecuteReader();

                        String cusId1 = null;
                        while (f.Read())
                        {
                            cusId1 = f[0].ToString();
                        }
                        dt.con.Close();

                        DBConnect ca = new DBConnect();
                        String sql7 = "Insert into hallbook(custId,chk_in,chk_out,capacity,noOfperson,price,package) values ('" + cusId1 + "','" + chkinHall.Value.ToString("yyyy-MM-dd") + "','" + chkoutHall.Value.ToString("yyyy-MM-dd") + "','" + txtCapacity.Text + "','" + txtNoperson.Text + "','" + txtPrice.Text + "','" + cmbHallpackage.Text + "')";
                        MySqlCommand cmnd1 = new MySqlCommand(sql7, ca.con);
                        cmnd1.ExecuteNonQuery();

                        MessageBox.Show("Booking Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Booking cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }





                }
                catch (Exception x)
                {

                    Console.WriteLine(x.Message);


                }



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbHallpackage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbHallpackage_MouseClick(object sender, MouseEventArgs e)
        {
            loadpackages2();
        }

        private void loadpackages2()
        {
            DBConnect de = new DBConnect();
            List<string> m = new List<string>();

            String q = "Select hallType from halls";
            MySqlCommand cmd1 = new MySqlCommand(q, de.con);
            MySqlDataReader r = cmd1.ExecuteReader();

            while (r.Read())
            {
                m.Add(r[0].ToString());
            }

            cmbHallpackage.DataSource = m;
        }

        //private void cmbMrMsH_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (cmbMrMsH.Text.Length > 0)
        //        {
        //            txtFirstnamehall.Focus();

        //        }else {

        //            cmbMrMsH.Focus();

        //        }
        //    }
        //}

        private void txtFirstnamehall_TextChanged(object sender, EventArgs e)
        {

        }

        //private void txtFirstnamehall_KeyDown(object sender, KeyEventArgs e)
        //{

        //    DateTime value;
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (txtFirstnamehall.Text.Length > 0)
        //        {
        //            txtLastnameHall.Focus();

        //        }
        //        else
        //        {

        //            txtFirstnamehall.Focus();

        //        }
        //    }
        //}

        private bool Validation()
        {
            //DateTime value;
            //DateTime value1;

            bool result = false;
            if (String.IsNullOrEmpty(cmbMrMsH.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbMrMsH, "Name required");
            }
            else if (String.IsNullOrEmpty(txtFirstnamehall.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFirstnamehall, "firstname required");
            }
            else if (String.IsNullOrEmpty(txtLastnameHall.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtLastnameHall, "lastname required");
            }
            else if (txtNIChall.Text.Length < 12 || txtNIChall.Text.Length > 12)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtNIChall, "length should be 12");
            }
            else if (String.IsNullOrEmpty(txtAddresshall.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAddresshall, "Adress is required");
            }
            else if (txtMobilehall.Text.Length < 10 || txtMobilehall.Text.Length > 10)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMobilehall, "length should be 10");
            }
            else if (String.IsNullOrEmpty(txtEmailhall.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmailhall, "Email is required");
            }
            else if (String.IsNullOrEmpty(txtEmailhall.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmailhall, "Email is required");
            }
            //else if (!DateTime.TryParse(chkinHall.Text, out value))
            //{
            //    //    //DateTime value;
            //    //    //if (!DateTime.TryParse(startDateTextBox.Text, out value))
            //    //    //{
            //    //    chkinHall.Text = DateTime.Today.ToShortDateString();
            //    //    //}



            //    //}else if (!DateTime.TryParse(chkinHall.Text, out value1))
            //    //{

            //    //    chkoutHall.Text = DateTime.Today.ToShortDateString();

            //    //}
            else if (String.IsNullOrEmpty(txtCapacity.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtCapacity, "Capacity is required");

            }
            else if (String.IsNullOrEmpty(txtNoperson.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtNoperson, "No of person is reqired");
            }
            else if (String.IsNullOrEmpty(txtPrice.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPrice, "price is required");

            }
            else if (String.IsNullOrEmpty(cmbHallpackage.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbHallpackage, "package is reqyired");

            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }



        private void btnClearh_Click(object sender, EventArgs e)
        {
            cmbMrMsH.SelectedItem = null;
            cmbHallpackage.SelectedItem = null;
            txtAddresshall.Clear();
            txtEmailhall.Clear();
            txtFirstnamehall.Clear();
            txtLastnameHall.Clear();
            txtMobilehall.Clear();
            txtNIChall.Clear();
            txtNoperson.Clear();
            txtCapacity.Clear();
            txtPrice.Clear();

        }

        private void btnUpdateh_Click(object sender, EventArgs e)
        {
            updateh(this.cusIDToUpdate, cmbMrMrs.Text, txtFirstname.Text, txtLastname.Text, gender, txtNic.Text, txtAddress.Text, txtMobile.Text, txtEmail.Text, chkinDate.Value.ToString("yyyy-MM-dd"), chkoutDate.Value.ToString("yyyy-MM-dd"), txtNoofrooms.Text, txtNoofadults.Text, txtNoofchild.Text, cmbPackage.Text);
        }
    }
}
