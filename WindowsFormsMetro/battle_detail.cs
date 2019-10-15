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
    public partial class battle_detail : Form
    {
        public battle_detail()
        {
            InitializeComponent();
        }

        private void battle_detail_Load(object sender, EventArgs e)
        {
           
            List<Battal_Detail_Info> list = new List<Battal_Detail_Info>();
            string url= "https://api.shisanshui.rtxux.xyz/history/";
            url += play_info.Combat_Selected_Id.ToString();
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-auth-token", User_With_Token.Token);
            IRestResponse response = client.Execute(request);
            string info = response.Content;
            JObject jo = (JObject)JsonConvert.DeserializeObject(info);
            if ((int)jo["status"] == 0)
            {
                foreach (var item in jo["data"]["detail"])
                {
                    Battal_Detail_Info temp = new Battal_Detail_Info();
                    temp.player_id = (int)item["player_id"];
                    temp.name = item["name"].ToString();
                    temp.score = (int)item["score"];
                    temp.card = item["card"].ToString();
                    list.Add(temp);
                }
                DGV_Combat_Detail.DataSource = new BindingList<Battal_Detail_Info>(list);
            }
        }
    }
}
