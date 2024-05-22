using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Net.Mail;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SürücüKursu
{
    public partial class pass_sıfırla : Form
    {
        public pass_sıfırla()
        {
            InitializeComponent();
        }

     
        MailMessage ePosta = new MailMessage();

        private void pass_sıfırla_Load(object sender, EventArgs e)
        {
            k_adi.Text = KullaniciGiris.kul_adi;
            k_adi.Focus();
        }

        public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("iletisim@okanduzgun.com");
            ePosta.To.Add(p_eposta.Text);
            //ePosta.Attachments.Add(new Attachment(@"C:\deneme.txt"));
            ePosta.Subject = konu;
            ePosta.Body = icerik;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("sevgitunca72@gmail.com", "116206072");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
                MessageBox.Show("Şifreniz Başarı ile değiştirildi, Şifre değişikliği bilgisi E-Mail adresinize gönderilmiştir !!!", " E-Mail Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show("Şifreniz Başarı ile değiştirildi, fakat teknik hata sebebiyle E-Posta adresinize bilgilendirme E-Mail;i gönderilemedi. Hata Bilgisi: " + ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;

        }

        private void s_yenile_Click(object sender, EventArgs e)
        {
            if (k_adi.Text == "" || p_adi.Text == "" || p_soyadi.Text == "" || p_eposta.Text == "" || p_number.Text == "" || p_tc.Text == "" || y_sifre.Text == "" || y_tekrar.Text == "")
            {
                errorProvider1.SetError(k_adi, "Boş Geçilemez !!!");
                errorProvider1.SetError(p_adi, "Boş Geçilemez !!!");
                errorProvider1.SetError(p_eposta, "Boş Geçilemez !!!");
                errorProvider1.SetError(p_number, "Boş Geçilemez !!!");
                errorProvider1.SetError(p_soyadi, "Boş Geçilemez !!!");
                errorProvider1.SetError(p_tc, "Boş Geçilemez !!!");
                errorProvider1.SetError(y_sifre, "Boş Geçilemez !!!");
                errorProvider1.SetError(y_tekrar, "Boş Geçilemez !!!");
            }
            else
            {
                if (y_sifre.Text == y_tekrar.Text)
                {

                    DialogResult sonuc;
                sonuc = MessageBox.Show("Şifre degişikliği işlemini onaylıyor musunuz ?", "Kullanıcı Şifre Yenileme Onayı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    if (sonuc == DialogResult.Yes)
                    {
                     
                        SqlConnection connection = new SqlConnection(Program.connectionString);
                        connection.Open();
                        SqlCommand komut = new SqlCommand("Select * From giris where kul_adi=? and per_adi=? and per_soy=? and per_tc=? and per_numarası=? and per_eposta=?", connection);
                        komut.Parameters.AddWithValue("?", k_adi.Text);
                        komut.Parameters.AddWithValue("?", p_adi.Text);
                        komut.Parameters.AddWithValue("?", p_soyadi.Text);
                        komut.Parameters.AddWithValue("?", p_tc.Text);
                        komut.Parameters.AddWithValue("?", p_number.Text);
                        komut.Parameters.AddWithValue("?", p_eposta.Text);
                        SqlDataReader oku = komut.ExecuteReader();
                        if (oku.Read() == true)
                        {
                            SqlConnection connection_ = new SqlConnection(Program.connectionString);
                            connection.Open();
                            SqlCommand komut_ = new SqlCommand("Update giris set kul_sifre=? where kul_adi=? ", connection_);
                            komut_.Parameters.AddWithValue("?", y_sifre.Text);
                            komut_.Parameters.AddWithValue("?", KullaniciGiris.kul_adi);
                            komut_.ExecuteNonQuery();
                            k_adi.Enabled = false;
                            p_adi.Enabled = false;
                            p_soyadi.Enabled = false;
                            p_eposta.Enabled = false;
                            p_number.Enabled = false;
                            p_tc.Enabled = false;
                            y_sifre.Enabled = false;
                            y_tekrar.Enabled = false;
                            s_yenile.Enabled = false;
                            kapat.Enabled = true;
                            Gonder("Şifre Değişikliği", "Şifreniz Başarılı bir şekilde degiştirilmiştir !!! Bu mail bilgilendirme amaçlı gönderilmiştir...");
                        }
                        else
                        {
                            MessageBox.Show("Girilen bilgiler veritabanı ile uyuşmuyor,Lütfen bilgilerinizi kontrol ediniz !!!", "Hatalı Bilgi Girişi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        komut.Dispose();
                        oku.Close();
                        

                    }
                }
                else
                {
                    MessageBox.Show("Şifreleriniz birbiri ile uyumlu degildir !!!", "Yeni şifrelerinizi kontrol ediniz !!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

                }

            }
        }

        private void y_sifre_TextChanged(object sender, EventArgs e)
        {
            y_sifre.BackColor = Color.Red;

        }

        private void y_tekrar_TextChanged(object sender, EventArgs e)
        {
            y_tekrar.BackColor = Color.Red;
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void k_adi_TextChanged(object sender, EventArgs e)
        {
            k_adi.BackColor = Color.Aqua;
        }

        private void p_adi_TextChanged(object sender, EventArgs e)
        {
            p_adi.BackColor = Color.Aqua;
        }

        private void p_soyadi_TextChanged(object sender, EventArgs e)
        {
            p_soyadi.BackColor = Color.Aqua;
        }

        private void p_tc_TextChanged(object sender, EventArgs e)
        {
            p_tc.BackColor = Color.Aqua;
        }

        private void p_number_TextChanged(object sender, EventArgs e)
        {
            p_number.BackColor = Color.Aqua;
        }

        private void p_eposta_TextChanged(object sender, EventArgs e)
        {
            p_eposta.BackColor = Color.Aqua;
        }
    }
}
