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
    public partial class frmBar : Form
    {
        String EmployeeID = null;


        public frmBar()
        {
            InitializeComponent();
        }

        public frmBar(String EmployeeID)
        {
            this.EmployeeID = EmployeeID;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlOrder.BringToFront();
            //pnlOrder.Show();
            //panel2.Hide();
            //pnlAddItems.Hide();
            //pnlbev.Hide();
            //pnlHome.Hide();
            //pnlLiquor.Hide();
            //pnlStockHandle.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlAddItems.BringToFront();

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlHome.BringToFront();
            retrieve();
        }

        public void retrieve()
        {
            dgvOrders.DataSource = loadData();
        }
        public DataTable loadData() {

            DataTable dt = new DataTable();

            DBConnect db = new DBConnect();

            String q = "Select stockID as 'Stock ID',brandName as 'Brand Name',quantity as 'Quantity',type as 'Type',volume as 'Volume' from stock";
            MySqlCommand cmd = new MySqlCommand(q, db.con);
            MySqlDataReader r = cmd.ExecuteReader();

            dt.Load(r);

            return dt;
        
        }

        private void dgvOrders_MouseClick(object sender, MouseEventArgs e)
        {
            txtStockID.Text = dgvOrders.SelectedRows[0].Cells[0].Value.ToString();
            txtQuantity.Value = Int32.Parse(dgvOrders.SelectedRows[0].Cells[2].Value.ToString());
            cmbBrand.Text = dgvOrders.SelectedRows[0].Cells[1].Value.ToString();
            cmbType.Text = dgvOrders.SelectedRows[0].Cells[3].Value.ToString();
            cmbVolume.Text = dgvOrders.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbBrand.Text == "" || txtQuantity.Value == 0 || cmbType.Text == "" || cmbVolume.Text =="")
                {
                    MessageBox.Show("Invalid values. You have to insert a brand name and quantiy both", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DBConnect db = new DBConnect();

                    DialogResult d = MessageBox.Show("Are you sure you want to add this product..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (d == DialogResult.Yes)
                    {
                        String q = "insert into stock(brandName,quantity,type,volume) values('" + cmbBrand.Text + "','" + txtQuantity.Value.ToString() + "','" + cmbType.Text + "','" + cmbVolume.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(q, db.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product inserted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retrieve();
                        txtStockID.Text = "";
                        txtQuantity.Value = 0;
                        cmbBrand.Text = "";
                        cmbType.SelectedItem = "";
                        cmbVolume.SelectedItem = "";
                    }
                }
            }
            catch (Exception ex)
            {
                
               MessageBox.Show("You are trying to insert the product "+cmbBrand.Text+" more than once. Try pressing update button", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbBrand.Text == "" || txtQuantity.Value == 0 || cmbType.Text == "" || cmbVolume.Text == "")
                {
                    MessageBox.Show("Invalid values. You have to insert a brand name and quantiy both", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DBConnect db = new DBConnect();

                    DialogResult d = MessageBox.Show("Are you sure you want to update the quantity of this product..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (d == DialogResult.Yes)
                    {
                        String q = "update stock set quantity = '"+txtQuantity.Value.ToString()+"',type = '"+cmbType.Text+"' where stockID = '"+txtStockID.Text+"' and brandName ='"+cmbBrand.Text+"'";
                        MySqlCommand cmd = new MySqlCommand(q, db.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product updated successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retrieve();
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                //MessageBox.Show("You are trying to insert the product " + cmbBrand.Text + " more than once. Try pressing update button", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clear()
        {
            txtStockID.Text = "";
            txtQuantity.Value = 0;
            cmbBrand.Text = "";
            cmbType.Text = "";
            cmbVolume.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbBrand.Text == "" || txtQuantity.Value == 0)
                {
                    MessageBox.Show("Invalid values. You have to insert a brand name and quantiy both", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DBConnect db = new DBConnect();

                    DialogResult d = MessageBox.Show("Are you sure you want to Delete this product..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (d == DialogResult.Yes)
                    {
                        String q = "Delete from stock where stockID = '"+txtStockID.Text+"'";
                        MySqlCommand cmd = new MySqlCommand(q, db.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product deleted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retrieve();
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                //MessageBox.Show("You are trying to insert the product " + cmbBrand.Text + " more than once. Try pressing update button", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlStockHandle.BringToFront();
            //////////pnlLiquor.Hide();
            //////////pnlHome.Hide();
            //////////pnlbev.Hide();
            //////////panel1.Hide();
            //////////panel2.Hide();
            //////////panel4.Hide();
        }

        private void btnbeverages_Click(object sender, EventArgs e)
        {
            pnlbev.BringToFront();
            //cmbBrandBev.DataSource = loadBeverages();

          
        }
        private List<String> loadBeverages()
        {

            List<String> bevs = new List<String>();
            using (DBConnect db = new DBConnect())
            {
                String q = "SELECT `brandName` FROM `stock` where type = 'beverage' ";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    bevs.Add(r[0].ToString());
                }
            }
            return bevs;
        }
        private List<String> loadLiquors()
        {

            List<String> bevs = new List<String>();
            using (DBConnect db = new DBConnect())
            {
                String q = "SELECT DISTINCT(brandName) FROM `stock` where type = 'liquor' AND quantity > 0";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    bevs.Add(r[0].ToString());
                }
            }
            return bevs;
        }


        private void btnliquor_Click(object sender, EventArgs e)
        {
            pnlLiquor.BringToFront();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
          
            using (DBConnect db = new DBConnect())
            {
                String q = "insert into adddrinks(brand,type,qty,costPrice) values('" + cmbBrandAdd.Text + "','" + cmbTypeAdd.Text + "','" + txtQty.Text + "','" + txtCostpriceAdd.Text + "')";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                cmd.ExecuteNonQuery();
                
            }

            MessageBox.Show("Adding Succesfull", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }


        private void btnBevOrder_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != "" && cmbBrandBev.Text != "" && cmbTypeBev.Text != "" && numQtyBev.Value != 0)
            {
                using (DBConnect db = new DBConnect())
                {


                    String t = "insert into orderbeverages(customerID,brand,type,qty) values('" + txtCustomerID.Text + "','" + cmbBrandBev.Text + "','" + cmbTypeBev.Text + "','" + numQtyBev.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(t, db.con);
                    cmd.ExecuteNonQuery();
                }

                using (DBConnect db = new DBConnect())
                {
                    String q = "update stock set quantity = quantity - '" + numQtyBev.Value.ToString() + "' where brandName = '" + cmbBrandBev.Text + "'and volume='" + cmbTypeBev.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    retrieve();
                }
                MessageBox.Show("Adding Succesfull", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbBrandBev.Text = "";
                cmbTypeBev.Text = "";
                numQtyBev.Value = 0;
                txtCustomerID.Clear();
                txtCustomerID.Focus();
            }
            else
            {
                MessageBox.Show("Field should not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLiqAddOrder_Click(object sender, EventArgs e)
         {
             if (txtcustmID.Text != "" && cmbLiqBrand.Text != "" && cmbTypeLiq.Text != "" && numQtyLic.Value != 0)
            {
          
                using (DBConnect db = new DBConnect())
                {
                    String liq = "insert into orderliquor(customerID,brand,type,qty) values('" + txtcustmID .Text+ "','" + cmbLiqBrand.Text + "','" + cmbTypeLiq.Text + "','" + numQtyLic.Value + "')";
                MySqlCommand cmd = new MySqlCommand(liq, db.con);
                cmd.ExecuteNonQuery();
   
                }
                using (DBConnect db = new DBConnect())
                {
                    String q = "update stock set quantity = quantity - '" + numQtyLic.Value.ToString() + "' where brandName = '" + cmbLiqBrand.Text + "' and volume='" + cmbTypeLiq .Text+ "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    retrieve();
                }
                MessageBox.Show("Adding Succesfull", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbLiqBrand.Text = "";
                cmbTypeLiq.Text = "";
                numQtyLic.Value = 0;
                txtcustmID.Clear();
                txtcustmID.Focus();
            }
            else
            {
                MessageBox.Show("Field should not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        private void btnLiqClear_Click(object sender, EventArgs e)
        {
            cmbLiqBrand.Text = "";
            cmbTypeLiq.Text = "";
            numQtyLic.Value = 0;
        }

        private void btnBevClear_Click(object sender, EventArgs e)
        {
            cmbBrandBev.Text = "";
            cmbTypeBev.Text = "";
            numQtyBev.Value = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbBrandBev_MouseClick(object sender, MouseEventArgs e)
        {
            cmbBrandBev.DataSource = loadBeverages();
        }

        private void cmbBrand_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            dgvBill.DataSource = loadBill();
            
        }
        private DataTable loadBill()
        {
            float total = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("Brand", typeof(String));
            dt.Columns.Add("Volume", typeof(String));
            dt.Columns.Add("Quantity", typeof(String));
            dt.Columns.Add("Price", typeof(float));


            using (DBConnect db = new DBConnect())
            {
                String q = "SELECT `brand`,`type`,`qty` FROM `orderbeverages` WHERE `customerID` = '" + txtCusID.Text + "'";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    String brand = r[0].ToString();
                    String type = r[1].ToString();
                    String qty = r[2].ToString();

                    using (DBConnect db1 = new DBConnect())
                    {
                        String q1 = "SELECT `sellingPrice` FROM `bar_manage` WHERE `brandName` ='" + brand + "' and `volume` = '" + type + "'";
                        MySqlCommand cmd1 = new MySqlCommand(q1, db1.con);
                        MySqlDataReader r1 = cmd1.ExecuteReader();

                        while (r1.Read())
                        {
                            String price = r1[0].ToString();
                            dt.Rows.Add(brand, type, qty, price);
                            total = total + float.Parse(price);
                        } 
                    }
                    
                }
            }
            using (DBConnect db = new DBConnect())
            {
                String q = "SELECT `brand`,`type`,`qty` FROM `orderliquor` WHERE `customerID` = '" + txtCusID.Text + "'";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    String brand = r[0].ToString();
                    String type = r[1].ToString();
                    String qty = r[2].ToString();

                    using (DBConnect db1 = new DBConnect())
                    {
                        String q1 = "SELECT `sellingPrice` FROM `bar_manage` WHERE `brandName` ='" + brand + "' and `volume` = '" + type + "'";
                        MySqlCommand cmd1 = new MySqlCommand(q1, db1.con);
                        MySqlDataReader r1 = cmd1.ExecuteReader();

                        while (r1.Read())
                        {
                            String price = r1[0].ToString();
                            dt.Rows.Add(brand, type, qty, price);
                            total = total + float.Parse(price);
                        }
                    }

                }
            }
            lblTot.Text = "Rs. " + total.ToString() + ".00";
            return dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlConfirmOrder.BringToFront();
            txtCusID.Focus();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtCusID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSerach_Click(sender, e);
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {





            foreach (DataGridViewRow r in dgvBill.Rows)
            {
                String brand = r.Cells[0].Value.ToString();
                String volume = r.Cells[1].Value.ToString();
                String qty = r.Cells[2].Value.ToString();
                String price = r.Cells[3].Value.ToString();

                using (DBConnect db = new DBConnect())
                {
                    String con = "insert into confirm_order(customerID,brand,volume,qty,price) values('"+txtCusID.Text+"','"+brand+"','"+volume+"','"+qty+"','"+price+"')";
                    MySqlCommand cmd = new MySqlCommand(con, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adding Succesfull", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
               
            }


            //DBConnect db = new DBConnect();

            //String con = "insert into confirm_order(customerID,brand,volume,qty,price) values('" + cmbLiqBrand.Text + "','" + cmbTypeLiq.Text + "','" + numQtyLic.Text + "')";
            //MySqlCommand cmd = new MySqlCommand(con, db.con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Adding Succesfull", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void pnlStockHandle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmbBrandAdd.Text = "";
            cmbTypeAdd.Text = "";
            txtQty.Value = 0;
            txtCostpriceAdd.Text = "";
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBrandBev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLiqBrand_MouseClick(object sender, MouseEventArgs e)
        {
            cmbLiqBrand.DataSource = loadLiquors();
        }

        private void cmbTypeLiq_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private List<String> loadLiquorType()
        {
            using (DBConnect db = new DBConnect())
            {
                List<String> type = new List<String>();
                String q = "select volume from stock where brandName = '" + cmbLiqBrand.Text + "' and quantity > 0";
                MySqlCommand cmd = new MySqlCommand(q, db.con);
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    type.Add(r[0].ToString());
                }
                return type;
            }
           
        }

        private void cmbLiqBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTypeLiq.DataSource = loadLiquorType();
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfile emp = new EmployeeProfile(this.EmployeeID);
            emp.Show();
        }
    }
}
