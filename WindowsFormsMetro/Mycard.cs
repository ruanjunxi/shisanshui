using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMetro
{
    public class MyCard
    {
        public static int id;    //这个战局的id
        public static List<int> PreList =new List<int> { } ;
        public static List<int> MidList = new List<int> { };
        public static List<int> AftList = new List<int> { };
        public static List<int> My_Card = new List<int> { };
        public static List<int> Str_To_Card(string card)
        {
            List<int> listCard = new List<int>();
            for (int i = 0; i < card.Length; i += 3)
            {
                if (card[i + 1] == '1')   //此时牌面为10；
                {
                    if (card[i] == '$')
                    {
                        listCard.Add(100 + convert2('1'));
                        i++;
                    }
                    else if (card[i] == '&')
                    {
                        listCard.Add(200 + convert2('1'));
                        i++;
                    }
                    else if (card[i] == '*')
                    {
                        listCard.Add(300 + convert2('1'));
                        i++;
                    }
                    else if (card[i] == '#')
                    {
                        listCard.Add(400 + convert2('1'));
                        i++;
                    }
                }
                else
                {
                    if (card[i] == '$')
                    {
                        listCard.Add(100 + convert2(card[i + 1]));
                    }
                    else if (card[i] == '&')
                    {
                        listCard.Add(200 + convert2(card[i + 1]));
                    }
                    else if (card[i] == '*')
                    {
                        listCard.Add(300 + convert2(card[i + 1]));
                    }
                    else if (card[i] == '#')
                    {
                        listCard.Add(400 + convert2(card[i + 1]));
                    }
                }

            }
            return listCard;
        }
        /// <summary>
        /// 转换牌面数字,在上述函数中使用；
        /// </summary>
        /// <param name="tmp"></param>
        /// <returns></returns>
        public static int convert2(char tmp)
        {
            if (tmp == 'A')
            {
                return 14;
            }
            else if (tmp == 'J')
            {
                return 11;
            }
            else if (tmp == 'Q')
            {
                return 12;
            }
            else if (tmp == 'K')
            {
                return 13;
            }
            else if (tmp == '1')
            {
                return 10;
            }
            else
            {
                return tmp - 48;
            }
        }

    }
}

