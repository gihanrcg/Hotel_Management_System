using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceRecorder
{
    public partial class frmMenu : Form
    {
        DialogResult dr;
        MySqlCommand cmd;
        public frmMenu()
        {
            InitializeComponent();
            pnlOrderFood.Visible = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            displayMenuCard();
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {
            pnlFoodMenu.Visible = false;
            txtCustId.Clear();
            pnlOrderFood.Visible = true;
            displayMenu();
            displayMenuID();

        }

        private void btnDisplayMenu_Click(object sender, EventArgs e)
        {
            displayMenuCard();
            pnlOrderFood.Visible = false;
            pnlFoodMenu.Visible = true;
        }

        public void displayMenuID()
        {
            DBConnect db = new DBConnect();
            cmd = db.con.CreateCommand();
            //MessageBox.Show(cmbItemName.SelectedItem.ToString());
            string slctName = "SELECT Menu_ID FROM menu_items WHERE Item = '" + cmbMenu.SelectedItem.ToString() + "'";
            cmd = new MySqlCommand(slctName, db.con);
            MySqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtMenuId.Text = dr.GetInt32("Menu_ID").ToString();
                }
                db.con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void displayMenu()
        {
            DBConnect db = new DBConnect();
            cmd = db.con.CreateCommand();
            List<String> list = new List<String>();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Item FROM menu_items";

            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                list.Add(r[0].ToString());
            }

            cmbMenu.DataSource = list;
            //lblitemcount.text = list.count.tostring() + " items";

            db.con.Close();
        }

        public void pricePerPortion()
        {
            DBConnect db = new DBConnect();
            cmd = db.con.CreateCommand();
            //MessageBox.Show(cmbItemName.SelectedItem.ToString());
            string slctName = "SELECT Price_Per_Portion FROM menu_items WHERE Portion = '" + cmbPortion.SelectedItem.ToString() + "'";
            cmd = new MySqlCommand(slctName, db.con);
            MySqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtPricePerPortion.Text = dr.GetInt32("Price_Per_Portion").ToString();
                }
                db.con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmbPortion_SelectedIndexChanged(object sender, EventArgs e)
        {
            pricePerPortion();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            String curTime = DateTime.Today.ToString("yyyy-MM-dd");

            if (String.IsNullOrEmpty(txtPricePerPortion.Text) == false && String.IsNullOrEmpty(cmbPortion.Text) == false && (nudQtyOrder.Value) != 0)
            {
                dr = MessageBox.Show("Are you sure you place this Order..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr.Equals(DialogResult.Yes))
                {
                    try
                    {
                        DBConnect db = new DBConnect();
                        cmd = db.con.CreateCommand();
                        int qty = Convert.ToInt32(Math.Round(nudQtyOrder.Value, 0));
                        float pricePerPortion = Convert.ToInt32(txtPricePerPortion.Text);
                        float totalPrice = qty * pricePerPortion;

                        String ins = "INSERT INTO order_items(Customer_ID,Menu_ID,Item,Portion,Price_Per_Portion,QTY,Total_Price,Time) VALUES ('" + txtCustId.Text + "','" + txtMenuId.Text + "','" + cmbMenu.Text + "','" + cmbPortion.Text + "','" + pricePerPortion + "','" + qty + "','" + totalPrice + "','" + curTime + "')";
                        cmd = new MySqlCommand(ins, db.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order Placed");
                        db.con.Close();

                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
            else
            {
                MessageBox.Show("All the fields are required to be filled", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            clearOrder();
        }

        public void clearOrder()
        {
            txtPricePerPortion.Clear();
            nudQtyOrder.Value = 0;
        }

        public void displayMenuCard()
        {
            DBConnect db = new DBConnect();
            cmd = db.con.CreateCommand();

            String slct = "SELECT * FROM order_items ORDER BY Customer_ID";
            cmd = new MySqlCommand(slct, db.con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dtgMenu.DataSource = dt;

            db.con.Close();
        }
    }
}
