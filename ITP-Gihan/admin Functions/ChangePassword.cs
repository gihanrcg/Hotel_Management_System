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
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        String id;
        String oldPassword;

        public ChangePassword(String employeeID, String password)
        {
            InitializeComponent();
            id = employeeID;
            oldPassword = password;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtRenewPassword.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EncryptAndDecrypt en = new EncryptAndDecrypt();

            if (txtNewPassword.Text.Length >= 4)
            {
                if (txtNewPassword.Text.Equals(txtRenewPassword.Text))
                {
                    if (oldPassword.Equals(en.EncryptString(txtCurrentPassword.Text)))
                    {
                        DialogResult d = MessageBox.Show("Are you sure you want to update your password...?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (d == DialogResult.Yes)
                        {
                            DBConnect db = new DBConnect();

                            String q = "update employee set password = '" + en.EncryptString(txtNewPassword.Text) + "' where employeeNo ='" + id + "'";
                            MySqlCommand cmd = new MySqlCommand(q, db.con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Password updated successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Make sure you entered valid current password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnClear_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("New password does not match with re-entered new password", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnClear_Click(sender, e);
                } 
            }
            else
            {
                MessageBox.Show("New password should be at least 4 characters", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
