using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Hw_Form_Arregation
{
    public partial class Hw_StructSaveGrades : Form
    {
        public Hw_StructSaveGrades()
        {
            InitializeComponent();
        }
        private string Name { get;set; }
        struct Grades//創建Struct 欄位有名稱跟成績
        {
            public string Name { get; set; }
            public int Grade { get; set; }
            
        }
        Grades ChineseScore, EnglishScore, MathScore, MaxGrade, MinGrade;//創建國文、英文、數學、最大及最小的Struct
        private void btnSave_Click(object sender, EventArgs e)
        {
            //將TextBox內容傳進Name及Struct的Grade欄位中
            Name = txtName.Text;
            ChineseScore.Grade = int.Parse(txtChinese.Text);
            EnglishScore.Grade = int.Parse(txtEnglish.Text);
            MathScore.Grade = int.Parse(txtMath.Text);
        }

        private void btnShowSave_Click(object sender, EventArgs e)
        {
            if(Name == "Hw_StructSaveGrades")//如果還未存檔過
            {
                labGrades.Text = labGrades.Text = $"姓名:0\n國文:0分\n英文:0分\n數學:0分\n";//就給予預設值
            }
            else
            {
                labGrades.Text = $"姓名:{Name}\n國文:{ChineseScore.Grade}分\n英文:{EnglishScore.Grade}分\n數學:{MathScore.Grade}分\n";
            }
            
        }
        private void btnShowMaxMin_Click(object sender, EventArgs e)
        {
            ChineseScore.Name = "國文";//要賦予Name欄位值
            EnglishScore.Name = "英文";
            MathScore.Name = "數學";
            GetMaxGrade(ChineseScore, EnglishScore, MathScore);
            GetMinGrade(ChineseScore, EnglishScore, MathScore);

            labMaxMinGrade.Text = $"最高科目成績為: {MaxGrade.Name}{MaxGrade.Grade}分\n最低科目成績為: {MinGrade.Name}{MinGrade.Grade}分";
        }
        void GetMaxGrade(Grades ChineseScore, Grades EnglishScore, Grades MathScore)//透過邏輯判斷式來比大小
        {
            if (ChineseScore.Grade >= EnglishScore.Grade&&ChineseScore.Grade>=MathScore.Grade)
            {
                MaxGrade = ChineseScore;//最高的成績會複製欄位及成績給MaxGrade
            }
            else if(EnglishScore.Grade>= MathScore.Grade&& EnglishScore.Grade >= ChineseScore.Grade)
            {
                MaxGrade = EnglishScore;
            }
            else
            {
                MaxGrade = MathScore;
            }
        }
        void GetMinGrade(Grades ChineseScore, Grades EnglishScore, Grades MathScore)
        {
            if (ChineseScore.Grade <= EnglishScore.Grade && ChineseScore.Grade <= MathScore.Grade)
            {
                MinGrade = ChineseScore;//最低的成績會複製欄位及成績給MinGrade
            }
            else if (EnglishScore.Grade <= MathScore.Grade && EnglishScore.Grade <= ChineseScore.Grade)
            {
                MinGrade = EnglishScore;
            }
            else 
            {
                MinGrade = MathScore;
            }
        }
    }
}
