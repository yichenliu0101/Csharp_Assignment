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
    public partial class Hw_Alarm : Form
    {
        public Hw_Alarm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("HH:mm:ss");
            string AlarmTime = $"{txtHour.Text}:{txtMin.Text}:{txtSec.Text}";
            if (checkBox1.Checked)
            {
                if (labTime.Text == AlarmTime)
                {
                    MessageBox.Show("起床重睡");
                }
            }
        }
    }
}
