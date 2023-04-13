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
    public partial class Hw_XOGame : Form
    {
        public Hw_XOGame()
        {
            InitializeComponent();
        }
        public int Count { get; set; }
        public bool Turn { get; set; }
        #region OX
        private void btnSpace1_Click(object sender, EventArgs e)
        {
            O_or_X(btnSpace1);
        }
        private void btnSpace2_Click(object sender, EventArgs e)
        {
            O_or_X(btnSpace2);
        }

        private void btnSpace3_Click(object sender, EventArgs e)
        {
            O_or_X(btnSpace3);
        }

        private void btnSpace4_Click(object sender, EventArgs e)
        {
            O_or_X(btnSpace4);
        }

        private void btnSpace5_Click(object sender, EventArgs e)
        {
            O_or_X(btnSpace5);
        }

        private void btnSpace6_Click(object sender, EventArgs e)
        {
            O_or_X(btnSpace6);
        }

        private void btnSpace7_Click(object sender, EventArgs e)
        {
            O_or_X(btnSpace7);
        }

        private void btnSpace8_Click(object sender, EventArgs e)
        {
            O_or_X(btnSpace8);
        }

        private void btnSpace9_Click(object sender, EventArgs e)
        {
            O_or_X(btnSpace9);
        }
        #endregion
        void O_or_X(Button button)
        {
            if (Count % 2 == 0)
            {
                button.Text = "X";
                Turn = true;
            }
            else
            {
                button.Text = "O";
                Turn = false;
            }
            Count++;
            button.Enabled = false;
            Who_Win();
        }
        void Who_Win()
        {
            bool hasWinner = false;
            //Rows Check
            if((btnSpace1.Text == btnSpace2.Text)&&(btnSpace2.Text == btnSpace3.Text) && (!btnSpace1.Enabled))
            {
                hasWinner = true;
            }
            else if ((btnSpace4.Text == btnSpace5.Text) && (btnSpace5.Text == btnSpace6.Text) && (!btnSpace4.Enabled))
            {
                hasWinner = true;
            }
            else if ((btnSpace7.Text == btnSpace8.Text) && (btnSpace8.Text == btnSpace9.Text) && (!btnSpace7.Enabled))
            {
                hasWinner = true;
            }

            //Columns Check
            else if ((btnSpace1.Text == btnSpace4.Text) && (btnSpace4.Text == btnSpace7.Text) && (!btnSpace1.Enabled))
            {
                hasWinner = true;
            }
            else if ((btnSpace2.Text == btnSpace5.Text) && (btnSpace5.Text == btnSpace8.Text) && (!btnSpace2.Enabled))
            {
                hasWinner = true;
            }
            else if ((btnSpace3.Text == btnSpace6.Text) && (btnSpace6.Text == btnSpace9.Text) && (!btnSpace3.Enabled))
            {
                hasWinner = true;
            }

            //斜的
            //Columns Check
            else if ((btnSpace1.Text == btnSpace5.Text) && (btnSpace5.Text == btnSpace9.Text) && (!btnSpace1.Enabled))
            {
                hasWinner = true;
            }
            else if ((btnSpace3.Text == btnSpace5.Text) && (btnSpace5.Text == btnSpace7.Text) && (!btnSpace3.Enabled))
            {
                hasWinner = true;
            }

            if (hasWinner)
            {
                string Winner = "";
                if(Turn)
                {
                    Winner = "X";
                }
                else
                {
                    Winner = "O";
                }
                MessageBox.Show($"{Winner}手獲勝");
                Reset(btnSpace1);
                Reset(btnSpace2);
                Reset(btnSpace3);
                Reset(btnSpace4);
                Reset(btnSpace5);
                Reset(btnSpace6);
                Reset(btnSpace7);
                Reset(btnSpace8);
                Reset(btnSpace9);
                Count = 0;
            }
            else
            {
                if(Count == 9)
                {
                    MessageBox.Show("Tie!");
                    Reset(btnSpace1);
                    Reset(btnSpace2);
                    Reset(btnSpace3);
                    Reset(btnSpace4);
                    Reset(btnSpace5);
                    Reset(btnSpace6);
                    Reset(btnSpace7);
                    Reset(btnSpace8);
                    Reset(btnSpace9);
                    Count = 0;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset(btnSpace1);
            Reset(btnSpace2);
            Reset(btnSpace3);
            Reset(btnSpace4);
            Reset(btnSpace5);
            Reset(btnSpace6);
            Reset(btnSpace7);
            Reset(btnSpace8);
            Reset(btnSpace9);
            Count = 0;
        }
        void Reset(Button btn)
        {
            btn.Text = "";
            btn.Enabled = true;
        }
        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Hw_XOGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                btnReset_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnEsc_Click(sender, e);
            }
        }
    }
}
