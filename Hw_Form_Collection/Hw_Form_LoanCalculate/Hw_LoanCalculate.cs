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
    public partial class Hw_LoanCalculate : Form
    {
        public Hw_LoanCalculate()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            double Total = double.Parse(txtTotal.Text);
            double Year = double.Parse(txtTime.Text);
            double Rate = double.Parse(txtRate.Text);
            double FirstPay = double.Parse(txtFirst.Text);
            //{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            double AvgPayRate = Math.Pow((1 + Rate / 100 / 12), Year * 12) * Rate / 100 / 12 / (Math.Pow((1 + Rate / 100 / 12), Year * 12) - 1);
            String TotalPay;
            String MonthPay;
            MonthPay = Convert.ToString(Math.Round((Total - FirstPay) * AvgPayRate));
            TotalPay = Convert.ToString(Total + double.Parse(MonthPay) * Year * 12);
            Form_LoanReport form_LoanReport = new Form_LoanReport();
            form_LoanReport.Show();

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double Total = double.Parse(txtTotal.Text);
            double YearToMonth = (double.Parse(txtTime.Text)) * 12;
            double ToMonthRate = (double.Parse(txtRate.Text)) / 100 / 12;
            double FirstPay = double.Parse(txtFirst.Text);
            //{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            double AvgPayRate = (Math.Pow((1 + ToMonthRate), YearToMonth) * ToMonthRate) / (Math.Pow((1 + ToMonthRate), YearToMonth) - 1);
            String TotalPay;
            String MonthPay;
            MonthPay = Convert.ToString(Math.Round((Total - FirstPay) * AvgPayRate));
            TotalPay = Convert.ToString(double.Parse(MonthPay) * YearToMonth);
            MessageBox.Show($"總付款金額為:{TotalPay}元");

        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            double Total = double.Parse(txtTotal.Text);
            double YearToMonth = (double.Parse(txtTime.Text)) * 12;
            double ToMonthRate = (double.Parse(txtRate.Text)) / 100 / 12;
            double FirstPay = double.Parse(txtFirst.Text);
            //{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            double AvgPayRate = Math.Pow((1 + ToMonthRate), YearToMonth) * ToMonthRate / (Math.Pow((1 + ToMonthRate), YearToMonth) - 1);
            string MonthPay;
            MonthPay = Convert.ToString(Math.Round((Total - FirstPay) * AvgPayRate));
            MessageBox.Show($"月繳金額為:{MonthPay}元");
        }

    }
}
