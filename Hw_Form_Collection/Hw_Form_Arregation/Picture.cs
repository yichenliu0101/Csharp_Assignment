﻿using System;
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
    public partial class Picture : Form
    {
        public PictureBox pictureBox { get; set; }
        public Picture()
        {
            InitializeComponent();
        }

        private void Picture_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox.Image;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
