using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_Form_Arregation
{
    public partial class Hw_PictureViewer : Form
    {
        public Hw_PictureViewer()
        {
            InitializeComponent();
        }

        private void Hw_PictureViewer_Load(object sender, EventArgs e)
        {
            //C:\Users\aaron\Documents\GitHub\Csharp_Assignment\Hw_Form_Collection\Hw_Form_Arregation\bin\Debug
            string imageDirectory = @"..\..\Resources";

            string[] imageFileList = Directory.GetFiles(imageDirectory);

            int x = 20;
            int y = 20;
            foreach (string imageFile in imageFileList)
            {
                PictureBox pic = new PictureBox();
                pic.Size = new Size(100, 100);
                pic.Location = new Point(x, y);
                pic.Image = Image.FromFile(imageFile);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                x += pic.Width + 20;
                if (x > this.Width - 100)
                {
                    x = 20;
                    y += 100;
                }
                panel1.Controls.Add(pic);
                pic.Click += new EventHandler(pic_Click);

            }
            //int x = 20;
            //int y = 20;
            //int maxHeight = -1;
            //for (int i = 0; i < imageList1.Images.Count; i++)
            //{
            //    PictureBox pic = new PictureBox();
            //    pic.Image = imageList1.Images[i];
            //    pic.SizeMode = PictureBoxSizeMode.Zoom;
            //    pic.Location = new Point(x, y);
            //    x += pic.Width + 20;
            //    if (x > this.ClientSize.Width - 100)
            //    {
            //        x = 20;
            //        y += maxHeight + 100;
            //    }
            //    panel1.Controls.Add(pic);
            //}

        }
        void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            Picture frm = new Picture();
            frm.pictureBox = pic;
            frm.ShowDialog();
        }
        private void Hw_PictureViewer_Resize(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string imageDirectory = @"..\..\Resources";

            string[] imageFileList = Directory.GetFiles(imageDirectory);
            int x = 20;
            int y = 20;
            foreach (string imageFile in imageFileList)
            {
                PictureBox pic = new PictureBox();
                pic.Size = new Size(100, 100);
                pic.Location = new Point(x, y);
                pic.Image = Image.FromFile(imageFile);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                x += pic.Width + 20;
                if (x > this.Width - 100)
                {
                    x = 20;
                    y += 100;
                }
                panel1.Controls.Add(pic);
                pic.Click += new EventHandler(pic_Click);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
