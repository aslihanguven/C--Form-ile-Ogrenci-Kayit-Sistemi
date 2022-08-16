namespace Öğrenci_Kaydetmek
{
    partial class rastgeleKayitOlustur
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
            this.isimler = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sehirler = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // isimler
            // 
            this.isimler.FormattingEnabled = true;
            this.isimler.Items.AddRange(new object[] {
            "Berfin Dilara Karataş",
            "Sedef Tapu",
            "Belginar Kurtulmuş",
            "Merve Korkmaz",
            "Ahmet Demircin",
            "Agil Salimov",
            "Tuğba Kedik",
            "Ezgi Karaca",
            "Ayşe Meriç",
            "Melda Köksallı",
            "Ayça Soner",
            "Senay Dursun",
            "Hatice Elif Arıöz",
            "Elif Hatice Arıöz",
            "İlayda Aladağ",
            "Yunus Emre Çöp",
            "İsmail Kaplan",
            "Metin Gözüyılmaz",
            "Ecem Oymak",
            "Özlem Çayır",
            "İlayda Katkak",
            "Nilay Balcı",
            "Burcu Keskin",
            "Kübra Tırtar",
            "Şeyma Betül Yazıcıoğlu",
            "Esen Karaoğlu",
            "Yasemin Karahan",
            "Beril Sena Gebecik",
            "Serdar Mavi",
            "Zeynep Ece Minare",
            "Nurseli Baru",
            "Hasene Şahin",
            "Merve Yavuz",
            "Mediha Aksüt",
            "Semih Kumaş",
            "Büşra Tekel",
            "Sevgi Yılmaz",
            "Muhammed Akpınar",
            "Emirhan Temizkal",
            "Yıldırım Polat",
            "Ali Celal Kurtlar",
            "Ali Eren Erzincan",
            "Berfu Donoğlu",
            "Burcu Ece İlter",
            "Kübra Ünal",
            "Furkan İhtiyaroğlu",
            "Özgün Üresin",
            "Muammer Çağtay Er",
            "Sami Karabulut",
            "Bilal Sofu",
            "Özge Karasöğüt",
            "Ecem Bakar",
            "Hilal Yurt",
            "Eda Uzunay",
            "Nazlıhan Subaşı",
            "Sinem Akan",
            "Özlem Öztürk",
            "Fatma Doyuk",
            "Merve Deniz Sargınalp",
            "Seha Cavaş",
            "Hasan Hüseyin Arslan",
            "Erkan Dönmez",
            "Hüseyin Saygı"});
            this.isimler.Location = new System.Drawing.Point(12, 23);
            this.isimler.Name = "isimler";
            this.isimler.Size = new System.Drawing.Size(47, 355);
            this.isimler.TabIndex = 0;
          
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rastgele 100 Kayıt Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(139, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(630, 355);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad Soyad";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Öğrenci No";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doğum Tarihi";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Doğum Yeri";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sınıf/Şube";
            this.columnHeader6.Width = 73;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Telefon";
            this.columnHeader7.Width = 93;
            // 
            // sehirler
            // 
            this.sehirler.FormattingEnabled = true;
            this.sehirler.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.sehirler.Location = new System.Drawing.Point(65, 23);
            this.sehirler.Name = "sehirler";
            this.sehirler.Size = new System.Drawing.Size(47, 355);
            this.sehirler.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rastgeleKayitOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.sehirler);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isimler);
            this.Name = "rastgeleKayitOlustur";
            this.Text = "rastgeleKayitOlustur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox isimler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListBox sehirler;
        private System.Windows.Forms.Timer timer1;
    }
}