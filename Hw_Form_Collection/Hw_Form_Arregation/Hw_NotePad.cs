using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hw_Form_Arregation
{
    public partial class Hw_NotePad : Form
    {
        public Hw_NotePad()
        {
            InitializeComponent();
        }
        private ColorDialog colorDialog = new ColorDialog(); 
        private FontDialog fontDialog = new FontDialog();

        private void IconOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.Text =File.ReadAllText(ofd.FileName);
                this.Text = ofd.FileName;
            }
            ofd = null;
        }

        private void btnOpenFIle_Click(object sender, EventArgs e)
        {
            IconOpenFile_Click(sender, e);
        }

        private void btnDup_Click(object sender, EventArgs e)
        {
            IconDup_Click(sender, e);
        }
        private void btnCut_Click(object sender, EventArgs e)
        {
            IconCut_Click(sender, e);
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            IconPaste_Click(sender, e);
        }
        private void IconCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void IconDup_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void IconPaste_Click(object sender, EventArgs e)
        {
           richTextBox1.Paste();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            richTextBox1 .SelectAll();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {    

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void btnText_Click(object sender, EventArgs e)
        {  
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.Font = fontDialog.Font;
            }
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.richTextBox1.Text.ToUpper();
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.richTextBox1.Text.ToLower();
        }

        private void btnChangeLine_Click(object sender, EventArgs e)
        {
            if(this.richTextBox1.Multiline)
            {
                this.richTextBox1.Multiline = false;
            }
            else
            {
                this.richTextBox1.Multiline = true;
            }
            
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor= Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.Blue;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.Black;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            IconInfo_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("tt hh:mm:ss");
        }

        private void IconInfo_Click(object sender, EventArgs e)
        {
            Hw_Notepad_Info info = new Hw_Notepad_Info();
            info.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
