using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Employee : Form
    {

        
        private float otRate;
        //private float basicSal;
        //private float etf;
        //private float epf;
        //private float leaves;
        //private float ot;
        //private float bonus;
        //private float totDeduction;
        //private float totEarn;
        //private float netpay;


        public Employee()
        {
           
            InitializeComponent();
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pnlPayment.Hide();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            pnlPayment.Show();
            
            
        }

        private void empID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            
            pnlPayment.Hide();
            
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DBConnect db = new DBConnect();

        //        String q = "insert into emp(id,name,age,contact) values ('" + txtID.Text + "','" + txtName.Text + "','" + txtAge.Text + "','" + txtConNum.Text + "')";
        //        MySqlCommand cmd = new MySqlCommand(q, db.con);
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Adding Succesfull", "Done !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch(Exception exep)
        //    {
        //        MessageBox.Show("Error !!!");
        //    }

        //}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btnSrch_Click(object sender, EventArgs e)
        //{
        //    DBConnect db = new DBConnect();
        //    String q = "SELECT * FROM emp WHERE id ='" + txtID.Text + "'";
        //    MySqlCommand cmd = new MySqlCommand(q, db.con);
        //    MySqlDataReader r = cmd.ExecuteReader();

        //    if (r.HasRows)
        //    {
        //        while (r.Read())
        //        {
        //            txtID.Text = r[0].ToString();
        //            txtName.Text = r[1].ToString();
        //            txtAge.Text = r[2].ToString();
        //            txtConNum.Text = r[3].ToString();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No records found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
            

        //{
        //    try
        //    {
        //        DialogResult d = MessageBox.Show("Are you sure you want to update your details...?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (d.Equals(DialogResult.Yes))
        //        {
        //            DBConnect db = new DBConnect();
        //            String q = "update emp set name='" + txtName.Text + "',age ='" + txtAge.Text + "',contact='" + txtConNum.Text + "' where id = '"+txtID+"'";
        //            MySqlCommand cmd = new MySqlCommand(q, db.con);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Details updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception exep)
        //    {
        //        MessageBox.Show("Your Details is already added");
        //    }
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            float totDeduction = 0;
            float totEarn = 0;
            float basicSal = 0;
            //float epf = 0;
            float etf = 0;
            float netSal = 0;


            if (ValidationEmployeeSalary())
            {


                using (DBConnect db = new DBConnect())
                {
                    String q = "SELECT * FROM employee WHERE employeeNo ='" + txtEmpID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    MySqlDataReader r = cmd.ExecuteReader();



                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            txtEmpID.Text = r[0].ToString();
                            txtEmpName.Text = r[1].ToString();
                            txtDesignation.Text = r[7].ToString();

                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("No employees found!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

                using (DBConnect db = new DBConnect())
                {
                    String y = "SELECT * FROM employeesalarydetails WHERE type ='" + txtDesignation.Text + "'";
                    MySqlCommand cmd1 = new MySqlCommand(y, db.con);
                    MySqlDataReader r1 = cmd1.ExecuteReader();
                    if (r1.HasRows)
                    {
                        while (r1.Read())
                        {
                            basicSal = float.Parse(r1[1].ToString());
                            txtBasicSal.Text = "Rs." + r1[1].ToString() + ".00";
                            totEarn = basicSal;

                        }

                    }
                    else
                    {
                        MessageBox.Show("No employees found!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



                using (DBConnect db = new DBConnect())
                {
                    String z = "SELECT valueID,value FROM globalvalues ";
                    MySqlCommand cmd2 = new MySqlCommand(z, db.con);
                    MySqlDataReader r2 = cmd2.ExecuteReader();

                    if (r2.HasRows)
                    {
                        // otHours = float.Parse(r2[2].ToString());
                        while (r2.Read())
                        {
                            if (r2[0].ToString().Equals("epf"))
                            {

                                txtEPF.Text = "Rs." + (basicSal * float.Parse(r2[1].ToString())).ToString() + ".00";
                            }
                            else if (r2[0].ToString().Equals("etf"))
                            {
                                etf = (basicSal * float.Parse(r2[1].ToString()));
                                totDeduction = totDeduction + etf;
                                txtETF.Text = "Rs." + (basicSal * float.Parse(r2[1].ToString())).ToString() + ".00";
                            }
                            else if (r2[0].ToString().Equals("ot"))
                            {
                                otRate = float.Parse(r2[1].ToString());
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("No records found!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                using (DBConnect db = new DBConnect())
                {
                    String today = DateTime.Today.ToString("yyyy-MM-dd");
                    String[] dayArray = today.Split('-');
                    String thisMonth = dayArray[1];
                    String thisYear = dayArray[0];

                    String ot = "SELECT TIMEDIFF(outTime,inTime) FROM `employee_attendance` WHERE employeeNo ='" + txtEmpID.Text + "' and date between '" + thisYear + "-" + thisMonth + "-01" + "' and '" + thisYear + "-" + thisMonth + "-30" + "' ";
                    MySqlCommand cmd = new MySqlCommand(ot, db.con);
                    MySqlDataReader dr = cmd.ExecuteReader();


                    float totalOtAmout = 0;
                    float totalOtHours = 0;



                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            String otHourString = dr[0].ToString();
                            String[] otHourStringArray = otHourString.Split(':');
                            float otHour = float.Parse(otHourStringArray[0]);


                            if (otHour > 8)
                            {
                                totalOtHours = totalOtHours + (otHour - 8);
                            }
                        }

                        totalOtAmout = totalOtHours * otRate;
                        txtOT.Text = "Rs. " + totalOtAmout + ".00";

                        totEarn = totEarn + totalOtAmout;
                    }
                    else
                    {
                        MessageBox.Show("No records found!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

                lblPaydate.Text = DateTime.Today.ToString("yyyy MMMM" + "30");
                lblPaydate.Visible = true;

                txtTotEarn.Text = "Rs. " + totEarn + " .00";
                txtTotDeduction.Text = "Rs. " + totDeduction + " .00";

                netSal = totEarn - totDeduction;
                txtNetSal.Text = "Rs. " + netSal + " .00";


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidationEmployeeSalary())
            {
            PaysheetViewer p = new PaysheetViewer(txtEmpName.Text,txtEmpID.Text,txtDesignation.Text,txtBasicSal.Text,txtLeaves.Text,txtOT.Text,txtEPF.Text,txtTotEarn.Text,txtTotDeduction.Text,txtNetSal.Text,lblPaydate.Text);       

            p.Show();
        }
        }

        private void txtBasicSal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void datePaydate_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool ValidationEmployeeSalary()
        {

            bool result = false;
            if (String.IsNullOrEmpty(txtEmpID.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmpID, "Employee ID is required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private void txtLeaves_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                try
                {
                    DBConnect db = new DBConnect();

                    String q = "insert into emp_salary(id,basicSalary,etf,epf,leaves,ot,bonus,totDeduction,totEarn,netpay,paydate) values ('" + txtEmpID.Text + "','" + txtBasicSal.Text + "','" + txtETF.Text + "','" + txtEPF.Text + "','" + txtLeaves.Text + "','" + txtOT.Text + "','" + txtTotDeduction.Text + "','" + txtTotEarn.Text + "','" + txtNetSal.Text + "','" + lblPaydate.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deducted", "Done !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception exep)
                {
                    MessageBox.Show("Error !!!");
                }

            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlPayment_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}


