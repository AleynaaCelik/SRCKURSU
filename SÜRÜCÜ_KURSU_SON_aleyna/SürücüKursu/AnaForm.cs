using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SürücüKursu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        String rapor = "Seçim Yapılmadı";
        String belge = "Seçim Yapılmadı";
        String ödeme_şekli = null;
        String cekim_tipi = null;
        String taksit_sayisi = null;
        public static String id = null;

        private void buttonCikis_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void buttonNüfüsBilgileri_Click(object sender, EventArgs e)
        {
         id = dataGridView1.CurrentRow.Cells["tc_kimlik"].Value.ToString();
         NufusBilgileri nufus_bilgileri = new NufusBilgileri();
         nufus_bilgileri.ShowDialog();
        }

        private void buttonAdayBilgileri_Click(object sender, EventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells["tc_kimlik"].Value.ToString();
            AdayBilgileri aday_bilgi = new AdayBilgileri();
            aday_bilgi.ShowDialog();
        }

   
        private void buttonCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOdemeler_Click_1(object sender, EventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells["tc_kimlik"].Value.ToString();
            Odemeler odemeler = new Odemeler();
            odemeler.ShowDialog();
        }

        private void buttonPersonelBilgileri_Click_1(object sender, EventArgs e)
        {
            id =  GridView2_personel.CurrentRow.Cells["per_tc"].Value.ToString();
            PersonelBilgileri personel = new PersonelBilgileri();
            personel.ShowDialog();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_doldur()
        {
            comboBox1.SelectedText = "Birini Seçiniz";
            comboBox2.SelectedText = "Birini Seçiniz";
            comboBox3.SelectedText = "Birini Seçiniz";
            comboBox4.SelectedText = "Birini Seçiniz";
            dini.SelectedText = "Birini Seçiniz";
            veriliş_nedeni.SelectedText = "Birini Seçiniz";

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

            comboBox5.Items.Add("1 Taksit");
            comboBox5.Items.Add("2 Taksit");
            comboBox5.Items.Add("3 Taksit");
            comboBox5.Items.Add("4 Taksit");
            comboBox5.Items.Add("5 Taksit");
            comboBox5.Items.Add("6 Taksit");


            dini.Items.Add("İslam");
            dini.Items.Add("Yabanci Uyruklu");

            veriliş_nedeni.Items.Add("Kayıp");
            veriliş_nedeni.Items.Add("Yenileme");
            veriliş_nedeni.Items.Add("Değiştirme");

  
        }
        public void grid_doldur()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Program.connectionString);
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter("Select aday_id,tc_kimlik,ad,soyad,telefon,saglik_rapor,adli_belge,kayit_tarih,ehliyet_sinifi from aday_bilgi order by aday_id desc", connection);
                DataSet ds = new DataSet();
                adp.Fill(ds,"table");
                dataGridView1.DataSource = ds.Tables["table"];
                connection.Close
                    ();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Aday bilgileri listelenirken hata oluştu !!! Hata Bilgisi " + ex, "Aday bilgileri gösterilemiyor !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            } 
        }
        private void personel_doldur()
        {
            try
            {

                SqlConnection sqlconnection = new SqlConnection(Program.connectionString);
                sqlconnection.Open();
                SqlDataAdapter adap = new SqlDataAdapter("Select per_tc,per_adi,per_soyad,per_telefon,per_email,per_görevi From personel order by per_id desc", sqlconnection);
                DataTable doldur = new DataTable();
                adap.Fill(doldur);
                GridView2_personel.DataSource = doldur;
                adap.Dispose();
                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel bilgileri listelenirken hata oluştu !!! Hata Bilgisi " + ex, "Personel bilgileri gösterilemiyor !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
            
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            
            comboBox1_doldur();
            grid_doldur();
            buttonPersonelBilgileri.Enabled = false;
          
        }

        private void kaydet()
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
                try
                {

                    DialogResult sonuc;
                    sonuc = MessageBox.Show("Aday bilgilerini onaylıyor musunuz ?", "Sisteme Kayıt Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    if (sonuc == DialogResult.Yes)
                    {
                        SqlConnection connection = new SqlConnection(Program.connectionString);
                        connection.Open();
                        SqlCommand komut = new SqlCommand("insert into aday_bilgi (tc_kimlik,ad,soyad,kul_arac,yas,tahsil,telefon,saglik_rapor,adli_belge,kayit_tarih,sinif_adi,ehliyet_sinifi) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", connection);
                        komut.Parameters.AddWithValue("@p1", textBox1.Text);
                        komut.Parameters.AddWithValue("@p2", textBox2.Text);
                        komut.Parameters.AddWithValue("@p3", textBox3.Text);
                        komut.Parameters.AddWithValue("@p4", comboBox1.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@p5", textBox4.Text);
                        komut.Parameters.AddWithValue("@p6", comboBox2.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@p7", textBox5.Text);
                        komut.Parameters.AddWithValue("@p8", rapor);
                        komut.Parameters.AddWithValue("@p9", belge);
                        komut.Parameters.AddWithValue("@p10", dateTimePicker1.Value);
                        komut.Parameters.AddWithValue("@p11", comboBox3.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@p12", comboBox4.SelectedItem.ToString());
                        komut.ExecuteNonQuery();
                        connection.Close();
                        grid_doldur();
                        MessageBox.Show("Kursiyer bilgileri sisteme başarı ile girilmiştir !!! ", "Sürücü Kursu Yeni Kayıt !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        groupBox1.Enabled = false;
                        b_kaydet.Enabled = false;
                        yeni_kayit.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kursiyer bilgileri sisteme kaydedilirken hata oluştu !!! Hata Bilgisi " + ex, "Yeni Kayıt Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }

        private void b_kaydet_Click(object sender, EventArgs e)
        {
            
            kaydet();
        
            
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

        private void yeni_kayit_Click(object sender, EventArgs e)
        {
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox1.SelectedText = "Birini Seçiniz";
            comboBox2.SelectedText = "Birini Seçiniz";
            comboBox3.SelectedText = "Birini Seçiniz";
            comboBox4.SelectedText = "Birini Seçiniz";
            groupBox1.Enabled = true;
            b_kaydet.Enabled = true;
            yeni_kayit.Enabled = false;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            //comboBox1.SelectedItem = -1;
            //comboBox2.SelectedItem = -1;
            //comboBox3.SelectedItem = -1;
            //comboBox4.SelectedItem = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }

        private void nufus_insert()
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
                        SqlCommand komut = new SqlCommand("insert into nufus (seri_no,numara,tc,adi,soyadi,baba,ana,dogum,dogum_tarih,medeni,dini,kan_grup,il,ilce,mahalle,cilt_no,aile_sıra,sıra_no,v_yer,v_nedeni,kayit_no,verilis_tarih) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22)", connection);
                        komut.Parameters.AddWithValue("@p1", seri.Text);
                        komut.Parameters.AddWithValue("@p2", no.Text);
                        komut.Parameters.AddWithValue("@p3", tc_kimlik.Text);
                        komut.Parameters.AddWithValue("@p4", ad.Text);
                        komut.Parameters.AddWithValue("@p5", soyad.Text);
                        komut.Parameters.AddWithValue("@p6", baba.Text);
                        komut.Parameters.AddWithValue("@p7", ana.Text);
                        komut.Parameters.AddWithValue("@p8", dogum_yeri.Text);
                        komut.Parameters.AddWithValue("@p9", dogum_tarih.Value);
                        komut.Parameters.AddWithValue("@p10", medeni.Text);
                        komut.Parameters.AddWithValue("@p11", dini.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@p12", kan_grup.Text);
                        komut.Parameters.AddWithValue("@p13", il.Text);
                        komut.Parameters.AddWithValue("@p14", ilçe.Text);
                        komut.Parameters.AddWithValue("@p15", mahalle.Text);
                        komut.Parameters.AddWithValue("@p16", cilt_no.Text);
                        komut.Parameters.AddWithValue("@p17", aile_sıra.Text);
                        komut.Parameters.AddWithValue("@p18", sıra.Text);
                        komut.Parameters.AddWithValue("@p19", verildiği_yer.Text);
                        komut.Parameters.AddWithValue("@p20", veriliş_nedeni.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@p21", kayıt_no.Text);
                        komut.Parameters.AddWithValue("@p22", veriliş_tarih.Value);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kursiyer Nufus bilgileri sisteme başarı ile girilmiştir !!! ", "Sürücü Kursu Yeni Kayıt !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        connection.Close();
                        
                        nufus_kaydet.Enabled = false;
                        seri.Enabled = false;
                        no.Enabled = false;
                        tc_kimlik.Enabled = false;
                        ad.Enabled = false;
                        soyad.Enabled = false;
                        baba.Enabled = false;
                        dini.Enabled = false;
                        ana.Enabled = false;
                        dogum_yeri.Enabled = false;
                        dogum_tarih.Enabled = false;
                        medeni.Enabled = false;
                        kan_grup.Enabled = false;
                        kan_grup.Enabled = false;
                        il.Enabled = false;
                        ilçe.Enabled = false;
                        mahalle.Enabled = false;
                        cilt_no.Enabled = false;
                        aile_sıra.Enabled = false;
                        sıra.Enabled = false;
                        verildiği_yer.Enabled = false;
                        veriliş_nedeni.Enabled = false;
                        veriliş_tarih.Enabled = false;
                        kayıt_no.Enabled = false;
                        nufus_yeni.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kursiyer bilgileri sisteme kaydedilirken hata oluştu !!! Hata Bilgisi " + ex, "Kişisel Bilgiler Kayıt Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }



        private void nufus_kaydet_Click(object sender, EventArgs e)
        {
         
            nufus_insert();
           
        }


        private void odeme_kaydet()
        {
            if (comboBox5.SelectedIndex == -1)
            {
                taksit_sayisi = "Taksit Bulunmamaktadir";
            }
            else
            {
                taksit_sayisi = comboBox5.SelectedItem.ToString();
            }

            if (o_tc_kimlik.Text == "" || o_tutar.Text == "" || t_borc.Text == "")
            {
                errorProvider1.SetError(o_tc_kimlik, "Boş Geçilemez !!!");
                errorProvider1.SetError(o_tutar, "Boş Geçilemez !!!");
                errorProvider1.SetError(t_borc, "Boş Geçilemez !!!");
            }
            else
            {
                try
                {
                    DialogResult sonuc;
                    sonuc = MessageBox.Show("Kursiyer Ödeme bilgilerini onaylıyor musunuz ?", "Ödeme bilgisi Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    if (sonuc == DialogResult.Yes)
                    {

                        int toplam_borc = Convert.ToInt32(t_borc.Text);
                        int ödeme_tutar = Convert.ToInt32(o_tutar.Text);
                        int kalan_borc = toplam_borc - ödeme_tutar;
                        SqlConnection connection = new SqlConnection(Program.connectionString);
                        connection.Open();
                        SqlCommand komut = new SqlCommand("insert into odeme(tc_kimlik,o_tarih,toplam_borc,o_tutar,kalan_borc,o_sekli,c_tipi,t_sayisi) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connection);
                        komut.Parameters.AddWithValue("@p1", o_tc_kimlik.Text);
                        komut.Parameters.AddWithValue("@p2", odeme_dateTime.Value.ToString());
                        komut.Parameters.AddWithValue("@p3", t_borc.Text);
                        komut.Parameters.AddWithValue("@p4", o_tutar.Text);
                        komut.Parameters.AddWithValue("@p5", kalan_borc.ToString());
                        komut.Parameters.AddWithValue("@p6", ödeme_şekli);
                        komut.Parameters.AddWithValue("@p7", cekim_tipi);
                        komut.Parameters.AddWithValue("@p8", taksit_sayisi);
                        komut.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Kursiyer Ödeme bilgileri sisteme başarı ile kaydedilmiştir !!! ", "Sürücü Kursu Ödeme Kayıt !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        o_tc_kimlik.Enabled = false;
                        odeme_dateTime.Enabled = false;
                        t_borc.Enabled = false;
                        o_tutar.Enabled = false;
                        ödeme_kaydet.Enabled = false;
                        ödeme_yeni.Enabled = true;
                        radio_kredi.Enabled = false;
                        radio_nakit.Enabled = false;
                        ödeme_group.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kursiyer Ödeme bilgileri sisteme kaydedilirken hata oluştu !!! Hata Bilgisi " + ex, "Yeni Kayıt Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }


        private void ödeme_kaydet_Click(object sender, EventArgs e)
        {
            odeme_kaydet();
            
            
        }

        private void ödeme_yeni_Click(object sender, EventArgs e)
        {
            o_tc_kimlik.Text = null;
            o_tutar.Text = null;
            t_borc.Text = null;
            o_tc_kimlik.Enabled = true;
            odeme_dateTime.Enabled = true;
            t_borc.Enabled = true;
            o_tutar.Enabled = true;
            ödeme_kaydet.Enabled = true;
            ödeme_yeni.Enabled = false;
            radio_nakit.Checked = false;
            radio_kredi.Checked = false;
            radioButton6.Checked = false;
            radioButton5.Checked = false;
            radio_kredi.Enabled = true;
            radio_nakit.Enabled = true;
        }

        private void radio_kredi_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_kredi.Checked == true)
            {
                ödeme_group.Enabled = true;
                ödeme_şekli = radio_kredi.Text;
               
            }
            else
            {
                ödeme_group.Enabled = false;

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                comboBox5.Enabled = true;
                cekim_tipi = radioButton5.Text;
                
            }
            else
            {
                comboBox5.Enabled = false;
                comboBox5.Text = "Taksit Sayısını Seçiniz !!!";
                
            }
        }

        private void radio_pesin_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nakit.Checked == true)
            {
               ödeme_şekli = radio_nakit.Text;
               cekim_tipi = "Null";
               taksit_sayisi = "Null";
               
            }
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            cekim_tipi = radioButton6.Text;
            
        }
        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kursiyer_panel.SelectedIndex == 4)
            {
                buttonPersonelBilgileri.Enabled = true;
                buttonAdayBilgileri.Enabled = false;
                buttonNüfüsBilgileri.Enabled = false;
                buttonOdemeler.Enabled = false;
                button_not.Enabled = false;
                liste_yenile.Enabled = false;
                personel_doldur();
            }
            else if (kursiyer_panel.SelectedIndex == 6)
            {
                buttonPersonelBilgileri.Enabled = false;
                buttonAdayBilgileri.Enabled = false;
                buttonNüfüsBilgileri.Enabled = false;
                buttonOdemeler.Enabled = false;
                button_not.Enabled = false;
                liste_yenile.Enabled = false;
                //ayarlar_giris giris = new ayarlar_giris();
                //giris.ShowDialog();
                
            }
            else
            {
                buttonPersonelBilgileri.Enabled = false;
                buttonAdayBilgileri.Enabled = true;
                buttonNüfüsBilgileri.Enabled = true;
                buttonOdemeler.Enabled = true;
                button_not.Enabled = true;
                liste_yenile.Enabled = true;
            }
        }

        private void notbilgi_kaydet()
        {
            if (not_tc.Text == "" || not_ilkyardim.Text == "" || not_motor.Text == "" || not_trafik.Text == "")
            {
                errorProvider1.SetError(not_tc, "Boş Geçilemez !!!");
                errorProvider1.SetError(not_ilkyardim, "Boş Geçilemez !!!");
                errorProvider1.SetError(not_motor, "Boş Geçilemez !!!");
                errorProvider1.SetError(not_trafik, "Boş Geçilemez !!!");
            }
            else
            {
                DialogResult sonuc;
                sonuc = MessageBox.Show("Kursiyer Not bilgilerini onaylıyor musunuz ?", "Ödeme bilgisi Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (sonuc == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(Program.connectionString);
                        connection.Open();
                        SqlCommand komut = new SqlCommand("insert into notlar(tc_kimlik,s_tarih,trafik_notu,motor_notu,ilkyardim_notu) values(@p1,@p2,@p3,@p4,@p5)", connection);
                        komut.Parameters.AddWithValue("@p1", not_tc.Text);
                        komut.Parameters.AddWithValue("@p2", not_dateTimePicker2.Value);
                        komut.Parameters.AddWithValue("@p3", not_trafik.Text);
                        komut.Parameters.AddWithValue("@p4", not_motor.Text);
                        komut.Parameters.AddWithValue("@p5", not_ilkyardim.Text);
                        komut.ExecuteNonQuery();
                        connection.Close(); 
                        MessageBox.Show("Kursiyer Not bilgileri sisteme başarı ile kaydedilmiştir !!! ", "Sürücü Kursu Not Kayıt !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        not_tc.Enabled = false;
                        not_motor.Enabled = false;
                        not_trafik.Enabled = false;
                        not_ilkyardim.Enabled = false;
                        not_dateTimePicker2.Enabled = false;
                        not_bilgi_kaydet.Enabled = false;
                        not_yeni_k.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kursiyer Not bilgileri sisteme kaydedilirken hata oluştu !!! Hata Bilgisi " + ex, "Yeni Kayıt Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void not_bilgi_kaydet_Click(object sender, EventArgs e)
        {

            
            notbilgi_kaydet();
           

        }

        private void not_yeni_k_Click(object sender, EventArgs e)
        {
            not_tc.Enabled = true;
            not_motor.Enabled = true;
            not_trafik.Enabled = true;
            not_ilkyardim.Enabled = true;
            not_dateTimePicker2.Enabled = true;
            not_bilgi_kaydet.Enabled = true;
            not_yeni_k.Enabled = false;
            not_tc.Text = null;
            not_motor.Text = null;
            not_trafik.Text = null;
            not_ilkyardim.Text = null;
        }

        private void personel_kaydet()
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
                sonuc = MessageBox.Show("Personel bilgilerini onaylıyor musunuz ?", "Ödeme bilgisi Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (sonuc == DialogResult.Yes)
                {
                    try
                    {

                        SqlConnection connection = new SqlConnection(Program.connectionString);
                        connection.Open();
                        SqlCommand komut = new SqlCommand("insert into personel(per_tc,per_adi,per_soyad,per_telefon,per_adres,per_email,per_görevi) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connection);
                        komut.Parameters.AddWithValue("@p1", p_tc_kimlik.Text);
                        komut.Parameters.AddWithValue("@p2", p_ad.Text);
                        komut.Parameters.AddWithValue("@p3", p_soyadi.Text);
                        komut.Parameters.AddWithValue("@p4", p_telefon.Text);
                        komut.Parameters.AddWithValue("@p5", p_adres.Text);
                        komut.Parameters.AddWithValue("@p6", p_eposta.Text);
                        komut.Parameters.AddWithValue("@p7", p_görev.Text);
                        komut.ExecuteNonQuery();
                        personel_doldur();
                        connection.Close();
                        MessageBox.Show("Personel bilgileri sisteme başarı ile kaydedilmiştir !!! ", "Sürücü Kursu Personel Kayıt !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        p_ad.Enabled = false;
                        p_adres.Enabled = false;
                        p_eposta.Enabled = false;
                        p_görev.Enabled = false;
                        p_soyadi.Enabled = false;
                        p_tc_kimlik.Enabled = false;
                        p_telefon.Enabled = false;
                        p_bilgikaydet.Enabled = false;
                        p_yenikayit.Enabled = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kursiyer Not bilgileri sisteme kaydedilirken hata oluştu !!! Hata Bilgisi " + ex, "Yeni Kayıt Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }


        }


        private void p_bilgikaydet_Click(object sender, EventArgs e)
        {
           
            personel_kaydet();
            
        }

        private void p_yenikayit_Click(object sender, EventArgs e)
        {
            p_ad.Text = null;
            p_adres.Text = null;
            p_eposta.Text = null;
            p_görev.Text = null;
            p_soyadi.Text = null;
            p_tc_kimlik.Text = null;
            p_telefon.Text = null;
            p_ad.Enabled =true;
            p_adres.Enabled = true;
            p_eposta.Enabled = true;
            p_görev.Enabled = true;
            p_soyadi.Enabled = true;
            p_tc_kimlik.Enabled = true;
            p_telefon.Enabled = true;
            p_bilgikaydet.Enabled = true;
            p_yenikayit.Enabled = false;
        }
        private void aday_arama()
        {
            try
            {

                SqlConnection connection = new SqlConnection(Program.connectionString);
                connection.Open();
                SqlCommand komut = new SqlCommand("Select tc_kimlik from aday_bilgi where (tc_kimlik=@p1 or ad=@p2)", connection);
                komut.Parameters.AddWithValue("@p1", arama.Text);
                komut.Parameters.AddWithValue("@p2", arama.Text);
               SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read() == true)
                {

                    SqlConnection connection_ = new SqlConnection(Program.connectionString);
                    connection_.Open();
                    SqlCommand komut_ = new SqlCommand("Select aday_id,tc_kimlik,ad,soyad,telefon,saglik_rapor,adli_belge,kayit_tarih,ehliyet_sinifi From aday_bilgi where tc_kimlik=@p1 or ad=@p2 order by aday_id desc", connection_);
                    komut_.Parameters.AddWithValue("@p1", arama.Text);
                    komut_.Parameters.AddWithValue("@p2", arama.Text);
                    SqlDataAdapter adap=new SqlDataAdapter();
                    adap.SelectCommand = komut_;
                    DataTable doldur = new DataTable();
                    adap.Fill(doldur);
                    GridView2_personel.DataSource = doldur;
                    adap.Dispose();
                  

                }
                else
                {
                    MessageBox.Show("Aranılan sorguya ait kursiyer bulunamadı !!!", "Kursiyer Bulunamadı !!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    arama.Text = null;
                    grid_doldur();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Kursiyer Araması sorgulanırken hata oluştu !!! Hata Bilgisi " + ex, "Arama Sorgulama Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (arama.Text == "")
            {
               
                errorProvider1.SetError(arama, "Boş Geçilemez !!!");

            }
            else
            {
                if (radio_tc_arama.Checked == true)
                {
                    aday_arama();
                    
                }
                else if (radio_isim_arama.Checked == true)
                {
                    
                    aday_arama();
                   
                }
                else
                {
                    MessageBox.Show("Arama Seçimizini yapmadınız !!!", "Arama Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                }
            }
        }

        private void liste_yenile_Click(object sender, EventArgs e)
        {

            grid_doldur();
    
        }

        private void nufus_yeni_Click(object sender, EventArgs e)
        {
            nufus_kaydet.Enabled = true;
            seri.Enabled = true;
            no.Enabled = true;
            tc_kimlik.Enabled = true;
            ad.Enabled = true;
            soyad.Enabled = true;
            baba.Enabled = true;
            dini.Enabled = true;
            ana.Enabled = true;
            dogum_yeri.Enabled = true;
            dogum_tarih.Enabled = true;
            medeni.Enabled = true;
            kan_grup.Enabled = true;
            kan_grup.Enabled = true;
            il.Enabled = true;
            ilçe.Enabled = true;
            mahalle.Enabled = true;
            cilt_no.Enabled = true;
            aile_sıra.Enabled = true;
            sıra.Enabled = true;
            verildiği_yer.Enabled = true;
            veriliş_nedeni.Enabled = true;
            veriliş_tarih.Enabled = true;
            kayıt_no.Enabled = true;
            nufus_yeni.Enabled = false;
            nufus_kaydet.Enabled = true;
        }

        private void button_not_Click(object sender, EventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells["tc_kimlik"].Value.ToString();
            notlar notlar = new notlar();
            notlar.ShowDialog();
        }

        private void sifre_degis()
        {
            if (per_number.Text == "" || m_sifre.Text == "" || y_sifre.Text == "" || y_s_tekrar.Text == "")
            {
                errorProvider1.SetError(per_number, "Boş Geçilemez !!!");
                errorProvider1.SetError(m_sifre, "Boş Geçilemez !!!");
                errorProvider1.SetError(y_sifre, "Boş Geçilemez !!!");
                errorProvider1.SetError(y_s_tekrar, "Boş Geçilemez !!!");

            }
            else
            {
                if (y_sifre.Text != y_s_tekrar.Text)
                {
                    MessageBox.Show("Şifreleriniz birbiri ile uyumlu degildir !!!", "Yeni şifrelerinizi kontrol ediniz !!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
                else
                {

                    DialogResult sonuc;
                    sonuc = MessageBox.Show("Kullanici şifrenizi değiştirmeyi onaylıyor musunuz ?", "Şifre Degiştirme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    if (sonuc == DialogResult.Yes)
                    {
                        try
                        {
                            SqlConnection connection = new SqlConnection(Program.connectionString);
                            connection.Open();
                            SqlCommand komut = new SqlCommand("Select * from giris Where kul_sifre=@kul_sifre and per_numarası=@per_number", connection);
                            komut.Parameters.AddWithValue("@kul_sifre", m_sifre.Text);
                            komut.Parameters.AddWithValue("@per_number", per_number.Text);
                          SqlDataReader  oku = komut.ExecuteReader();
                            if (oku.Read() == true)
                            {


                                SqlConnection connection_ = new SqlConnection(Program.connectionString);
                                connection_.Open();
                                SqlCommand komut_ = new SqlCommand("Update giris set kul_sifre=? Where per_numarası=?", connection_);
                                komut_.Parameters.AddWithValue("?", y_sifre.Text);
                                komut_.Parameters.AddWithValue("?", per_number.Text);
                                komut_.ExecuteNonQuery();
                                connection_.Close();
                                MessageBox.Show("Şifreniz degiştirilmiştir !!!", "Şifre degişikliği bilgisi !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                per_number.Text = null;
                                m_sifre.Text = null;
                                y_sifre.Text = null;
                                y_s_tekrar.Text = null;
                            }
                            else
                            {
                                MessageBox.Show("Personel Numaranızı veya Mevcut Şifrenizi hatalı girdiniz, Lütfen tekrar deneyiniz !!!", "Şifreniz Hatalı !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                m_sifre.Text = null;
                                y_sifre.Text = null;
                                y_s_tekrar.Text = null;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Şifre degiştirme işlemi gerçekleşirken sistemde hata oluştu !!! Hata Bilgisi " + ex, "Personel şifre degiştirme hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                        }
                    }
                }
            }
        }

        private void sifre_degistir_Click(object sender, EventArgs e)
        {
           
            sifre_degis();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        //private void radioButton1_Click(object sender, EventArgs e)
        //{
        //    rapor = "Var";
        //}

        //private void radioButton2_Click(object sender, EventArgs e)
        //{
        //    rapor = "Yok";
        //}

        //private void radioButton4_Click(object sender, EventArgs e)
        //{
        //    belge = "Var";
        //}

        //private void radioButton3_Click(object sender, EventArgs e)
        //{
        //    belge = "Yok";
        //}

    }
}


       
 

