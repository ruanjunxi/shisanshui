namespace WindowsFormsMetro
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Login = new MetroFramework.Controls.MetroButton();
            this.Textbox_Username = new MetroFramework.Controls.MetroTextBox();
            this.Textbox_Password = new MetroFramework.Controls.MetroTextBox();
            this.Username = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Button_Login
            // 
            this.Button_Login.CausesValidation = false;
            this.Button_Login.Location = new System.Drawing.Point(143, 315);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(180, 29);
            this.Button_Login.TabIndex = 0;
            this.Button_Login.Text = "登陆";
            this.Button_Login.UseSelectable = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Textbox_Username
            // 
            // 
            // 
            // 
            this.Textbox_Username.CustomButton.Image = null;
            this.Textbox_Username.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.Textbox_Username.CustomButton.Name = "";
            this.Textbox_Username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Textbox_Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Textbox_Username.CustomButton.TabIndex = 1;
            this.Textbox_Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Textbox_Username.CustomButton.UseSelectable = true;
            this.Textbox_Username.CustomButton.Visible = false;
            this.Textbox_Username.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Textbox_Username.Lines = new string[0];
            this.Textbox_Username.Location = new System.Drawing.Point(143, 120);
            this.Textbox_Username.MaxLength = 32767;
            this.Textbox_Username.Name = "Textbox_Username";
            this.Textbox_Username.PasswordChar = '\0';
            this.Textbox_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Textbox_Username.SelectedText = "";
            this.Textbox_Username.SelectionLength = 0;
            this.Textbox_Username.SelectionStart = 0;
            this.Textbox_Username.ShortcutsEnabled = true;
            this.Textbox_Username.Size = new System.Drawing.Size(180, 23);
            this.Textbox_Username.TabIndex = 2;
            this.Textbox_Username.UseSelectable = true;
            this.Textbox_Username.WaterMarkColor = System.Drawing.Color.Black;
            this.Textbox_Username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Textbox_Password
            // 
            this.Textbox_Password.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.Textbox_Password.CustomButton.Image = null;
            this.Textbox_Password.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.Textbox_Password.CustomButton.Name = "";
            this.Textbox_Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Textbox_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Textbox_Password.CustomButton.TabIndex = 1;
            this.Textbox_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Textbox_Password.CustomButton.UseSelectable = true;
            this.Textbox_Password.CustomButton.Visible = false;
            this.Textbox_Password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Textbox_Password.Lines = new string[0];
            this.Textbox_Password.Location = new System.Drawing.Point(143, 228);
            this.Textbox_Password.MaxLength = 32767;
            this.Textbox_Password.Name = "Textbox_Password";
            this.Textbox_Password.PasswordChar = '*';
            this.Textbox_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Textbox_Password.SelectedText = "";
            this.Textbox_Password.SelectionLength = 0;
            this.Textbox_Password.SelectionStart = 0;
            this.Textbox_Password.ShortcutsEnabled = true;
            this.Textbox_Password.ShowClearButton = true;
            this.Textbox_Password.Size = new System.Drawing.Size(189, 23);
            this.Textbox_Password.TabIndex = 3;
            this.Textbox_Password.UseSelectable = true;
            this.Textbox_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Textbox_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Username
            // 
            this.Username.AutoScroll = true;
            this.Username.AutoScrollMinSize = new System.Drawing.Size(46, 22);
            this.Username.AutoSize = false;
            this.Username.BackColor = System.Drawing.SystemColors.Window;
            this.Username.Location = new System.Drawing.Point(62, 120);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(75, 23);
            this.Username.TabIndex = 4;
            this.Username.Text = "用户名";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(34, 22);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(62, 228);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(47, 23);
            this.htmlLabel2.TabIndex = 7;
            this.htmlLabel2.Text = "密码";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(60, 332);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "注册";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 383);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Textbox_Password);
            this.Controls.Add(this.Textbox_Username);
            this.Controls.Add(this.Button_Login);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "欢迎来到13水";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Button_Login;
        private MetroFramework.Controls.MetroTextBox Textbox_Username;
        private MetroFramework.Controls.MetroTextBox Textbox_Password;
        private MetroFramework.Drawing.Html.HtmlLabel Username;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

