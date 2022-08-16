namespace Öğrenci_Kaydetmek
{
    partial class Form2
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
            this.sehirler = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.isimler = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hastaliklar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
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
            this.sehirler.Location = new System.Drawing.Point(65, 12);
            this.sehirler.Name = "sehirler";
            this.sehirler.Size = new System.Drawing.Size(47, 355);
            this.sehirler.TabIndex = 7;
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
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(244, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(753, 355);
            this.listView1.TabIndex = 6;
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
            this.columnHeader3.Text = "TC No";
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
            this.columnHeader6.Text = "YAŞ";
            this.columnHeader6.Width = 73;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Telefon";
            this.columnHeader7.Width = 93;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "HASTALIKLARI";
            this.columnHeader8.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Rastgele 100 Kayıt Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.isimler.Location = new System.Drawing.Point(12, 12);
            this.isimler.Name = "isimler";
            this.isimler.Size = new System.Drawing.Size(47, 355);
            this.isimler.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hastaliklar
            // 
            this.hastaliklar.FormattingEnabled = true;
            this.hastaliklar.Items.AddRange(new object[] {
            "Abse",
            "Adale romatizması",
            "Adenit",
            "Ağız yaraları",
            "Ağrılı aybaşı hali",
            "Akciğer kanseri",
            "Akdeniz Ateşi",
            "Akrep sokması",
            "Akut Böbrek İltihabı",
            "Akut Bronşit",
            "Albüminüri",
            "Alerji",
            "Altını ıslatmak",
            "Amipli Dizanteri",
            "Anne sütünün azlığı",
            "Anus kaşıntısı",
            "Apandisit",
            "Arı sokması",
            "Arpacık",
            "Astım",
            "Astigmatlık",
            "Aşırı aybaşı kanaması",
            "Ateş",
            "Ayak ağrıları",
            "Ayak burkulması",
            "Ayak çıbanı",
            "Ayak şişmesi",
            "Ayak terlemesi",
            "Aybaşı düzensizliği",
            "Aybaşı kanaması azlığı",
            "Aybaşı kanaması yokluğu",
            "Aybaşı kanamasının gecikmesi",
            "Bademcik iltihabı",
            "Bağırsak gazı",
            "Bağırsak iltihabı",
            "Bağırsak kanaması",
            "Bağırsak solucanları",
            "Balgam",
            "Basilli Dizanteri",
            "Basur",
            "Baş ağrıları",
            "Baş dönmeleri",
            "Bayılmalar",
            "Bel ağrısı",
            "Bel gevşekliği",
            "Belsoğukluğu",
            "Beyzbol Parmağı",
            "Boğaz ağrısı",
            "Boğaz iltihabı",
            "Boğmaca",
            "Boyun tutulması",
            "Botulizm",
            "Böbrek ağrısı",
            "Böbrek iltihabı",
            "Böbrek kumu",
            "Böbrek taşı",
            "Böcek sokması",
            "Bronşit",
            "Bulantı",
            "Burkulmalar",
            "Burun ahtapotu",
            "Burun akıntısı",
            "Burun kanaması",
            "Burun tıkanıklığı",
            "Cinsel soğukluk",
            "Çarpıntı",
            "Çıbanlar",
            "Çıkıklar",
            "Çiçek",
            "Çift cinsiyetlilik",
            "Çiller",
            "Çocuk felci",
            "Çocuklarda gelişme bozuklukları",
            "Çok uyumak",
            "Çürükler",
            "Dalak hastalıkları",
            "Damar sertliği",
            "Deri iltihabı",
            "Deri kanseri",
            "Deri kuruluğu",
            "Deri lekeleri",
            "Dil büyümesi",
            "Dil felci",
            "Dil iltihabı",
            "Dil ülseri",
            "Diş ağrısı",
            "Diyabet",
            "Dizanteri",
            "Doğum sancıları",
            "Dolama",
            "Donmalar",
            "Dölyolu akıntısı",
            "Dudak çatlaması",
            "Egzama",
            "Ekstrasistol",
            "Enfarktüs",
            "Ensefalopati",
            "Epistaksis",
            "Ergenlik sivilceleri",
            "Ezikler",
            "Fabry",
            "Fazla terlemek",
            "Felç",
            "Ferç kaşıntısı",
            "Fıtık",
            "Fil hastalığı",
            "Fistül",
            "Frengi",
            "Gastrit",
            "Gazlar",
            "Gece körlüğü",
            "Geğirmek",
            "Gevşek penis",
            "Gıda zehirlenmeleri",
            "Göğüste su toplaması",
            "Göz ağrısı",
            "Göz iltihabı",
            "Göz kanlanması",
            "Göz kaşıntısı",
            "Göz sulanması",
            "Göz tiki",
            "Gözbebekleri iltihabı",
            "Gözkapağı iltihabı",
            "Gözkapağı şişliği",
            "Grip",
            "Guatr",
            "Guatr (Yumrulu)",
            "Güneş çarpması",
            "Güneş yanığı",
            "Halsizlik",
            "Hararet",
            "Hava yutma",
            "Havale",
            "Hazımsızlık",
            "Hemofili",
            "Hıçkırık",
            "Hipokrat yüzü",
            "Hipotiroidi",
            "Horlama",
            "Husye torbası şişliği",
            "İdrar torbası iltihabı",
            "İdrar tutamamak",
            "İdrar tutukluğu",
            "İdrar yollarında yanma",
            "İdrar zorluğu",
            "İdrarda kan görülmesi",
            "İdraryolları iltihabı",
            "İktidarsızlık",
            "İncinmek",
            "İshal",
            "İsilik",
            "İsteri",
            "İştahsızlık",
            "Kabakulak",
            "Kabızlık",
            "Kalbin hızlı atması",
            "Kalınbağırsak iltihabı",
            "Kalp ağrısı",
            "Kalp hastalıkları",
            "Kalp romatizması",
            "Kalp yetmezliği",
            "Kan çıbanı",
            "Kan işemek",
            "Kan tükürmek",
            "Kanda kolestrol yüksekliği",
            "Kanser",
            "Kansızlık",
            "Kaonjestij Kalp Hastalığı",
            "Karaciğer hastalıkları",
            "Karaciğer Büyümesi",
            "Karaciğer şişmesi",
            "Karaciğer Yağlanması",
            "Karaciğer yetersizliği",
            "Karın ağrısı",
            "Kaşıntı",
            "Katarakt",
            "Kekemelik",
            "Kellik",
            "Kemik erimesi(Osteoproz)",
            "Kemik iltihabı",
            "Kemik veremi",
            "Kemik yumuşaması",
            "Kırıklar",
            "Kısırlık",
            "Kızamık",
            "Kızamıkçık",
            "Kızıl",
            "Kloroz",
            "Kolera",
            "Kolesterol",
            "Kör çıban",
            "Kramp",
            "Kronik Böbrek İltihabı",
            "Kronik Bronşit",
            "Kuduz",
            "Kulak ağrısı",
            "Kulak akıntısı",
            "Kulak çınlaması",
            "Kulak iltihabı",
            "Kulak kiri",
            "Kulunç ağrısı",
            "Kum sancıları",
            "Kurdeşen",
            "Kuşpalazı",
            "Kuş Gribi",
            "Loğusa humması",
            "Lösemi",
            "Lumbago",
            "Lipom",
            "Lyme",
            "Mastitis",
            "Mastositoz",
            "Morfinizm",
            "Morfinomani",
            "Mide tembelliği",
            "Mide ülseri",
            "Mide yanması",
            "Migren",
            "Miyopluk",
            "Nasır",
            "Narkolepsi",
            "Nefes darlığı",
            "Nefes kokusu",
            "Nefrit",
            "Nevralji",
            "Nevrasteni",
            "Nezle",
            "Nikris hastalığı",
            "Nörofibromatoz",
            "Nöropatik osteoartropati",
            "Onikiparmak bağırsağı ülseri",
            "Ödem",
            "Osteoporoz",
            "Pamukçuk",
            "Paratifo",
            "Paslı dil",
            "Prostat büyümesi",
            "Prostat iltihabı",
            "Prostat kanseri",
            "Panik atak",
            "Parkinasan",
            "Rahim egzaması",
            "Rahim iltihabı",
            "Rahim kanaması",
            "Rahim kanseri",
            "Rahim sarkması",
            "Rahim urları",
            "Rahimde polip",
            "Raşitizm",
            "Romatizma",
            "Saç dökülmesi",
            "Saç ve sakal ağarması",
            "Saçkıran",
            "Saçların kepeklenmesi",
            "Safra kesesi iltihabı",
            "Safra taşları",
            "Sağ Kalp Yetmezliği",
            "Sağırlık",
            "Sakal iltihabı",
            "Salgın menenjit",
            "Saman nezlesi",
            "Sara",
            "Sarılık",
            "Sedef hastalığı",
            "Ses kaybı",
            "Ses kısıklığı",
            "Sık sık idrara gitme",
            "Sıraca",
            "Sıtma",
            "Siğiller",
            "Sinir bozukluğu",
            "Sinirsel ağrılar",
            "Sinirsel hazımsızlık",
            "Sinirsel kusma",
            "Sinüzit",
            "Siroz",
            "Sivilce",
            "Siyatik",
            "Skorbüt",
            "Şarbon",
            "Şeker hastalığı",
            "Şirpençe",
            "Şişmanlık",
            "Tarantula ısırması",
            "Tansiyon düşüklüğü",
            "Tansiyon yüksekliği",
            "Tavukkarası",
            "Taşikardi",
            "Temriye",
            "Tetanoz",
            "Tırnak batması",
            "Tırnak iltihabı",
            "Tifo",
            "Tifüs",
            "Titremek",
            "Uçuk",
            "Ur",
            "Uykusuzluk",
            "Uyurgezerlik",
            "Uyuz",
            "Üremi",
            "Üşümek",
            "ülser",
            "Varis",
            "Varis ülseri",
            "Veba",
            "Verem",
            "Yanıklar",
            "Yaralar",
            "Yılan sokması",
            "Yılancık",
            "Zatülcenp",
            "Zatürree",
            "Zayıflık",
            "Zihin yorgunluğu",
            "Zollinger Ellison Sendromu",
            "Zona"});
            this.hastaliklar.Location = new System.Drawing.Point(118, 12);
            this.hastaliklar.Name = "hastaliklar";
            this.hastaliklar.Size = new System.Drawing.Size(120, 355);
            this.hastaliklar.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 444);
            this.Controls.Add(this.hastaliklar);
            this.Controls.Add(this.sehirler);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isimler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox sehirler;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox isimler;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListBox hastaliklar;
    }
}