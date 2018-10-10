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
    public partial class availabil : Form
    {
        String panel;

        public availabil()
        {
            InitializeComponent();
        }
        public availabil(String p)
        {
            InitializeComponent();
            panel = p;

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstname_Click(object sender, EventArgs e)
        {

        }

        private void lblsearchname_Click(object sender, EventArgs e)
        {

        }

        private void lblseachcateg_Click(object sender, EventArgs e)
        {

        }

        public void showPanelCustomerDetail()
        {
            pnlCustomerdetails.Show();
        }

        private void availabil_Load(object sender, EventArgs e)
        {
            if (panel == "pnlCustomerdetails")
            {
                pnlCustomerdetails.Show();
                pnlHalldetails.Hide();
                pnlCheckAvailability.Hide();


                retrieve();
            }
            else if (panel == "Halldetails")
            {
                pnlCustomerdetails.Hide();
                pnlHalldetails.Show();
                pnlCheckAvailability.Hide();


                retrieve2();
            }
            else if (panel == "availability")
            {
                pnlCheckAvailability.BringToFront();
                pnlHalldetails.Hide();
                pnlCustomerdetails.Hide();
                //retrieve1();
            }


        }



        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void retrieve()
        {
            DBConnect db = new DBConnect();
            MySqlCommand cmd = db.con.CreateCommand();
            cmd.CommandText = "select u.cusId,u.MrMs,u.f_name,u.l_name,u.gender,u.nic_pass,u.address,u.mobile,u.email,r.roomType,r.chk_in,r.chk_out,r.noOfrooms,r.noOfadults,r.noOfchild,r.bookingId from roombook r,userbooking u where r.cusId = u.cusId";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCustomerDetails.DataSource = dt;
        }
        //private void retrieve1()
        //{
        //    DBConnect db = new DBConnect();
        //    MySqlCommand cmd = db.con.CreateCommand();
        //    cmd.CommandText = "select r.roomType,r.chk_in,r.chk_out,r.bookingId from roombook r,userbooking u where r.cusId = u.cusId";
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    dgvCheckAvailability.DataSource = dt;
        //}
        private void retrieve2()
        {

            DBConnect df = new DBConnect();
            MySqlCommand cmd = df.con.CreateCommand();
            cmd.CommandText = "select u.cusId,u.MrMs,u.f_name,u.l_name,u.gender,u.nic_pass,u.address,u.mobile,u.email,h.package ,h.chk_in,h.chk_out,h.capacity,h.noOfperson,h.price from hallbook h,userbooking u where h.custId = u.cusId";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvHallDetails.DataSource = dt;







        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHalldetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCheckAvailability_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        bool close = true;
        private void availabil_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (close)
            {
                //DialogResult result = MessageBox.Show("Are you sure want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (result == DialogResult.Yes)
                //{
                close = false;
                this.Close();
                frmReceptionist f = new frmReceptionist();
                f.Show();



                //    }
                //    else
                //    {
                //        e.Cancel = true;


                //    }
                //}
            }
        }

        private void btnDeletedgr_Click(object sender, EventArgs e)
        {

            //try
            //{
            DialogResult d = MessageBox.Show("Are you sure you want to Delete this position..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d.Equals(DialogResult.Yes))
            {

                DBConnect db = new DBConnect();

                String q = "delete from userbooking where cusId='" + txtCusID.Text + "'; delete from roombook where  cusId = '" + txtCusID.Text + "'";
                MySqlCommand cmd7 = new MySqlCommand(q, db.con);
                cmd7.ExecuteNonQuery();
                MessageBox.Show(" Deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("already Deleted");
            //}

            retrieve();
        }

        private void dgvCustomerDetails_MouseClick(object sender, MouseEventArgs e)
        {
            txtCusID.Text = dgvCustomerDetails.SelectedRows[0].Cells[0].Value.ToString();
        }
        private void dgvHallDetails_MouseClick(object sender, MouseEventArgs e)
        {
            txtCusID1.Text = dgvHallDetails.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnUpdatedgr_Click(object sender, EventArgs e)
        {
            //DBConnect de = new DBConnect();

            //int cusId2;
            //cusId2 = Convert.ToInt32(dgvCustomerDetails.SelectedCells[0].Value.ToString());
            //String q = "select * from userbooking where cusId='" + txtCusID.Text + "'; select * from roombook where  cusId = '" + txtCusID.Text + "'";
            //MySqlCommand cmd9 = new MySqlCommand(q, de.con);
            //cmd9.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //MySqlDataAdapter da = new MySqlDataAdapter(cmd9);
            //da.Fill(dt);
            ////dgvCustomerDetails.DataSource = dt;

            //foreach (DataRow dr in dt.Rows)
            //{

            //  cmbMrMrs.Text = dr["MrMs"].ToString();







        }

        private void dgvHallDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmReceptionist f2 = new frmReceptionist("hallbooking", txtCusID1.Text);
            f2.cmbMrMsH.Text = this.dgvHallDetails.CurrentRow.Cells[1].Value.ToString();
            f2.txtFirstnamehall.Text = this.dgvHallDetails.CurrentRow.Cells[2].Value.ToString();
            f2.txtLastnameHall.Text = this.dgvHallDetails.CurrentRow.Cells[3].Value.ToString();

            f2.txtNIChall.Text = this.dgvHallDetails.CurrentRow.Cells[5].Value.ToString();
            f2.txtAddresshall.Text = this.dgvHallDetails.CurrentRow.Cells[6].Value.ToString();
            f2.txtMobilehall.Text = this.dgvHallDetails.CurrentRow.Cells[7].Value.ToString();
            f2.txtEmailhall.Text = this.dgvHallDetails.CurrentRow.Cells[8].Value.ToString();
            f2.cmbHallpackage.Text = this.dgvHallDetails.CurrentRow.Cells[9].Value.ToString();
            DateTime chkinHall = DateTime.Parse(this.dgvHallDetails.CurrentRow.Cells[10].Value.ToString());

            f2.chkinDate.Value = chkinHall;

            DateTime chkoutHall = DateTime.Parse(this.dgvHallDetails.CurrentRow.Cells[11].Value.ToString());
            f2.chkoutDate.Value = chkoutHall;
            f2.txtCapacity.Text = this.dgvHallDetails.CurrentRow.Cells[12].Value.ToString();
            f2.txtNoperson.Text = this.dgvHallDetails.CurrentRow.Cells[13].Value.ToString();
            f2.txtPrice.Text = this.dgvHallDetails.CurrentRow.Cells[14].Value.ToString();
            f2.pnlHallbooking.BringToFront();
            f2.Show();
            this.Close();



        }

        private void dgvCustomerDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmReceptionist f2 = new frmReceptionist("roomBooking", txtCusID.Text);
            f2.cmbMrMrs.Text = this.dgvCustomerDetails.CurrentRow.Cells[1].Value.ToString();
            f2.txtFirstname.Text = this.dgvCustomerDetails.CurrentRow.Cells[2].Value.ToString();
            f2.txtLastname.Text = this.dgvCustomerDetails.CurrentRow.Cells[3].Value.ToString();

            f2.txtNic.Text = this.dgvCustomerDetails.CurrentRow.Cells[5].Value.ToString();
            f2.txtAddress.Text = this.dgvCustomerDetails.CurrentRow.Cells[6].Value.ToString();
            f2.txtMobile.Text = this.dgvCustomerDetails.CurrentRow.Cells[7].Value.ToString();
            f2.txtEmail.Text = this.dgvCustomerDetails.CurrentRow.Cells[8].Value.ToString();
            f2.cmbPackage.Text = this.dgvCustomerDetails.CurrentRow.Cells[9].Value.ToString();
            DateTime chkin = DateTime.Parse(this.dgvCustomerDetails.CurrentRow.Cells[10].Value.ToString());

            f2.chkinDate.Value = chkin;

            DateTime chkout = DateTime.Parse(this.dgvCustomerDetails.CurrentRow.Cells[11].Value.ToString());
            f2.chkoutDate.Value = chkout;
            f2.txtNoofrooms.Text = this.dgvCustomerDetails.CurrentRow.Cells[12].Value.ToString();
            f2.txtNoofadults.Text = this.dgvCustomerDetails.CurrentRow.Cells[13].Value.ToString();
            f2.txtNoofchild.Text = this.dgvCustomerDetails.CurrentRow.Cells[14].Value.ToString();
            f2.pnlRoombooking.BringToFront();
            f2.Show();
            this.Close();



        }

        private void pnlCheckAvailability_Paint(object sender, PaintEventArgs e)
        {

        }

        private DataTable loadCheckAvailability(String fromDate, String toDate)
        {
            DataTable dt = new DataTable();


            if (cmbPackage.Text == "Room")
            {

                dt.Columns.Add("Room Type", typeof(String));
                dt.Columns.Add("No of rooms available", typeof(int));

                using (DBConnect db = new DBConnect())
                {
                    String q = "select roomType,noOfrooms from rooms";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    MySqlDataReader r = cmd.ExecuteReader();

                    while (r.Read())
                    {
                        String roomType = r[0].ToString();
                        String noOfTotalRooms = r[1].ToString();

                        using (DBConnect db1 = new DBConnect())
                        {
                            String q1;

                            if (toDate == null)
                            {
                                q1 = "SELECT roomType,sum(noOfrooms) FROM roombook where chk_in <= '" + fromDate + "' and chk_out >= '" + fromDate + "' and roomType = '" + roomType + "' GROUP by roomType";

                            }
                            else
                            {
                                q1 = "SELECT roomType,sum(noOfrooms) FROM roombook where( (chk_in <= '" + fromDate + "' and chk_out >= '" + toDate + "') OR (chk_out >= '" + fromDate + "' and chk_out <= '" + toDate + "') OR (chk_in>= '" + fromDate + "' and chk_in <= '" + toDate + "') )and roomType = '" + roomType + "' GROUP by roomType";
                            }
                            MySqlCommand cmd1 = new MySqlCommand(q1, db1.con);
                            MySqlDataReader r1 = cmd1.ExecuteReader();
                            if (r1.HasRows)
                            {
                                while (r1.Read())
                                {
                                    String bookedRooms = r1[1].ToString();
                                    int availableRooms = Int32.Parse(noOfTotalRooms) - Int32.Parse(bookedRooms);

                                    if (availableRooms >= 0)
                                    {
                                        dt.Rows.Add(roomType, availableRooms);
                                    }
                                    else
                                    {
                                        dt.Rows.Add(roomType, 0);
                                    }
                                }
                            }
                            else
                            {
                                dt.Rows.Add(roomType, Int32.Parse(noOfTotalRooms));
                            }
                        }
                    }
                }


            }
            else
            {

                dt.Columns.Add("hall Type", typeof(String));
                dt.Columns.Add("No of halls ", typeof(int));
                using (DBConnect de = new DBConnect())
                {

                    String q2 = "select hallType,noOfhalls from halls";
                    MySqlCommand cmd = new MySqlCommand(q2, de.con);
                    MySqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        String package = r[0].ToString();
                        String noOfhalls = r[1].ToString();

                        using (DBConnect db1 = new DBConnect())
                        {
                            String q3;

                            if (toDate == null)
                            {
                                q3 = "SELECT package FROM hallbook where chk_in <= '" + fromDate + "' and chk_out >= '" + fromDate + "' and package = '" + package + "' GROUP by package";

                            }
                            else
                            {
                                q3 = "SELECT package FROM hallbook where( (chk_in <= '" + fromDate + "' and chk_out >= '" + toDate + "') OR (chk_out >= '" + fromDate + "' and chk_out <= '" + toDate + "') OR (chk_in>= '" + fromDate + "' and chk_in <= '" + toDate + "') )and package = '" + package + "' GROUP by package";
                            }

                            MySqlCommand cmd1 = new MySqlCommand(q3, db1.con);
                            MySqlDataReader r2 = cmd1.ExecuteReader();
                            if (r2.HasRows)
                            {
                                while (r2.Read())
                                { 
                                    String bookedhalls = r2[1].ToString();
                                    int availablehalls = Int32.Parse(noOfhalls) - Int32.Parse(bookedhalls);

                                    if (availablehalls >= 0)
                                    { 
                                        dt.Rows.Add(package, availablehalls);
                                    }
                                    else
                                    {
                                        dt.Rows.Add(package, 0);
                                    }
                                }
                            }
                            else
                            {
                                dt.Rows.Add(package, Int32.Parse(noOfhalls));
                            }
                        }
                    }
                }
            }

            return dt;


        }


            //private void button5_Click(object sender, EventArgs e)
            //{
            //    String fromdate = chkin1.Value.ToString("yyyy-MM-dd");
            //    String todate = chkout2.Value.ToString("yyyy-MM-dd");

            //    if (chkout2.Value.ToString("yyyy-MM-dd").Equals(DateTime.Today.ToString("yyyy-MM-dd")))
            //    {
            //        todate = null;
            //    }
            //    Console.WriteLine("Todate : " + todate);
            //    dgvCheckAvailability.DataSource = loadCheckAvailability(fromdate, todate);
            //}

            private void btnSearch_Click(object sender, EventArgs e)
            {
                GenerateQuotaions g = new GenerateQuotaions();
                g.Show();
            }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            String fromdate = chkin1.Value.ToString("yyyy-MM-dd");
            String todate = chkout2.Value.ToString("yyyy-MM-dd");

            if (chkout2.Value.ToString("yyyy-MM-dd").Equals(DateTime.Today.ToString("yyyy-MM-dd")))
            {
                todate = null;
            }
            Console.WriteLine("Todate : " + todate);
            dgvCheckAvailability.DataSource = loadCheckAvailability(fromdate, todate);
        }
    }

}
     
    
