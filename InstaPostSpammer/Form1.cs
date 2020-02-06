using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaPostSpammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private static IInstaApi api;
        private static UserSessionData user;
        int saydimmm = 0;
        private async void btnBaslat_Click(object sender, EventArgs e)
        {

            try
            {
                if (btnBaslat.Text == "Durdur")
                {
                    timer1.Stop();
                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + "Durduruldu.");
                    btnBaslat.Text = "Başlat";
                    saydimmm = 0;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
                    {
                        MessageBox.Show("Kullanıcı Adı Boş Olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrEmpty(txtParola.Text))
                    {
                        MessageBox.Show("Parola Boş Olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        MessageBox.Show("URL Boş Olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    user = new UserSessionData();
                    user.UserName = txtKullaniciAdi.Text;
                    user.Password = txtParola.Text;
                    api = InstaApiBuilder.CreateBuilder().SetUser(user).UseLogger(new DebugLogger(LogLevel.Exceptions)).Build();

                    label4.Text = "Giriş yapılıyor.."; label4.ForeColor = Color.Orange;
                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + "Giriş yapılıyor..");
                    var logInResult = await api.LoginAsync();
                    if (logInResult.Succeeded)
                    {
                        label4.Text = "Giriş yapıldı."; label4.ForeColor = Color.Green;
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + "Giriş yapıldı.");
                        if (await Get_Media_ID())
                        {
                            Invoke((MethodInvoker)delegate {
                                timer1.Interval = (int)numericUpDown1.Value * 1000;
                                timer1.Start();
                                btnBaslat.Text = "Durdur";
                            });
                        }
                        else
                        {
                            btnBaslat.Text = "Başlat";
                            MessageBox.Show("Media ID'si alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        btnBaslat.Text = "Başlat";
                        label4.Text = "Giriş yapılamadı, loglara bakın.";
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + "Giriş yapılamadı:");
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + logInResult.Info.Message);
                        label4.ForeColor = Color.Red;
                        if (logInResult.Value == InstaLoginResult.ChallengeRequired)
                        {
                            var challenge = await api.GetChallengeRequireVerifyMethodAsync();
                            if (challenge.Succeeded)
                            {
                                if (challenge.Value.SubmitPhoneRequired)
                                {
                                    //telefon
                                }
                                else
                                {
                                    if (challenge.Value.StepData != null)
                                    {
                                        if (!string.IsNullOrEmpty(challenge.Value.StepData.PhoneNumber))
                                        {
                                            var pnv = challenge.Value.StepData.PhoneNumber;
                                            MessageBox.Show(pnv);
                                            sendCode(api);
                                        }
                                        if (!string.IsNullOrEmpty(challenge.Value.StepData.Email))
                                        {
                                            var emv = challenge.Value.StepData.Email;
                                            MessageBox.Show(emv);
                                            sendCode(api);
                                        }

                                    }
                                }
                            }
                            else
                                //MessageBox.Show(challenge.Info.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + challenge.Info.Message);
                            label4.Text = "Bir hata oluştu, loglara bakın.";
                            label4.ForeColor = Color.Red;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        async void sendCode(IInstaApi api)
        {
            bool isEmail = true;
            try
            {
                if (isEmail)
                {
                    var email = await api.RequestVerifyCodeToEmailForChallengeRequireAsync();
                    panel1.Visible = true;
                    Size = new Size(487, 397);
                    if (email.Succeeded)
                    {
                        MessageBox.Show("gönderildi");
                    }
                    else
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + email.Info.Message);
                    label4.Text = "Bir hata oluştu, loglara bakın.";
                    label4.ForeColor = Color.Red;
                }
                else
                {
                    var phoneNumber = await api.RequestVerifyCodeToSMSForChallengeRequireAsync();
                    if (phoneNumber.Succeeded)
                    {
                        MessageBox.Show("doğrulandı");
                        panel1.Visible = false;
                        Size = new Size(487, 337);
                    }
                    else
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + phoneNumber.Info.Message);
                    label4.Text = "Bir hata oluştu, loglara bakın.";
                    label4.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + ex.Message);
                label4.Text = "Bir hata oluştu, loglara bakın.";
                label4.ForeColor = Color.Red;
            }
        }

        public async void Dogrula(IInstaApi api)
        {
            try
            {
                var verifyLogin = await api.VerifyCodeForChallengeRequireAsync(txtDogrulama.Text);
                if (verifyLogin.Succeeded)
                {
                    MessageBox.Show("doğrulandı");
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Yanlış kod");
                    if (verifyLogin.Value == InstaLoginResult.TwoFactorRequired)
                    {
                        MessageBox.Show("iki faktörlü doğrulama gerekiyor.");
                    }
                    else
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + verifyLogin.Info.Message);
                    label4.Text = "Bir hata oluştu, loglara bakın.";
                    label4.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + ex.Message);
                label4.Text = "Bir hata oluştu, loglara bakın.";
                label4.ForeColor = Color.Red;
            }
        }
        private static readonly HttpClient httpClient = new HttpClient();
        public async Task<string> GetResponseText(string address)
        {
            return await httpClient.GetStringAsync(@"http://api.instagram.com/oembed?callback=&url=" + address);
        }
        int satirnum = 0;
        int tekrar = 0;
        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Lines.Length > satirnum)
                {
                    var yorumm = await api.CommentProcessor.CommentMediaAsync(Aydi, textBox1.Lines[satirnum].ToString());
                    if (yorumm.Succeeded)
                    {
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + "Yorum yapıldı: " + textBox1.Lines[satirnum].ToString());
                        satirnum += 1;
                        saydimmm += 1;
                        if (saydimmm == (int)numericUpDown2.Value)
                        {
                            await Task.Delay((int)numericUpDown3.Value * 1000);
                            saydimmm = 0;
                            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "] " + ((int)numericUpDown3.Value * 1000).ToString() + " saniye beklendi.");
                        }
                    }
                    else
                    {
                        listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + "Yorum yapılamadı.");
                    }
                }
                else if (satirnum == textBox1.Lines.Length)
                {
                    tekrar += 1;
                    if (tekrar != (int)numericUpDown4.Value)
                    {
                        satirnum = 0;
                        //listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "] " + tekrar +".tekrar.");
                    }
                    else
                    {
                        IslemBitti();
                    }
                }

            }
            catch (Exception ex)
            {
                listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "]" + ex.Message);
            }
        }
        private void IslemBitti()
        {
            timer1.Stop();
            tekrar = 0;
            satirnum = 0;
            saydimmm = 0;
            btnBaslat.Text = "Başlat";
            listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm") + "] İşlem bitti.");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dogrula(api);
        }
        private void button3_Click(object sender, EventArgs e)
        {

            Application.Restart();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtParola.Text))
            {
                if (checkBox2.Checked)
                {
                    using (StreamWriter sw = new StreamWriter("data.base"))
                    {
                        sw.WriteLine(txtKullaniciAdi.Text + "\n" + txtParola.Text);
                    }
                }
                else
                {
                    File.Delete("data.base");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists("data.base"))
            {
                txtKullaniciAdi.Text = File.ReadAllLines("data.base")[0];
                txtParola.Text = File.ReadAllLines("data.base")[1];
                checkBox2.Checked = true;
                btnBaslat.PerformClick();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                txtParola.PasswordChar = '\0';
            }
            else { txtParola.PasswordChar = '*'; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Kodlayan: Sagopa K\nYazıldığı Dil: C#.NET\nhttps://www.turkhackteam.org/members/798025.html", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value * 1000;
        }
        string Aydi = "";
        private async Task<bool> Get_Media_ID()
        {
            try
            {
                string test = await GetResponseText(textBox2.Text);
                MediaID media_ID = JsonConvert.DeserializeObject<MediaID>(test);
                Aydi = media_ID.media_id;
                return true;
            }
            catch (Exception) { return false; }

        }
        public class MediaID
        {
            public string media_id { get; set; }
        }
    }
}
