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
    public partial class Hw_Students_Grade : Form
    {
        public Hw_Students_Grade()
        {
            InitializeComponent();
        }
        private void InitialListView()
        {
            listViewAll.Columns.Add("姓名", 75);
            listViewAll.Columns.Add("國文", 40);
            listViewAll.Columns.Add("英文", 40);
            listViewAll.Columns.Add("數學", 40);
            listViewAll.Columns.Add("總分", 50);
            listViewAll.Columns.Add("平均", 50);
            listViewAll.Columns.Add("最低", 65);
            listViewAll.Columns.Add("最高", 65);

            listViewAvg.Columns.Add("欄位", 75);
            listViewAvg.Columns.Add("國文", 40);
            listViewAvg.Columns.Add("英文", 40);
            listViewAvg.Columns.Add("數學", 40);
        }
        #region Definition
        private string Name { get; set; }
        struct Grades//創建Struct 欄位有名稱跟成績
        {
            public string Name { get; set; }
            public int Grade { get; set; }
            public int Total { get; set; }
            public int Avg { get; set; }
            public int Max { get; set; }
            public int Min { get; set; }
        }
        private int RandomIndex = 1;

        Grades ChineseScore, EnglishScore, MathScore, MaxGrade, MinGrade;//創建國文、英文、數學、最大及最小的Struct
        #endregion
        private void Hw_Students_Grade_Load(object sender, EventArgs e)
        {
            InitialListView();
        }
        #region Click Event
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("請輸入姓名");
            }
            else if(txtChinese.Text == "")
            {
                MessageBox.Show("請輸入國文成績");
            }
            else if (txtEnglish.Text == "")
            {
                MessageBox.Show("請輸入英文成績");
            }
            else if (txtMath.Text == "")
            {
                MessageBox.Show("請輸入數學成績");
            }
            else
            {
                btnCalculate.Enabled = true;
                Name = txtName.Text;
                ChineseScore.Name = "國文";
                ChineseScore.Grade = Convert.ToInt32(txtChinese.Text);
                EnglishScore.Name = "英文";
                EnglishScore.Grade = Convert.ToInt32(txtEnglish.Text);
                MathScore.Name = "數學";
                MathScore.Grade = Convert.ToInt32(txtMath.Text);
                GetMaxGrade(ChineseScore, EnglishScore, MathScore);
                GetMinGrade(ChineseScore, EnglishScore, MathScore);
                double ScoresAvg; 
                string[] items = { txtName.Text, txtChinese.Text, txtEnglish.Text, txtMath.Text, 
                                    GetTotal(ChineseScore, EnglishScore, MathScore, out ScoresAvg).ToString(),
                                     ScoresAvg.ToString(), $"{MinGrade.Name}{MinGrade.Grade}", $"{MaxGrade.Name}{MaxGrade.Grade}" };
                var ListViewItems = new ListViewItem(items);
                listViewAll.Items.Add(ListViewItems);

            }
        }
        private void btnRandomSave_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
            Random ChineseRandom = new Random(Guid.NewGuid().GetHashCode());
            Random EnglishRandom = new Random(Guid.NewGuid().GetHashCode());
            Random MathRandom = new Random(Guid.NewGuid().GetHashCode());
            ChineseScore.Name = "國文";
            ChineseScore.Grade = ChineseRandom.Next(0, 100);
            EnglishScore.Name = "英文";
            EnglishScore.Grade = EnglishRandom.Next(0, 100);
            MathScore.Name = "數學";
            MathScore.Grade = MathRandom.Next(0, 100);
            GetMaxGrade(ChineseScore, EnglishScore, MathScore);
            GetMinGrade(ChineseScore, EnglishScore, MathScore);
            double ScoresAvg;
            string[] items = { Convert.ToString(RandomIndex) , Convert.ToString(ChineseScore.Grade),
                                Convert.ToString(EnglishScore.Grade), Convert.ToString(MathScore.Grade),
                                GetTotal(ChineseScore, EnglishScore, MathScore, out ScoresAvg).ToString(),
                                ScoresAvg.ToString(), $"{MinGrade.Name}{MinGrade.Grade}", $"{MaxGrade.Name}{MaxGrade.Grade}" };
            var ListViewItems = new ListViewItem(items);
            listViewAll.Items.Add(ListViewItems);
            RandomIndex++;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ChineseScore.Min = 100;
            EnglishScore.Min = 100;
            MathScore.Min = 100;
            for (int i = 0; i < listViewAll.Items.Count; i++)
            {
                ChineseScore.Total += int.Parse(listViewAll.Items[i].SubItems[1].Text);
                EnglishScore.Total += int.Parse(listViewAll.Items[i].SubItems[2].Text);
                MathScore.Total += int.Parse(listViewAll.Items[i].SubItems[3].Text);

                ChineseScore.Max = Math.Max(int.Parse(listViewAll.Items[i].SubItems[1].Text), ChineseScore.Max);
                EnglishScore.Max = Math.Max(int.Parse(listViewAll.Items[i].SubItems[2].Text), EnglishScore.Max);
                MathScore.Max = Math.Max(int.Parse(listViewAll.Items[i].SubItems[3].Text), MathScore.Max);

                ChineseScore.Min = Math.Min(int.Parse(listViewAll.Items[i].SubItems[1].Text), ChineseScore.Min);
                EnglishScore.Min = Math.Min(int.Parse(listViewAll.Items[i].SubItems[2].Text), EnglishScore.Min);
                MathScore.Min = Math.Min(int.Parse(listViewAll.Items[i].SubItems[3].Text), MathScore.Min);
            }
            ChineseScore.Avg = ChineseScore.Total / listViewAll.Items.Count;
            EnglishScore.Avg = EnglishScore.Total / listViewAll.Items.Count;
            MathScore.Avg = ChineseScore.Total / listViewAll.Items.Count;
            string[] items1 = { "總分", Convert.ToString(ChineseScore.Total), Convert.ToString(EnglishScore.Total), Convert.ToString(MathScore.Total) };
            string[] items2 = { "平均", Convert.ToString(ChineseScore.Avg), Convert.ToString(EnglishScore.Avg), Convert.ToString(MathScore.Avg) };
            string[] items3 = { "最高分", Convert.ToString(ChineseScore.Max), Convert.ToString(EnglishScore.Max), Convert.ToString(MathScore.Max) };
            string[] items4 = { "最低分", Convert.ToString(ChineseScore.Min), Convert.ToString(EnglishScore.Min), Convert.ToString(MathScore.Min) };
            var SumItem = new ListViewItem(items1);
            var SumItem2 = new ListViewItem(items2);
            var SumItem3 = new ListViewItem(items3);
            var SumItem4 = new ListViewItem(items4);
            listViewAvg.Items.Add(SumItem);
            listViewAvg.Items.Add(SumItem2);
            listViewAvg.Items.Add(SumItem3);
            listViewAvg.Items.Add(SumItem4);
            btnAddStudent.Enabled = false;
            btnCalculate.Enabled = false;
            btnRandomSave.Enabled = false;
            btnRandomAdd20.Enabled = false;
        }
        private void btnResetAll_Click(object sender, EventArgs e)
        {
            listViewAll.Items.Clear();
            listViewAvg.Items.Clear();
            RandomIndex = 1;
            ChineseScore.Total = 0;
            EnglishScore.Total = 0;
            MathScore.Total = 0;
            ChineseScore.Avg = 0;
            EnglishScore.Avg = 0;
            MathScore.Avg = 0;
            ChineseScore.Max = 0;
            EnglishScore.Max = 0;
            MathScore.Max = 0;
            ChineseScore.Min = 0;
            EnglishScore.Min = 0;
            MathScore.Min = 0;
            btnAddStudent.Enabled = true;
            btnRandomSave.Enabled = true;
            btnRandomAdd20.Enabled = true;
            btnCalculate.Enabled = false;
        }

        private void btnRandomAdd20_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
            Random ChineseRandom = new Random(Guid.NewGuid().GetHashCode());
            Random EnglishRandom = new Random(Guid.NewGuid().GetHashCode());
            Random MathRandom = new Random(Guid.NewGuid().GetHashCode());
            ChineseScore.Name = "國文";
            EnglishScore.Name = "英文";
            MathScore.Name = "數學";
            for(int i = 0; i < 20; i++)
            {
                ChineseScore.Grade = ChineseRandom.Next(0, 100);
                EnglishScore.Grade = EnglishRandom.Next(0, 100);
                MathScore.Grade = MathRandom.Next(0, 100);
                GetMaxGrade(ChineseScore, EnglishScore, MathScore);
                GetMinGrade(ChineseScore, EnglishScore, MathScore);
                double ScoresAvg;
                string[] items = { Convert.ToString(RandomIndex) , Convert.ToString(ChineseScore.Grade),
                                Convert.ToString(EnglishScore.Grade), Convert.ToString(MathScore.Grade),
                                GetTotal(ChineseScore, EnglishScore, MathScore, out ScoresAvg).ToString(),
                                ScoresAvg.ToString(), $"{MinGrade.Name}{MinGrade.Grade}", $"{MaxGrade.Name}{MaxGrade.Grade}" };
                var ListViewItems = new ListViewItem(items);
                listViewAll.Items.Add(ListViewItems);
                RandomIndex++;
            }
        }
        #endregion
        #region Method to Get最大最小總和平均
        void GetMaxGrade(Grades ChineseScore, Grades EnglishScore, Grades MathScore)//透過邏輯判斷式來比大小
        {
            if (ChineseScore.Grade >= EnglishScore.Grade && ChineseScore.Grade >= MathScore.Grade)
            {
                MaxGrade = ChineseScore;//最高的成績會複製欄位及成績給MaxGrade
            }
            else if (EnglishScore.Grade >= MathScore.Grade && EnglishScore.Grade >= ChineseScore.Grade)
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
        int GetTotal(Grades ChineseScore, Grades EnglishScore, Grades MathScore, out double Avg)
        {
            int Total = ChineseScore.Grade + EnglishScore.Grade + MathScore.Grade;
            Avg = Math.Round(Convert.ToDouble(Total) / 3, 1);
            return Total;
        }
        #endregion

    }

}
