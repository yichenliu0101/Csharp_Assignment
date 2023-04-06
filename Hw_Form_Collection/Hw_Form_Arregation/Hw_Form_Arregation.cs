using Frm_M02_HelloForm;
using Hw_Form_LoanCalculate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hw_Form_LoanCalculate;
using Hw_Form_Pos;

namespace Hw_Form_Arregation
{
    public partial class Hw_Form_Arregation : Form
    {
        public Hw_Form_Arregation()
        {
            InitializeComponent();
        }
        private void btnHw01_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_HelloHi Form = new Frm_HelloHi();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btnHw02_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_LoanCalculate Form = new Hw_LoanCalculate();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_Pos Form = new Hw_Pos();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_StructSaveGrades Form = new Hw_StructSaveGrades();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_Students_Grade Form = new Hw_Students_Grade();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btn_Save_List_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_Students_Grade_List Form = new Hw_Students_Grade_List();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_Method Form = new Hw_Method();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_ClassCalculate Form = new Hw_ClassCalculate();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_ForDoWhile Form = new Hw_ForDoWhile();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void BtnXO_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_XOGame Form = new Hw_XOGame();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_ScreenSaver Form = new Hw_ScreenSaver();
            Form.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_NotePad Form = new Hw_NotePad();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btnPainter_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_Painter Form = new Hw_Painter();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hw_PictureViewer Form = new Hw_PictureViewer();
            Form.TopLevel = false;
            Form.Parent = this;
            splitContainer2.Panel2.Controls.Add(Form);
            Form.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {

        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {

        }
    }
}
