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
    public partial class ManageBar : MetroFramework.Forms.MetroForm
    {
        public ManageBar()
        {
            InitializeComponent();
        }

        private void ManageBar_Load(object sender, EventArgs e)
        {
            Retrieve();
        }
        private void Retrieve()
        {
            DBConnect db = new DBConnect();
            MySqlCommand cmd = db.con.CreateCommand();
            cmd.CommandText = "select stockID as 'Stock ID',brandName as 'Brand Name',quantity as 'Quantity',type as 'Type',volume as 'Volume' from stock";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvBarManage.DataSource = dt;
        }
        private void add(String brand, String qty, String type, String volume)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to add this item..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.Equals(DialogResult.Yes))
                {
                    DBConnect db = new DBConnect();
                    String q = "insert into stock(`brandName`, `quantity`, `type`, `volume`)values('" + brand + "','" + qty + "','" + type + "','" + volume + "')";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Your Item is already added. Try to Update or Delete");
            }
        }

        private void update(String stockId, String brand, String qty, String type, String volume)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to update this item..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.Equals(DialogResult.Yes))
                {
                    DBConnect db = new DBConnect();
                    String q = "update stock set brandName='" + brand + "',quantity ='" + qty + "',type='" + type + "',volume='" + volume + "' where stockID='" + stockId + "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Your position is already added");
            }
        }
        private void delete(String stockID)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to Delete this item..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.Equals(DialogResult.Yes))
                {
                    DBConnect db = new DBConnect();
                    String q = "delete from stock where stockID='" + stockID + "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("item Deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Retrieve();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Your item is already Deleted");
            }
        }

        private void clear()
        {
            txtStockID.Text = "";
            txtBrandName.Clear();
            txtQuantity.Value = 0;
            txtType.Text = "";
            txtVolume.Text = "";
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            add(txtBrandName.Text, txtQuantity.Value.ToString(), txtType.Text, txtVolume.Text);
            Retrieve();
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update(txtStockID.Text, txtBrandName.Text, txtQuantity.Value.ToString(), txtType.Text, txtVolume.Text);
            Retrieve();
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete(txtStockID.Text);
            clear();
        }

        private void btnDownloadToExcel_Click(object sender, EventArgs e)
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
            dgvBarManage.MultiSelect = true;
            dgvBarManage.SelectAll();
            DataObject dataObj = dgvBarManage.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }
            dgvBarManage.MultiSelect = false;

        }

        private void dgvBarManage_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtStockID.Text = dgvBarManage.SelectedRows[0].Cells[0].Value.ToString();
            txtBrandName.Text = dgvBarManage.SelectedRows[0].Cells[1].Value.ToString();
            txtQuantity.Value = Int32.Parse(dgvBarManage.SelectedRows[0].Cells[2].Value.ToString());
            txtType.Text = dgvBarManage.SelectedRows[0].Cells[3].Value.ToString();
            txtVolume.Text = dgvBarManage.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

    }
}
