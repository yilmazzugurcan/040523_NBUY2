namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFotograf = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.txtDersId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnDersListesi = new System.Windows.Forms.Button();
            this.btnNotListesi = new System.Windows.Forms.Button();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.rbAdaGore = new System.Windows.Forms.RadioButton();
            this.btnLinqEntity = new System.Windows.Forms.Button();
            this.rbAdaGoreTersten = new System.Windows.Forms.RadioButton();
            this.rbIlkUc = new System.Windows.Forms.RadioButton();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.rbAIlebaslayan = new System.Windows.Forms.RadioButton();
            this.rbAIlebiten = new System.Windows.Forms.RadioButton();
            this.rbKayitvarmi = new System.Windows.Forms.RadioButton();
            this.rbToplamSayi = new System.Windows.Forms.RadioButton();
            this.rbSnav1toplam = new System.Windows.Forms.RadioButton();
            this.rbOrtalama = new System.Windows.Forms.RadioButton();
            this.rbEnyksk = new System.Windows.Forms.RadioButton();
            this.rbEnDsk = new System.Windows.Forms.RadioButton();
            this.btnJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(3, 4);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.Size = new System.Drawing.Size(618, 144);
            this.dgvListe.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFotograf);
            this.groupBox1.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox1.Controls.Add(this.txtOgrenciAd);
            this.groupBox1.Controls.Add(this.txtOgrenciId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // txtFotograf
            // 
            this.txtFotograf.Location = new System.Drawing.Point(74, 97);
            this.txtFotograf.Name = "txtFotograf";
            this.txtFotograf.Size = new System.Drawing.Size(100, 20);
            this.txtFotograf.TabIndex = 7;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(74, 71);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtOgrenciSoyad.TabIndex = 6;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(74, 45);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(100, 20);
            this.txtOgrenciAd.TabIndex = 5;
            this.txtOgrenciAd.TextChanged += new System.EventHandler(this.txtOgrenciAd_TextChanged);
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Location = new System.Drawing.Point(74, 18);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.Size = new System.Drawing.Size(100, 20);
            this.txtOgrenciId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fotograf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtDurum);
            this.groupBox2.Controls.Add(this.txtOrtalama);
            this.groupBox2.Controls.Add(this.txtSinav3);
            this.groupBox2.Controls.Add(this.txtSinav2);
            this.groupBox2.Controls.Add(this.txtSinav1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(230, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 212);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notlar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sınav Not Guncelle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(78, 127);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(100, 20);
            this.txtDurum.TabIndex = 9;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(78, 101);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 8;
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(78, 75);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(100, 20);
            this.txtSinav3.TabIndex = 7;
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(78, 49);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(100, 20);
            this.txtSinav2.TabIndex = 6;
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(78, 23);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(100, 20);
            this.txtSinav1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Durum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ortalama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sınav 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sınav 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sınav 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDersAd);
            this.groupBox3.Controls.Add(this.txtDersId);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 78);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ders";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(74, 45);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(100, 20);
            this.txtDersAd.TabIndex = 3;
            // 
            // txtDersId
            // 
            this.txtDersId.Location = new System.Drawing.Point(74, 19);
            this.txtDersId.Name = "txtDersId";
            this.txtDersId.Size = new System.Drawing.Size(100, 20);
            this.txtDersId.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Id";
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.Location = new System.Drawing.Point(451, 166);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(109, 23);
            this.btnOgrenciListele.TabIndex = 4;
            this.btnOgrenciListele.Text = "Öğrenci Listele";
            this.btnOgrenciListele.UseVisualStyleBackColor = true;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(451, 195);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(451, 224);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(451, 253);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(451, 282);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(109, 23);
            this.btnBul.TabIndex = 8;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnDersListesi
            // 
            this.btnDersListesi.Location = new System.Drawing.Point(451, 311);
            this.btnDersListesi.Name = "btnDersListesi";
            this.btnDersListesi.Size = new System.Drawing.Size(109, 23);
            this.btnDersListesi.TabIndex = 9;
            this.btnDersListesi.Text = "Ders Listesi";
            this.btnDersListesi.UseVisualStyleBackColor = true;
            this.btnDersListesi.Click += new System.EventHandler(this.btnDersListesi_Click);
            // 
            // btnNotListesi
            // 
            this.btnNotListesi.Location = new System.Drawing.Point(451, 338);
            this.btnNotListesi.Name = "btnNotListesi";
            this.btnNotListesi.Size = new System.Drawing.Size(109, 23);
            this.btnNotListesi.TabIndex = 10;
            this.btnNotListesi.Text = "Not Listesi";
            this.btnNotListesi.UseVisualStyleBackColor = true;
            this.btnNotListesi.Click += new System.EventHandler(this.btnNotListesi_Click);
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(451, 367);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(109, 23);
            this.btnProcedure.TabIndex = 11;
            this.btnProcedure.Text = "Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // rbAdaGore
            // 
            this.rbAdaGore.AutoSize = true;
            this.rbAdaGore.Location = new System.Drawing.Point(639, 12);
            this.rbAdaGore.Name = "rbAdaGore";
            this.rbAdaGore.Size = new System.Drawing.Size(95, 17);
            this.rbAdaGore.TabIndex = 12;
            this.rbAdaGore.TabStop = true;
            this.rbAdaGore.Text = "Ada göre sırala";
            this.rbAdaGore.UseVisualStyleBackColor = true;
            // 
            // btnLinqEntity
            // 
            this.btnLinqEntity.Location = new System.Drawing.Point(658, 354);
            this.btnLinqEntity.Name = "btnLinqEntity";
            this.btnLinqEntity.Size = new System.Drawing.Size(75, 23);
            this.btnLinqEntity.TabIndex = 13;
            this.btnLinqEntity.Text = "Linq Entity";
            this.btnLinqEntity.UseVisualStyleBackColor = true;
            this.btnLinqEntity.Click += new System.EventHandler(this.btnLinqEntity_Click);
            // 
            // rbAdaGoreTersten
            // 
            this.rbAdaGoreTersten.AutoSize = true;
            this.rbAdaGoreTersten.Location = new System.Drawing.Point(639, 35);
            this.rbAdaGoreTersten.Name = "rbAdaGoreTersten";
            this.rbAdaGoreTersten.Size = new System.Drawing.Size(130, 17);
            this.rbAdaGoreTersten.TabIndex = 14;
            this.rbAdaGoreTersten.TabStop = true;
            this.rbAdaGoreTersten.Text = "Ada göre sırala tersten";
            this.rbAdaGoreTersten.UseVisualStyleBackColor = true;
            // 
            // rbIlkUc
            // 
            this.rbIlkUc.AutoSize = true;
            this.rbIlkUc.Location = new System.Drawing.Point(639, 58);
            this.rbIlkUc.Name = "rbIlkUc";
            this.rbIlkUc.Size = new System.Drawing.Size(45, 17);
            this.rbIlkUc.TabIndex = 15;
            this.rbIlkUc.TabStop = true;
            this.rbIlkUc.Text = "Ilk 3";
            this.rbIlkUc.UseVisualStyleBackColor = true;
            // 
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Location = new System.Drawing.Point(639, 81);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(76, 17);
            this.rbId.TabIndex = 16;
            this.rbId.TabStop = true;
            this.rbId.Text = "ID ye Göre";
            this.rbId.UseVisualStyleBackColor = true;
            this.rbId.CheckedChanged += new System.EventHandler(this.rbId_CheckedChanged);
            // 
            // rbAIlebaslayan
            // 
            this.rbAIlebaslayan.AutoSize = true;
            this.rbAIlebaslayan.Location = new System.Drawing.Point(639, 104);
            this.rbAIlebaslayan.Name = "rbAIlebaslayan";
            this.rbAIlebaslayan.Size = new System.Drawing.Size(93, 17);
            this.rbAIlebaslayan.TabIndex = 17;
            this.rbAIlebaslayan.TabStop = true;
            this.rbAIlebaslayan.Text = "A ile  başlayan";
            this.rbAIlebaslayan.UseVisualStyleBackColor = true;
            // 
            // rbAIlebiten
            // 
            this.rbAIlebiten.AutoSize = true;
            this.rbAIlebiten.Location = new System.Drawing.Point(639, 127);
            this.rbAIlebiten.Name = "rbAIlebiten";
            this.rbAIlebiten.Size = new System.Drawing.Size(74, 17);
            this.rbAIlebiten.TabIndex = 18;
            this.rbAIlebiten.TabStop = true;
            this.rbAIlebiten.Text = "A ile  biten";
            this.rbAIlebiten.UseVisualStyleBackColor = true;
            // 
            // rbKayitvarmi
            // 
            this.rbKayitvarmi.AutoSize = true;
            this.rbKayitvarmi.Location = new System.Drawing.Point(639, 150);
            this.rbKayitvarmi.Name = "rbKayitvarmi";
            this.rbKayitvarmi.Size = new System.Drawing.Size(80, 17);
            this.rbKayitvarmi.TabIndex = 19;
            this.rbKayitvarmi.TabStop = true;
            this.rbKayitvarmi.Text = "Kayıt Var mı";
            this.rbKayitvarmi.UseVisualStyleBackColor = true;
            // 
            // rbToplamSayi
            // 
            this.rbToplamSayi.AutoSize = true;
            this.rbToplamSayi.Location = new System.Drawing.Point(639, 173);
            this.rbToplamSayi.Name = "rbToplamSayi";
            this.rbToplamSayi.Size = new System.Drawing.Size(86, 17);
            this.rbToplamSayi.TabIndex = 20;
            this.rbToplamSayi.TabStop = true;
            this.rbToplamSayi.Text = "Toplam Kayıt";
            this.rbToplamSayi.UseVisualStyleBackColor = true;
            // 
            // rbSnav1toplam
            // 
            this.rbSnav1toplam.AutoSize = true;
            this.rbSnav1toplam.Location = new System.Drawing.Point(639, 195);
            this.rbSnav1toplam.Name = "rbSnav1toplam";
            this.rbSnav1toplam.Size = new System.Drawing.Size(90, 17);
            this.rbSnav1toplam.TabIndex = 21;
            this.rbSnav1toplam.TabStop = true;
            this.rbSnav1toplam.Text = "Sınav Toplam";
            this.rbSnav1toplam.UseVisualStyleBackColor = true;
            // 
            // rbOrtalama
            // 
            this.rbOrtalama.AutoSize = true;
            this.rbOrtalama.Location = new System.Drawing.Point(639, 218);
            this.rbOrtalama.Name = "rbOrtalama";
            this.rbOrtalama.Size = new System.Drawing.Size(67, 17);
            this.rbOrtalama.TabIndex = 22;
            this.rbOrtalama.TabStop = true;
            this.rbOrtalama.Text = "Ortalama";
            this.rbOrtalama.UseVisualStyleBackColor = true;
            // 
            // rbEnyksk
            // 
            this.rbEnyksk.AutoSize = true;
            this.rbEnyksk.Location = new System.Drawing.Point(639, 242);
            this.rbEnyksk.Name = "rbEnyksk";
            this.rbEnyksk.Size = new System.Drawing.Size(71, 17);
            this.rbEnyksk.TabIndex = 23;
            this.rbEnyksk.TabStop = true;
            this.rbEnyksk.Text = "En Yksek";
            this.rbEnyksk.UseVisualStyleBackColor = true;
            // 
            // rbEnDsk
            // 
            this.rbEnDsk.AutoSize = true;
            this.rbEnDsk.Location = new System.Drawing.Point(639, 263);
            this.rbEnDsk.Name = "rbEnDsk";
            this.rbEnDsk.Size = new System.Drawing.Size(58, 17);
            this.rbEnDsk.TabIndex = 24;
            this.rbEnDsk.TabStop = true;
            this.rbEnDsk.Text = "En dsk";
            this.rbEnDsk.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(451, 396);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(109, 23);
            this.btnJoin.TabIndex = 25;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.rbEnDsk);
            this.Controls.Add(this.rbEnyksk);
            this.Controls.Add(this.rbOrtalama);
            this.Controls.Add(this.rbSnav1toplam);
            this.Controls.Add(this.rbToplamSayi);
            this.Controls.Add(this.rbKayitvarmi);
            this.Controls.Add(this.rbAIlebiten);
            this.Controls.Add(this.rbAIlebaslayan);
            this.Controls.Add(this.rbId);
            this.Controls.Add(this.rbIlkUc);
            this.Controls.Add(this.rbAdaGoreTersten);
            this.Controls.Add(this.btnLinqEntity);
            this.Controls.Add(this.rbAdaGore);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.btnNotListesi);
            this.Controls.Add(this.btnDersListesi);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnOgrenciListele);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFotograf;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtOgrenciId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.TextBox txtDersId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnDersListesi;
        private System.Windows.Forms.Button btnNotListesi;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.RadioButton rbAdaGore;
        private System.Windows.Forms.Button btnLinqEntity;
        private System.Windows.Forms.RadioButton rbAdaGoreTersten;
        private System.Windows.Forms.RadioButton rbIlkUc;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.RadioButton rbAIlebaslayan;
        private System.Windows.Forms.RadioButton rbAIlebiten;
        private System.Windows.Forms.RadioButton rbKayitvarmi;
        private System.Windows.Forms.RadioButton rbToplamSayi;
        private System.Windows.Forms.RadioButton rbSnav1toplam;
        private System.Windows.Forms.RadioButton rbOrtalama;
        private System.Windows.Forms.RadioButton rbEnyksk;
        private System.Windows.Forms.RadioButton rbEnDsk;
        private System.Windows.Forms.Button btnJoin;
    }
}

