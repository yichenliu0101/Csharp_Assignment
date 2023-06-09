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
    public partial class Hw_Students_Grade_List : Form
    {
        public Hw_Students_Grade_List()
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

            SearchOutput.Columns.Add("姓名", 75);
            SearchOutput.Columns.Add("國文", 40);
            SearchOutput.Columns.Add("英文", 40);
            SearchOutput.Columns.Add("數學", 40);
            SearchOutput.Columns.Add("總分", 50);
            SearchOutput.Columns.Add("平均", 50);
            SearchOutput.Columns.Add("最低", 65);
            SearchOutput.Columns.Add("最高", 65);
        }

        private void Hw_Students_Grade_List_Load(object sender, EventArgs e)
        {
            InitialListView();
        }
        #region Definition
        private string Name { get; set; }
        struct Grades//創建Struct 欄位有名稱跟成績
        {
            public string Name { get; set; }
            public uint Grade { get; set; }
            public uint Total { get; set; }
            public uint Avg { get; set; }
            public uint Max { get; set; }
            public uint Min { get; set; }
        }
        Grades ChineseScore, EnglishScore, MathScore, MaxGrade, MinGrade;//創建國文、英文、數學、最大及最小的Struct  
        #endregion
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                listViewAll.Visible = true;
                SearchOutput.Visible = false;
                if (txtName.Text == "")
                {
                    MessageBox.Show("請輸入姓名");
                }
                else if (txtChinese.Text == "")
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
                    Name = txtName.Text;
                    ChineseScore.Name = "國文";
                    ChineseScore.Grade = Convert.ToUInt32(txtChinese.Text);
                    EnglishScore.Name = "英文";
                    EnglishScore.Grade = Convert.ToUInt32(txtEnglish.Text);
                    MathScore.Name = "數學";
                    MathScore.Grade = Convert.ToUInt32(txtMath.Text);
                    if(ChineseScore.Grade > 100 ||  EnglishScore.Grade > 100 ||MathScore.Grade > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    GetMaxGrade(ChineseScore, EnglishScore, MathScore);
                    GetMinGrade(ChineseScore, EnglishScore, MathScore);
                    double ScoresAvg;
                    string[] items = { txtName.Text, txtChinese.Text, txtEnglish.Text, txtMath.Text,
                                    GetTotal(ChineseScore, EnglishScore, MathScore, out ScoresAvg).ToString(),
                                     ScoresAvg.ToString(), $"{MinGrade.Name}{MinGrade.Grade}", $"{MaxGrade.Name}{MaxGrade.Grade}" };
                    var ListViewItems = new ListViewItem(items);
                    listViewAll.Items.Add(ListViewItems);
                    btnStat.Enabled = true;
                    listViewAll.Visible = true;
                    SearchOutput.Visible = false;
                    btnRemove.Enabled = true;
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("請輸入0~100的數字");
                txtChinese.Text = "";
                txtEnglish.Text = "";
                txtMath.Text = "";
                txtChinese.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("請輸入數字");
                txtChinese.Text = "";
                txtEnglish.Text = "";
                txtMath.Text = "";
                txtChinese.Focus();
            }


        }
        private void btnResetAll_Click(object sender, EventArgs e)
        {
            listViewAll.Visible = true;
            SearchOutput.Visible = false;
            listViewAll.Items.Clear();
            listViewAvg.Items.Clear();
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
            btnRemove.Enabled = false;
            btnStat.Enabled = false;
            btnAddStudent.Enabled = true;
            btnInsertSave.Enabled = true;
        }
        private void btnStat_Click(object sender, EventArgs e)
        {
            listViewAll.Visible = true;
            SearchOutput.Visible = false;
            ChineseScore.Min = 100;
            EnglishScore.Min = 100;
            MathScore.Min = 100;
            for (int i = 0; i < listViewAll.Items.Count; i++)
            {
                ChineseScore.Total += uint.Parse(listViewAll.Items[i].SubItems[1].Text);
                EnglishScore.Total += uint.Parse(listViewAll.Items[i].SubItems[2].Text);
                MathScore.Total += uint.Parse(listViewAll.Items[i].SubItems[3].Text);

                ChineseScore.Max = Math.Max(uint.Parse(listViewAll.Items[i].SubItems[1].Text), ChineseScore.Max);
                EnglishScore.Max = Math.Max(uint.Parse(listViewAll.Items[i].SubItems[2].Text), EnglishScore.Max);
                MathScore.Max = Math.Max(uint.Parse(listViewAll.Items[i].SubItems[3].Text), MathScore.Max);

                ChineseScore.Min = Math.Min(uint.Parse(listViewAll.Items[i].SubItems[1].Text), ChineseScore.Min);
                EnglishScore.Min = Math.Min(uint.Parse(listViewAll.Items[i].SubItems[2].Text), EnglishScore.Min);
                MathScore.Min = Math.Min(uint.Parse(listViewAll.Items[i].SubItems[3].Text), MathScore.Min);
            }
            ChineseScore.Avg = ChineseScore.Total / Convert.ToUInt32(listViewAll.Items.Count);
            EnglishScore.Avg = EnglishScore.Total / Convert.ToUInt32(listViewAll.Items.Count);
            MathScore.Avg = ChineseScore.Total / Convert.ToUInt32(listViewAll.Items.Count);
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
            btnRemove.Enabled = false;
            btnStat.Enabled = false;
            btnInsertSave.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listViewAll.Items.Count == 1)
            {
                btnRemove.Enabled = false;
                btnStat.Enabled = false;
            }
            listViewAll.Items.RemoveAt(0);
        }
        private void btnInsertSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("請輸入姓名");
                }
                else if (txtChinese.Text == "")
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
                    Name = txtName.Text;
                    ChineseScore.Name = "國文";
                    ChineseScore.Grade = Convert.ToUInt32(txtChinese.Text);
                    EnglishScore.Name = "英文";
                    EnglishScore.Grade = Convert.ToUInt32(txtEnglish.Text);
                    MathScore.Name = "數學";
                    MathScore.Grade = Convert.ToUInt32(txtMath.Text);
                    GetMaxGrade(ChineseScore, EnglishScore, MathScore);
                    GetMinGrade(ChineseScore, EnglishScore, MathScore);
                    double ScoresAvg;
                    string[] items = { txtName.Text, txtChinese.Text, txtEnglish.Text, txtMath.Text,
                                    GetTotal(ChineseScore, EnglishScore, MathScore, out ScoresAvg).ToString(),
                                     ScoresAvg.ToString(), $"{MinGrade.Name}{MinGrade.Grade}", $"{MaxGrade.Name}{MaxGrade.Grade}" };
                    var ListViewItems = new ListViewItem(items);
                    listViewAll.Items.Insert(0, ListViewItems);
                    btnStat.Enabled = true;
                    listViewAll.Visible = true;
                    SearchOutput.Visible = false;
                    btnRemove.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("請輸入數字");
                txtChinese.Text = "";
                txtEnglish.Text = "";
                txtMath.Text = "";
                txtChinese.Focus();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchOutput.Items.Clear();
                SearchOutput.Visible = true;
                uint ChineseMin = Convert.ToUInt32(txtSearchMin.Text);
                uint ChineseMax = Convert.ToUInt32(txtSearchMax.Text);
                if(ChineseMin > ChineseMax)
                {
                    uint temp = ChineseMin;
                    ChineseMin = ChineseMax;
                    ChineseMax = temp;
                }
                for (int i = 0; i < listViewAll.Items.Count; i++)
                {
                    if (Convert.ToUInt32(listViewAll.Items[i].SubItems[1].Text) >= ChineseMin &&
                        Convert.ToUInt32(listViewAll.Items[i].SubItems[1].Text) <= ChineseMax)
                    {
                        string[] SearchCollection = new string[] { listViewAll.Items[i].SubItems[0].Text, listViewAll.Items[i].SubItems[1].Text, listViewAll.Items[i].SubItems[2].Text, listViewAll.Items[i].SubItems[3].Text,
                        listViewAll.Items[i].SubItems[4].Text, listViewAll.Items[i].SubItems[5].Text, listViewAll.Items[i].SubItems[6].Text, listViewAll.Items[i].SubItems[7].Text };
                        ListViewItem SearchItems = new ListViewItem(SearchCollection);
                        SearchOutput.Items.Add(SearchItems);
                    }
                }
                listViewAll.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("請輸入數字");
                txtSearchMin.Text = "";
                txtSearchMax.Text = "";
                txtSearchMin.Focus();
            }



        }
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
        uint GetTotal(Grades ChineseScore, Grades EnglishScore, Grades MathScore, out double Avg)
        {
            uint Total = ChineseScore.Grade + EnglishScore.Grade + MathScore.Grade;
            Avg = Math.Round(Convert.ToDouble(Total) / 3, 1);
            return Total;
        }
        #endregion
    }
}
