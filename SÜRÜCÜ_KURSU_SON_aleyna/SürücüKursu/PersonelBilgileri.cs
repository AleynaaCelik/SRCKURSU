using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SürücüKursu
{
    public partial class PersonelBilgileri : Form
    {
        public PersonelBilgileri()
        {
            InitializeComponent();
        }

        //OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + @"\database.accdb");
       // OleDbCommand komut = null;
      //  OleDbDataAdapter adapter = null;
        //DataTable doldur = null;

        private void personel_doldur()
        {
            SqlConnection connection = new SqlConnection(Program.connectionString);
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From personel Where per_tc=?",connection);

            komut.Parameters.AddWithValue("",AnaForm.id);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = komut;
            DataTable doldur = new DataTable();
            adapter.Fill(doldur);
            dataGridView1.DataSource = doldur;
            connection.Close();
            adapter.Dispose();

        }

        private void PersonelBilgileri_Load(object sender, EventArgs e)
        {
            p_tc_kimlik.Text = AnaForm.id;
            p_tc_kimlik.Enabled = false;
            
            personel_doldur();
           
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personel_guncelle()
        {

            if (p_ad.Text == "" || p_adres.Text == "" || p_eposta.Text == "" || p_görev.Text == "" || p_soyadi.Text == "" || p_tc_kimlik.Text == "" || p_telefon.Text == "")
            {
                errorProvider1.SetError(p_ad, "Boş Geçilemez !!!");
                errorProvider1.SetError(p_adres, "Boş Geçilemez !!!");
                errorProvider1.SetError(p_eposta, "Boş Geçilemez !!!");
                errorProvider1.SetError(p_görev, "Boş Geçilemez !!!");
                errorProvider1.SetError(p_soyadi, "Boş Geçilemez !!!");
                errorProvider1.SetError(p_tc_kimlik, "Boş Geçilemez !!!");
                errorProvider1.SetError(p_telefon, "Boş Geçilemez !!!");

            }
            else
            {
                DialogResult sonuc;
                sonuc = MessageBox.Show("Aday bilgileri güncellemeyi onaylıyor musunuz ?", "Bilgi Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (sonuc == DialogResult.Yes)
                {
                    try
                    {

                        SqlConnection connection = new SqlConnection(Program.connectionString);
                        connection.Open();
                        SqlCommand komut = new SqlCommand("Update personel set per_adi=?,per_soyad=?,per_telefon=?,per_adres=?,per_görevi=? Where per_tc=?", connection);
                        komut.Parameters.AddWithValue("?", p_ad.Text);
                        komut.Parameters.AddWithValue("?", p_soyadi.Text);
                        komut.Parameters.AddWithValue("?", p_telefon.Text);
                        komut.Parameters.AddWithValue("?", p_adres.Text);
                        komut.Parameters.AddWithValue("?", p_görev.Text);
                        komut.Parameters.AddWithValue("?", AnaForm.id);
                        komut.ExecuteNonQuery();
                        komut.Dispose();
                        personel_doldur();
                        MessageBox.Show("Personel bilgileriniz güncellendi !!!", "Güncelleme Başarılı !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Personel bilgilerini güncellerken sistemde hata oluştu !!! Hata Bilgisi " + ex, "Personel bilgileri güncelleme Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    }
                }

            }
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
          
            personel_guncelle();
            
        }

        private void personel_sil()
        {
                DialogResult sonuc;
                sonuc = MessageBox.Show("Personel bilgilerini silmeyi onaylıyor musunuz ?", "Onayınız bekleniyor !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (sonuc == DialogResult.Yes)
                {
                    try
                    {

                    SqlConnection connection = new SqlConnection(Program.connectionString);
                    connection.Open();
                    SqlCommand komut = new SqlCommand("Delete from personel Where per_tc=?", connection);
                        komut.Parameters.AddWithValue("?", AnaForm.id);
                        komut.ExecuteNonQuery();
                        komut.Dispose();
                        MessageBox.Show("Personel bilgileriniz silinmiştir !!!", "Silme İşlemi Başarılı !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Personel bilgilerini silerken sistemde hata oluştu !!! Hata Bilgisi " + ex, "Personel bilgileri silme hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    }
            }

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
           
            personel_sil();
            
        }

        private void p_tc_kimlik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

