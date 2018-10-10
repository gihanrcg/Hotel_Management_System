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
using Microsoft.Office;

namespace AttendanceRecorder
{
    public partial class ManageRooms : MetroFramework.Forms.MetroForm
    {
        public ManageRooms()
        {
            InitializeComponent();
        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {
            retieve();
        }
        private void retieve()
        {
            //DBConnect db = new DBConnect();
            //String q = "Select RoomID as 'Room Id',roomType as 'Room Type',priceForNight as 'Price For Night',priceForHours as 'Price per an Hour',noOfRooms as 'Total No of Rooms',noOfRoomsAvailable as 'No of Rooms Available' From rooms";


            DBConnect db = new DBConnect();
            MySqlCommand cmd = db.con.CreateCommand();
            cmd.CommandText = "Select RoomID as 'Room Id',roomType as 'Room Type',priceForNight as 'Price For Night',priceForHours as 'Price per an Hour',noOfRooms as 'Total No of Rooms',noOfRoomsAvailable as 'No of Rooms Available' From rooms";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvRooms.DataSource = dt;
        }

        private void dgvRooms_MouseClick(object sender, MouseEventArgs e)
        {
            txtRoomType.Text = dgvRooms.SelectedRows[0].Cells[1].Value.ToString();
            txtPricePerNight.Text = dgvRooms.SelectedRows[0].Cells[2].Value.ToString();
            txtPricePerhour.Text = dgvRooms.SelectedRows[0].Cells[3].Value.ToString();
            txtTotal.Text = dgvRooms.SelectedRows[0].Cells[4].Value.ToString();
            txtAvailable.Text = dgvRooms.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void add(String type, String pricePerNight, String pricePerHour, String total, String available)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to add this room..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.Equals(DialogResult.Yes))
                {
                    DBConnect db = new DBConnect();
                    String q = "insert into rooms(roomType,priceForNight,priceForHours,noOfRooms,noOfRoomsAvailable)values('" + type + "','" + pricePerNight + "','" + pricePerHour + "','" + total + "','" + available + "')";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Your position is already added");
            }
        }

        private void update(String type, String pricePerNight, String pricePerHour, String total, String available)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to update this room..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.Equals(DialogResult.Yes))
                {
                    DBConnect db = new DBConnect();
                    String q = "update rooms set roomType='" + type + "',priceForNight ='" + pricePerNight + "',priceForHours='" + pricePerHour + "',noOfRooms='" + total + "',noOfRoomsAvailable='" + available + "' where roomType='" + type + "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Your room is already added");
            }
        }
        private void delete(String type)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to Delete this room..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.Equals(DialogResult.Yes))
                {
                    DBConnect db = new DBConnect();
                    String q = "delete from rooms where roomType='" + type + "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Your position is already Deleted");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add(txtRoomType.Text, txtPricePerNight.Text, txtPricePerhour.Text, txtTotal.Text, txtAvailable.Text);
            retieve();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update(txtRoomType.Text, txtPricePerNight.Text, txtPricePerhour.Text, txtTotal.Text, txtAvailable.Text);
            retieve();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete(txtRoomType.Text);
            retieve();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            copyDataGridToClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true); 
        }
        private void copyDataGridToClipboard()
        {
            dgvRooms.SelectAll();
            DataObject dataObj = dgvRooms.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }


        }
    }
}
