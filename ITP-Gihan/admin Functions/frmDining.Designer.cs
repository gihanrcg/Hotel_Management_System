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
    public partial class frmDining : System.Windows.Forms.Form
    {
        private Label itemId;
        private Label item;
        private TextBox txtItemId;
        private DataGridView dgvTempryBill;
        private Button save;
        private Button btnUpdate;
        private Button btnPrint;
        private GroupBox operation;
        private GroupBox insertGroupbox;
        private Label label2;
        private Label fQuan;
        private TextBox txtItemQty;
        private Button btnClear;
        private TextBox txtUnitPrice;
        private ComboBox ddfoodname;
        private Button btnRefresh;
        private Label txtID;
        private Label label1;
        private Label lblUnit;
        private Label lblDate;
        private TextBox txtDate;
        private Label label3;
        private IContainer components;
        private TextBox txtprice;
        private Label lblprice;
        private Button btn_tot;
        private Label lblTotal;
        private Button btnProfile;
        private Button btnLogout;
    }
}
