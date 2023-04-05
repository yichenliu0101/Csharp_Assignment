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
        private int xSpeed { get;set;}
        private int ySpeed { get;set;}
        float vel = 0.003f; // fraction of screen width per step
        float velX = 0;
        float velY = 0;
        int cornerCount = 0; // how often have we hit the corner
        private void Hw_ScreenSaver_Load(object sender, EventArgs e)
        {
            DanceCat.Top = 0;
            DanceCat.Left = 0;

            Cursor.Hide();

        }
        private void Hw_ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Todo PictureBox Movement
            //xSpeed = 4;
            //ySpeed = 4;
            //DanceCat.Left += xSpeed;
            //if (DanceCat.Location.X+ DanceCat.Width > this.ClientSize.Width || DanceCat.Location.X < 0)
            //{
            //    xSpeed = -xSpeed;
            //}
            //DanceCat.Top += ySpeed;
            //if (DanceCat.Location.Y + DanceCat.Height > this.ClientSize.Height || DanceCat.Location.Y < 0)
            //{
            //    ySpeed = -ySpeed;
            //}
            //DanceCat.Refresh();

            var pos = DanceCat.Location;
            pos.X += (int)velX;
            pos.Y += (int)velY;

            int count = 0;
            if (pos.X < 0)
            {
                velX = Math.Abs(velX);
                count++;
            }
            if (pos.Y < 0)
            {
                velY = Math.Abs(velY);
                count++;
            }
            if (pos.X > Width - DanceCat.Width)
            {
                velX = -Math.Abs(velX);
                count++;
            }
            if (pos.Y > Height - DanceCat.Height)
            {
                velY = -Math.Abs(velY);
                count++;
            }

            DanceCat.Location = pos;

        }

    }
}
