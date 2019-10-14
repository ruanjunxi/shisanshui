using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMetro
{
    class Discard
    {
        public static int id;
        //public static List<int> PreList;
        //public static List<int> MidList;
        //public static List<int> AftList;
        public static string[] array_card = new string[3];
        public static void Card_To_Str()
        {
            int count = 0;
            List<int> list = new List<int>();
            list.AddRange(MyCard.PreList);
            list.AddRange(MyCard.MidList);
            list.AddRange(MyCard.AftList);
            foreach (var item in list)
            {
                if (count < 3)//添加前墩
                {
                    array_card[0] += convert_huase(item / 100);
                    if (item % 100 == 10)
                    {
                        array_card[0] += convert_num(item % 100);
                        array_card[0] += '0';
                    }
                    else array_card[0] += convert_num(item % 100);
                    if (count < 2)
                    {
                        array_card[0] += ' ';
                    }
                }
                else if (count >= 3 && count < 8)
                {
                    array_card[1] += convert_huase(item / 100);
                    if (item % 100 == 10)
                    {
                        array_card[1] += convert_num(item % 100);
                        array_card[1] += '0';
                    }
                    else array_card[1] += convert_num(item % 100);
                    if (count < 7)
                    {
                        array_card[1] += ' ';
                    }
                }
                else   //count>=8
                {
                    array_card[2] += convert_huase(item / 100);
                    if (item % 100 == 10)
                    {
                        array_card[2] += convert_num(item % 100);
                        array_card[2] += '0';
                    }
                    else array_card[2] += convert_num(item % 100);
                    if (count < 12)
                    {
                        array_card[2] += ' ';
                    }
                }
                count++;
            }
        }
        public static char convert_num(int num)
        {
            if (num == 14)
            {
                return 'A';
            }
            else if (num == 13)
            {
                return 'K';
            }
            else if (num == 12)
            {
                return 'Q';
            }
            else if (num == 11)
            {
                return 'J';
            }
            else if (num == 10)  //(num==10)
            {
                return '1';
            }
            else if (num == 9)
            {
                return '9';
            }
            else if (num == 8)
            {
                return '8';
            }
            else if (num == 7)
            {
                return '7';
            }
            else if (num == 6)
            {
                return '6';
            }
            else if (num == 5)
            {
                return '5';
            }
            else if (num == 4)
            {
                return '4';
            }
            else if (num == 3)
            {
                return '3';
            }
            else //num==2
            {
                return '2';
            }
        }
        public static char convert_huase(int num)
        {
            if (num == 1)
            {
                return '$';
            }
            else if (num == 2)
            {
                return '&';
            }
            else if (num == 3)
            {
                return '*';
            }
            else
            {
                return '#';
            }
        }
    }
}
