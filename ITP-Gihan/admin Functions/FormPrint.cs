//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace AttendanceRecorder
//{

   

//    public partial class FormPrint : Form
//    {

//        List<Receipt> _list;
//        String _total,_date;
//        public FormPrint(List<Receipt> datasource,String total,String date)
//        {
//            InitializeComponent();
//            _list = datasource;
//            _total = total;
//            _date = date;
           
           
//        }

//        private void FormPrint_Load(object sender, EventArgs e)
//        {

//            ReceiptBindingSource.DataSource = _list;
//            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
//            {
//                new Microsoft.Reporting.WinForms.ReportParameter("pTotal",_total),
//                new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date)
                
            
            
            
//            };

//            this.reportViewer1.LocalReport.SetParameters(para);

//            this.reportViewer1.RefreshReport();
//        }

//        private void reportViewer1_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
