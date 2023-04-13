using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_Form_Arregation
{
    public partial class Hw_ClassCalculate : Form
    {
        public Hw_ClassCalculate()
        {
            InitializeComponent();
        }
        public class Calculate
        {
            public double Num1 { get; set; }
            public double Num2 { get; set; }
            public string Oper { get; set; }
            public Calculate(string num1, string num2)
            {
                Num1 = double.Parse(num1);
                Num2 = double.Parse(num2);
            }
            public string Ans(double num1, double num2, string Oper)
            {
                string ans;
                switch (Oper)
                {
                    case "+":
                        ans = Convert.ToString(num1 + num2);
                        break;
                    case "-":
                        ans = Convert.ToString(num1 - num2);
                        break;
                    case "*":
                        ans = Convert.ToString(num1 * num2);
                        break;
                    case "/":
                        ans = Convert.ToString(Math.Round(Convert.ToDouble(num1) / Convert.ToDouble(num2), 4));
                        break;
                    default:
                        ans = "";
                        break;
                }
                return ans;
            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Calculate PlusOp = new Calculate(txtNum1.Text, txtNum2.Text);
            labAns.Text =  PlusOp.Ans(PlusOp.Num1, PlusOp.Num2, "+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Calculate PlusOp = new Calculate(txtNum1.Text, txtNum2.Text);
            labAns.Text = PlusOp.Ans(PlusOp.Num1, PlusOp.Num2, "-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Calculate PlusOp = new Calculate(txtNum1.Text, txtNum2.Text);
            labAns.Text = PlusOp.Ans(PlusOp.Num1, PlusOp.Num2, "*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Calculate PlusOp = new Calculate(txtNum1.Text, txtNum2.Text);
            labAns.Text = PlusOp.Ans(PlusOp.Num1, PlusOp.Num2, "/");
        }
    }
}
