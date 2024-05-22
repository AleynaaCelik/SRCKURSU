using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;

namespace SürücüKursu
{
    public partial class NufusBilgileri : Form
    {
        public NufusBilgileri()
        {
            InitializeComponent();
        }

        //OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + @"\database.accdb");
        //OleDbCommand komut = null;
       // OleDbDataAdapter adapter = null;
       // DataTable doldur = null;

        private void griddoldur()
        {

            SqlConnection connection = new SqlConnection(Program.connectionString);
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From nufus Where tc=?", connection);
            komut.Parameters.AddWithValue("?", AnaForm.id.ToString());

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = komut;
            DataTable doldur = new DataTable();
            adapter.Fill(doldur);
            dataGridView1.DataSource = doldur;
            connection.Close();
            adapter.Dispose();

        }

        private void combobox_doldur()
        {
            dini.Items.Add("İslam");
            dini.Items.Add("Yabanci Uyruklu");

            veriliş_nedeni.Items.Add("Kayıp");
            veriliş_nedeni.Items.Add("Yenileme");
            veriliş_nedeni.Items.Add("Değiştirme");
        }


        private void guncelle()
        {
            if (seri.Text == "" || no.Text == "" || tc_kimlik.Text == "" || ad.Text == "" || soyad.Text == "" || baba.Text == "" || ana.Text == "" || dogum_yeri.Text == "" || medeni.Text == "" || kan_grup.Text == "" || il.Text == "" || ilçe.Text == "" || mahalle.Text == "" || cilt_no.Text == "" || aile_sıra.Text == "" || sıra.Text == "" || verildiği_yer.Text == "" || kayıt_no.Text == "" || dini.SelectedIndex == -1 || veriliş_nedeni.SelectedIndex == -1)
            {
                errorProvider1.SetError(seri, "Boş Geçilemez !!!");
                errorProvider1.SetError(no, "Boş Geçilemez !!!");
                errorProvider1.SetError(tc_kimlik, "Boş Geçilemez !!!");
                errorProvider1.SetError(ad, "Boş Geçilemez !!!");
                errorProvider1.SetError(soyad, "Boş Geçilemez !!!");
                errorProvider1.SetError(baba, "Boş Geçilemez !!!");
                errorProvider1.SetError(ana, "Boş Geçilemez !!!");
                errorProvider1.SetError(dogum_yeri, "Boş Geçilemez !!!");
                errorProvider1.SetError(medeni, "Boş Geçilemez !!!");
                errorProvider1.SetError(kan_grup, "Boş Geçilemez !!!");
                errorProvider1.SetError(il, "Boş Geçilemez !!!");
                errorProvider1.SetError(ilçe, "Boş Geçilemez !!!");
                errorProvider1.SetError(mahalle, "Boş Geçilemez !!!");
                errorProvider1.SetError(cilt_no, "Boş Geçilemez !!!");
                errorProvider1.SetError(aile_sıra, "Boş Geçilemez !!!");
                errorProvider1.SetError(sıra, "Boş Geçilemez !!!");
                errorProvider1.SetError(verildiği_yer, "Boş Geçilemez !!!");
                errorProvider1.SetError(kayıt_no, "Boş Geçilemez !!!");
                errorProvider1.SetError(dini, "Boş Geçilemez !!!");
                errorProvider1.SetError(veriliş_nedeni, "Boş Geçilemez !!!");
            }
            else
            {

                try
                {

                    DialogResult sonuc;
                    sonuc = MessageBox.Show("Kursiyer bilgilerini onaylıyor musunuz ?", "Sisteme Kayıt Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    if (sonuc == DialogResult.Yes)
                    {

                        SqlConnection connection = new SqlConnection(Program.connectionString);
                        connection.Open();
                        SqlCommand komut = new SqlCommand("update nufus set seri_no=@seri,numara=@no,tc=@tc,adi=@adi,soyadi=@soyadi,baba=@baba,ana=@ana,dogum=@dogum,dogum_tarih=@dogum_tarih,medeni=@medeni,dini=@dini,kan_grup=@kan_grup,il=@il,ilce=@ilce,mahalle=@mahalle,cilt_no=@cilt_no,aile_sıra=@aile_sıra,sıra_no=@sıra_no,v_yer=@v_yer,v_nedeni=@v_nedeni,kayit_no=@kayit_no,verilis_tarih=@verilis_tarih Where tc='" + AnaForm.id + "'", connection);
                        komut.Parameters.AddWithValue("@seri", seri.Text);
                        komut.Parameters.AddWithValue("@no", no.Text);
                        komut.Parameters.AddWithValue("@tc", tc_kimlik.Text);
                        komut.Parameters.AddWithValue("@adi", ad.Text);
                        komut.Parameters.AddWithValue("@soyadi", soyad.Text);
                        komut.Parameters.AddWithValue("@baba", baba.Text);
                        komut.Parameters.AddWithValue("@ana", ana.Text);
                        komut.Parameters.AddWithValue("@dogum", dogum_yeri.Text);
                        komut.Parameters.AddWithValue("@dogum_tarih", dogum_tarih.Value.ToString());
                        komut.Parameters.AddWithValue("@medeni", medeni.Text);
                        komut.Parameters.AddWithValue("@dini", dini.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@kan_grup", kan_grup.Text);
                        komut.Parameters.AddWithValue("@il", il.Text);
                        komut.Parameters.AddWithValue("@ilce", ilçe.Text);
                        komut.Parameters.AddWithValue("@mahalle", mahalle.Text);
                        komut.Parameters.AddWithValue("@cilt_no", cilt_no.Text);
                        komut.Parameters.AddWithValue("@aile_sıra", aile_sıra.Text);
                        komut.Parameters.AddWithValue("@sıra_no", sıra.Text);
                        komut.Parameters.AddWithValue("@v_yer", verildiği_yer.Text);
                        komut.Parameters.AddWithValue("@v_nedeni", veriliş_nedeni.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@kayit_no", kayıt_no.Text);
                        komut.Parameters.AddWithValue("@verilis_tarih", veriliş_tarih.Value.ToString());
                        komut.ExecuteNonQuery();
                        komut.Dispose();
                        griddoldur();
                        MessageBox.Show("Kursiyer Nufus bilgileri başarı ile güncellenmiştir !!! ", "Güncelleme Başarılı !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kursiyer Nufus bilgileri güncellenlenirken hata oluştu !!! Hata Bilgisi " + ex, "Kişisel Bilgiler Güncelleme Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void NufusBilgileri_Load(object sender, EventArgs e)
        {
           
            griddoldur();
            combobox_doldur();
            
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {

        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            
            guncelle();
            
        }

        private void aday_nufus_sil()
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Aday bilgilerini silmeyi onaylıyor musunuz ?", "Bilgi Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    SqlConnection connection = new SqlConnection(Program.connectionString);
                    connection.Open();
                    SqlCommand komut = new SqlCommand("Delete From nufus where tc=?", connection);
                    komut.Parameters.AddWithValue("?", AnaForm.id);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Seçilen aday nufus bilgisi silindi !!!", "Silme işlemi Başarılı !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aday bilgilerini silerken sistemde hata oluştu !!! Hata Bilgisi " + ex, "Aday Silme İşlemi Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
            }
        }

        private void buttonSil_Click_1(object sender, EventArgs e)
        {
            
            aday_nufus_sil();
            
        }

        private void medeni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
