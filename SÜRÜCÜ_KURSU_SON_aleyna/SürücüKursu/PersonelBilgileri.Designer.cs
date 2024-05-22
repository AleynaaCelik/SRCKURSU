namespace SürücüKursu
{
    partial class PersonelBilgileri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelBilgileri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.p_görev = new System.Windows.Forms.TextBox();
            this.p_eposta = new System.Windows.Forms.TextBox();
            this.p_adres = new System.Windows.Forms.TextBox();
            this.p_telefon = new System.Windows.Forms.TextBox();
            this.p_soyadi = new System.Windows.Forms.TextBox();
            this.p_ad = new System.Windows.Forms.TextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.p_tc_kimlik = new System.Windows.Forms.TextBox();
            this.label105 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 110);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.p_görev);
            this.groupBox9.Controls.Add(this.p_eposta);
            this.groupBox9.Controls.Add(this.p_adres);
            this.groupBox9.Controls.Add(this.p_telefon);
            this.groupBox9.Controls.Add(this.p_soyadi);
            this.groupBox9.Controls.Add(this.p_ad);
            this.groupBox9.Controls.Add(this.label113);
            this.groupBox9.Controls.Add(this.label111);
            this.groupBox9.Controls.Add(this.label110);
            this.groupBox9.Controls.Add(this.label109);
            this.groupBox9.Controls.Add(this.label108);
            this.groupBox9.Controls.Add(this.label107);
            this.groupBox9.Controls.Add(this.label106);
            this.groupBox9.Controls.Add(this.p_tc_kimlik);
            this.groupBox9.Controls.Add(this.label105);
            this.groupBox9.Controls.Add(this.label103);
            this.groupBox9.Controls.Add(this.label102);
            this.groupBox9.Controls.Add(this.label101);
            this.groupBox9.Controls.Add(this.label100);
            this.groupBox9.Controls.Add(this.label99);
            this.groupBox9.Controls.Add(this.label98);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox9.Location = new System.Drawing.Point(3, 128);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(905, 307);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Personel Bilgileri Kayıt";
            // 
            // p_görev
            // 
            this.p_görev.Location = new System.Drawing.Point(101, 282);
            this.p_görev.Name = "p_görev";
            this.p_görev.Size = new System.Drawing.Size(150, 20);
            this.p_görev.TabIndex = 23;
            // 
            // p_eposta
            // 
            this.p_eposta.Location = new System.Drawing.Point(101, 256);
            this.p_eposta.Name = "p_eposta";
            this.p_eposta.Size = new System.Drawing.Size(150, 20);
            this.p_eposta.TabIndex = 21;
            // 
            // p_adres
            // 
            this.p_adres.Location = new System.Drawing.Point(101, 139);
            this.p_adres.MaxLength = 255;
            this.p_adres.Multiline = true;
            this.p_adres.Name = "p_adres";
            this.p_adres.Size = new System.Drawing.Size(252, 111);
            this.p_adres.TabIndex = 20;
            // 
            // p_telefon
            // 
            this.p_telefon.Location = new System.Drawing.Point(101, 109);
            this.p_telefon.MaxLength = 11;
            this.p_telefon.Name = "p_telefon";
            this.p_telefon.Size = new System.Drawing.Size(150, 20);
            this.p_telefon.TabIndex = 19;
            // 
            // p_soyadi
            // 
            this.p_soyadi.Location = new System.Drawing.Point(101, 79);
            this.p_soyadi.MaxLength = 25;
            this.p_soyadi.Name = "p_soyadi";
            this.p_soyadi.Size = new System.Drawing.Size(150, 20);
            this.p_soyadi.TabIndex = 18;
            // 
            // p_ad
            // 
            this.p_ad.Location = new System.Drawing.Point(101, 49);
            this.p_ad.MaxLength = 25;
            this.p_ad.Name = "p_ad";
            this.p_ad.Size = new System.Drawing.Size(150, 20);
            this.p_ad.TabIndex = 17;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.ForeColor = System.Drawing.Color.Black;
            this.label113.Location = new System.Drawing.Point(84, 285);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(11, 13);
            this.label113.TabIndex = 16;
            this.label113.Text = ":";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.ForeColor = System.Drawing.Color.Black;
            this.label111.Location = new System.Drawing.Point(84, 259);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(11, 13);
            this.label111.TabIndex = 14;
            this.label111.Text = ":";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.ForeColor = System.Drawing.Color.Black;
            this.label110.Location = new System.Drawing.Point(84, 188);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(11, 13);
            this.label110.TabIndex = 13;
            this.label110.Text = ":";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.ForeColor = System.Drawing.Color.Black;
            this.label109.Location = new System.Drawing.Point(84, 112);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(11, 13);
            this.label109.TabIndex = 12;
            this.label109.Text = ":";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.ForeColor = System.Drawing.Color.Black;
            this.label108.Location = new System.Drawing.Point(84, 82);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(11, 13);
            this.label108.TabIndex = 11;
            this.label108.Text = ":";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.ForeColor = System.Drawing.Color.Black;
            this.label107.Location = new System.Drawing.Point(84, 52);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(11, 13);
            this.label107.TabIndex = 10;
            this.label107.Text = ":";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.ForeColor = System.Drawing.Color.Black;
            this.label106.Location = new System.Drawing.Point(84, 22);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(11, 13);
            this.label106.TabIndex = 9;
            this.label106.Text = ":";
            // 
            // p_tc_kimlik
            // 
            this.p_tc_kimlik.Location = new System.Drawing.Point(101, 19);
            this.p_tc_kimlik.MaxLength = 11;
            this.p_tc_kimlik.Name = "p_tc_kimlik";
            this.p_tc_kimlik.Size = new System.Drawing.Size(150, 20);
            this.p_tc_kimlik.TabIndex = 8;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.ForeColor = System.Drawing.Color.Black;
            this.label105.Location = new System.Drawing.Point(31, 285);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(48, 13);
            this.label105.TabIndex = 7;
            this.label105.Text = "Görevi ";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.ForeColor = System.Drawing.Color.Black;
            this.label103.Location = new System.Drawing.Point(36, 188);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(39, 13);
            this.label103.TabIndex = 5;
            this.label103.Text = "Adres";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.ForeColor = System.Drawing.Color.Black;
            this.label102.Location = new System.Drawing.Point(24, 259);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(51, 13);
            this.label102.TabIndex = 4;
            this.label102.Text = "E-Posta";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.ForeColor = System.Drawing.Color.Black;
            this.label101.Location = new System.Drawing.Point(25, 112);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(50, 13);
            this.label101.TabIndex = 3;
            this.label101.Text = "Telefon";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.ForeColor = System.Drawing.Color.Black;
            this.label100.Location = new System.Drawing.Point(30, 82);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(45, 13);
            this.label100.TabIndex = 2;
            this.label100.Text = "Soyadi";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.ForeColor = System.Drawing.Color.Black;
            this.label99.Location = new System.Drawing.Point(50, 52);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(25, 13);
            this.label99.TabIndex = 1;
            this.label99.Text = "Adı";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.ForeColor = System.Drawing.Color.Black;
            this.label98.Location = new System.Drawing.Point(7, 22);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(72, 13);
            this.label98.TabIndex = 0;
            this.label98.Text = "T.C. Kimlik ";
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGüncelle.Image = global::SürücüKursu.Properties.Resources.Aha_Soft_Free_3d_Glossy_Interface_Circulation1;
            this.buttonGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGüncelle.Location = new System.Drawing.Point(3, 441);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(112, 40);
            this.buttonGüncelle.TabIndex = 24;
            this.buttonGüncelle.Text = "GÜNCELLE";
            this.buttonGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGüncelle.UseVisualStyleBackColor = true;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.Image = global::SürücüKursu.Properties.Resources.Aha_Soft_Free_3d_Glossy_Interface_Turn_off;
            this.buttonCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCikis.Location = new System.Drawing.Point(831, 441);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(77, 40);
            this.buttonCikis.TabIndex = 26;
            this.buttonCikis.Text = "ÇIKIŞ";
            this.buttonCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click_1);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Image = global::SürücüKursu.Properties.Resources.sil;
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.Location = new System.Drawing.Point(119, 441);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(70, 40);
            this.buttonSil.TabIndex = 25;
            this.buttonSil.Text = "SİL";
            this.buttonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PersonelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(911, 483);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonelBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Bilgileri";
            this.Load += new System.EventHandler(this.PersonelBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox p_görev;
        private System.Windows.Forms.TextBox p_eposta;
        private System.Windows.Forms.TextBox p_adres;
        private System.Windows.Forms.TextBox p_telefon;
        private System.Windows.Forms.TextBox p_soyadi;
        private System.Windows.Forms.TextBox p_ad;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.TextBox p_tc_kimlik;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}