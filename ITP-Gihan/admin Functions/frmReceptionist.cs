using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AttendanceRecorder
{
    public partial class frmReceptionist : Form
    {
        String EmployeeID = null;

        String gender = "";
        String gender1 = "";

        String panelToLoad = null;
        String NICToUpdate = null;
        
        //String panelToLoad1 = null;



        public frmReceptionist(String EmployeeID)
        {
            this.EmployeeID = EmployeeID;
          
            InitializeComponent();

        }
        public frmReceptionist(String p, String NIC,String EmployeeID)
        {
            this.NICToUpdate = NIC;
            this.EmployeeID = EmployeeID;
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
            else if (panelToLoad == "hallbooking") {

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
                pnlReport1.Hide();

            }
            rbMale.Checked = true;

            
        }

        private void btnRoombook_Click(object sender, EventArgs e)
        {
          //  pnlRoombooking.BringToFront();
            pnlMain.Hide();
            pnlCancelReservation.Hide();
            pnlHallbooking.Hide();
            pnlWelcome1.Hide();
            pnlWelcome2.Hide();
            pnlRoombooking.Show();
            pnlReport1.Hide();
            loadpackages();
        }

        private void btnHallbook_Click(object sender, EventArgs e)
        {
         //   pnlHallbooking.BringToFront();
            pnlMain.Hide();
            pnlCancelReservation.Hide();
            pnlHallbooking.Show();
            pnlWelcome1.Hide();
            pnlWelcome2.Hide();
            pnlRoombooking.Hide();
            pnlReport1.Hide();
        }

        private void btnBooknow_Click(object sender, EventArgs e)
        {


            if (Validation1())
            {

                DBConnect dn = new DBConnect();

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

                        String sql = "Insert into userbooking(MrMs,f_name,l_name,gender,nic_pass,address,mobile,email) values ('" + cmbMrMrs.Text + "','" + txtFirstname.Text + "','" + txtLastname.Text + "','" + gender + "','" +txtNIC.Text + "','" + txtAddress.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "')";
                        MySqlCommand cmnd = new MySqlCommand(sql, dn.con);
                        cmnd.ExecuteNonQuery();


                        //String sql3 = "select cusId from userbooking where f_name='" + txtFirstname.Text + "' and l_name='" + txtLastname.Text + "'";
                        //MySqlCommand cmd = new MySqlCommand(sql3, dn.con);
                        //MySqlDataReader r = cmd.ExecuteReader();

                        //String cusId = null;
                        //while (r.Read())
                        //{
                        //    cusId = r[0].ToString();
                        //}
                        //dn.con.Close();

                        DBConnect c = new DBConnect();
                       // String sql1 = "Insert into roombook(cusId,chk_in,chk_out,noOfrooms,noOfadults,noOfchild,roomType) values ('" + cusId + "','" + chkinDate.Value.ToString("yyyy-MM-dd") + "','" + chkoutDate.Value.ToString("yyyy-MM-dd") + "','" + txtNoofrooms.Text + "','" + txtNoofadults.Text + "','" + txtNoofchild.Text + "','" + cmbPackage.Text + "')";
                        String sql1 = "Insert into roombook(chk_in,chk_out,noOfrooms,noOfadults,noOfchild,roomType,cusNIC) values ('" + chkinDate.Value.ToString("yyyy-MM-dd") + "','" + chkoutDate.Value.ToString("yyyy-MM-dd") + "','" + txtNoofrooms.Text + "','" + txtNoofadults.Text + "','" + txtNoofchild.Text + "','" + cmbPackage.Text + "','"+txtNIC.Text+"')";
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
        }


       // private void update(String NIC,String MrMsr, String fname, String lname, String gender,String nic,  String addressr, String mobiler, String emailr, String chkin, String chkout, String noofroomsr, String noofadultsr, String noofchildr, String roomtyper)
        private void update(String NIC,String MrMsr, String fname, String lname,String nic,  String addressr, String mobiler, String emailr, String chkin, String chkout, String noofroomsr, String noofadultsr, String noofchildr, String roomtyper)
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

               // String q = "update userbooking set MrMs='" + cmbMrMrs.Text + "',f_name ='" + txtFirstname.Text + "',l_name='" +txtLastname.Text + "',gender='" + gender + "',nic_pass='" + txtNIC.Text + "',address='" + txtAddress.Text + "',mobile='" + txtMobile.Text + "',email='" + txtEmail.Text + "' where nic_pass = '"+txtNIC.Text+"' ; update roombook set chk_in ='" + chkinDate.Value.ToString("yyyy-MM-dd") + "',chk_out='" + chkoutDate.Value.ToString("yyyy-MM-dd") + "',noOfrooms='" + txtNoofrooms.Text+ "',noOfadults='" + txtNoofadults.Text + "',noOfchild='" + txtNoofchild.Text + "',roomType='" + cmbPackage.Text + "' where cusNIC = '"+txtNIC.Text+"'";
                String q = "update userbooking set MrMs='" + cmbMrMrs.Text + "',f_name ='" + txtFirstname.Text + "',l_name='" + txtLastname.Text + "',nic_pass='" + txtNIC.Text + "',address='" + txtAddress.Text + "',mobile='" + txtMobile.Text + "',email='" + txtEmail.Text + "' where nic_pass = '" + txtNIC.Text + "' ; update roombook set chk_in ='" + chkinDate.Value.ToString("yyyy-MM-dd") + "',chk_out='" + chkoutDate.Value.ToString("yyyy-MM-dd") + "',noOfrooms='" + txtNoofrooms.Text + "',noOfadults='" + txtNoofadults.Text + "',noOfchild='" + txtNoofchild.Text + "',roomType='" + cmbPackage.Text + "' where cusNIC = '" + txtNIC.Text + "'";
                    MySqlCommand cmd7 = new MySqlCommand(q, db.con);
                cmd7.ExecuteNonQuery();
                MessageBox.Show(" updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }


        private void updateh(String NIC, String MrMsr, String fname, String lname,  String nic, String addressr, String mobiler, String emailr, String chkin, String chkout, String capacity, String noofperson, String price, String package)
        {
          


            DialogResult d = MessageBox.Show("Are you sure you want to Update this position..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d.Equals(DialogResult.Yes))
            {

                DBConnect db = new DBConnect();

              //  String q = "update userbooking set MrMs='" + cmbMrMrs.Text + "',f_name ='" + txtFirstname.Text + "',l_name='" + txtLastname.Text + "',gender='" + gender + "',nic_pass='" + txtNIC.Text + "',address='" + txtAddress.Text + "',mobile='" + txtMobile.Text + "',email='" + txtEmail.Text + "' where nic_pass = '" + NIC + "' ; update roombook set chk_in ='" + chkinDate.Value.ToString("yyyy-MM-dd") + "',chk_out='" + chkoutDate.Value.ToString("yyyy-MM-dd") + "',noOfrooms='" + txtNoofrooms.Text + "',noOfadults='" + txtNoofadults + "',noOfchild='" + txtNoofchild.Text + "',roomType='" + cmbPackage.Text + "' where cusNIC = '" + NIC + "'";
                String q = "update userbooking set MrMs='" + cmbMrMrs.Text + "',f_name ='" + txtFirstname.Text + "',l_name='" + txtLastname.Text + "',nic_pass='" + txtNIC.Text + "',address='" + txtAddress.Text + "',mobile='" + txtMobile.Text + "',email='" + txtEmail.Text + "' where nic_pass = '" + NIC + "' ; update hallbook set chk_in ='" + chkinDate.Value.ToString("yyyy-MM-dd") + "',chk_out='" + chkoutDate.Value.ToString("yyyy-MM-dd") + "',capacity='" + txtCapacity.Text + "',noOfperson ='" + txtNoperson.Text + "',price='" + txtPrice.Text + "',package='" + cmbHallpackage.Text + "' where cusNIC = '" + NIC + "'";
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
            pnlReport1.Hide();
           // pnlCancelReservation.BringToFront();
        }

        //private void pnlRoombooking_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            availabil a = new availabil("availability",EmployeeID);
            a.Show();
            this.Hide();

        }

        //private void textBox6_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMrMrs.SelectedItem = null;
            cmbPackage.SelectedItem = null;
            txtAddress.Clear();
            txtEmail.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtMobile.Clear();
            txtNIC.Clear();
            txtNoofadults.Clear();
            txtNoofchild.Clear();
            txtNoofrooms.Clear();



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            //update(this.NICToUpdate,cmbMrMrs.Text, txtFirstname.Text, txtLastname.Text,gender, txtNIC.Text, txtAddress.Text,txtMobile.Text,txtEmail.Text, chkinDate.Value.ToString("yyyy-MM-dd"), chkoutDate.Value.ToString("yyyy-MM-dd"),txtNoofrooms.Text,txtNoofadults.Text,txtNoofchild.Text,cmbPackage.Text);
            update(this.NICToUpdate, cmbMrMrs.Text, txtFirstname.Text, txtLastname.Text,txtNIC.Text,  txtAddress.Text, txtMobile.Text, txtEmail.Text, chkinDate.Value.ToString("yyyy-MM-dd"), chkoutDate.Value.ToString("yyyy-MM-dd"), txtNoofrooms.Text, txtNoofadults.Text, txtNoofchild.Text, cmbPackage.Text);
        }

        private void btnHallDetails_Click(object sender, EventArgs e)
        {
            availabil a = new availabil("Halldetails",EmployeeID);
            a.Show();
            this.Hide();

        }

        private void btnCustomerdetail_Click(object sender, EventArgs e)
        {
            availabil a = new availabil("pnlCustomerdetails",EmployeeID);
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


                        //String sql6 = "select cusId from userbooking where f_name='" + txtFirstname.Text + "' and l_name='" + txtLastname.Text + "'";
                        //MySqlCommand cmd = new MySqlCommand(sql6, dt.con);
                        //MySqlDataReader f = cmd.ExecuteReader();

                        //String cusId1 = null;
                        //while (f.Read())
                        //{
                        //    cusId1 = f[0].ToString();
                        //}
                        //dt.con.Close();

                        DBConnect ca = new DBConnect();
                        String sql7 = "Insert into hallbook(chk_in,chk_out,capacity,noOfperson,price,package,cusNIC) values ('" + chkinHall.Value.ToString("yyyy-MM-dd") + "','" + chkoutHall.Value.ToString("yyyy-MM-dd") + "','" + txtCapacity.Text + "','" + txtNoperson.Text + "','" + txtPrice.Text + "','" + cmbHallpackage.Text + "','"+txtNIChall.Text+"')";
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


        /// <summary>
        /// hall validation pahalata
        /// </summary>
        /// <returns></returns>
        private bool Validation()
        {
            //DateTime value;
            //DateTime value1;

            //DateTime selectedDate1 = Convert.ToDateTime(chkinHall.Value);

            //DateTime selectedDate2 = Convert.ToDateTime(chkoutHall.Value);

            DateTime checkin = chkinHall.Value.Date;
            DateTime checkout = chkoutHall.Value.Date;
            DateTime todayDate = DateTime.Today.Date;

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
            else if (String.IsNullOrEmpty(txtNIChall.Text) || !(txtNIChall.Text.Length == 10 || txtNIChall.Text.Length == 12))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtNIChall, "length should be 10 or 12");
            }
            else if (String.IsNullOrEmpty(txtAddresshall.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAddresshall, "Adress is required");
            }
            else if (txtMobilehall.Text.Length != 10 || !Regex.Match(txtMobilehall.Text, "[0-9]{10}").Success)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMobilehall, "length should be 10");
            }

            else if (String.IsNullOrEmpty(txtEmailhall.Text) )
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmailhall, "Email is required");
            }



            else if (checkin < todayDate)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(chkinHall, "chkin date Must be greater then Today's date");
                //MessageBox.Show("chkin date Must be greater then Today's date");
            }
            else if (checkout < checkin)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(chkoutHall, "chkin date Must be greater then check in date");
                //MessageBox.Show("chkout date Must be greater then Today's date");
            }

            //else if (((DateTime.Compare(chkinHall.Value, DateTime.Now)) > 0))
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(chkinHall, "Invalid Date");

            //}
            //else if (((DateTime.Compare(chkoutHall.Value, DateTime.Now)) > 0))
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(chkoutHall, "Invalid Date");
            //}
            // else if (String.IsNullOrEmpty(txtEmailhall.Text))
            // {
            //     errorProvider1.Clear();
            //     errorProvider1.SetError(txtEmailhall, "Email is required");
            //}
            // //else if (!DateTime.TryParse(chkinHall.Text, out value))
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

        //Room validation pahalata
        private bool Validation1() 
            {


                DateTime checkin1 = chkinDate.Value.Date;
                DateTime checkout1 = chkoutDate.Value.Date;
                DateTime todayDate1 = DateTime.Today.Date;


                //DateTime selectedDate3 = Convert.ToDateTime(chkinDate.Value);

                //DateTime selectedDate4 = Convert.ToDateTime(chkoutDate.Value);
                //DateTime todayDate = Convert.ToDateTime(DateTime.Now);
                //DateTime value;
                //DateTime value1;

                bool result = false;
                if (String.IsNullOrEmpty(cmbMrMrs.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbMrMrs, "Name required");
                }
                else if (String.IsNullOrEmpty(txtFirstname.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtFirstname, "firstname required");
                }
                else if (String.IsNullOrEmpty(txtLastname.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtLastname, "lastname required");
                }
                else if (String.IsNullOrEmpty(txtNIC.Text) || !(txtNIC.Text.Length == 10 || txtNIC.Text.Length == 12))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtNIC, "length should be 12");
                }
                else if (String.IsNullOrEmpty(txtAddress.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtAddress, "Adress is required");
                }
                 else if (txtMobile.Text.Length != 10 || !Regex.Match(txtMobile.Text, "[0-9]{10}").Success)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtMobile, "length should be 10");
                }
                else if (String.IsNullOrEmpty(txtEmail.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtEmail, "Email is required");
                }


                else if (checkin1 < todayDate1)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(chkinDate, "chkin date Must be greater then Today's date");
                    //MessageBox.Show("chkin date Must be greater then Today's date");
                }
                else if (checkout1 < checkin1)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(chkoutDate, "chkin date Must be greater then check in date");
                    //MessageBox.Show("chkout date Must be greater then Today's date");
                }
               
                // else if (String.IsNullOrEmpty(txtEmailhall.Text))
                // {
                //     errorProvider1.Clear();
                //     errorProvider1.SetError(txtEmailhall, "Email is required");
                //}
                // //else if (!DateTime.TryParse(chkinHall.Text, out value))
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
                else if (String.IsNullOrEmpty(txtNoofrooms.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtNoofrooms, "Capacity is required");

                }
                else if (String.IsNullOrEmpty(txtNoofadults.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtNoofadults, "No of person is reqired");
                }
                else if (String.IsNullOrEmpty(txtNoofchild.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtNoofchild, "price is required");

                }
                else if (String.IsNullOrEmpty(cmbPackage.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbPackage, "package is reqyired");

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
            updateh(this.NICToUpdate, cmbMrMrs.Text, txtFirstname.Text, txtLastname.Text, txtNIC.Text, txtAddress.Text, txtMobile.Text, txtEmail.Text, chkinDate.Value.ToString("yyyy-MM-dd"), chkoutDate.Value.ToString("yyyy-MM-dd"), txtCapacity.Text, txtNoperson.Text, txtPrice.Text, cmbHallpackage.Text);
        }

        private void btnGeneratequotation_Click(object sender, EventArgs e)
        {
            pnlReport1.Show();
            pnlMain.Hide();
            pnlCancelReservation.Hide();
            pnlHallbooking.Hide();
            pnlWelcome1.Hide();
            pnlWelcome2.Hide();
            pnlRoombooking.Hide();

           // reportTestGihan hn = new reportTestGihan();
            //hn.Show();        
            
        }

        private void btnCustomizeReport_Click(object sender, EventArgs e)
        {
            //customizeReport hm = new customizeReport();
            //hm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfile p = new EmployeeProfile(this.EmployeeID);
            p.Show();
        }

        //private void txtNIC_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void txtNic_TextChanged(object sender, EventArgs e)
        //{
               
        //}
    }
    }
