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
    public partial class Frm_M02_HelloForm : Form
    {
        public Frm_M02_HelloForm()
        {
            InitializeComponent();
        }


        private void btnHello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EName = txtEnglish.Text;
            string Sex = txtSex.Text;
            string Astro = txtAstro.Text;

            MessageBox.Show($"Hello, 我是 {Name},\n 英文名字是 {EName},\n性別是 {Sex},\n星座是 {Astro}" );
        }

        private void txtHello_TextChanged(object sender, EventArgs e)
        {
            //todo 0328 

        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EName = txtEnglish.Text;
            string Sex = txtSex.Text;
            string Astro = txtAstro.Text;

            MessageBox.Show($"Hi, 我是 {Name},\n英文名字是 {EName},\n性別是 {Sex},\n星座是 {Astro}");
        }
    }
}
