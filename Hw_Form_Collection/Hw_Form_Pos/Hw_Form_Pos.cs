using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_Form_Pos
{
    public partial class Hw_Form_Pos : Form
    {
        #region 宣告變數
        //宣告Class內變數
        private int BeerAmount { get; set; }
        private int BeerTotal { get; set; }
        private int TequilaAmount { get; set; }
        private int TequilaTotal { get; set; }
        private int WhiskyAmount { get; set; }
        private int WhiskyTotal { get; set; }
        private int WineAmount { get; set; }
        private int WineTotal { get; set; }
        private int TotalPrice { get; set; }
        #endregion
        public Hw_Form_Pos()
        {
            InitializeComponent();
        }
        #region 酒類Click事件
        private void btnBeer_Click(object sender, EventArgs e)
        {
            BeerTotal += 120;
            BeerAmount++;
            labTotal.Text = "NT$" + Convert.ToString(TotalPrice += 120);
            int BeerIndex = listShopping.FindString("啤酒Beer");//找尋酒類關鍵字
            int SpaceIndex = listShopping.FindString("尚未點餐"); //找尋是否清單為空

            for (int i = 0; i < listShopping.Items.Count; i++)//從ListBox找尋有關鍵字的String
            {
                if (BeerIndex == -1)
                {
                    if(SpaceIndex != -1)
                    {
                        listShopping.Items.RemoveAt(SpaceIndex); //移除尚未點餐的Index
                        listShopping.Items.Add($"啤酒Beer x{BeerAmount},共NT${BeerTotal}元"); //加入至ListBox
                    }
                    else//如果有其他酒類先加入了就不用尋找尚未點餐
                    {
                        listShopping.Items.Add($"啤酒Beer x{BeerAmount},共NT${BeerTotal}元");
                    }
                    
                    break;
                }
                else
                {
                    listShopping.Items.RemoveAt(BeerIndex);//移除目前Beer顯示在ListBox的Index
                    listShopping.Items.Insert(BeerIndex, $"啤酒Beer x{BeerAmount},共NT${BeerTotal}元");//加入新增的Beer數量和金額
                    break;
                }

            }
        }

        private void btnTequlia_Click(object sender, EventArgs e)
        {
            TequilaTotal += 590;
            TequilaAmount++;
            labTotal.Text = "NT$" + Convert.ToString(TotalPrice += 590);
            int TequliaIndex = listShopping.FindString("龍舌蘭Tequila");//找尋酒類關鍵字
            int SpaceIndex = listShopping.FindString("尚未點餐");//找尋是否清單為空
            for (int i = 0; i < listShopping.Items.Count; i++)//從ListBox找尋有關鍵字的String
            {
                if (TequliaIndex == -1)
                {
                   
                    if(SpaceIndex != -1)
                    {
                        listShopping.Items.RemoveAt(SpaceIndex);
                        listShopping.Items.Insert(SpaceIndex, $"龍舌蘭Tequila x{TequilaAmount},共NT${TequilaTotal}元");
                    }
                    else
                    {
                        listShopping.Items.Add($"龍舌蘭Tequila x{TequilaAmount},共NT${TequilaTotal}元");
                    }
                    
                    break;
                }
                else
                {
                    listShopping.Items.RemoveAt(TequliaIndex);
                    listShopping.Items.Insert(TequliaIndex, $"龍舌蘭Tequila x{TequilaAmount},共NT${TequilaTotal}元");
                    break;
                }

            }

        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            WhiskyTotal += 450;
            WhiskyAmount++;
            labTotal.Text = "NT$" + Convert.ToString(TotalPrice += 450);
            int WhiskyIndex = listShopping.FindString("威士忌Whisky");//找尋酒類關鍵字
            int SpaceIndex = listShopping.FindString("尚未點餐");//找尋是否清單為空
            for (int i = 0; i < listShopping.Items.Count; i++)//從ListBox找尋有關鍵字的String
            {
                if (WhiskyIndex == -1)
                {

                    if (SpaceIndex != -1)
                    {
                        listShopping.Items.RemoveAt(SpaceIndex);
                        listShopping.Items.Insert(SpaceIndex, $"威士忌Whisky x{WhiskyAmount},共NT${WhiskyTotal}元");
                    }
                    else
                    {
                        listShopping.Items.Add($"威士忌Whisky x{WhiskyAmount},共NT${WhiskyTotal}元");
                    }

                    break;
                }
                else
                {
                    listShopping.Items.RemoveAt(WhiskyIndex);
                    listShopping.Items.Insert(WhiskyIndex, $"威士忌Whisky x{WhiskyAmount},共NT${WhiskyTotal}元");
                    break;
                }

            }

        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            WineTotal += 220;
            WineAmount++;
            labTotal.Text = "NT$" + Convert.ToString(TotalPrice += 220);
            int WineIndex = listShopping.FindString("紅酒Wine");//找尋酒類關鍵字
            int SpaceIndex = listShopping.FindString("尚未點餐");//找尋是否清單為空
            for (int i = 0; i < listShopping.Items.Count; i++)//從ListBox找尋有關鍵字的String
            {
                if (WineIndex == -1)
                {
                    if (SpaceIndex != -1)
                    {
                        listShopping.Items.RemoveAt(SpaceIndex);
                        listShopping.Items.Add($"紅酒Wine x{WineAmount},共NT${WineTotal}元");
                    }
                    else
                    {
                        listShopping.Items.Add($"紅酒Wine x{WineAmount},共NT${WineTotal}元");
                    }

                    break;
                }
                else
                {
                    listShopping.Items.RemoveAt(WineIndex);
                    listShopping.Items.Insert(WineIndex, $"紅酒Wine x{WineAmount},共NT${WineTotal}元");
                    break;
                }

            }
        }
        #endregion
        #region 結帳事件
        private void btnCash_Click(object sender, EventArgs e)
        {
            if(TotalPrice == 0)
            {
                MessageBox.Show("尚未點餐!");
            }
            else
            {
                MessageBox.Show($"總金額: NT${TotalPrice}", "確認付款", MessageBoxButtons.OKCancel, MessageBoxIcon.None);//MessageBox.Show(內容, 標題, 選項, 圖示)
            }
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            if (TotalPrice == 0)
            {
                MessageBox.Show("尚未點餐!");
            }
            else
            {
                int TotalDiscountPrice = int.Parse(Convert.ToString(Math.Round(TotalPrice * 0.9)));
                MessageBox.Show($"總金額: NT${TotalPrice}\n折扣後金額: NT${TotalDiscountPrice}", "確認付款", MessageBoxButtons.OKCancel, MessageBoxIcon.None);//MessageBox.Show(內容, 標題, 選項, 圖示)
            }
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e) //全體歸零重新計算
        {
            TotalPrice = 0;
            BeerAmount = 0;
            BeerTotal = 0;
            TequilaAmount = 0;
            TequilaTotal = 0;
            WhiskyAmount = 0;
            WhiskyTotal = 0;
            WineAmount = 0;
            WineTotal = 0;
            labTotal.Text = "NT$0 ";
            listShopping.Items.Clear();
            listShopping.Items.Add("尚未點餐");

        }

        private void Hw_Form_Pos_Load(object sender, EventArgs e)
        {
            listShopping.Items.Add("尚未點餐");//一開始要先讓List有一個Object，才可以讓點的酒加入
        }
    }
}
