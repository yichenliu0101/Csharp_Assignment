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
        class GetTextBoxText
        {
            public double Total { get; set; }
            public double Year { get; set; }
            public double Rate { get; set; }
            public double FirstPay { get; set; }

            public GetTextBoxText(string Total, string Year, string Rate, string FirstPay)
            {
                this.Total = double.Parse(Total);
                this.Year = double.Parse(Year);
                this.Rate = double.Parse(Rate);
                this.FirstPay = double.Parse(FirstPay);
            }
            public double GetAvgPayRate(double Year, double Rate)
            {
                //每月應付本息金額之平均攤還率 ＝ { [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
                return ((Math.Pow((1 + (Rate / 100 / 12)), Year * 12) * Rate / 100 / 12 )/ (Math.Pow((1 + (Rate / 100 / 12)), Year * 12) - 1));
            }
            public string GetMonthPay(double Total, double Year, double Rate, double FirstPay)
            {
                return Convert.ToString(Math.Round((Total - FirstPay) * GetAvgPayRate(Year, Rate))); //使用Method來取得 平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率
            }
            public string GetTotalPay(double Total, double Year, double Rate, double FirstPay)
            {
                return Convert.ToString(double.Parse(GetMonthPay(Total, Year, Rate, FirstPay)) * Year * 12); //總計因此要把GetMonthPay*總月數
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            GetTextBoxText GetTextBox = new GetTextBoxText(txtTotal.Text, txtTime.Text, txtRate.Text, txtFirst.Text);
            double Total = GetTextBox.Total;
            double Year = GetTextBox.Year;
            double Rate = GetTextBox.Rate;
            double FirstPay = GetTextBox.FirstPay;
            string MonthPay = GetTextBox.GetMonthPay(Total, Year, Rate, FirstPay);
            string TotalPay = GetTextBox.GetTotalPay(Total, Year, Rate, FirstPay);
            Form_LoanReport form_LoanReport = new Form_LoanReport();
            form_LoanReport.Total = txtTotal.Text;
            form_LoanReport.Time = txtTime.Text;
            form_LoanReport.Rate = txtRate.Text;
            form_LoanReport.MonthPay = MonthPay;
            form_LoanReport.TotalPay = TotalPay;
            form_LoanReport.Show();

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            GetTextBoxText GetTextBox = new GetTextBoxText(txtTotal.Text, txtTime.Text, txtRate.Text, txtFirst.Text);
            double Total = GetTextBox.Total;
            double Year = GetTextBox.Year;
            double Rate = GetTextBox.Rate;
            double FirstPay = GetTextBox.FirstPay;
            string TotalPay = GetTextBox.GetTotalPay(Total, Year, Rate, FirstPay);
            MessageBox.Show($"總付款金額為:{TotalPay}元");

        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            GetTextBoxText GetTextBox = new GetTextBoxText(txtTotal.Text, txtTime.Text, txtRate.Text, txtFirst.Text);
            double Total = GetTextBox.Total;
            double Year = GetTextBox.Year;
            double Rate = GetTextBox.Rate;
            double FirstPay = GetTextBox.FirstPay;
            string MonthPay = GetTextBox.GetMonthPay(Total, Year, Rate, FirstPay);
            MessageBox.Show($"月繳金額為:{MonthPay}元");
        }

    }
}
