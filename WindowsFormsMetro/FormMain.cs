using System;
using System.Collections.Generic;
using System.ComponentModel;
using MetroFramework.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMetro
{
    public partial class FormMain : MetroForm
    {
        int count = 0;//窗口数量
        public FormMain()
        {
            InitializeComponent();
        }

        public Form_Rank Form_Rank
        {
            get => default;
            set
            {
            }
        }

        public Battle_Online Battle_Online
        {
            get => default;
            set
            {
            }
        }

        public Form_History_Combat Form_History_Combat
        {
            get => default;
            set
            {
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            skinPictureBox1.SendToBack();

        }

        private void button_Online_Click(object sender, EventArgs e)
        {
            
           
        }

        private void skinButton1_Click(object sender, EventArgs e)  //显示排行榜
        {
            Form_Rank form = new Form_Rank();
            form.ShowDialog();
        }

        private void buttonOnline_Click(object sender, EventArgs e)
        {

                Battle_Online form = new Battle_Online();
                count++;
                form.ShowDialog();
            

            //var client = new RestClient("http://shisanshui.rtxux.xyz/game/open");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("x-auth-token", User.Token);
            //IRestResponse response = client.Execute(request);
            //var contentPost = response.Content;
            //JObject jo = (JObject)JsonConvert.DeserializeObject(contentPost);
            //string Card = jo["data"]["Card"].ToString();
            //MessageBox.Show(Card);
        }

       

        private void btn_AI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能尚未实现，等待开发组的更新！");
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            military_exploits form = new military_exploits();
            form.ShowDialog();
        }
    }
}
