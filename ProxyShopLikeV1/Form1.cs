using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.Win32;
using MetroFramework;
using MetroFramework.Controls;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProxyShopLikeV1.Properties;

namespace ProxyShopLikeV1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        RegistryKey reg_key;
        int seconds = 0;
        RadioButton rb = null;
        bool connected = false;

        public Form1()
        {
            InitializeComponent();
            tbl_apiKey.AutoSize = false;
            //tbl_apiKey.Size = new System.Drawing.Size(315, 30);

            reg_key = Registry.CurrentUser.OpenSubKey(@"Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            LoadComboItems();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            tbl_timeout.Enabled = false;
            tbl_timeout.Text = "1800";

            //load setting
            tbl_apiKey.Text = Settings.Default["apikey"].ToString();
            string methodSave = Settings.Default["method"].ToString();
            string autoGetSave = Settings.Default["autoget"].ToString();
            tbl_timeout.Text = Settings.Default["timeout"].ToString();

            if(methodSave == "Get New IP")
            {
                getNew.Checked = true;
            }
            else if(methodSave == "Get Current IP")
            {
                getCurrent.Checked = true;
            }

            if(autoGetSave == "True")
            {
                autoGet.Checked = true;
                tbl_timeout.Enabled = true;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btn_connect.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btn_disconnect.PerformClick();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://proxy.shoplike.vn");
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            tbl_timeout.Enabled = false;
            handleConnect();
        }

        public void handleConnect()
        {
            string api_key = tbl_apiKey.Text;
            int timeoutProxy = Convert.ToInt32(tbl_timeout.Text);

            if (getNew.Checked == true)
            {
                rb = getNew;
            }
            else if (getCurrent.Checked == true)
            {
                rb = getCurrent;
            }

            if (rb == null)
            {
                MetroMessageBox.Show(this, "Vui lòng chọn phương thức GET.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string codeLocation = ((KeyValuePair<string, string>)cb_location.SelectedItem).Key;
                string nameLocation = ((KeyValuePair<string, string>)cb_location.SelectedItem).Value;

                string _location;
                if (codeLocation == "random")
                {
                    _location = "";
                }
                else
                {
                    _location = "&location=" + codeLocation;
                }

                string methodGet = rb.Text;
                string URL;
                if (methodGet == "Get New IP")
                {
                    URL = "http://proxy.shoplike.vn/Api/getNewProxy?access_token=" + api_key + _location;
                }
                else
                {
                    URL = "http://proxy.shoplike.vn/Api/getCurrentProxy?access_token=" + api_key;
                }

                string data = webGetMethod(URL);
                dynamic jsonObj = JsonConvert.DeserializeObject(data);

                string status = jsonObj.status;

                if (status == "error")
                {
                    MetroMessageBox.Show(this, (string)jsonObj.mess, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    string location = (string)jsonObj.data.location;
                    string proxy = (string)jsonObj.data.proxy;
                    
                    if(methodGet == "Get New IP")
                    {
                        int timeoutPrxGet = (int)jsonObj.data.proxyTimeout;
                    }    

                    if (autoGet.Checked == true)
                    {
                        //MetroMessageBox.Show(this, "Auto checkbox", "Auto checkbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        seconds = Convert.ToInt32(tbl_timeout.Text);
                        timer1.Start();
                    }


                    reg_key.SetValue("ProxyEnable", 1);
                    reg_key.SetValue("ProxyServer", proxy);
                    string _str = "Location : " + nameLocation + "\nProxy : " + proxy;
                    lb_status.ForeColor = Color.Green;
                    lb_status.Text = "Đang Kết Nối";
                    lbInfo.Text = nameLocation + "\n" + proxy;
                    saveSettingUser();
                    connected = true;
                    MetroMessageBox.Show(this, _str, "Kết Nối Proxy Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void saveSettingUser()
        {
            //save setting 
            Settings.Default["apikey"] = tbl_apiKey.Text;
            Settings.Default["method"] = rb.Text;
            Settings.Default["autoget"] = autoGet.Checked.ToString();
            Settings.Default["timeout"] = tbl_timeout.Text;
            Settings.Default.Save();
        }
        private void LoadComboItems()
        {
            var str = File.ReadAllText("locatison.json");
            var x = JsonConvert.DeserializeObject<Rootobject>(str);

            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            foreach (var location in x.location)
            {
                comboSource.Add(location.code, location.name);
                cb_location.DataSource = new BindingSource(comboSource, null);
                cb_location.DisplayMember = "Value";
                cb_location.ValueMember = "Key";

            }
        }


        public string webGetMethod(string URL)
        {
            string jsonString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request.ContentType = "application/x-www-form-urlencoded";

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jsonString = sr.ReadToEnd();
            sr.Close();
            return jsonString;
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            var statusProxyEnable = reg_key.GetValue("ProxyEnable");
            if (statusProxyEnable.ToString() == "1")
            {
                reg_key.SetValue("ProxyEnable", 0);
                lb_status.ForeColor = Color.Blue;
                lb_status.Text = "Sẵn Sàng Kết Nối";
                lbInfo.Text = "";
                timer1.Stop();
                lbCountDown.Text = "";
                connected = false;
                MetroMessageBox.Show(this, "Cảm ơn bạn đã sử dụng dịch vụ!", "Ngắt Kết Nối Thành Công!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MetroMessageBox.Show(this, "Chưa kết nối sao mà huỷ kết nối được hả. hmmm!!", "Bạn chưa kết nối Proxy!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tbl_timeout_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void autoGet_Click(object sender, EventArgs e)
        {

            if (autoGet.Checked == true)
            {
                tbl_timeout.Enabled = true;
            }
            else
            {
                tbl_timeout.Enabled = false;
            }
        }

        private void tbl_timeout_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbl_timeout.Text) >= 1801 || Convert.ToInt32(tbl_timeout.Text) <= 59)
            {
                tbl_timeout.Text = "1800";
                MetroMessageBox.Show(this, "Giá Trị Thời Gian Không Hợp Lệ. Tối thiểu 59s và tối đa 1800s.", "Lỗi Giá Trị Nhập Vào!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbCountDown.Text = seconds--.ToString() + "s";
            if(seconds < 0)
            {
                timer1.Stop();
                seconds = Convert.ToInt32(tbl_timeout.Text);
                btn_connect.PerformClick();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if(connected == false)
            {
                //save setting 
                Settings.Default["apikey"] = "";
                Settings.Default["method"] = "";
                Settings.Default["autoget"] = "";
                Settings.Default["timeout"] = "1800";
                Settings.Default.Save();
                MetroMessageBox.Show(this, "Xoá Thiết lập thành công.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
                Environment.Exit(0);
            } 
            else
            {
                MetroMessageBox.Show(this, "Ngắt kết nối rồi hãy reset thiết lập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }

    public class Rootobject
    {
        public Location[] location { get; set; }
    }

    public class Location
    {
        public string id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

}
