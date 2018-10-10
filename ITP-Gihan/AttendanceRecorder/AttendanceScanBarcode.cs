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
    public partial class AttendanceScanBarcode : MetroFramework.Forms.MetroForm
    {
        private Attendance mainForm = null;

        public AttendanceScanBarcode()
        {
            InitializeComponent();
        }

        public AttendanceScanBarcode(Form callingForm)
        {
            mainForm = callingForm as Attendance; 
            InitializeComponent();
        }

        private void AttendanceScanBarcode_Load(object sender, EventArgs e)
        {
     
        }



        private void txtEmployeeID_TextChanged_1(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text.Length == 8)
            {
                
                Console.Beep(1000, 400);
                this.mainForm.employeeID = txtEmployeeID.Text;
                this.Close();
                
            }
        }
    }
}
