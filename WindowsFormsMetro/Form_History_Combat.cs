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
    public partial class Form_History_Combat : Form
    {
        public Form_History_Combat()
        {
            InitializeComponent();
        }

        public battle_detail battle_detail
        {
            get => default;
            set
            {
            }
        }

        private void Form_History_Combat_Load(object sender, EventArgs e)
        {
            List<Player_History> list = new List<Player_History>();
            string url = "https://api.shisanshui.rtxux.xyz/history?page=1&limit=10&player_id=" + play_info.player_ID.ToString();
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-auth-token", User_With_Token.Token);
            IRestResponse response = client.Execute(request);
            string info = response.Content;
            JObject jo = (JObject)JsonConvert.DeserializeObject(info);
            if ((int)jo["status"] == 0)
            {
                foreach (var item in jo["data"])
                {
                        Player_History player = new Player_History();
                        player.Combat_Id = (int)item["id"];
                        player.Card = item["card"].ToString();
                        player.Score = (int)item["score"];
                        player.Timestamp = (int)item["timestamp"];
                        list.Add(player);
                }
                DGV_Combat.DataSource = new BindingList<Player_History>(list);
            }
        }

        private void DGV_Combat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DGV_Combat.CurrentCell.ColumnIndex == 0)
            {
                // play_info.player_ID = (int)DGV_Combat.CurrentCell.Value;
                play_info.Combat_Selected_Id= (int)DGV_Combat.CurrentCell.Value;
                battle_detail form = new battle_detail();
                form.ShowDialog();
            }
        }
    }
}
