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
    public partial class AdayBilgileri : Form
    {

       // OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + @"\database.accdb");
       // OleDbCommand komut = null;
       // OleDbDataAdapter adapter = null;
       // DataTable doldur = null;
        String rapor = "Seçim Yapılmadı";
        String belge = "Seçim Yapılmadı";


        public AdayBilgileri()
        {
            InitializeComponent();
        }

        private void griddoldur()
        {
            SqlConnection connection = new SqlConnection(Program.connectionString);
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From aday_bilgi Where tc_kimlik=?", connection);
            komut.Parameters.AddWithValue("?", AnaForm.id.ToString());

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = komut;
            DataTable doldur = new DataTable();
            adapter.Fill(doldur);
            dataGridView1.DataSource = doldur;
            connection.Close();
            adapter.Dispose();
        }

        private void aday_guncelle()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1)
            {
                errorProvider1.SetError(textBox1, "Boş Geçilemez !!!");
                errorProvider1.SetError(textBox2, "Boş Geçilemez !!!");
                errorProvider1.SetError(textBox3, "Boş Geçilemez !!!");
                errorProvider1.SetError(textBox4, "Boş Geçilemez !!!");
                errorProvider1.SetError(textBox5, "Boş Geçilemez !!!");
                //errorProvider1.SetError(radioButton1,"Boş Geçilemez !!!");
                //errorProvider1.SetError(textBox7, "Boş Geçilemez !!!");
                errorProvider1.SetError(comboBox1, "Boş Geçilemez !!!");
                errorProvider1.SetError(comboBox2, "Boş Geçilemez !!!");
                errorProvider1.SetError(comboBox3, "Boş Geçilemez !!!");
                errorProvider1.SetError(comboBox4, "Boş Geçilemez !!!");
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
                        SqlCommand komut = new SqlCommand("Update aday_bilgi set tc_kimlik=?,ad=?,soyad=?,kul_arac=?,yas=?,tahsil=?,telefon=?,saglik_rapor=?,adli_belge=?,kayit_tarih=?,sinif_adi=?,ehliyet_sinifi=? Where tc_kimlik=?  ", connection);
                        komut.Parameters.AddWithValue("?", textBox1.Text);
                        komut.Parameters.AddWithValue("?", textBox2.Text);
                        komut.Parameters.AddWithValue("?", textBox3.Text);
                        komut.Parameters.AddWithValue("?", comboBox1.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("?", textBox4.Text);
                        komut.Parameters.AddWithValue("?", comboBox2.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("?", textBox5.Text);
                        komut.Parameters.AddWithValue("?", rapor);
                        komut.Parameters.AddWithValue("?", belge);
                        komut.Parameters.AddWithValue("?", dateTimePicker1.Value.ToString());
                        komut.Parameters.AddWithValue("?", comboBox3.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("?", comboBox4.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("?", AnaForm.id);

                        komut.ExecuteNonQuery();
                        MessageBox.Show("Aday bilgileriniz güncellendi !!!", "Güncelleme Başarılı !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        komut.Dispose();
                        //adapter.Dispose();
                        griddoldur();
                        AnaForm listele = (AnaForm)Application.OpenForms["anaform"];
                        listele.grid_doldur();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Aday bilgilerini güncellerken sistemde hata oluştu !!! Hata Bilgisi " + ex, "Aday bilgileri güncelleme Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }

            }
        }

        private void aday_sil()
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Aday bilgileri silmeyi onaylıyor musunuz ?", "Bilgi Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    SqlConnection connection = new SqlConnection(Program.connectionString);
                    connection.Open();
                    SqlCommand komut = new SqlCommand("Delete From aday_bilgi where aday_id=?", connection);
                    komut.Parameters.AddWithValue("?", AnaForm.id);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Seçilen aday bilgisi silindi !!!", "Silme işlemi Başarılı !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    AnaForm listele = (AnaForm)Application.OpenForms["anaform"];
                    listele.grid_doldur();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Aday bilgilerini silerken sistemde hata oluştu !!! Hata Bilgisi " + ex, "Aday Silme İşlemi Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }  
            }
        }

        private void comboBox1_doldur()
        {
            comboBox1.SelectedText = "Birini Seçiniz";
            comboBox2.SelectedText = "Birini Seçiniz";
            comboBox3.SelectedText = "Birini Seçiniz";
            comboBox4.SelectedText = "Birini Seçiniz";
        
            comboBox1.Items.Add("M");
            comboBox1.Items.Add("N");
            comboBox1.Items.Add("G");
            comboBox1.Items.Add("O");

            comboBox2.Items.Add("İlkÖğretim");
            comboBox2.Items.Add("OrtaÖğretim");
            comboBox2.Items.Add("Üniversite");
            comboBox2.Items.Add("Yüksek Lisans");
            comboBox2.Items.Add("Doktora");

            comboBox3.Items.Add("2013/1 Gündüz");
            comboBox3.Items.Add("2013/1 Gece");
            comboBox3.Items.Add("2013/2 Gündüz");
            comboBox3.Items.Add("2013/2 Gece");

            comboBox4.Items.Add("A1");
            comboBox4.Items.Add("A2");
            comboBox4.Items.Add("B");
            comboBox4.Items.Add("C");
            comboBox4.Items.Add("D");
            comboBox4.Items.Add("E");
            comboBox4.Items.Add("F");
            comboBox4.Items.Add("G");
            comboBox4.Items.Add("H");
            comboBox4.Items.Add("K");
        }

        private void AdayBilgileri_Load(object sender, EventArgs e)
        {
            
            griddoldur();
           
            comboBox1_doldur();
            
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
           
            aday_guncelle();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                rapor = "Var";
            }
            else
            {
                rapor = "Seçim Yapılmadı";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                rapor = "Yok";
            }
            else
            {
                rapor = "Seçim Yapılmadı";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                belge = "Var";
            }
            else
            {
                belge = "Seçim Yapılmadı";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                belge = "Yok";
            }
            else
            {
                belge = "Seçim Yapılmadı";
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            
            aday_sil();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
