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
    public partial class Hw_Painter : Form
    {
        public Hw_Painter()
        {
            InitializeComponent();
            //Bitmap bmp;
            //int oldx, oldy;
            //int penPoint;
            //Color penColor;
            //Graphics g;
            //Pen pen;
        }
        public int x0, y0;
        public ColorDialog dlg = new ColorDialog();
        private void Hw_Painter_Load(object sender, EventArgs e)
        {
            trackBar1.SetRange(1, 100);
            pictureBox1.Image = new Bitmap(800, 600);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(dlg.Color, int.Parse(trackBar1.Value.ToString()));
                g.DrawLine(p, x0, y0, e.X, e.Y);
                x0 = e.X; 
                y0 = e.Y;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            dlg.ShowDialog();
            labeColor.BackColor = dlg.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labNumber.Text = Convert.ToString(trackBar1.Value);
        }
    }
}
