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
    public partial class Hw_Guess_Num : Form
    {
        public Hw_Guess_Num()
        {
            InitializeComponent();
        }
        static public int GuessNum;
        public int Ans { get;set; }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            GuessNum = Convert.ToInt32(txtInput.Text);
            if( GuessNum == Ans)
            {
                MessageBox.Show($"Congratulation! You got {Ans}");
                Hw_Guess.MaxNumber = 100;
                Hw_Guess.MinNumber = 0;
                this.Close();
            }
            else
            {
                if (DialogResult == DialogResult.Cancel)
                {
                    Hw_Guess.MaxNumber = 100;
                    Hw_Guess.MinNumber = 0;
                }
                if (GuessNum < Ans && GuessNum> Hw_Guess.MinNumber)
                {
                    Hw_Guess.lab.Text = $"Too Small\nBetween {GuessNum} and {Hw_Guess.MaxNumber}";
                    Hw_Guess.MinNumber = GuessNum;
                }
                else if (GuessNum > Ans && GuessNum < Hw_Guess.MaxNumber)
                {
                    Hw_Guess.lab.Text = $"Too Large\nBetween {Hw_Guess.MinNumber} and {GuessNum}";
                    Hw_Guess.MaxNumber = GuessNum;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hw_Guess.MaxNumber = 100;
            Hw_Guess.MinNumber = 0;
            this.Close();
        }
    }
}
