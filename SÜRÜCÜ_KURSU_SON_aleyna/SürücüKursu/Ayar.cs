using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SürücüKursu
{
    public partial class Ayar : Form
    {
        public Ayar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveINI ini = new SaveINI(Program.programPath);
            sifrele sifrele = new sifrele();

            ini.Yaz("information","database",databaseTxt.Text);
            ini.Yaz("information", "server", serverTxt.Text);
            ini.Yaz("information", "sqlUser", userTxt.Text);
            ini.Yaz("information", "sqlPassword", sifrele.TextSifrele(passwordTxt.Text));

            MessageBox.Show("Ayararın geçerli olması için program yeniden başlatılacaktır!", "SURUCU KURSU", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Ayarların geçerli olması için program yeniden başlatılacaktır!", "SURUCU KURSU", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialog==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
