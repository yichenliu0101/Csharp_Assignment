using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_Form_LoanCalculate
{
    public partial class Form_LoanReport : Form
    {
        public Form_LoanReport()
        {
            InitializeComponent();
        }
        public string Total { get;set; }
        public string Time { get;set; }
        public string Rate { get;set; }
        public string MonthPay { get;set; }
        public string TotalPay { get;set; }

        private void Form_LoanReport_Load(object sender, EventArgs e)
        {
            txtOuputTotal.Text = Total;
            txtOuputTime.Text = Time;
            txtOutputRate.Text = Rate;
            txtOuputPayMonth.Text = MonthPay;
            txtOuputTotalPay.Text = TotalPay;

        }
    }
}
