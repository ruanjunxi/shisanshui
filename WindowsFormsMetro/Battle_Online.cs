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
    public partial class Battle_Online : Form
    {
        public Battle_Online()
        {
            InitializeComponent();
        }

        private void Battle_Online_Load(object sender, EventArgs e)
        {

        }


        private void skinButton1_Click(object sender, EventArgs e)  //寻找对局
        {
            string Json_Repost = APIHelper.HttpPost("https://api.shisanshui.rtxux.xyz/game/open", "", User_With_Token.Token);
            JObject jo = (JObject)JsonConvert.DeserializeObject(Json_Repost);
            string Card = jo["data"]["card"].ToString();
            MyCard.id = (int)jo["data"]["id"];
            Discard.id = MyCard.id;    //战局Id
            List<int> card = new List<int>();
            card = MyCard.Str_To_Card(Card);          //Mycard.Str_To_Card(Card);
            MyCard.My_Card = card;                     // 获得牌型对应的数字
            this.Hide();
            Sendcard send = new Sendcard();
            send.ShowDialog();
        }
    }
}
