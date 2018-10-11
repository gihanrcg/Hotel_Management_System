using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceRecorder
{
    public partial class frmInventory : Form
    {
        String EmployeeID = null;

        DialogResult dr;
        MySqlCommand cmd;
        public frmInventory()
        {
            InitializeComponent();

        }
        public frmInventory(String employeeID)
        {
            InitializeComponent();
            this.EmployeeID = employeeID;

        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            dtgInventory.Visible = false;
            pnlInsertInventory.Visible = false;
            pnlRunningOut.Visible = false;
            pnlViewInventory.Visible = true;
            dtgInventory.Visible = false;
            pnlUpdateInventory.Visible = false;
            btnDeleteItems.Visible = false;
            txtSearch.Visible = false;
            lblSearch.Visible = false;
            btnRunningOut.Visible = false;

            fillItemName();
            runningOut();
        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            pnlRunningOut.Visible = false;
            pnlCover.Visible = false;
            pnlViewInventory.Visible = true;
            dtgInventory.Visible = true;
            txtSearch.Visible = true;
            lblSearch.Visible = true;
            pnlInsertInventory.Visible = false;
            pnlUpdateInventory.Visible = false;
            DBConnect db = new DBConnect();
            cmd = db.con.CreateCommand();

            String slct = "SELECT * FROM inventory ORDER BY ID";
            cmd = new MySqlCommand(slct, db.con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dtgInventory.DataSource = dt;

            btnDeleteItems.Visible = true;
            db.con.Close();

        }

        void runningOut()
        {
            DBConnect db = new DBConnect();
            cmd = db.con.CreateCommand();

            String lack = "SELECT ID, Name, Remaining_Quantity, Unit FROM Inventory WHERE Unit = 'kg' AND Remaining_Quantity <" + 15 + " OR Unit = 'nos' AND Remaining_Quantity <=" + 50 + " OR Unit = 'litres' AND Remaining_Quantity <=" + 20;
            cmd = new MySqlCommand(lack, db.con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dtgRunningOut.DataSource = dt;
            int count = -1;
            foreach (DataGridViewRow item in dtgRunningOut.Rows)
            {
                ++count;
            }
   
            if (count > 0)
            {
                btnRunningOut.Visible = true;
            }
            else
            {
                btnRunningOut.Visible = false;
            }

            lblRunningItems.Text = "Running out of " + count.ToString() + " items";
            
            db.con.Close();
        }

        private void btnInsertItems_Click(object sender, EventArgs e)
        {
            runningOut();
            pnlRunningOut.Visible = false;
            pnlCover.Visible = false;
            pnlUpdateInventory.Visible = false;
            pnlUpdateInventory.Visible = false;
            pnlInsertInventory.Visible = true;

        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            runningOut();
            pnlRunningOut.Visible = false;
            pnlCover.Visible = false;
            pnlUpdateInventory.Visible = true;
            pnlInsertInventory.Visible = false;
            pnlViewInventory.Visible = false;
        }

        private void btnDeleteItems_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Delete record(s)?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dtgInventory.Rows)
                {

                    try
                    {
                        if (bool.Parse(item.Cells[0].Value.ToString()))
                        {
                            DBConnect db = new DBConnect();
                            cmd = db.con.CreateCommand();
                            //MessageBox.Show(item.Cells[1].Value.ToString());
                            String dlt = "DELETE FROM inventory WHERE ID = '" + item.Cells[1].Value.ToString() + "'";
                            cmd = new MySqlCommand(dlt, db.con);
                            cmd.ExecuteNonQuery();
                            int rowIndex = dtgInventory.CurrentCell.RowIndex;
                            dtgInventory.Rows.RemoveAt(rowIndex);
                            MessageBox.Show("Successfully Deleted selected Row(s)");
                            db.con.Close();
                        }
                        runningOut();
                    }
                    catch (NullReferenceException en)
                    {
                        
                    }

                }

            }

        }

        private void btnConfirmInsert_Click(object sender, EventArgs e)
        {
            String curTime = DateTime.Today.ToString("yyyy-MM-dd");

            if (String.IsNullOrEmpty(txtProductName.Text) == false && String.IsNullOrEmpty(cmbProductType.Text) == false && String.IsNullOrEmpty(cmbUnit.Text) == false)
            {
                dr = MessageBox.Show("Are you sure you want to add this item..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr.Equals(DialogResult.Yes))
                {
                    try
                    {
                        DBConnect db = new DBConnect();
                        cmd = db.con.CreateCommand();
                        int qty = Convert.ToInt32(Math.Round(nudQty.Value, 0));
                        
                        String ins = "INSERT INTO inventory(Name,Type,Remaining_Quantity,Unit,Edited_At) VALUES ('" + txtProductName.Text + "','" + cmbProductType.Text + "','" + qty + "','" + cmbUnit.Text + "','"+curTime+"')";
                        cmd = new MySqlCommand(ins, db.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New item added");
                        db.con.Close();
                        fillItemName();
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
            runningOut();

        }

        private void pnlUpdateInventory_Paint(object sender, PaintEventArgs e)
        {

        }

        void fillItemName()
        {
            DBConnect db = new DBConnect();
            cmd = db.con.CreateCommand();
            List<String> list = new List<String>();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name FROM inventory";

            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                list.Add(r[0].ToString());
            }

            cmbItemName.DataSource = list;
            lblItemCount.Text = list.Count.ToString() + " Items";

            db.con.Close();
        }


        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            var qty = nudQtyUpdate.Value + nudAddorDeduct.Value;
            dr = MessageBox.Show("Are you sure you want to Update this Record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr.Equals(DialogResult.Yes))
            {
                DBConnect db = new DBConnect();
                cmd = db.con.CreateCommand();
                String update = "UPDATE inventory SET Remaining_Quantity = '" + qty + "' WHERE ID = '" + txtItemCode.Text + "'";
                cmd = new MySqlCommand(update, db.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated");
                db.con.Close();
            }
            fillRemQty();
            runningOut();
        }

        void fillItemCode()
        {
            DBConnect db = new DBConnect();
            cmd = db.con.CreateCommand();
            //MessageBox.Show(cmbItemName.SelectedItem.ToString());
            string slctName = "SELECT ID FROM inventory WHERE Name = '" + cmbItemName.SelectedItem.ToString() + "'";
            cmd = new MySqlCommand(slctName, db.con);
            MySqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtItemCode.Text = dr.GetInt32("ID").ToString();
                }
                db.con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        void fillRemQty()
        {
            DBConnect db = new DBConnect();
            cmd = db.con.CreateCommand();
            string slctRemQty = "SELECT Remaining_Quantity FROM inventory WHERE ID = '" + txtItemCode.Text + "'";
            cmd = new MySqlCommand(slctRemQty, db.con);
            MySqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nudQtyUpdate.Value = dr.GetInt32("Remaining_Quantity");
                }
                db.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbItemName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            fillItemCode();
            fillRemQty();
        }

        private void cmbItemName_MouseClick(object sender, MouseEventArgs e)
        {
            fillItemName();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var dbConnection = new DBConnect();

            var query = "SELECT * FROM inventory WHERE Name LIKE '%" + txtSearch.Text + "%' ORDER BY ID";
            var command = new MySqlCommand(query, dbConnection.con);

            var adaptor = new MySqlDataAdapter(command);
            var table = new DataTable();

            adaptor.Fill(table);
            dtgInventory.DataSource = table;

            dbConnection.con.Close();
        }

        private void btnRunningOut_Click(object sender, EventArgs e)
        {
            pnlRunningOut.Visible = true;
            //runningOut();
        }

        private void btnConfirmDeduct_Click(object sender, EventArgs e)
        {
            var qty = nudQtyUpdate.Value - nudAddorDeduct.Value;
            dr = MessageBox.Show("Are you sure you want to Update this Record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr.Equals(DialogResult.Yes))
            {
                DBConnect db = new DBConnect();
                cmd = db.con.CreateCommand();
                String update = "UPDATE inventory SET Remaining_Quantity = '" + qty + "' WHERE ID = '" + txtItemCode.Text + "'";
                cmd = new MySqlCommand(update, db.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated");
                db.con.Close();
            }
            fillRemQty();
            runningOut();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfile p = new EmployeeProfile(EmployeeID);
            p.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
