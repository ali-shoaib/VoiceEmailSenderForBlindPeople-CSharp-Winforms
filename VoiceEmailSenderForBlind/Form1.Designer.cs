namespace VoiceEmailSenderForBlind
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.sub = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.xuiCheckBox1 = new XanderUI.XUICheckBox();
            this.SendEmail = new XanderUI.XUIButton();
            this.StopListen = new XanderUI.XUIButton();
            this.StartListen = new XanderUI.XUIButton();
            this.smtp = new System.Windows.Forms.TextBox();
            this.xuiGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.from.Location = new System.Drawing.Point(461, 50);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(185, 26);
            this.from.TabIndex = 1;
            this.from.TextChanged += new System.EventHandler(this.from_TextChanged);
            // 
            // to
            // 
            this.to.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.to.Location = new System.Drawing.Point(461, 92);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(185, 26);
            this.to.TabIndex = 2;
            this.to.TextChanged += new System.EventHandler(this.to_TextChanged);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(461, 135);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(185, 26);
            this.sub.TabIndex = 3;
            this.sub.TextChanged += new System.EventHandler(this.sub_TextChanged);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(461, 218);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(185, 26);
            this.pass.TabIndex = 6;
            this.pass.UseSystemPasswordChar = true;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // body
            // 
            this.body.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body.Location = new System.Drawing.Point(461, 286);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(185, 107);
            this.body.TabIndex = 7;
            this.body.TextChanged += new System.EventHandler(this.body_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "SMTP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Message";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(634, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(664, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.LightSkyBlue;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.PowderBlue;
            this.xuiGradientPanel1.Controls.Add(this.xuiBanner1);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiGradientPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(319, 569);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 25;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.LightCyan;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.White;
            this.xuiBanner1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiBanner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.xuiBanner1.Location = new System.Drawing.Point(43, 177);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(231, 233);
            this.xuiBanner1.TabIndex = 0;
            this.xuiBanner1.Text = "Voice Email Sender For Blind Ones";
            // 
            // xuiCheckBox1
            // 
            this.xuiCheckBox1.CheckboxCheckColor = System.Drawing.Color.HotPink;
            this.xuiCheckBox1.CheckboxColor = System.Drawing.Color.Lavender;
            this.xuiCheckBox1.CheckboxHoverColor = System.Drawing.Color.PaleTurquoise;
            this.xuiCheckBox1.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.xuiCheckBox1.Checked = false;
            this.xuiCheckBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiCheckBox1.ForeColor = System.Drawing.Color.Black;
            this.xuiCheckBox1.Location = new System.Drawing.Point(461, 244);
            this.xuiCheckBox1.Name = "xuiCheckBox1";
            this.xuiCheckBox1.Size = new System.Drawing.Size(100, 27);
            this.xuiCheckBox1.TabIndex = 26;
            this.xuiCheckBox1.Text = "Show Password";
            this.xuiCheckBox1.TickThickness = 2;
            this.xuiCheckBox1.Click += new System.EventHandler(this.xuiCheckBox1_Click);
            // 
            // SendEmail
            // 
            this.SendEmail.BackgroundColor = System.Drawing.Color.LightPink;
            this.SendEmail.ButtonImage = null;
            this.SendEmail.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.SendEmail.ButtonText = "SEND";
            this.SendEmail.ClickBackColor = System.Drawing.Color.Pink;
            this.SendEmail.ClickTextColor = System.Drawing.Color.White;
            this.SendEmail.CornerRadius = 5;
            this.SendEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendEmail.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SendEmail.HoverBackgroundColor = System.Drawing.Color.HotPink;
            this.SendEmail.HoverTextColor = System.Drawing.Color.White;
            this.SendEmail.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SendEmail.Location = new System.Drawing.Point(461, 408);
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(96, 40);
            this.SendEmail.TabIndex = 29;
            this.SendEmail.TextColor = System.Drawing.Color.White;
            this.SendEmail.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // StopListen
            // 
            this.StopListen.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.StopListen.ButtonImage = null;
            this.StopListen.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.StopListen.ButtonText = "Stop Listening";
            this.StopListen.ClickBackColor = System.Drawing.Color.SkyBlue;
            this.StopListen.ClickTextColor = System.Drawing.Color.White;
            this.StopListen.CornerRadius = 5;
            this.StopListen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopListen.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.StopListen.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.StopListen.HoverTextColor = System.Drawing.Color.White;
            this.StopListen.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.StopListen.Location = new System.Drawing.Point(523, 512);
            this.StopListen.Name = "StopListen";
            this.StopListen.Size = new System.Drawing.Size(154, 45);
            this.StopListen.TabIndex = 28;
            this.StopListen.TextColor = System.Drawing.Color.White;
            this.StopListen.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.StopListen.Click += new System.EventHandler(this.StopListen_Click);
            // 
            // StartListen
            // 
            this.StartListen.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.StartListen.ButtonImage = null;
            this.StartListen.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.StartListen.ButtonText = "Start Listening";
            this.StartListen.ClickBackColor = System.Drawing.Color.SkyBlue;
            this.StartListen.ClickTextColor = System.Drawing.Color.White;
            this.StartListen.CornerRadius = 5;
            this.StartListen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartListen.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.StartListen.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.StartListen.HoverTextColor = System.Drawing.Color.White;
            this.StartListen.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.StartListen.Location = new System.Drawing.Point(340, 512);
            this.StartListen.Name = "StartListen";
            this.StartListen.Size = new System.Drawing.Size(164, 45);
            this.StartListen.TabIndex = 27;
            this.StartListen.TextColor = System.Drawing.Color.White;
            this.StartListen.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.StartListen.Click += new System.EventHandler(this.StartListen_Click);
            // 
            // smtp
            // 
            this.smtp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtp.Location = new System.Drawing.Point(461, 177);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(185, 26);
            this.smtp.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 569);
            this.ControlBox = false;
            this.Controls.Add(this.smtp);
            this.Controls.Add(this.SendEmail);
            this.Controls.Add(this.StopListen);
            this.Controls.Add(this.StartListen);
            this.Controls.Add(this.xuiCheckBox1);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.body);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailSendingApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox sub;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUICheckBox xuiCheckBox1;
        private XanderUI.XUIBanner xuiBanner1;
        private XanderUI.XUIButton StartListen;
        private XanderUI.XUIButton StopListen;
        private XanderUI.XUIButton SendEmail;
        private System.Windows.Forms.TextBox smtp;
    }
}

