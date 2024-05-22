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
    public partial class KullaniciGiris : Form
    {
        //OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + @"\database.accdb");
        //OleDbCommand komut = null;
        //OleDbDataReader oku = null;
        //AnaForm anamenu = new AnaForm();
        //pass_sıfırla sıfırla = new pass_sıfırla();
        public static string kul_adi = null;

        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void giris()
        {
            string kullanici = "", sifre = "";
            SaveINI ini = new SaveINI(Program.programPath);
            sifrele sifrele = new sifrele();
            if (Program.loginUser!=string.Empty && Program.loginPassword!=string.Empty )
             {
                kullanici = textBox1.Text;
                sifre = textBox2.Text;
            }
            else
            {
                kullanici = textBox1.Text;
                sifre =textBox2.Text;
            }
            SqlConnection connection = new SqlConnection(Program.connectionString);
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From giris where kul_adi=@p1 and kul_sifre=@p2", connection);  
            komut.Parameters.AddWithValue("@p1",kullanici);
            komut.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader reader = komut.ExecuteReader();

            if(reader.Read())
            {
                if(checkBox1.Checked==true)
                {
                    ini.Yaz("information","rememberedUser",textBox1.Text);
                    ini.Yaz("information","rememberedPassword",sifre);
                }


                AnaForm anaform = new AnaForm();
                anaform.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "SURUCU KURSU", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                textBox2.Text =string.Empty;
                textBox1.Text=string.Empty;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                errorProvider1.SetError(textBox1, "Boş Geçilemez !!!");
                errorProvider1.SetError(textBox2, "Boş Geçilemez !!!");
            }
            else
            {
                giris();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Aqua;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Aqua;
        }

        private void p_sıfır_Click(object sender, EventArgs e)
        {
            //sıfırla.ShowDialog();
            //p_sıfır.Enabled = false;
        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.loginUser;
            textBox2.Text = Program.loginPassword;
        }
    }
}

