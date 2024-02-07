namespace EtutTest
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEtut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.cmbxOgretmen = new System.Windows.Forms.ComboBox();
            this.LblOgretmen = new System.Windows.Forms.Label();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbxDers = new System.Windows.Forms.ComboBox();
            this.LblDers = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtEtutId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOgrenci = new System.Windows.Forms.TextBox();
            this.BtnEtutVer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnOgrenciEkle = new System.Windows.Forms.Button();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSinif = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtDersAdi = new System.Windows.Forms.TextBox();
            this.BtnDersEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnFotograf = new System.Windows.Forms.Button();
            this.TxtOgretmenDers = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnOgretmenEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEtut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mskSaat);
            this.groupBox1.Controls.Add(this.cmbxOgretmen);
            this.groupBox1.Controls.Add(this.LblOgretmen);
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.cmbxDers);
            this.groupBox1.Controls.Add(this.LblDers);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnEtut
            // 
            this.BtnEtut.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnEtut.Location = new System.Drawing.Point(165, 238);
            this.BtnEtut.Name = "BtnEtut";
            this.BtnEtut.Size = new System.Drawing.Size(148, 37);
            this.BtnEtut.TabIndex = 1;
            this.BtnEtut.Text = "Etüt Oluştur";
            this.BtnEtut.UseVisualStyleBackColor = false;
            this.BtnEtut.Click += new System.EventHandler(this.BtnEtut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tarih:";
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(115, 198);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(229, 34);
            this.mskSaat.TabIndex = 5;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // cmbxOgretmen
            // 
            this.cmbxOgretmen.FormattingEnabled = true;
            this.cmbxOgretmen.Location = new System.Drawing.Point(115, 90);
            this.cmbxOgretmen.Name = "cmbxOgretmen";
            this.cmbxOgretmen.Size = new System.Drawing.Size(229, 36);
            this.cmbxOgretmen.TabIndex = 4;
            // 
            // LblOgretmen
            // 
            this.LblOgretmen.AutoSize = true;
            this.LblOgretmen.ForeColor = System.Drawing.Color.White;
            this.LblOgretmen.Location = new System.Drawing.Point(2, 90);
            this.LblOgretmen.Name = "LblOgretmen";
            this.LblOgretmen.Size = new System.Drawing.Size(99, 28);
            this.LblOgretmen.TabIndex = 3;
            this.LblOgretmen.Text = "Öğretmen:";
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(115, 145);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(229, 34);
            this.mskTarih.TabIndex = 2;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbxDers
            // 
            this.cmbxDers.FormattingEnabled = true;
            this.cmbxDers.Location = new System.Drawing.Point(115, 31);
            this.cmbxDers.Name = "cmbxDers";
            this.cmbxDers.Size = new System.Drawing.Size(229, 36);
            this.cmbxDers.TabIndex = 1;
            this.cmbxDers.SelectedIndexChanged += new System.EventHandler(this.cmbxDers_SelectedIndexChanged);
            // 
            // LblDers
            // 
            this.LblDers.AutoSize = true;
            this.LblDers.ForeColor = System.Drawing.Color.White;
            this.LblDers.Location = new System.Drawing.Point(39, 39);
            this.LblDers.Name = "LblDers";
            this.LblDers.Size = new System.Drawing.Size(58, 28);
            this.LblDers.TabIndex = 0;
            this.LblDers.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEtutId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtOgrenci);
            this.groupBox2.Controls.Add(this.BtnEtutVer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(384, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 181);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // TxtEtutId
            // 
            this.TxtEtutId.Enabled = false;
            this.TxtEtutId.Location = new System.Drawing.Point(115, 26);
            this.TxtEtutId.Name = "TxtEtutId";
            this.TxtEtutId.Size = new System.Drawing.Size(180, 34);
            this.TxtEtutId.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Etüt Id:";
            // 
            // TxtOgrenci
            // 
            this.TxtOgrenci.Location = new System.Drawing.Point(115, 92);
            this.TxtOgrenci.Name = "TxtOgrenci";
            this.TxtOgrenci.Size = new System.Drawing.Size(180, 34);
            this.TxtOgrenci.TabIndex = 10;
            // 
            // BtnEtutVer
            // 
            this.BtnEtutVer.BackColor = System.Drawing.Color.Violet;
            this.BtnEtutVer.Location = new System.Drawing.Point(131, 130);
            this.BtnEtutVer.Name = "BtnEtutVer";
            this.BtnEtutVer.Size = new System.Drawing.Size(164, 44);
            this.BtnEtutVer.TabIndex = 9;
            this.BtnEtutVer.Text = "Etüt Ver";
            this.BtnEtutVer.UseVisualStyleBackColor = false;
            this.BtnEtutVer.Click += new System.EventHandler(this.BtnEtutVer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(968, 218);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(962, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnFotograf);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(1010, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(243, 288);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BtnOgretmenEkle);
            this.groupBox7.Controls.Add(this.TxtOgretmenDers);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.TxtOgretmenAd);
            this.groupBox7.Controls.Add(this.TxtOgretmenSoyad);
            this.groupBox7.Location = new System.Drawing.Point(992, 293);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(261, 218);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnOgrenciEkle);
            this.groupBox4.Controls.Add(this.mskTelefon);
            this.groupBox4.Controls.Add(this.TxtMail);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.TxtSinif);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.TxtAd);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TxtSoyad);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(715, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 288);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // BtnOgrenciEkle
            // 
            this.BtnOgrenciEkle.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnOgrenciEkle.Location = new System.Drawing.Point(88, 226);
            this.BtnOgrenciEkle.Name = "BtnOgrenciEkle";
            this.BtnOgrenciEkle.Size = new System.Drawing.Size(177, 44);
            this.BtnOgrenciEkle.TabIndex = 26;
            this.BtnOgrenciEkle.Text = "Öğrenci Ekle";
            this.BtnOgrenciEkle.UseVisualStyleBackColor = false;
            this.BtnOgrenciEkle.Click += new System.EventHandler(this.BtnOgrenciEkle_Click);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(88, 143);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(177, 34);
            this.mskTelefon.TabIndex = 25;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(88, 186);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(177, 34);
            this.TxtMail.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 28);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mail:";
            // 
            // TxtSinif
            // 
            this.TxtSinif.Location = new System.Drawing.Point(88, 100);
            this.TxtSinif.Name = "TxtSinif";
            this.TxtSinif.Size = new System.Drawing.Size(177, 34);
            this.TxtSinif.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sınıf:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefon:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(88, 17);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(177, 34);
            this.TxtAd.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ad:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(88, 60);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(177, 34);
            this.TxtSoyad.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Soyad:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtDersAdi);
            this.groupBox5.Controls.Add(this.BtnDersEkle);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(387, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 111);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // TxtDersAdi
            // 
            this.TxtDersAdi.Location = new System.Drawing.Point(107, 21);
            this.TxtDersAdi.Name = "TxtDersAdi";
            this.TxtDersAdi.Size = new System.Drawing.Size(209, 34);
            this.TxtDersAdi.TabIndex = 15;
            // 
            // BtnDersEkle
            // 
            this.BtnDersEkle.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnDersEkle.Location = new System.Drawing.Point(131, 60);
            this.BtnDersEkle.Name = "BtnDersEkle";
            this.BtnDersEkle.Size = new System.Drawing.Size(164, 40);
            this.BtnDersEkle.TabIndex = 14;
            this.BtnDersEkle.Text = "Ders Ekle";
            this.BtnDersEkle.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 28);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ders Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 197);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnFotograf
            // 
            this.BtnFotograf.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnFotograf.Location = new System.Drawing.Point(36, 232);
            this.BtnFotograf.Name = "BtnFotograf";
            this.BtnFotograf.Size = new System.Drawing.Size(186, 44);
            this.BtnFotograf.TabIndex = 27;
            this.BtnFotograf.Text = "Fotoğraf Yükle";
            this.BtnFotograf.UseVisualStyleBackColor = false;
            this.BtnFotograf.Click += new System.EventHandler(this.BtnFotograf_Click);
            // 
            // TxtOgretmenDers
            // 
            this.TxtOgretmenDers.Location = new System.Drawing.Point(85, 103);
            this.TxtOgretmenDers.Name = "TxtOgretmenDers";
            this.TxtOgretmenDers.Size = new System.Drawing.Size(170, 34);
            this.TxtOgretmenDers.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 28);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ders:";
            // 
            // TxtOgretmenAd
            // 
            this.TxtOgretmenAd.Location = new System.Drawing.Point(85, 20);
            this.TxtOgretmenAd.Name = "TxtOgretmenAd";
            this.TxtOgretmenAd.Size = new System.Drawing.Size(170, 34);
            this.TxtOgretmenAd.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 28);
            this.label12.TabIndex = 29;
            this.label12.Text = "Ad:";
            // 
            // TxtOgretmenSoyad
            // 
            this.TxtOgretmenSoyad.Location = new System.Drawing.Point(85, 63);
            this.TxtOgretmenSoyad.Name = "TxtOgretmenSoyad";
            this.TxtOgretmenSoyad.Size = new System.Drawing.Size(170, 34);
            this.TxtOgretmenSoyad.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 28);
            this.label13.TabIndex = 27;
            this.label13.Text = "Soyad:";
            // 
            // BtnOgretmenEkle
            // 
            this.BtnOgretmenEkle.BackColor = System.Drawing.Color.Violet;
            this.BtnOgretmenEkle.Location = new System.Drawing.Point(57, 157);
            this.BtnOgretmenEkle.Name = "BtnOgretmenEkle";
            this.BtnOgretmenEkle.Size = new System.Drawing.Size(186, 44);
            this.BtnOgretmenEkle.TabIndex = 28;
            this.BtnOgretmenEkle.Text = "Öğretmen Ekle\r\n";
            this.BtnOgretmenEkle.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1285, 523);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Etüt Sistemi ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEtut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.ComboBox cmbxOgretmen;
        private System.Windows.Forms.Label LblOgretmen;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.ComboBox cmbxDers;
        private System.Windows.Forms.Label LblDers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnEtutVer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtOgrenci;
        private System.Windows.Forms.TextBox TxtEtutId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnOgrenciEkle;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSinif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnFotograf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnOgretmenEkle;
        private System.Windows.Forms.TextBox TxtOgretmenDers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtOgretmenAd;
        private System.Windows.Forms.TextBox TxtOgretmenSoyad;
        private System.Windows.Forms.TextBox TxtDersAdi;
        private System.Windows.Forms.Button BtnDersEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

