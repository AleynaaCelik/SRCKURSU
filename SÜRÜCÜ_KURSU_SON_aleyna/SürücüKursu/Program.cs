using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SürücüKursu
{
    static class Program
    {
        public static string dbName = "", server = "", user = "", password = "", loginUser = "", loginPassword = "", 
            programPath = System.IO.Directory.GetCurrentDirectory()+"//dbconfig.ini",
            connectionString="";
        [STAThread]
        static void Main()
        {
            SaveINI ini = new SaveINI(Program.programPath);
            sifrele sifrele = new SürücüKursu.sifrele();

          try
          {
              dbName = ini.Oku("information", "database");
              server = ini.Oku("information", "server");
              user = ini.Oku("information", "sqlUser");
              password = sifrele.TextSifreCoz(ini.Oku("information", "sqlPassword"));
              loginUser = ini.Oku("information", "rememberedUser");
              loginPassword =ini.Oku("information", "rememberedPassword");
          }
        catch
          {
              MessageBox.Show("Konfigurasyon dosyası doldurulmalıdır!", "SURUCU KURSU", MessageBoxButtons.OK, MessageBoxIcon.Error);
              Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);
              Application.Run(new Ayar());
          }

            if (dbName != string.Empty && server != string.Empty && user != string.Empty && password != string.Empty)
            {
                connectionString = @"data source=" + server + ";initial catalog=" + dbName + ";user=" + user + ";pwd=" + password;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new KullaniciGiris());
            }
            else
            {
                MessageBox.Show("Konfigurasyon dosyası doldurulmalıdır!", "SURUCU KURSU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Ayar());
            }


        }
    }
}
