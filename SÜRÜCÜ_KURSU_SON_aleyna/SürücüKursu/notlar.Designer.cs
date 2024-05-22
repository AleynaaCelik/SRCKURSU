namespace SürücüKursu
{
    partial class notlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notlar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.not_ilkyardim = new System.Windows.Forms.TextBox();
            this.not_dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label97 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.not_motor = new System.Windows.Forms.TextBox();
            this.not_trafik = new System.Windows.Forms.TextBox();
            this.not_tc = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 110);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.buttonGüncelle);
            this.groupBox8.Controls.Add(this.buttonCikis);
            this.groupBox8.Controls.Add(this.buttonSil);
            this.groupBox8.Controls.Add(this.not_ilkyardim);
            this.groupBox8.Controls.Add(this.not_dateTimePicker2);
            this.groupBox8.Controls.Add(this.label97);
            this.groupBox8.Controls.Add(this.label96);
            this.groupBox8.Controls.Add(this.label95);
            this.groupBox8.Controls.Add(this.label94);
            this.groupBox8.Controls.Add(this.label93);
            this.groupBox8.Controls.Add(this.label92);
            this.groupBox8.Controls.Add(this.label91);
            this.groupBox8.Controls.Add(this.not_motor);
            this.groupBox8.Controls.Add(this.not_trafik);
            this.groupBox8.Controls.Add(this.not_tc);
            this.groupBox8.Controls.Add(this.label90);
            this.groupBox8.Controls.Add(this.label89);
            this.groupBox8.Controls.Add(this.label88);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox8.Location = new System.Drawing.Point(247, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(503, 259);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Gerekli alanları doldurunuz !!!";
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGüncelle.Image = global::SürücüKursu.Properties.Resources.Aha_Soft_Free_3d_Glossy_Interface_Circulation1;
            this.buttonGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGüncelle.Location = new System.Drawing.Point(113, 214);
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
            this.buttonCikis.Location = new System.Drawing.Point(305, 214);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(77, 40);
            this.buttonCikis.TabIndex = 7;
            this.buttonCikis.Text = "ÇIKIŞ";
            this.buttonCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Image = global::SürücüKursu.Properties.Resources.sil;
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.Location = new System.Drawing.Point(229, 214);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(70, 40);
            this.buttonSil.TabIndex = 6;
            this.buttonSil.Text = "SİL";
            this.buttonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // not_ilkyardim
            // 
            this.not_ilkyardim.Location = new System.Drawing.Point(162, 174);
            this.not_ilkyardim.MaxLength = 3;
            this.not_ilkyardim.Name = "not_ilkyardim";
            this.not_ilkyardim.Size = new System.Drawing.Size(150, 20);
            this.not_ilkyardim.TabIndex = 4;
            // 
            // not_dateTimePicker2
            // 
            this.not_dateTimePicker2.Location = new System.Drawing.Point(163, 60);
            this.not_dateTimePicker2.Name = "not_dateTimePicker2";
            this.not_dateTimePicker2.Size = new System.Drawing.Size(150, 20);
            this.not_dateTimePicker2.TabIndex = 14;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(146, 177);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(11, 13);
            this.label97.TabIndex = 13;
            this.label97.Text = ":";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(146, 140);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(11, 13);
            this.label96.TabIndex = 12;
            this.label96.Text = ":";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(146, 103);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(11, 13);
            this.label95.TabIndex = 11;
            this.label95.Text = ":";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(146, 66);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(11, 13);
            this.label94.TabIndex = 10;
            this.label94.Text = ":";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.ForeColor = System.Drawing.Color.Black;
            this.label93.Location = new System.Drawing.Point(65, 66);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(75, 13);
            this.label93.TabIndex = 9;
            this.label93.Text = "Sınav Tarihi";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.ForeColor = System.Drawing.Color.Black;
            this.label92.Location = new System.Drawing.Point(72, 29);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(68, 13);
            this.label92.TabIndex = 8;
            this.label92.Text = "T.C. Kimlik";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(145, 29);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(11, 13);
            this.label91.TabIndex = 7;
            this.label91.Text = ":";
            // 
            // not_motor
            // 
            this.not_motor.Location = new System.Drawing.Point(162, 137);
            this.not_motor.MaxLength = 3;
            this.not_motor.Name = "not_motor";
            this.not_motor.Size = new System.Drawing.Size(150, 20);
            this.not_motor.TabIndex = 3;
            // 
            // not_trafik
            // 
            this.not_trafik.Location = new System.Drawing.Point(162, 100);
            this.not_trafik.MaxLength = 3;
            this.not_trafik.Name = "not_trafik";
            this.not_trafik.Size = new System.Drawing.Size(150, 20);
            this.not_trafik.TabIndex = 2;
            this.not_trafik.TextChanged += new System.EventHandler(this.not_trafik_TextChanged);
            // 
            // not_tc
            // 
            this.not_tc.Enabled = false;
            this.not_tc.Location = new System.Drawing.Point(162, 26);
            this.not_tc.Name = "not_tc";
            this.not_tc.Size = new System.Drawing.Size(150, 20);
            this.not_tc.TabIndex = 1;
            this.not_tc.TextChanged += new System.EventHandler(this.not_tc_TextChanged);
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.ForeColor = System.Drawing.Color.Black;
            this.label90.Location = new System.Drawing.Point(7, 177);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(133, 13);
            this.label90.TabIndex = 3;
            this.label90.Text = "İlk Yardim Sinavi Notu";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.ForeColor = System.Drawing.Color.Black;
            this.label89.Location = new System.Drawing.Point(31, 140);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(109, 13);
            this.label89.TabIndex = 2;
            this.label89.Text = "Motor Sınavi Notu";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.ForeColor = System.Drawing.Color.Black;
            this.label88.Location = new System.Drawing.Point(29, 103);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(110, 13);
            this.label88.TabIndex = 1;
            this.label88.Text = "Trafik Sınavi Notu";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(3, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 294);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kursiyer Not Girişi";
            // 
            // notlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(911, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "notlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sürücü Adayı Not Bilgisi ve Girişi ";
            this.Load += new System.EventHandler(this.notlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox not_ilkyardim;
        private System.Windows.Forms.DateTimePicker not_dateTimePicker2;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox not_motor;
        private System.Windows.Forms.TextBox not_trafik;
        private System.Windows.Forms.TextBox not_tc;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}