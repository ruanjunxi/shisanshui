using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMetro
{
    public partial class Sendcard : Form
    {
        public Sendcard()
        {
            InitializeComponent();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
          
            //将理好的牌转化为字符串数组
            Discard.Card_To_Str();
            SendCard();
            //出完牌后，将list清空
            clear();

        }
        //public static List<int> PreList = new List<int> { };
        //public static List<int> MidList = new List<int> { };
        //public static List<int> AftList = new List<int> { };
        private void clear()
        {
            MyCard.AftList.Clear();
            MyCard.MidList.Clear();
            MyCard.PreList.Clear();
            MyCard.My_Card.Clear();
            for(int i = 0; i < 3; i++)
            {
                Discard.array_card[i] = null;
            }
        }

        private void SendCard()
        {
            json js = new json();
            js.id = Discard.id;
            js.card = Discard.array_card;
            string jsonStr = JsonConvert.SerializeObject(js);
            //string contentPost = APIHelper.HttpPost("https://api.shisanshui.rtxux.xyz/game/submit", jsonStr, User_With_Token.Token);
            var client = new RestClient("https://api.shisanshui.rtxux.xyz/game/submit");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("x-auth-token", User_With_Token.Token);
            request.AddParameter("application/json", jsonStr, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            string contentPost = response.Content;
            JObject jo = (JObject)JsonConvert.DeserializeObject(contentPost);
            if ((int)jo["status"] == 2001)
            {
                MessageBox.Show("未结束战局过多！");
            }
            else if ((int)jo["status"] == 2003)
            {
                MessageBox.Show("不合法墩牌,或战局已结束！");
            }
            else if ((int)jo["status"] == 3001)
            {
                MessageBox.Show("战局不存在或未结束!");
            }
            if ((int)jo["status"] == 0)
            {
                MessageBox.Show("出牌成功！");
            }
        }

        private void Sendcard_Load(object sender, EventArgs e)
        {
            List<CardModel> cmlist = new List<CardModel>();
            List<int> templist = new List<int>();
            cmlist = AI_Helper.GetAllResult(cmlist, MyCard.My_Card);
            foreach (var item2 in cmlist[0].typeCardList)
            {
                templist.AddRange(item2.cardList);
            }
            //将理后的牌放入三墩；    
            for (int i = 0; i < templist.Count; i++)
            {
                if (i < 5)    //后墩
                {
                    MyCard.AftList.Add(templist[i]);
                }
                else if (i >= 5 && i < 10)    //中墩
                {
                    MyCard.MidList.Add(templist[i]);
                }
                else   //前墩
                {
                    MyCard.PreList.Add(templist[i]);
                }

            }
            List<int> list = new List<int>();
            list.AddRange(MyCard.PreList);
            list.AddRange(MyCard.MidList);
            list.AddRange(MyCard.AftList);
            LoadCard(list);
        }

        /// <summary>
        /// 根据传入的牌型在相应的picturebox里加载
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="cardtype"></param>
        /// CCWin.SkinControl.SkinPictureBox spb
        private void LoadCard(List<int> list)
        {
            int i = 0;
            //string card = cardtype;
            //if (card[0] == '*')
            //{
            //    card = card.Substring(1);
            //    spb.Load("images/扑克牌图片/_" + card + ".jpg");
            //}
            //else
            //{
            //    spb.Load("images/扑克牌图片/" + card + ".jpg");

            //}
            //D:\c#\practice\WindowsFormsMetro\Resources\card\
            if (i < 3)  //前墩
            {
                i += 3;
                PB_Pre1.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[0].ToString() + ".jpg");
                PB_Pre_2.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[1].ToString() + ".jpg");
                PB_Pre3.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[2].ToString() + ".jpg");
            }
             if (i >= 3 && i < 8)  //中墩
            {
                i += 5;
                PB_Mid_1.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\"+list[3].ToString()+".jpg");
                PB_Mid2.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[4].ToString() + ".jpg");
                PB_Mid3.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[5].ToString() + ".jpg");
                PB_Mid4.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[6].ToString() + ".jpg");
                PB_Mid5.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[7].ToString() + ".jpg");
                    
            }
            if(i>=8)   //后墩
            {
                i += 5;
                PB_Aft1.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[8].ToString() + ".jpg");
                PB_Aft2.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[9].ToString() + ".jpg");
                PB_Aft3.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[10].ToString() + ".jpg");
                PB_Aft4.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[11].ToString() + ".jpg");
                PB_Aft5.BackgroundImage = Image.FromFile("D:\\c#\\practice\\WindowsFormsMetro\\Resources\\card\\" + list[12].ToString() + ".jpg");
            }
        }
    }
   
}
