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
    public partial class Hw_Guess_Delegate : Form
    {
        public Hw_Guess_Delegate()
        {
            InitializeComponent();
        }
        public int NumAns;
        public Random ans = new Random();
        public int MaxNumber = 100;
        public int MinNumber = 1;
        private void Hw_Guess_Delegate_Load(object sender, EventArgs e)
        {
            CreateAns();
        }
        public void CreateAns()
        {
            NumAns = ans.Next(1, 100);
        }

        private void btnShowAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Answer:{NumAns}");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Hw_GuessNum_Delegate Guess = new Hw_GuessNum_Delegate();
            Guess.EventReturn = new Hw_GuessNum_Delegate.NumReturn(EventReturn);
            Guess.Ans = NumAns;
            Guess.MaxNumber = MaxNumber;
            Guess.MinNumber = MinNumber;
            Guess.ShowDialog();
            if (Guess.DialogResult == DialogResult.Cancel)
            {
                MaxNumber = 100;
                MinNumber = 1;
                CreateAns();
                labGuess.Text = $"Please Select A Number Between {MinNumber} to {MaxNumber}!";
            }
        }
        void EventReturn(int GuessNum)
        {
            if (GuessNum > NumAns && GuessNum < MaxNumber)
            {
                MaxNumber = GuessNum;
                labGuess.Text = $"Too Large\nBetween {MinNumber} and {GuessNum}";
            }
            else if (GuessNum < NumAns && GuessNum > MinNumber)
            {
                MinNumber = GuessNum;
                labGuess.Text = $"Too Small\nBetween {GuessNum} and {MaxNumber}";
            }
        }
    }
}
