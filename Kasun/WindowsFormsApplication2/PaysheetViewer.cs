using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace AttendanceRecorder
{
    public partial class PaysheetViewer : Form
    {

        String name;
        String empID;
        String designation;
        String basicSalary;
        String leaves;
        String ot;
        String epf;
        String bonus;
        String totEarn;
        String totDeduction;
        String netPay;
        String paydate;

        public PaysheetViewer()
        {
            InitializeComponent();
        }
        public PaysheetViewer(String name, String empID, String designation, String basicSalary, String leaves, String ot, String epf, String totEarn, String totDeduction, String netPay, String paydate)
        {
            InitializeComponent();
            this.name = name;
            this.empID = empID;
            this.designation = designation;
            this.basicSalary = basicSalary;
            this.leaves = leaves;
            this.ot = ot;
            this.epf = epf;
            //this.bonus = bonus;
            this.totEarn = totEarn;
            this.totDeduction = totDeduction;
            this.netPay = netPay;
            this.paydate = paydate;
        }

        private void PaysheetViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotelDataSet.employee);

            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("name", name));
            parameters.Add(new ReportParameter("empID", empID));
            parameters.Add(new ReportParameter("designation", designation));
            parameters.Add(new ReportParameter("basicSalary", basicSalary));
            parameters.Add(new ReportParameter("leaves", leaves));
            parameters.Add(new ReportParameter("ot", ot));
            parameters.Add(new ReportParameter("epf", epf));
            //parameters.Add(new ReportParameter("bonus", bonus));
            parameters.Add(new ReportParameter("totEarns", totEarn));
            parameters.Add(new ReportParameter("totDeduction", totDeduction));
            parameters.Add(new ReportParameter("netPay", netPay));
            parameters.Add(new ReportParameter("paydate", paydate));
            this.reportViewer1.LocalReport.SetParameters(parameters);



            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
