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
    public partial class Odemeler : Form
    {
        public Odemeler()
        {
            InitializeComponent();
        }

        
        String id = null;


        private void grid_doldur()
        {
            SqlConnection connection = new SqlConnection(Program.connectionString);
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From odeme Where tc_kimlik=? order by odeme_id desc", connection);
            komut.Parameters.AddWithValue("?", AnaForm.id);


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = komut;
            DataTable doldur = new DataTable();
            adapter.Fill(doldur);
            dataGridView1.DataSource = doldur;
            connection.Close();
            adapter.Dispose();


        }

        private void Odemeler_Load(object sender, EventArgs e)
        {
            o_tc_kimlik.Text = AnaForm.id.ToString();
            
            grid_doldur();
           
        }

        private void buttonCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void odeme_giris()
        {
            if (o_tc_kimlik.Text == "" || t_borc.Text == "" || o_tutar.Text == "")
            {
                errorProvider1.SetError(o_tc_kimlik, "Boş Geçilemez !!!");
                errorProvider1.SetError(t_borc, "Boş Geçilemez !!!");
                errorProvider1.SetError(o_tutar, "Boş Geçilemez !!!");
            }
            else
            {
                int toplam_borc = Convert.ToInt32(t_borc.Text);
                int odeme = Convert.ToInt32(o_tutar.Text);
                int kalan_borc = toplam_borc - odeme;

                DialogResult sonuc;
                sonuc = MessageBox.Show("Kursiyer Ödeme bilgilerini onaylıyor musunuz ?", "Ödeme bilgisi Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                try
                {
                    if (sonuc == DialogResult.Yes)
                    {

                        SqlConnection connection = new SqlConnection(Program.connectionString);
                        connection.Open();
                        SqlCommand komut = new SqlCommand("insert into odeme(tc_kimlik,o_tarih,toplam_borc,o_tutar,kalan_borc) Values(?,?,?,?,?)", connection);
                        komut.Parameters.AddWithValue("?", AnaForm.id);
                        komut.Parameters.AddWithValue("?", odeme_dateTime.Value.ToString());
                        komut.Parameters.AddWithValue("?", t_borc.Text);
                        komut.Parameters.AddWithValue("?", o_tutar.Text);
                        komut.Parameters.AddWithValue("?", kalan_borc.ToString());
                        komut.ExecuteNonQuery();
                        grid_doldur();
                        MessageBox.Show("Kursiyer ödeme bilgileri sisteme başarı ile girilmiştir !!! ", "Sürücü adayı ödeme Bilgileri !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ödeme bilgi girişi yapılırken sistemde hata oluştu !!! Hata Bilgisi " + ex, "Ödeme girişi hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
            }
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
           
            odeme_giris();
           
        }

        private void odeme_sil()
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Ödeme bilgilerini silmeyi onaylıyor musunuz ?", "Ödeme Bilgisi Silme Onayı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    id = dataGridView1.CurrentRow.Cells["odeme_id"].Value.ToString();

                    SqlConnection connection = new SqlConnection(Program.connectionString);
                    connection.Open();
                    SqlCommand komut = new SqlCommand("Delete From odeme where odeme_id=?", connection);
                    komut.Parameters.AddWithValue("?", id);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Seçilen ödeme bilgisi silindi !!!", "Silme işlemi Başarılı !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aday bilgilerini silerken sistemde hata oluştu !!! Hata Bilgisi " + ex, "Aday Silme İşlemi Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
            }

        }


        private void buttonSil_Click(object sender, EventArgs e)
        {
           
            odeme_sil();
           
        }

        private void o_tc_kimlik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
