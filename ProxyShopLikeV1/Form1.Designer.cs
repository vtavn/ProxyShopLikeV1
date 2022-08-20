namespace ProxyShopLikeV1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_footer = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lb_apikey = new MetroFramework.Controls.MetroLabel();
            this.getNew = new MetroFramework.Controls.MetroRadioButton();
            this.getCurrent = new MetroFramework.Controls.MetroRadioButton();
            this.btn_connect = new MetroFramework.Controls.MetroButton();
            this.btn_disconnect = new MetroFramework.Controls.MetroButton();
            this.cb_location = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbl_apiKey = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.autoGet = new MetroFramework.Controls.MetroCheckBox();
            this.lb_status = new MetroFramework.Controls.MetroLabel();
            this.tbl_timeout = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbInfo = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbCountDown = new MetroFramework.Controls.MetroLabel();
            this.btn_reset = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lb_footer
            // 
            this.lb_footer.AutoSize = true;
            this.lb_footer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_footer.Location = new System.Drawing.Point(33, 463);
            this.lb_footer.Margin = new System.Windows.Forms.Padding(3);
            this.lb_footer.Name = "lb_footer";
            this.lb_footer.Size = new System.Drawing.Size(81, 16);
            this.lb_footer.TabIndex = 6;
            this.lb_footer.Text = "© ShopLike";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(139, 463);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mua Proxy";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lb_apikey
            // 
            this.lb_apikey.AutoSize = true;
            this.lb_apikey.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_apikey.ForeColor = System.Drawing.Color.Black;
            this.lb_apikey.Location = new System.Drawing.Point(24, 91);
            this.lb_apikey.Name = "lb_apikey";
            this.lb_apikey.Size = new System.Drawing.Size(57, 19);
            this.lb_apikey.TabIndex = 9;
            this.lb_apikey.Text = "API KEY";
            // 
            // getNew
            // 
            this.getNew.AutoSize = true;
            this.getNew.Location = new System.Drawing.Point(129, 161);
            this.getNew.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.getNew.MinimumSize = new System.Drawing.Size(85, 30);
            this.getNew.Name = "getNew";
            this.getNew.Size = new System.Drawing.Size(85, 30);
            this.getNew.TabIndex = 10;
            this.getNew.Text = "Get New IP";
            this.getNew.UseSelectable = true;
            // 
            // getCurrent
            // 
            this.getCurrent.AutoSize = true;
            this.getCurrent.Location = new System.Drawing.Point(242, 161);
            this.getCurrent.MinimumSize = new System.Drawing.Size(85, 30);
            this.getCurrent.Name = "getCurrent";
            this.getCurrent.Size = new System.Drawing.Size(97, 30);
            this.getCurrent.TabIndex = 11;
            this.getCurrent.Text = "Get Current IP";
            this.getCurrent.UseSelectable = true;
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_connect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_connect.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_connect.Location = new System.Drawing.Point(24, 320);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(134, 48);
            this.btn_connect.TabIndex = 12;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseCustomBackColor = true;
            this.btn_connect.UseCustomForeColor = true;
            this.btn_connect.UseSelectable = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.BackColor = System.Drawing.Color.Brown;
            this.btn_disconnect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_disconnect.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_disconnect.Location = new System.Drawing.Point(205, 320);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(134, 48);
            this.btn_disconnect.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_disconnect.TabIndex = 13;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseCustomBackColor = true;
            this.btn_disconnect.UseCustomForeColor = true;
            this.btn_disconnect.UseSelectable = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // cb_location
            // 
            this.cb_location.FormattingEnabled = true;
            this.cb_location.ItemHeight = 23;
            this.cb_location.Location = new System.Drawing.Point(121, 212);
            this.cb_location.Name = "cb_location";
            this.cb_location.Size = new System.Drawing.Size(218, 29);
            this.cb_location.Style = MetroFramework.MetroColorStyle.Blue;
            this.cb_location.TabIndex = 14;
            this.cb_location.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(24, 216);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "LOCATION";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(24, 167);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "METHOD";
            // 
            // tbl_apiKey
            // 
            // 
            // 
            // 
            this.tbl_apiKey.CustomButton.Image = null;
            this.tbl_apiKey.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.tbl_apiKey.CustomButton.Name = "";
            this.tbl_apiKey.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbl_apiKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbl_apiKey.CustomButton.TabIndex = 1;
            this.tbl_apiKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbl_apiKey.CustomButton.UseSelectable = true;
            this.tbl_apiKey.CustomButton.Visible = false;
            this.tbl_apiKey.DisplayIcon = true;
            this.tbl_apiKey.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbl_apiKey.Icon = global::ProxyShopLikeV1.Properties.Resources.keypng;
            this.tbl_apiKey.Lines = new string[0];
            this.tbl_apiKey.Location = new System.Drawing.Point(24, 113);
            this.tbl_apiKey.MaxLength = 32767;
            this.tbl_apiKey.Name = "tbl_apiKey";
            this.tbl_apiKey.PasswordChar = '\0';
            this.tbl_apiKey.PromptText = "Api Key Proxy ShopLike..";
            this.tbl_apiKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbl_apiKey.SelectedText = "";
            this.tbl_apiKey.SelectionLength = 0;
            this.tbl_apiKey.SelectionStart = 0;
            this.tbl_apiKey.ShortcutsEnabled = true;
            this.tbl_apiKey.Size = new System.Drawing.Size(315, 30);
            this.tbl_apiKey.TabIndex = 8;
            this.tbl_apiKey.UseSelectable = true;
            this.tbl_apiKey.WaterMark = "Api Key Proxy ShopLike..";
            this.tbl_apiKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbl_apiKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(24, 264);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "OPTION";
            // 
            // autoGet
            // 
            this.autoGet.AutoSize = true;
            this.autoGet.Location = new System.Drawing.Point(121, 263);
            this.autoGet.MinimumSize = new System.Drawing.Size(114, 20);
            this.autoGet.Name = "autoGet";
            this.autoGet.Size = new System.Drawing.Size(114, 20);
            this.autoGet.TabIndex = 19;
            this.autoGet.Text = "Auto Get";
            this.autoGet.UseSelectable = true;
            this.autoGet.Click += new System.EventHandler(this.autoGet_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lb_status.Location = new System.Drawing.Point(87, 91);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(97, 19);
            this.lb_status.TabIndex = 20;
            this.lb_status.Text = "Chưa Kết Nối";
            this.lb_status.UseCustomBackColor = true;
            this.lb_status.UseCustomForeColor = true;
            this.lb_status.UseStyleColors = true;
            // 
            // tbl_timeout
            // 
            // 
            // 
            // 
            this.tbl_timeout.CustomButton.Image = null;
            this.tbl_timeout.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbl_timeout.CustomButton.Name = "";
            this.tbl_timeout.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbl_timeout.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbl_timeout.CustomButton.TabIndex = 1;
            this.tbl_timeout.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbl_timeout.CustomButton.UseSelectable = true;
            this.tbl_timeout.CustomButton.Visible = false;
            this.tbl_timeout.Lines = new string[0];
            this.tbl_timeout.Location = new System.Drawing.Point(263, 263);
            this.tbl_timeout.MaxLength = 32767;
            this.tbl_timeout.Name = "tbl_timeout";
            this.tbl_timeout.PasswordChar = '\0';
            this.tbl_timeout.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbl_timeout.SelectedText = "";
            this.tbl_timeout.SelectionLength = 0;
            this.tbl_timeout.SelectionStart = 0;
            this.tbl_timeout.ShortcutsEnabled = true;
            this.tbl_timeout.Size = new System.Drawing.Size(75, 23);
            this.tbl_timeout.TabIndex = 21;
            this.tbl_timeout.UseSelectable = true;
            this.tbl_timeout.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbl_timeout.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.tbl_timeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbl_timeout_KeyPress);
            this.tbl_timeout.Leave += new System.EventHandler(this.tbl_timeout_Leave);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(216, 264);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "TIME";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbInfo.Location = new System.Drawing.Point(110, 386);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(134, 19);
            this.lbInfo.TabIndex = 23;
            this.lbInfo.Text = "Proxy.ShopLike.Vn";
            this.lbInfo.UseCustomBackColor = true;
            this.lbInfo.UseCustomForeColor = true;
            this.lbInfo.UseStyleColors = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbCountDown
            // 
            this.lbCountDown.AutoSize = true;
            this.lbCountDown.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbCountDown.Location = new System.Drawing.Point(205, 91);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(0, 0);
            this.lbCountDown.TabIndex = 24;
            this.lbCountDown.UseCustomBackColor = true;
            this.lbCountDown.UseCustomForeColor = true;
            this.lbCountDown.UseStyleColors = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(239, 460);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 25;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseSelectable = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 499);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbCountDown);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbl_timeout);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.autoGet);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cb_location);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.getCurrent);
            this.Controls.Add(this.getNew);
            this.Controls.Add(this.lb_apikey);
            this.Controls.Add(this.tbl_apiKey);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lb_footer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(361, 499);
            this.MinimumSize = new System.Drawing.Size(361, 499);
            this.Name = "Form1";
            this.Text = "Proxy.ShopLike.Vn v1.0.0";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_footer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroTextBox tbl_apiKey;
        private MetroFramework.Controls.MetroLabel lb_apikey;
        private MetroFramework.Controls.MetroRadioButton getNew;
        private MetroFramework.Controls.MetroRadioButton getCurrent;
        private MetroFramework.Controls.MetroButton btn_connect;
        private MetroFramework.Controls.MetroButton btn_disconnect;
        private MetroFramework.Controls.MetroComboBox cb_location;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox autoGet;
        private MetroFramework.Controls.MetroLabel lb_status;
        private MetroFramework.Controls.MetroTextBox tbl_timeout;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lbInfo;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lbCountDown;
        private MetroFramework.Controls.MetroButton btn_reset;
    }
}

