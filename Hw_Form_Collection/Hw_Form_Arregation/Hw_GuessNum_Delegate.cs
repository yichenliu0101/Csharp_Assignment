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
    public partial class Hw_GuessNum_Delegate : Form
    {
        public delegate void NumReturn(int Num);//宣告委派
        public NumReturn EventReturn { get; set; }
        public int Ans { get; set; }
        public int MaxNumber { get; set; }
        public int MinNumber { get; set; }
        public Hw_GuessNum_Delegate()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ans != int.Parse(txtInput.Text))
                {
                    EventReturn(int.Parse(txtInput.Text));
                }
                else
                {
                    MessageBox.Show($"Congratulation! You got {Ans}");
                    this.Close();
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                txtInput.Text = "";
                txtInput.Focus();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
