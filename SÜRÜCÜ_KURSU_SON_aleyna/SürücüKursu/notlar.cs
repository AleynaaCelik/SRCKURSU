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
    public partial class notlar : Form
    {
        public notlar()
        {
            InitializeComponent();
        }

       
        String id = null;

        private void grid_doldur()
        {
            SqlConnection connection = new SqlConnection(Program.connectionString);
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From notlar Where tc_kimlik=?", connection);
            komut.Parameters.AddWithValue("?", AnaForm.id);

          SqlDataAdapter  adapter = new SqlDataAdapter();
            adapter.SelectCommand = komut;
           DataTable doldur = new DataTable();
            adapter.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void notlar_Load(object sender, EventArgs e)
        {
            not_tc.Text = AnaForm.id;
           
            grid_doldur();
            
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void not_guncelle()
        {
            if (not_trafik.Text == "" || not_motor.Text == "" || not_ilkyardim.Text == "")
            {
                errorProvider1.SetError(not_trafik, "Boş Geçilemez !!!");
                errorProvider1.SetError(not_motor, "Boş Geçilemez !!!");
                errorProvider1 .SetError (not_ilkyardim,"Boş Geçilemez");
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
                        SqlCommand komut = new SqlCommand("Update notlar set s_tarih=?,trafik_notu=?,motor_notu=?,ilkyardim_notu=? Where tc_kimlik=?", connection);
                komut.Parameters.AddWithValue("?", not_dateTimePicker2.Value.ToString());
                komut.Parameters.AddWithValue("?", not_trafik.Text);
                komut.Parameters.AddWithValue("?", not_motor.Text);
                komut.Parameters.AddWithValue("?", not_ilkyardim.Text);
                komut.Parameters.AddWithValue("?", AnaForm.id);
                komut.ExecuteNonQuery();
                        connection.Close();
                        grid_doldur();
                MessageBox.Show("Kursiyer not bilgisi başarılı bir şekilde güncellenmiştir !!! ", "Sürücü adayı not güncelleme !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                not_ilkyardim.Text = null;
                not_motor.Text = null;
                not_trafik.Text = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not bilgilerini güncellenirken sistemde hata oluştu !!! Hata Bilgisi " + ex, "Aday bilgileri güncelleme Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                }
            }
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            not_guncelle();
           
        }

        private void not_sil()
       {
               DialogResult sonuc;
               sonuc = MessageBox.Show("Sürücü adayı not bilgilerini silmeyi onaylıyor musunuz ?", "Bilgi Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

               if (sonuc == DialogResult.Yes)
               {
                   try
                   {
                    SqlConnection connection = new SqlConnection(Program.connectionString);
                    connection.Open();
                    SqlCommand komut = new SqlCommand("Delete from notlar Where tc_kimlik=?", connection);
                    komut.Parameters.AddWithValue("?", AnaForm.id);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Seçilen aday not bilgisi silindi !!!", "Silme işlemi Başarılı !!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                   catch(Exception ex)
                   {
                       MessageBox.Show("Aday not bilgilerini silerken sistemde hata oluştu !!! Hata Bilgisi " + ex, "Aday Silme İşlemi Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                   }

               }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            
            not_sil();
           
        }

        private void not_trafik_TextChanged(object sender, EventArgs e)
        {

        }

        private void not_tc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
