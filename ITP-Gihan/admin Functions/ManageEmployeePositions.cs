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
    public partial class ManageEmployeePositions : Form
    {

     
        

        public ManageEmployeePositions()
        {
            InitializeComponent();
                     

        }

        private void EmployeePositions_Load(object sender, EventArgs e)
        {
            Retrieve();
          
         
        }

        private void Retrieve()
        {
            DBConnect db = new DBConnect();
            MySqlCommand cmd = db.con.CreateCommand();
            cmd.CommandText = "select type as 'Position',basic as 'Basic Salary',casualLeaves as 'Casual Leaves',sickLeaves as 'Medical Leaves',shortLeaves as 'Short Leaves',halfdays as 'Half Days' from employeesalarydetails";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvEmployeePositions.DataSource = dt;
        }

        private DataTable loadPositions()
        {
            DataTable dt = new DataTable();;
            DBConnect db = new DBConnect();
            String q = "select * from employeesalarydetails";
            MySqlCommand cmd = new MySqlCommand(q, db.con);
            MySqlDataReader r = cmd.ExecuteReader();

            dt.Load(r);
            return dt;
        }

        private void add(String position, String basic,String casual,String Medical,String ShortLeaves,String Halfdays )
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to add this position..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.Equals(DialogResult.Yes))
                {
                    DBConnect db = new DBConnect();
                    String q = "insert into employeesalarydetails(type,basic,casualLeaves,sickLeaves,shortLeaves,halfdays)values('" + position + "','" + basic + "','" + casual +"','"+Medical+"','"+ShortLeaves+"','"+Halfdays+"')";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Position added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Your position is already added");
            }
        }

        private void update(String position, String basic, String casual, String Medical, String ShortLeaves, String Halfdays)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to update this position..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.Equals(DialogResult.Yes))
                {
                    DBConnect db = new DBConnect();
                    String q = "update employeesalarydetails set basic='" + basic + "',casualLeaves ='" + casual + "',sickLeaves='" + Medical + "',shortLeaves='" + ShortLeaves + "',halfdays='" + Halfdays + "' where type='" + position + "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Position updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Your position is already added");
            }
        }
        private void delete(String position)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to Delete this position..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.Equals(DialogResult.Yes))
                {
                    DBConnect db = new DBConnect();
                    String q = "delete from employeesalarydetails where type='" + position + "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Position Deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Your position is already Deleted");
            }
        }

        private void dgvEmployeePositions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                    

        }

        private void dgvEmployeePositions_MouseClick(object sender, MouseEventArgs e)
        {
            txtPosition.Text = dgvEmployeePositions.SelectedRows[0].Cells[0].Value.ToString();
            txtBasic.Text = dgvEmployeePositions.SelectedRows[0].Cells[1].Value.ToString();
            txtcasualLeaves.Value =Int32.Parse(dgvEmployeePositions.SelectedRows[0].Cells[2].Value.ToString());
            txtMedicalLeaves.Value = Int32.Parse(dgvEmployeePositions.SelectedRows[0].Cells[3].Value.ToString());
            txtShortLeaves.Value = Int32.Parse(dgvEmployeePositions.SelectedRows[0].Cells[4].Value.ToString());
            txtHalfDays.Value = Int32.Parse(dgvEmployeePositions.SelectedRows[0].Cells[5].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add(txtPosition.Text, txtBasic.Text,txtcasualLeaves.Value.ToString(),txtMedicalLeaves.Value.ToString(),txtShortLeaves.Value.ToString(),txtHalfDays.Value.ToString());
            clear();
            Retrieve();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update(txtPosition.Text, txtBasic.Text, txtcasualLeaves.Value.ToString(), txtMedicalLeaves.Value.ToString(), txtShortLeaves.Value.ToString(), txtHalfDays.Value.ToString());
            clear();
            Retrieve();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear();
            Retrieve();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete(txtPosition.Text);
            clear();
            Retrieve();
        }
        private void clear()
        {
            txtPosition.Clear();
            txtBasic.Clear();
            txtMedicalLeaves.Value = 0;
            txtShortLeaves.Value = 0;
            txtHalfDays.Value = 0;
            txtcasualLeaves.Value = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

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
            dgvEmployeePositions.MultiSelect = true;
            dgvEmployeePositions.SelectAll();
            DataObject dataObj = dgvEmployeePositions.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }
            dgvEmployeePositions.MultiSelect = true;

        }
    }
}
