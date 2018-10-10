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
    public partial class ScanBarcode : MetroFramework.Forms.MetroForm
    {
        private Form1 mainForm = null;
        
        public ScanBarcode()
        {
            InitializeComponent();
        }

    public ScanBarcode(Form callingForm)
    {
        mainForm = callingForm as Form1; 
        InitializeComponent();
    }


        private void ScanBarcode_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Focus();
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text.Length == 8)
            {
                Console.Beep(1000,400);
                this.mainForm.employeeID = txtEmployeeID.Text;
                this.Hide();
            }
        }
    }
}
