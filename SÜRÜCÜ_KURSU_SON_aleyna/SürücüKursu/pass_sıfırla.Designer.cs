namespace SürücüKursu
{
    partial class pass_sıfırla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pass_sıfırla));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kapat = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.y_tekrar = new System.Windows.Forms.TextBox();
            this.y_sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.s_yenile = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.p_eposta = new System.Windows.Forms.TextBox();
            this.p_number = new System.Windows.Forms.TextBox();
            this.p_tc = new System.Windows.Forms.TextBox();
            this.p_soyadi = new System.Windows.Forms.TextBox();
            this.p_adi = new System.Windows.Forms.TextBox();
            this.k_adi = new System.Windows.Forms.TextBox();
            this.e_posta = new System.Windows.Forms.Label();
            this.per_number = new System.Windows.Forms.Label();
            this.tc_kimlik = new System.Windows.Forms.Label();
            this.per_soy = new System.Windows.Forms.Label();
            this.per_adi = new System.Windows.Forms.Label();
            this.kul_adi = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kapat);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.s_yenile);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.p_eposta);
            this.groupBox1.Controls.Add(this.p_number);
            this.groupBox1.Controls.Add(this.p_tc);
            this.groupBox1.Controls.Add(this.p_soyadi);
            this.groupBox1.Controls.Add(this.p_adi);
            this.groupBox1.Controls.Add(this.k_adi);
            this.groupBox1.Controls.Add(this.e_posta);
            this.groupBox1.Controls.Add(this.per_number);
            this.groupBox1.Controls.Add(this.tc_kimlik);
            this.groupBox1.Controls.Add(this.per_soy);
            this.groupBox1.Controls.Add(this.per_adi);
            this.groupBox1.Controls.Add(this.kul_adi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgilerinizi Giriniz !!!";
            // 
            // kapat
            // 
            this.kapat.Enabled = false;
            this.kapat.ImageKey = "kapat.png";
            this.kapat.ImageList = this.ımageList1;
            this.kapat.Location = new System.Drawing.Point(247, 281);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(35, 33);
            this.kapat.TabIndex = 10;
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ResetButton1.png");
            this.ımageList1.Images.SetKeyName(1, "kapat.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.y_tekrar);
            this.groupBox2.Controls.Add(this.y_sifre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // y_tekrar
            // 
            this.y_tekrar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.y_tekrar.ForeColor = System.Drawing.Color.White;
            this.y_tekrar.Location = new System.Drawing.Point(119, 43);
            this.y_tekrar.MaxLength = 8;
            this.y_tekrar.Name = "y_tekrar";
            this.y_tekrar.Size = new System.Drawing.Size(139, 20);
            this.y_tekrar.TabIndex = 8;
            this.y_tekrar.UseSystemPasswordChar = true;
            this.y_tekrar.TextChanged += new System.EventHandler(this.y_tekrar_TextChanged);
            // 
            // y_sifre
            // 
            this.y_sifre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.y_sifre.ForeColor = System.Drawing.Color.White;
            this.y_sifre.Location = new System.Drawing.Point(119, 13);
            this.y_sifre.MaxLength = 8;
            this.y_sifre.Name = "y_sifre";
            this.y_sifre.Size = new System.Drawing.Size(139, 20);
            this.y_sifre.TabIndex = 7;
            this.y_sifre.UseSystemPasswordChar = true;
            this.y_sifre.TextChanged += new System.EventHandler(this.y_sifre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tekrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yeni Şifreniz";
            // 
            // s_yenile
            // 
            this.s_yenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.s_yenile.ImageKey = "ResetButton1.png";
            this.s_yenile.ImageList = this.ımageList1;
            this.s_yenile.Location = new System.Drawing.Point(70, 280);
            this.s_yenile.Name = "s_yenile";
            this.s_yenile.Size = new System.Drawing.Size(140, 34);
            this.s_yenile.TabIndex = 9;
            this.s_yenile.Text = "Şifremi Yenile !!!";
            this.s_yenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.s_yenile.UseVisualStyleBackColor = true;
            this.s_yenile.Click += new System.EventHandler(this.s_yenile_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = ":";
            // 
            // p_eposta
            // 
            this.p_eposta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.p_eposta.Location = new System.Drawing.Point(123, 180);
            this.p_eposta.MaxLength = 30;
            this.p_eposta.Name = "p_eposta";
            this.p_eposta.Size = new System.Drawing.Size(139, 20);
            this.p_eposta.TabIndex = 6;
            this.p_eposta.TextChanged += new System.EventHandler(this.p_eposta_TextChanged);
            // 
            // p_number
            // 
            this.p_number.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.p_number.Location = new System.Drawing.Point(123, 150);
            this.p_number.MaxLength = 9;
            this.p_number.Name = "p_number";
            this.p_number.Size = new System.Drawing.Size(139, 20);
            this.p_number.TabIndex = 5;
            this.p_number.TextChanged += new System.EventHandler(this.p_number_TextChanged);
            // 
            // p_tc
            // 
            this.p_tc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.p_tc.Location = new System.Drawing.Point(123, 120);
            this.p_tc.MaxLength = 11;
            this.p_tc.Name = "p_tc";
            this.p_tc.Size = new System.Drawing.Size(139, 20);
            this.p_tc.TabIndex = 4;
            this.p_tc.TextChanged += new System.EventHandler(this.p_tc_TextChanged);
            // 
            // p_soyadi
            // 
            this.p_soyadi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.p_soyadi.Location = new System.Drawing.Point(123, 90);
            this.p_soyadi.MaxLength = 25;
            this.p_soyadi.Name = "p_soyadi";
            this.p_soyadi.Size = new System.Drawing.Size(139, 20);
            this.p_soyadi.TabIndex = 3;
            this.p_soyadi.TextChanged += new System.EventHandler(this.p_soyadi_TextChanged);
            // 
            // p_adi
            // 
            this.p_adi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.p_adi.Location = new System.Drawing.Point(123, 60);
            this.p_adi.MaxLength = 25;
            this.p_adi.Name = "p_adi";
            this.p_adi.Size = new System.Drawing.Size(139, 20);
            this.p_adi.TabIndex = 2;
            this.p_adi.TextChanged += new System.EventHandler(this.p_adi_TextChanged);
            // 
            // k_adi
            // 
            this.k_adi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.k_adi.Enabled = false;
            this.k_adi.Location = new System.Drawing.Point(123, 30);
            this.k_adi.MaxLength = 25;
            this.k_adi.Name = "k_adi";
            this.k_adi.Size = new System.Drawing.Size(139, 20);
            this.k_adi.TabIndex = 1;
            this.k_adi.TextChanged += new System.EventHandler(this.k_adi_TextChanged);
            // 
            // e_posta
            // 
            this.e_posta.AutoSize = true;
            this.e_posta.Location = new System.Drawing.Point(6, 183);
            this.e_posta.Name = "e_posta";
            this.e_posta.Size = new System.Drawing.Size(97, 13);
            this.e_posta.TabIndex = 6;
            this.e_posta.Text = "E - Posta adresi";
            // 
            // per_number
            // 
            this.per_number.AutoSize = true;
            this.per_number.Location = new System.Drawing.Point(1, 153);
            this.per_number.Name = "per_number";
            this.per_number.Size = new System.Drawing.Size(103, 13);
            this.per_number.TabIndex = 5;
            this.per_number.Text = "Personel Number";
            // 
            // tc_kimlik
            // 
            this.tc_kimlik.AutoSize = true;
            this.tc_kimlik.Location = new System.Drawing.Point(44, 123);
            this.tc_kimlik.Name = "tc_kimlik";
            this.tc_kimlik.Size = new System.Drawing.Size(60, 13);
            this.tc_kimlik.TabIndex = 4;
            this.tc_kimlik.Text = "TC Kimlik";
            // 
            // per_soy
            // 
            this.per_soy.AutoSize = true;
            this.per_soy.Location = new System.Drawing.Point(8, 93);
            this.per_soy.Name = "per_soy";
            this.per_soy.Size = new System.Drawing.Size(96, 13);
            this.per_soy.TabIndex = 3;
            this.per_soy.Text = "Personel soyadi";
            // 
            // per_adi
            // 
            this.per_adi.AutoSize = true;
            this.per_adi.Location = new System.Drawing.Point(27, 63);
            this.per_adi.Name = "per_adi";
            this.per_adi.Size = new System.Drawing.Size(77, 13);
            this.per_adi.TabIndex = 2;
            this.per_adi.Text = "Personel adi";
            // 
            // kul_adi
            // 
            this.kul_adi.AutoSize = true;
            this.kul_adi.Location = new System.Drawing.Point(28, 33);
            this.kul_adi.Name = "kul_adi";
            this.kul_adi.Size = new System.Drawing.Size(76, 13);
            this.kul_adi.TabIndex = 1;
            this.kul_adi.Text = "Kullanici adi";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pass_sıfırla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 340);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pass_sıfırla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Sıfırlama !!!";
            this.Load += new System.EventHandler(this.pass_sıfırla_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label per_number;
        private System.Windows.Forms.Label tc_kimlik;
        private System.Windows.Forms.Label per_soy;
        private System.Windows.Forms.Label per_adi;
        private System.Windows.Forms.Label kul_adi;
        private System.Windows.Forms.TextBox p_eposta;
        private System.Windows.Forms.TextBox p_number;
        private System.Windows.Forms.TextBox p_tc;
        private System.Windows.Forms.TextBox p_soyadi;
        private System.Windows.Forms.TextBox p_adi;
        private System.Windows.Forms.TextBox k_adi;
        private System.Windows.Forms.Label e_posta;
        private System.Windows.Forms.Button s_yenile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox y_tekrar;
        private System.Windows.Forms.TextBox y_sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kapat;
    }
}