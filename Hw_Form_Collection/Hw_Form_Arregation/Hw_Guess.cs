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
    public partial class Hw_Guess : Form
    {
        public static Label lab;
        public Hw_Guess()
        {
            InitializeComponent();
            lab = labGuess;
        }
        public Random ans = new Random();
        public int NumAns;
        static public int MinNumber = 1;
        static public int MaxNumber = 100;

        private void btnShowAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Answer:{NumAns}");
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            Hw_Guess_Num Guess = new Hw_Guess_Num();
            Guess.Ans = NumAns;
            Guess.ShowDialog();
            if(Guess.DialogResult == DialogResult.Cancel)
            {
                CreateAns();
                labGuess.Text = "Please Select A Number Between 1 to 100!";
            }
           
        }

        private void Hw_Guess_Load(object sender, EventArgs e)
        {
            CreateAns();
        }
        public void CreateAns()
        {
            NumAns = ans.Next(1, 100);
        } 
    }
}
