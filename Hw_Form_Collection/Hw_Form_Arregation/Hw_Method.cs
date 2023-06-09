﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_Form_Arregation
{
    public partial class Hw_Method : Form
    {
        public Hw_Method()
        {
            InitializeComponent();
        }
        public int[] arr0711 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        public string[] arr0711_Str = new string[] { "Mother張", "Emma", "迪克蕭", "J40", "Candy", "Coconut", "MotherFucker" };
        private void btnOddOrEven_Click(object sender, EventArgs e)
        {
            try
            {
                int Num = int.Parse(txtNum.Text);
                if (Num % 2 == 0)
                {
                    labShow.Text = $"輸入的數 {Num}為 偶數";
                }
                else
                {
                    labShow.Text = $"輸入的數 {Num}為 奇數";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labShow.Text = "結果";
        }

        private void btnArrMaxMin_Click(object sender, EventArgs e)
        {
            int Max = 0;
            int Min = int.MaxValue;
            for(int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i] > Max)
                {
                    Max = arr0711[i];
                }
                if (arr0711[i] < Min)
                {
                    Min = arr0711[i];
                }
            }
            labShow.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為{Max}\n最小值為{Min}";
        }

        private void btnCountC_Click(object sender, EventArgs e)
        {
            int CountC = 0;
            for(int i = 0; i < arr0711_Str.Length; i++)
            {
                if (Regex.IsMatch(arr0711_Str[i], "C")){//檢查是否有符合的字母
                    CountC++;
                }
                if (Regex.IsMatch(arr0711_Str[i], "c"))
                {
                    CountC++;
                }
            }
            labShow.Text = $"string陣列arr0711_Str\n[\"Mother張\", \"Emma\", \"迪克蕭\", \"J40\", \"Candy\", \"Coconut\", \"MotherFucker\"]\n有C及c的名字一共有{CountC}個";
        }

        private void btnCountOddAndEven_Click(object sender, EventArgs e)
        {
            int CountOdd = 0;
            int CountEven = 0;
            for(int i = 0;i < arr0711.Length;i++)
            {
                if (arr0711[i] % 2 == 0)
                {
                    CountEven++;
                }
                else
                {
                    CountOdd++;
                }
            }
            labShow.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n奇數共{CountOdd}\n偶數共{CountEven}";
        }

        private void btnLongest_Click(object sender, EventArgs e)
        {
            string LongestName = "";
            for(int i = 0; i < arr0711_Str.Length; i++)
            {
                if (arr0711_Str[i].Length > LongestName.Length)//檢查長度是否大於另一個長度
                {
                    LongestName = arr0711_Str[i];
                }
            }
            labShow.Text = $"string陣列arr0711_Str\n[\"Mother張\", \"Emma\", \"迪克蕭\", \"J40\", \"Candy\", \"Coconut\", \"MotherFucker\"]\n最長的名字為{LongestName}";
        }

        private void btnOut1In0_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int[,] arr = new int[10, 10];
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if( i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        arr[i, j] = 1;
                        labShow.Text += arr[i, j];
                    }
                    else
                    {
                        arr[i, j] = 0;
                        labShow.Text += arr[i, j];
                    }
                }
                labShow.Text += "\n";
            }
        }

        private void btnIn0Out1_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int[,] arr = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        arr[i, j] = 0;
                        labShow.Text += arr[i, j];
                    }
                    else
                    {
                        arr[i, j] = 1;
                        labShow.Text += arr[i, j];
                    }
                }
                labShow.Text += "\n";
            }
        }

        private void btn1001_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            int[,] arr = new int[10, 10];
            for(int i  = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)//偶數row偶數column [0, 0], [2, 2]
                    {
                        arr[i, j] = 1;
                    }
                    else if (i % 2 != 0 && j % 2 != 0)//奇數row奇數column [1, 1], [3, 1]
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;

                    }
                    labShow.Text += arr[i, j];
                }
                labShow.Text += "\n";
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 200;
            labShow.Text = $"換位前n1 = {n1}, n2 = {n2}";
            Swap(ref n1, ref n2);
            /* Swap function也等於
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp; */
            labShow.Text += $"\n換位後n1 = {n1}, n2 = {n2}";
            
        }
        void Swap(ref int n1, ref int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }

        private void btnSumArray_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            for(int i = 0; i < arr0711.Length; i++)
            {
                Sum += arr0711[i];
            }
            labShow.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n加總為{Sum}";
        }

        private void btnMaxArray_Click(object sender, EventArgs e)
        {
            int Max = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                Max = Math.Max(Max, arr0711[i]);
            }
            labShow.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為{Max}";
        }

        private void btnMinArray_Click(object sender, EventArgs e)
        {
            int Min = int.MaxValue;
            for (int i = 0; i < arr0711.Length; i++)
            {
                Min = Math.Min(Min, arr0711[i]);
            }
            labShow.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最小值為{Min}";
        }
    }
}
