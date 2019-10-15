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
    public partial class FormRegister : MetroForm
    {
        public FormRegister()
        {
            InitializeComponent();
            InitButtonTooltip();
        }

        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
        private void InitButtonTooltip()
        {
            ToolTip ttSetp1 = new System.Windows.Forms.ToolTip();
            ttSetp1.SetToolTip(Button_Reg, "点击注册");
        }
        private void Button_Reg_Click(object sender, EventArgs e)
        {
            if (Textbox_Username1.Text == null)
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (Textbox_Password1.Text == null)
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            if (Textbox_Password1.Text.Trim() != TextBox_Confirm.Text.Trim())
            {
                MessageBox.Show("两次密码输入不相同");
                return;
            }
            var client = new RestClient("https://api.shisanshui.rtxux.xyz/auth/register");
            var request = new RestRequest(Method.POST);
            //string json = ClassToJson();
            User user = new User
            {
                username = Textbox_Username1.Text.Trim().ToString(),
                password = Textbox_Password1.Text.Trim().ToString()
            };
            var json = JsonConvert.SerializeObject(user);
            Console.WriteLine(json);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var contentPost = response.Content;
            Console.Read();
            JObject jo = (JObject)JsonConvert.DeserializeObject(contentPost);
            if ((int)jo["status"] == 1001)
            {
                MessageBox.Show("该账号已被注册！");
                return;
            }
            else
            {
                MessageBox.Show("注册成功！");
                
            }

        }

        private void Textbox_Password1_Click(object sender, EventArgs e)
        {

        }
    }
}
