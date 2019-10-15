using MetroFramework.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMetro
{
    public partial class Form_Rank : MetroForm
    {
        public Form_Rank()
        {
            InitializeComponent();
        }

        public Form_History_Combat a
        {
            get => default;
            set
            {
            }
        }

        private void Form_Rank_Load(object sender, EventArgs e)
        {
            //var client = new RestClient("https://api.shisanshui.rtxux.xyz/rank");
            //var request = new RestRequest(Method.GET);
            //IRestResponse response = client.Execute(request);
            //JArray jo = (JArray)JsonConvert.DeserializeObject(response.Content);
            //string cc = response.GetResponseHeader("Location");
            List<Play_Rank_Info> list = new List<Play_Rank_Info>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.shisanshui.rtxux.xyz/rank");
            request.Method = "GET";
            request.AllowAutoRedirect = false;
            HttpWebResponse reponse = (HttpWebResponse)request.GetResponse();
            string cc = reponse.GetResponseHeader("Location");
            var client = new RestClient(cc);
            var request1 = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request1);
            JArray jo = (JArray)JsonConvert.DeserializeObject(response.Content);
            for (int i = 0; i < jo.Count; i++)
            {
                Play_Rank_Info play = new Play_Rank_Info();
                play.Id = (int)jo[i]["player_id"];
                play.Score=(int)jo[i]["score"];
                play.Name= jo[i]["name"].ToString();
                list.Add(play);
            }
            this.DGV_rank.DataSource =  new BindingList<Play_Rank_Info>(list);
        }
                /*点击即可查看该玩家的历史作战记录
                 */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_rank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_rank.CurrentCell.ColumnIndex == 0)
            {
                play_info.player_ID = (int)DGV_rank.CurrentCell.Value;
               Form_History_Combat form = new Form_History_Combat();
               form.ShowDialog();
            }
            
        }
    }
}
