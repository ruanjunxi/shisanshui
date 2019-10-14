namespace WindowsFormsMetro
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.Username = new MetroFramework.Drawing.Html.HtmlLabel();
            this.Textbox_Password1 = new MetroFramework.Controls.MetroTextBox();
            this.Textbox_Username1 = new MetroFramework.Controls.MetroTextBox();
            this.Button_Reg = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.TextBox_Confirm = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(34, 22);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(261, 219);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(47, 23);
            this.htmlLabel2.TabIndex = 11;
            this.htmlLabel2.Text = "密码";
            // 
            // Username
            // 
            this.Username.AutoScroll = true;
            this.Username.AutoScrollMinSize = new System.Drawing.Size(46, 22);
            this.Username.AutoSize = false;
            this.Username.BackColor = System.Drawing.SystemColors.Window;
            this.Username.Location = new System.Drawing.Point(261, 160);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(75, 23);
            this.Username.TabIndex = 10;
            this.Username.Text = "用户名";
            // 
            // Textbox_Password1
            // 
            this.Textbox_Password1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.Textbox_Password1.CustomButton.Image = null;
            this.Textbox_Password1.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.Textbox_Password1.CustomButton.Name = "";
            this.Textbox_Password1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Textbox_Password1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Textbox_Password1.CustomButton.TabIndex = 1;
            this.Textbox_Password1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Textbox_Password1.CustomButton.UseSelectable = true;
            this.Textbox_Password1.CustomButton.Visible = false;
            this.Textbox_Password1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Textbox_Password1.Lines = new string[0];
            this.Textbox_Password1.Location = new System.Drawing.Point(351, 219);
            this.Textbox_Password1.MaxLength = 32767;
            this.Textbox_Password1.Name = "Textbox_Password1";
            this.Textbox_Password1.PasswordChar = '*';
            this.Textbox_Password1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Textbox_Password1.SelectedText = "";
            this.Textbox_Password1.SelectionLength = 0;
            this.Textbox_Password1.SelectionStart = 0;
            this.Textbox_Password1.ShortcutsEnabled = true;
            this.Textbox_Password1.ShowClearButton = true;
            this.Textbox_Password1.Size = new System.Drawing.Size(180, 23);
            this.Textbox_Password1.TabIndex = 9;
            this.Textbox_Password1.UseSelectable = true;
            this.Textbox_Password1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Textbox_Password1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Textbox_Password1.Click += new System.EventHandler(this.Textbox_Password1_Click);
            // 
            // Textbox_Username1
            // 
            // 
            // 
            // 
            this.Textbox_Username1.CustomButton.Image = null;
            this.Textbox_Username1.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.Textbox_Username1.CustomButton.Name = "";
            this.Textbox_Username1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Textbox_Username1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Textbox_Username1.CustomButton.TabIndex = 1;
            this.Textbox_Username1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Textbox_Username1.CustomButton.UseSelectable = true;
            this.Textbox_Username1.CustomButton.Visible = false;
            this.Textbox_Username1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Textbox_Username1.Lines = new string[0];
            this.Textbox_Username1.Location = new System.Drawing.Point(351, 160);
            this.Textbox_Username1.MaxLength = 32767;
            this.Textbox_Username1.Name = "Textbox_Username1";
            this.Textbox_Username1.PasswordChar = '\0';
            this.Textbox_Username1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Textbox_Username1.SelectedText = "";
            this.Textbox_Username1.SelectionLength = 0;
            this.Textbox_Username1.SelectionStart = 0;
            this.Textbox_Username1.ShortcutsEnabled = true;
            this.Textbox_Username1.Size = new System.Drawing.Size(180, 23);
            this.Textbox_Username1.TabIndex = 8;
            this.Textbox_Username1.UseSelectable = true;
            this.Textbox_Username1.WaterMarkColor = System.Drawing.Color.Black;
            this.Textbox_Username1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Button_Reg
            // 
            this.Button_Reg.Location = new System.Drawing.Point(336, 339);
            this.Button_Reg.Name = "Button_Reg";
            this.Button_Reg.Size = new System.Drawing.Size(203, 36);
            this.Button_Reg.TabIndex = 12;
            this.Button_Reg.Text = "注册";
            this.Button_Reg.UseSelectable = true;
            this.Button_Reg.Click += new System.EventHandler(this.Button_Reg_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(58, 22);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(261, 280);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 13;
            this.htmlLabel1.Text = "确认密码";
            // 
            // TextBox_Confirm
            // 
            this.TextBox_Confirm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.TextBox_Confirm.CustomButton.Image = null;
            this.TextBox_Confirm.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.TextBox_Confirm.CustomButton.Name = "";
            this.TextBox_Confirm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_Confirm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Confirm.CustomButton.TabIndex = 1;
            this.TextBox_Confirm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Confirm.CustomButton.UseSelectable = true;
            this.TextBox_Confirm.CustomButton.Visible = false;
            this.TextBox_Confirm.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBox_Confirm.Lines = new string[0];
            this.TextBox_Confirm.Location = new System.Drawing.Point(351, 280);
            this.TextBox_Confirm.MaxLength = 32767;
            this.TextBox_Confirm.Name = "TextBox_Confirm";
            this.TextBox_Confirm.PasswordChar = '*';
            this.TextBox_Confirm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Confirm.SelectedText = "";
            this.TextBox_Confirm.SelectionLength = 0;
            this.TextBox_Confirm.SelectionStart = 0;
            this.TextBox_Confirm.ShortcutsEnabled = true;
            this.TextBox_Confirm.ShowClearButton = true;
            this.TextBox_Confirm.Size = new System.Drawing.Size(180, 23);
            this.TextBox_Confirm.TabIndex = 14;
            this.TextBox_Confirm.UseSelectable = true;
            this.TextBox_Confirm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Confirm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox_Confirm);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.Button_Reg);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Textbox_Password1);
            this.Controls.Add(this.Textbox_Username1);
            this.Name = "FormRegister";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel Username;
        private MetroFramework.Controls.MetroTextBox Textbox_Password1;
        private MetroFramework.Controls.MetroTextBox Textbox_Username1;
        private MetroFramework.Controls.MetroButton Button_Reg;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTextBox TextBox_Confirm;
    }
}