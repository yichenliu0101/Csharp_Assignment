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
    public partial class Hw_ScreenSaver : Form
    {
        public Hw_ScreenSaver()
        {
            InitializeComponent();         
        }
        private int xSpeed = 4;
        private int ySpeed = 4;
        private void Hw_ScreenSaver_Load(object sender, EventArgs e)
        {
            DanceCat.Top = 0;
            DanceCat.Left = 0;


        }
        private void Hw_ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            DanceCat.Left += xSpeed;
            if (DanceCat.Location.X + DanceCat.Width > this.ClientSize.Width || DanceCat.Location.X < 0)
            {
                xSpeed = -xSpeed;
            }
            DanceCat.Top += ySpeed;
            if (DanceCat.Location.Y + DanceCat.Height > this.ClientSize.Height || DanceCat.Location.Y < 0)
            {
                ySpeed = -ySpeed;
            }
            //DanceCat.Refresh();

        }
        int x = Cursor.Position.X;
        int y = Cursor.Position.Y;
        private void Hw_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if(x!=Cursor.Position.X || y!=Cursor.Position.Y)
            {
                this.Close();
            }
        }
    }
}
