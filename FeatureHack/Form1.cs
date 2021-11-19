using aLib.Microsoft;
using System;
using System.Drawing;
using System.IO;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FeatureHack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lastb = xuiButton1;
            //lasttar.BackgroundColor = Color.FromArgb(28, 28, 28);


            /*string text = "§r_§_b_§_k_§_l_|_§_e_§_k_§_l_|_§_b_§_k_§_l_|_§_r_ _§_b_§_l_Ｓ_Ｋ_Ｙ_§_f_§_l_Ｂ_Ａ_Ｒ_Ｓ_ _§_6_§_l_»_ _§_f_§_l_В_с_е_м_ _б_е_с_п_л_а_т_н_ы_й_ _д_о_н_а_т_ _§_b_§_l_/_f_r_e_e_ _§_r_§_b_§_k_§_l_|_§_e_§_k_§_l_|_§_b_§_k_§_l_|_§_r_";
            string[] tex = text.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            string motd = "";
            for (int i = 0; i < tex.Length; i++)
            {
                if (tex[i].Equals("§"))
                {
                    i++;
                }
                else
                {
                    motd += tex[i];
                }
            }
            richTextBox1.Text = motd;*/
        }
        int id = 0000;
        string status = "Гость";
        int time = 0;
        string timetext = null;
        
        async void Live()
        {
            String[] all;
            //all.
            List<string> z = new List<string>();
            
            while (true)
            {

                FirebaseResponse res = await client.GetAsync(@"last");
                if (!z.Contains(res.Body.ToString()))
                {
                    
                    //MessageBox.Show(res.Body.ToString());
                    if(z.Count > 3)
                    {
                        z.RemoveAt(0);
                    }
                    z.Add(res.Body.ToString());
                    try
                    {
                        if (z.Count >= 1)
                        {
                            int index = 0;
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/online");
                            server_ip_1.Text = z[index].Replace("\"", "").Replace("_", ".");
                            server_online_1.Text = res.Body.ToString().Replace("\"", "").Replace("_", ".");
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/max");
                            int x = Int32.Parse(res.Body.ToString()) * 8;
                            server_hack_1.ButtonText = "Взломать за " + x + "р.";
                        }
                        if (z.Count >= 2)
                        {
                            int index = 1;
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/online");
                            server_ip_2.Text = z[index].Replace("\"", "").Replace("_", ".");
                            server_online_2.Text = res.Body.ToString().Replace("\"", "").Replace("_", ".");
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/max");
                            int x = Int32.Parse(res.Body.ToString()) * 8;
                            server_hack_2.ButtonText = "Взломать за " + x + "р.";
                        }
                        if (z.Count >= 3)
                        {
                            int index = 2;
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/online");
                            server_ip_3.Text = z[index].Replace("\"", "").Replace("_", ".");
                            server_online_3.Text = res.Body.ToString().Replace("\"", "").Replace("_", ".");
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/max");
                            int x = Int32.Parse(res.Body.ToString()) * 8;
                            server_hack_3.ButtonText = "Взломать за " + x + "р.";
                        }
                        if (z.Count >= 4)
                        {
                            int index = 3;
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/online");
                            server_ip_4.Text = z[index].Replace("\"", "").Replace("_", ".");
                            server_online_4.Text = res.Body.ToString().Replace("\"", "").Replace("_", ".");
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/max");
                            int x = Int32.Parse(res.Body.ToString()) * 8;
                            server_hack_4.ButtonText = "Взломать за " + x + "р.";
                        }
                        if (z.Count >= 5)
                        {
                            int index = 4;
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/online");
                            server_ip_5.Text = z[index].Replace("\"", "").Replace("_", ".");
                            server_online_5.Text = res.Body.ToString().Replace("\"", "").Replace("_", ".");
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/max");
                            int x = Int32.Parse(res.Body.ToString()) * 8;
                            server_hack_5.ButtonText = "Взломать за " + x + "р.";
                        }
                        if (z.Count >= 6)
                        {
                            int index = 5;
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/online");
                            server_ip_6.Text = z[index].Replace("\"", "").Replace("_", ".");
                            server_online_6.Text = res.Body.ToString().Replace("\"", "").Replace("_", ".");
                            res = await client.GetAsync(@"sersers/" + z[index].Replace("\"", "") + "/max");
                            int x = Int32.Parse(res.Body.ToString()) * 8;
                            server_hack_6.ButtonText = "Взломать за " + x + "р.";
                        }
                    }
                    catch
                    {
                        z.RemoveAt(z.Count-1);
                    }

                }
                //MessageBox.Show(res.Body.ToString());
            }
        }
        IFirebaseClient client;

        //MessageBox.Show("Erroe");
        char[] characters = new char[] {'A', 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z', ' ', '1', '2', '3', '4', '5', '6', '7',
            '8', '9', '0', '.'};

        private string Encode(string input, string keyword)
        {
            input = input.ToUpper();
            keyword = keyword.ToUpper();

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int c = (Array.IndexOf(characters, symbol) +
                    Array.IndexOf(characters, keyword[keyword_index])) % 44;
                
                //result += characters[c];
               /* if (result.Length >= 2) return result + "_" + Array.IndexOf(characters, symbol) +
                    Array.IndexOf(characters, keyword[keyword_index]);
                */
                keyword_index++;

                if ((keyword_index + 1) == keyword.Length)
                    keyword_index = 0;
            }

            return result;
        }
        public void load()
        {
            userlogin.Text = Properties.Settings.Default.login.ToString();
            userpas.Text = Properties.Settings.Default.password.ToString();
            userkey.Text = Properties.Settings.Default.key.ToString();
            MessageBox.Show(Encode("aaaaaaaaaaaaaaa", "koejhvreohgvoerhovuehrouvherouhveourhv"));
            
            IFirebaseConfig fconf = new FirebaseConfig()
            {
                AuthSecret = "Pn6fMPSXfyGOpxsJgqD6kRuUmhmfErSOjiYet4n1",
                BasePath = "https://point-86cbc.firebaseio.com/"
            };

            
            try
            {
                client = new FireSharp.FirebaseClient(fconf);
               // Live();


                //client.Set("123", "321");

            }
            catch
            {
                MessageBox.Show("Erroe");
            }

           /* string[] param = GET("http://feature-hack.ru/load.php?user=" + mm_Encryptions.License.GetUHId()).Replace("<br>", " ").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            id = Convert.ToInt32(param[0]);
            status = param[1];
            if (param[2].Equals("forever"))
            {
                timetext = "Безлимит";
            }
            else if (Convert.ToInt32(param[2]) > 0)
            {
                try
                {
                    time = Convert.ToInt32(param[2]);
                }
                catch
                {
                    time = 30;
                }

            }
            main_id.Text = "#" + id;
            main_status.Text = status;
            if (timetext != null)
            {
                main_time.Text = timetext;
            }else if (time > 0)
            {
                timer1.Start();
            }else
            {
                main_time.Text = "Нету";
            }
        }
        public void setTime()
        {
            time--;
            int time2 = time;
            if (time == 0)
            {
                main_time.Text = "Нету";
                timer1.Stop();
                return;
            }
            timetext = null;
            if (time2 > 86400)
            {
                timetext += time2 / 86400 + "д.";
                time2 -= 86400 * (time2 / 86400);
            }
            if (time2 > 3600)
            {
                timetext += time2 / 3600 + "ч.";
                time2 -= 3600 * (time2 / 3600);
            }
            if (time2 > 60)
            {
                timetext += time2 / 60 + "м.";
                time2 -= 60 * (time2 / 60);
            }
            if (time2 > 1)
            {
                timetext += time2 + "с.";
            }
            main_time.Text = timetext;*/
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel5.Location = new Point(178, 6);
            lastb.BackgroundColor = Color.FromArgb(15, 15, 15);
            lastb = xuiButton1;
            lastb.BackgroundColor = Color.FromArgb(28, 28, 28);
            load();
        }

        XanderUI.XUIButton lastb;
        XanderUI.XUIButton lasttar;

        private void xuiButton1_Click_1(object sender, EventArgs e)
        {
            this.panel3.Location = new Point(761, 20);
            this.panel2.Location = new Point(105, 449);
            this.panel6.Location = new Point(178, 6);
            this.panel5.Location = new Point(348, 464);
            lastb.BackgroundColor = Color.FromArgb(15, 15, 15);
            lastb = xuiButton1;
            lastb.BackgroundColor = Color.FromArgb(28, 28, 28);
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавим в следующих обновлениях", "FeatureHack", MessageBoxButtons.OK, MessageBoxIcon.Error);

            /*this.panel6.Location = new Point(648, 449);
            this.panel3.Location = new Point(761, 20);
            this.panel2.Location = new Point(178, 6);
            this.panel5.Location = new Point(348, 464);
            lastb.BackgroundColor = Color.FromArgb(15, 15, 15);
            lastb = xuiButton3;
            lastb.BackgroundColor = Color.FromArgb(28, 28, 28);*/
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            this.panel2.Location = new Point(105, 449);
            this.panel6.Location = new Point(648, 449);
            this.panel3.Location = new Point(178, 6);
            this.panel5.Location = new Point(178, 6);
            lastb.BackgroundColor = Color.FromArgb(15, 15, 15);
            lastb = xuiButton2;
            lastb.BackgroundColor = Color.FromArgb(28, 28, 28);
            
        }
        


        private string GET(string Url)
        {
            //
            System.Net.WebRequest req = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            StreamReader sr = new System.IO.StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();
            return Out;
        }


        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/featurehack");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCrnlGdGL4SjBcGYZlv_1eWg");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/9zcEsDJVBF");
        }

        
        int disc = 0;
        public int getPrice(string type, int count)
        {
            int price = 0;
            if (type.Equals("Legit Mini (Old)")) price = 35;
            if (type.Equals("Legit Maxi (Old)")) price = 50;
            if (type.Equals("Legit Mini (New)")) price = 85;
            if (type.Equals("Legit Maxi (New)")) price = 100;
            if (type.Equals("Hard Mini (New)")) price = 135;
            if (type.Equals("Hard Maxi (New)")) price = 150;
            if (type.Equals("Pro (New)")) price = 200;
            price = price * count;
            disc = 0;
            if (count >= 7)
            {
                int bust = 19 + (count / 7);
                if (bust > 50) bust = 50;
                disc = (int)System.Math.Round((double)(price * bust / 100));
            }
            return price - disc;
        }

        private void xuiButton17_Click_1(object sender, EventArgs e)
        {
            int count = Int32.Parse("" + days.Value);
            string type = comboBox1.Text;
            label10.Text = getPrice(type, count) + "р.";
            if (disc > 1) label10.Text += " Скидка: " + disc + "р.";
            this.panel2.Location = new Point(105, 449);
            this.panel6.Location = new Point(648, 449);
            this.panel3.Location = new Point(178, 6);
            this.panel5.Location = new Point(348, 464);
            lastb.BackgroundColor = Color.FromArgb(15, 15, 15);
            lastb = xuiButton17;
            lastb.BackgroundColor = Color.FromArgb(28, 28, 28);
        }

        private void xuiButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("При успешной активации будут сброшены:\nТекущий тариф(если он есть).\nВсе задержки прошлой активации.", "Активация по ключу", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel) return;
            if (enterkey.Text == null || enterkey.Text == "")
            {
                MessageBox.Show("Ошибка. Введите ключ активации", "Активация по ключу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (enterkey.Text.Split(new char[] { '-' }).Length == 4 && enterkey.Text.Length == 19)
            {
                string gets = GET("http://feature-hack.ru/action.php?code=" + enterkey.Text + "&pk=" + mm_Encryptions.License.GetUHId());
                if (gets.Equals("error"))
                {
                    if (MessageBox.Show("Ошибка. Ключ не найден.\nОбратиться в поддержку ?", "Активация по ключу", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) System.Diagnostics.Process.Start("https://vk.com/im?sel=-154817327");
                    return;
                }
                if (gets.Equals("good"))
                {
                    if (MessageBox.Show("Активация прошла успешно.", "Активация по ключу", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) load();
                }
                return;
            }
            DialogResult result = MessageBox.Show("Ошибка. Ключ не найден.\nОбратиться в поддержку ?", "Активация по ключу", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes) System.Diagnostics.Process.Start("https://vk.com/im?sel=-154817327");
        }

        private void xuiButton6_Click(object sender, EventArgs e)
        {
            string type = comboBox1.Text;
            int types = 1;
            if (type.Equals("Legit Mini (Old)")) types = 1;
            if (type.Equals("Legit Maxi (Old)")) types = 2;
            if (type.Equals("Legit Mini (New)")) types = 3;
            if (type.Equals("Legit Maxi (New)")) types = 4;
            if (type.Equals("Hard Mini (New)")) types = 5;
            if (type.Equals("Hard Maxi (New)")) types = 6;
            if (type.Equals("Pro (New)")) types = 7;
            string result = GET("http://feature-hack.ru/by.php?day=forever&type=" + types + "&pk=" + mm_Encryptions.License.GetUHId());
            System.Diagnostics.Process.Start(result);
        }

        private void xuiButton7_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse("" + days.Value);
            string type = comboBox1.Text;
            if (getPrice(type, count) < 99)
            {

                MessageBox.Show("В нашей платёжной системе платежи до 100р могут не проходить.\nВы можете произвести оплату прямо через разработчика в любой соц сети.\nКонтакты в левой части меню.", "Покупка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            int types = 1;
            if (type.Equals("Legit Mini (Old)")) types = 1;
            if (type.Equals("Legit Maxi (Old)")) types = 2;
            if (type.Equals("Legit Mini (New)")) types = 3;
            if (type.Equals("Legit Maxi (New)")) types = 4;
            if (type.Equals("Hard Mini (New)")) types = 5;
            if (type.Equals("Hard Maxi (New)")) types = 6;
            if (type.Equals("Pro (New)")) types = 7;
            string result = GET("http://feature-hack.ru/by.php?day=" + count + "&type=" + types + "&pk=" + mm_Encryptions.License.GetUHId());
            System.Diagnostics.Process.Start(result);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = Int32.Parse("" + days.Value);
            string type = comboBox1.Text;
            label10.Text = getPrice(type, count) + "р.";
            if (disc > 1) label10.Text += " Скидка: " + disc + "р.";
        }

        private void days_ValueChanged(object sender, EventArgs e)
        {
            int count = Int32.Parse("" + days.Value);
            string type = comboBox1.Text;
            label10.Text = getPrice(type, count) + "р.";
            if (disc > 1) label10.Text += " Скидка: " + disc + "р.";
        }

        private void xuiButton5_Click(object sender, EventArgs e)
        {
            if (time == 0 && !main_time.Text.Equals("Безлимит"))
            {
                //console.Text = "Необходим о получить доступ";
                return;
            }
            if (main_status.Text.Equals("Гость"))
            {
                //console.Text = "Необходим о получить доступ";
                return;
            }
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(Application.StartupPath.ToString() + "/servers.txt");
                //Write a line of text
                sw.WriteLine(GET("http://feature-hack.ru/seach.php?pk=" + mm_Encryptions.License.GetUHId()));
                //Close the file
                sw.Close();
                MessageBox.Show("Все найденные сервера были добавлены в список\nИ сохранены в папке с программой в файле servers.txt", "Поиск серверов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //setTime();
        }

        private void xuiButton8_Click(object sender, EventArgs e)
        {
            if (time == 0 && !main_time.Text.Equals("Безлимит"))
            {
                //console.Text = "Необходим о получить доступ";
                return;
            }

            String ip = console_ip.Text;
            if (ip.Contains(":")) ip = ip.Split(new char[] { ':' })[0];
            if (ip == null || ip == "") return;

            if (cmd.Text == null || cmd.Text == "")return;
            if (ip.Equals("localhost"))
            {
               // console.Text = "Подключение к локальному айпи не предусмотрено.";
                return;
            }

            if (!Regex.IsMatch(ip, @"^[0-9\.]+$"))
            {
                try
                {
                    ip = System.Net.Dns.GetHostEntry(console_ip.Text).AddressList[0].ToString();
                }
                catch
                {
                  //  console.Text = "Ошибка. Обратитесь в группу: https://vk.com/featurehack";
                    return;
                }
                //http://exe.feature-hack.ru//check/Examples/send.php
            }
            string result = GET("http://feature-hack.ru/send.php?cmd=" + cmd.Text + "&ip=" + ip + "&pk=" + mm_Encryptions.License.GetUHId());
            if (result.StartsWith("string")) result = result.Replace(result.Split(new char[] { ' ' })[0] + " ", "").Replace("\"", "");
          //  console.Text = result;
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void server_hack_6_Click(object sender, EventArgs e)
        {
            
        }

        private void server_hack_5_Click(object sender, EventArgs e)
        {
            
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void xuiButton9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.login = userlogin.Text;
            Properties.Settings.Default.password = userpas.Text;
            Properties.Settings.Default.key = userkey.Text;

            Properties.Settings.Default.Save();
        }
    }
}
