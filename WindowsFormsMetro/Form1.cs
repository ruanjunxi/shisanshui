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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMetro
{
    public partial class Form1:MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            InitButtonTooltip();
        }
        private void InitButtonTooltip()
        {
            ToolTip ttSetp1 = new System.Windows.Forms.ToolTip();
            ttSetp1.SetToolTip(Button_Login, "点击登陆");
            ttSetp1.SetToolTip(Button_Register, "我要注册");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {
            FormRegister form = new FormRegister();
            
        }
        private void Button_Register_Click(object sender, EventArgs e)
        {
            FormRegister form = new FormRegister();
            form.ShowDialog();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            if (Textbox_Username.Text == null)
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (Textbox_Password.Text == null)
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            var client = new RestClient("https://api.shisanshui.rtxux.xyz/auth/login");
            var request = new RestRequest(Method.POST);

            //string json = ClassToJson();
            User user = new User
            {
                username = Textbox_Username.Text.Trim().ToString(),
                password = Textbox_Password.Text.Trim().ToString()
            };
            
            var json = JsonConvert.SerializeObject(user);
            //string contentPost=APIHelper.HttpPost("https://api.shisanshui.rtxux.xyz/auth/login", json, "");
            //var json = JsonConvert.SerializeObject(user);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var contentPost = response.Content;
            JObject jo = (JObject)JsonConvert.DeserializeObject(contentPost);
            if ((int)jo["status"] != 0)
            {
                MessageBox.Show("账号不存在或密码错误！");
                return;
            }
            else
            {
                User_With_Token.username = user.username;
                User_With_Token.password = user.password;
                MessageBox.Show("登陆成功！");
                string Token = jo["data"]["token"].ToString();
                int id = (int)jo["data"]["user_id"];
                User_With_Token.Token = Token;
                //  MessageBox.Show(Token);
                Console.Read();
                this.DialogResult = DialogResult.OK;
            }
          

        }
    }
}
