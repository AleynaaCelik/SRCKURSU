namespace SürücüKursu
{
    partial class Odemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odemeler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_borc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.odeme_dateTime = new System.Windows.Forms.DateTimePicker();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.o_tutar = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.o_tc_kimlik = new System.Windows.Forms.TextBox();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 110);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.buttonGüncelle);
            this.groupBox7.Controls.Add(this.buttonCikis);
            this.groupBox7.Controls.Add(this.buttonSil);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox7.Location = new System.Drawing.Point(3, 128);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(905, 292);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ödeme Bilgileriniz Giriniz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.t_borc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label75);
            this.groupBox1.Controls.Add(this.label76);
            this.groupBox1.Controls.Add(this.odeme_dateTime);
            this.groupBox1.Controls.Add(this.label77);
            this.groupBox1.Controls.Add(this.label78);
            this.groupBox1.Controls.Add(this.o_tutar);
            this.groupBox1.Controls.Add(this.label79);
            this.groupBox1.Controls.Add(this.label80);
            this.groupBox1.Controls.Add(this.o_tc_kimlik);
            this.groupBox1.Location = new System.Drawing.Point(259, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 164);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kalan Borç";
            // 
            // t_borc
            // 
            this.t_borc.Location = new System.Drawing.Point(125, 81);
            this.t_borc.MaxLength = 10;
            this.t_borc.Name = "t_borc";
            this.t_borc.Size = new System.Drawing.Size(180, 20);
            this.t_borc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(108, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.ForeColor = System.Drawing.Color.Black;
            this.label75.Location = new System.Drawing.Point(34, 28);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(68, 13);
            this.label75.TabIndex = 1;
            this.label75.Text = "T.C. Kimlik";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.ForeColor = System.Drawing.Color.Black;
            this.label76.Location = new System.Drawing.Point(20, 56);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(82, 13);
            this.label76.TabIndex = 2;
            this.label76.Text = "Ödeme Tarihi";
            // 
            // odeme_dateTime
            // 
            this.odeme_dateTime.Location = new System.Drawing.Point(125, 53);
            this.odeme_dateTime.Name = "odeme_dateTime";
            this.odeme_dateTime.Size = new System.Drawing.Size(180, 20);
            this.odeme_dateTime.TabIndex = 2;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.ForeColor = System.Drawing.Color.Black;
            this.label77.Location = new System.Drawing.Point(19, 112);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(83, 13);
            this.label77.TabIndex = 3;
            this.label77.Text = "Ödeme Tutari";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.ForeColor = System.Drawing.Color.Black;
            this.label78.Location = new System.Drawing.Point(108, 28);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(11, 13);
            this.label78.TabIndex = 4;
            this.label78.Text = ":";
            // 
            // o_tutar
            // 
            this.o_tutar.Location = new System.Drawing.Point(125, 109);
            this.o_tutar.MaxLength = 10;
            this.o_tutar.Name = "o_tutar";
            this.o_tutar.Size = new System.Drawing.Size(180, 20);
            this.o_tutar.TabIndex = 4;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.ForeColor = System.Drawing.Color.Black;
            this.label79.Location = new System.Drawing.Point(108, 56);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(11, 13);
            this.label79.TabIndex = 5;
            this.label79.Text = ":";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.ForeColor = System.Drawing.Color.Black;
            this.label80.Location = new System.Drawing.Point(108, 112);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(11, 13);
            this.label80.TabIndex = 6;
            this.label80.Text = ":";
            // 
            // o_tc_kimlik
            // 
            this.o_tc_kimlik.Enabled = false;
            this.o_tc_kimlik.Location = new System.Drawing.Point(125, 25);
            this.o_tc_kimlik.MaxLength = 11;
            this.o_tc_kimlik.Name = "o_tc_kimlik";
            this.o_tc_kimlik.Size = new System.Drawing.Size(180, 20);
            this.o_tc_kimlik.TabIndex = 1;
            this.o_tc_kimlik.TextChanged += new System.EventHandler(this.o_tc_kimlik_TextChanged);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGüncelle.Image = global::SürücüKursu.Properties.Resources.Aha_Soft_Free_3d_Glossy_Interface_Circulation1;
            this.buttonGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGüncelle.Location = new System.Drawing.Point(296, 189);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(112, 40);
            this.buttonGüncelle.TabIndex = 5;
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
            this.buttonCikis.Location = new System.Drawing.Point(488, 189);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(77, 40);
            this.buttonCikis.TabIndex = 7;
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
            this.buttonSil.Location = new System.Drawing.Point(412, 189);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(70, 40);
            this.buttonSil.TabIndex = 6;
            this.buttonSil.Text = "SİL";
            this.buttonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Odemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(911, 421);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Odemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sürücü Adayi Ödeme Bilgileri";
            this.Load += new System.EventHandler(this.Odemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker odeme_dateTime;
        private System.Windows.Forms.TextBox o_tutar;
        private System.Windows.Forms.TextBox o_tc_kimlik;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_borc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}