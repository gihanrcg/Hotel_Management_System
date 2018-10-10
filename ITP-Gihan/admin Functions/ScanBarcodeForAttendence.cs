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
    public partial class ScanBarcodeForAttendence : MetroFramework.Forms.MetroForm
    {
        private AttendenceRecorder mainForm = null;

        public ScanBarcodeForAttendence()
        {
            InitializeComponent();
        }

        public ScanBarcodeForAttendence(Form callingForm)
        {
            this.mainForm = callingForm as AttendenceRecorder;
            InitializeComponent();
        }

        private void ScanBarcodeForAttendence_Load(object sender, EventArgs e)
        {
            txtID.Focus();
        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 8)
            {
                Console.Beep(1000, 400);
                this.mainForm.employeeId = txtID.Text;                                              
                this.Close();


            }


        }


    }
}
