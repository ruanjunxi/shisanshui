namespace WindowsFormsMetro
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.buttonOnline = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.btn_AI = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(-15, -15);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // buttonOnline
            // 
            this.buttonOnline.BackColor = System.Drawing.Color.Transparent;
            this.buttonOnline.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonOnline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOnline.DownBack = null;
            this.buttonOnline.Font = new System.Drawing.Font("楷体", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOnline.Location = new System.Drawing.Point(796, 280);
            this.buttonOnline.MouseBack = null;
            this.buttonOnline.MouseBaseColor = System.Drawing.Color.Cyan;
            this.buttonOnline.Name = "buttonOnline";
            this.buttonOnline.NormlBack = null;
            this.buttonOnline.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.buttonOnline.Size = new System.Drawing.Size(183, 82);
            this.buttonOnline.TabIndex = 6;
            this.buttonOnline.Text = "在线对战";
            this.buttonOnline.UseVisualStyleBackColor = false;
            this.buttonOnline.Click += new System.EventHandler(this.buttonOnline_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("楷体", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.Location = new System.Drawing.Point(1067, 523);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(183, 78);
            this.skinButton1.TabIndex = 7;
            this.skinButton1.Text = "排行榜";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // btn_AI
            // 
            this.btn_AI.BackColor = System.Drawing.Color.Transparent;
            this.btn_AI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AI.BackgroundImage")));
            this.btn_AI.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_AI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AI.DownBack = global::WindowsFormsMetro.Properties.Resources.online_battla_click;
            this.btn_AI.DownBaseColor = System.Drawing.Color.White;
            this.btn_AI.Font = new System.Drawing.Font("楷体", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AI.ForeColor = System.Drawing.Color.Black;
            this.btn_AI.Location = new System.Drawing.Point(1067, 280);
            this.btn_AI.MouseBack = null;
            this.btn_AI.Name = "btn_AI";
            this.btn_AI.NormlBack = null;
            this.btn_AI.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btn_AI.Size = new System.Drawing.Size(183, 82);
            this.btn_AI.TabIndex = 5;
            this.btn_AI.Text = "AI对战";
            this.btn_AI.UseVisualStyleBackColor = false;
            this.btn_AI.Click += new System.EventHandler(this.btn_AI_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton2.DownBack = null;
            this.skinButton2.Font = new System.Drawing.Font("楷体", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton2.Location = new System.Drawing.Point(796, 523);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton2.Size = new System.Drawing.Size(183, 78);
            this.skinButton2.TabIndex = 9;
            this.skinButton2.Text = "查看战绩";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1371, 697);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.buttonOnline);
            this.Controls.Add(this.btn_AI);
            this.Controls.Add(this.metroButton1);
            this.Name = "FormMain";
            this.Text = "13水";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private CCWin.SkinControl.SkinButton btn_AI;
        private CCWin.SkinControl.SkinButton buttonOnline;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
    }
}