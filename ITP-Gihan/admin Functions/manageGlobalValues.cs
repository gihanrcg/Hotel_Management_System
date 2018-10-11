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
    public partial class manageGlobalValues : MetroFramework.Forms.MetroForm
    {
        public manageGlobalValues()
        {
            InitializeComponent();
        }

        private void manageGlobalValues_Load(object sender, EventArgs e)
        {
            Retrieve();
        }

        private void Retrieve()
        {
            DBConnect db = new DBConnect();
            MySqlCommand cmd = db.con.CreateCommand();
            cmd.CommandText = "select valueID as 'Type',value as 'Value' from globalvalues";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvGlobal.DataSource = dt;
        }

        private void dgvGlobal_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dgvGlobal.SelectedRows[0].Cells[0].Value.ToString();
            txtGlobal.Text = dgvGlobal.SelectedRows[0].Cells[1].Value.ToString();
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update(txtID.Text, txtGlobal.Text);
            Retrieve();
        }
        private void update(String ID,String Value)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to update this value..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.Equals(DialogResult.Yes))
                {
                    DBConnect db = new DBConnect();
                    String q = "update globalvalues set value='" + Value +"'where valueID='" + ID + "'";
                    MySqlCommand cmd = new MySqlCommand(q, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Value updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Your value is already added");
            }
        }
    }
}
