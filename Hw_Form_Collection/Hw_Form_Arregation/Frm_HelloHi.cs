using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_M02_HelloForm
{
    public partial class Frm_HelloHi : Form
    {
        public Frm_HelloHi()
        {
            InitializeComponent();
        }


        private void btnHello_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("請輸入姓名");
            }
            else if (txtEnglish.Text == "")
            {
                MessageBox.Show("請輸入英文名字");
            }
            else if (txtSex.Text == "")
            {
                MessageBox.Show("請輸入性別");
            }
            else if (txtAstro.Text == "")
            {
                MessageBox.Show("請輸入星座");
            }
            else
            {
                string Name = txtName.Text;
                string EName = txtEnglish.Text;
                string Sex = txtSex.Text;
                string Astro = txtAstro.Text;

                MessageBox.Show($"Hello, 我是 {Name},\n 英文名字是 {EName},\n性別是 {Sex},\n星座是 {Astro}");
            }

        }


        private void btnHi_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("請輸入姓名");
            }
            else if (txtEnglish.Text == "")
            {
                MessageBox.Show("請輸入英文名字");
            }
            else if (txtSex.Text == "")
            {
                MessageBox.Show("請輸入性別");
            }
            else if (txtAstro.Text == "")
            {
                MessageBox.Show("請輸入星座");
            }
            else
            {
                string Name = txtName.Text;
                string EName = txtEnglish.Text;
                string Sex = txtSex.Text;
                string Astro = txtAstro.Text;

                MessageBox.Show($"Hi, 我是 {Name},\n英文名字是 {EName},\n性別是 {Sex},\n星座是 {Astro}");
            }
        }
    }
}
