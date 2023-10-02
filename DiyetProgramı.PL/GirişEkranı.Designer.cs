namespace DiyetProgramı.PL
{
    partial class GirişEkranı
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            GirisYapBtn = new Button();
            KullaniciAdiTextBox = new TextBox();
            SifreTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            GirisPanel = new Panel();
            KayitOlPanel = new Panel();
            KayitEkraniBtn = new Button();
            label8 = new Label();
            kullaniciSifreTekrariTextBox = new TextBox();
            label7 = new Label();
            kullaniciMailTextBox = new TextBox();
            label6 = new Label();
            kullaniciSifreTextBox = new TextBox();
            label5 = new Label();
            label10 = new Label();
            label4 = new Label();
            label9 = new Label();
            label3 = new Label();
            BoyTextBox = new TextBox();
            isimTextBox = new TextBox();
            yasTextBox = new TextBox();
            soyisimTextBox = new TextBox();
            KiloTextBox = new TextBox();
            button11 = new Button();
            KiyasRaporBtn = new Button();
            GunSonuRaporuBtn = new Button();
            RaporPanel = new Panel();
            CesitLbl2 = new Label();
            CesitLbl1 = new Label();
            KiyasLbl1 = new Label();
            KiyasLbl2 = new Label();
            RaporLbl = new Label();
            AylikRadioBtn = new RadioButton();
            HaftalikRadioBtn = new RadioButton();
            RaporlarDateTimePicker = new DateTimePicker();
            kiyasRaporOgunListBox = new ListBox();
            GunSonuKiyasRaporListBox = new ListBox();
            OgunEkleBtn = new Button();
            YemekComboBox = new ComboBox();
            OgunConboBox = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            OgunEklePanel = new Panel();
            label26 = new Label();
            pictureBox8 = new PictureBox();
            OgunEkleDateTimePicker = new DateTimePicker();
            porsiyonyaztextBox1 = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            YemekGuncellePanel = new Panel();
            label27 = new Label();
            OpenFileDialog = new Button();
            MevcutYemekListBox = new ListBox();
            YemekSilBtn = new Button();
            YemekGuncelleBtn = new Button();
            pictureBox10 = new PictureBox();
            katagorilistcomboBox2 = new ComboBox();
            NewYemekEkleBtn = new Button();
            YemekAdiEktextBox2 = new TextBox();
            KalorimikektextBox3 = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            OgunGuncellePanel = new Panel();
            label15 = new Label();
            pictureBox14 = new PictureBox();
            OgunGuncelleDateTimePicker = new DateTimePicker();
            OgunUpdateDeleteYemekCombobox = new ComboBox();
            label25 = new Label();
            porsiyonYazTextBox = new TextBox();
            label23 = new Label();
            label24 = new Label();
            OgunUpdateDeleteOgunCombobox = new ComboBox();
            Öğün_Sil = new Button();
            OgunUpdateDeleteListBox = new ListBox();
            OgunGetirBtn = new Button();
            Ögün_Güncelle = new Button();
            openFileDialog1 = new OpenFileDialog();
            MenüPanel = new Panel();
            CikisBtn = new Button();
            YardimBtn = new Button();
            HakkimizdeBtn = new Button();
            YemekCesidiBtnnn = new Button();
            KıyasRaporBtnnn = new Button();
            GunSonRaporBtn = new Button();
            OgunBtnnn = new Button();
            YemekBtnnn = new Button();
            ProfilBtnnn = new Button();
            Homebtnnn = new Button();
            kayıtbtnn = new Button();
            Girisbtnn = new Button();
            LogoPanel = new Panel();
            label30 = new Label();
            BaslikPanel = new Panel();
            EkranIsmiLbl = new Label();
            ProfilPanel = new Panel();
            ProfilGuncelleBtn = new Button();
            kilotxtBox = new TextBox();
            YastxtBox = new TextBox();
            boytxtBox = new TextBox();
            SoyadtxtBox = new TextBox();
            Isimtxtbox = new TextBox();
            label31 = new Label();
            GirisPanel.SuspendLayout();
            KayitOlPanel.SuspendLayout();
            RaporPanel.SuspendLayout();
            OgunEklePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            YemekGuncellePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            OgunGuncellePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            MenüPanel.SuspendLayout();
            LogoPanel.SuspendLayout();
            BaslikPanel.SuspendLayout();
            ProfilPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // GirisYapBtn
            // 
            GirisYapBtn.Location = new Point(434, 249);
            GirisYapBtn.Name = "GirisYapBtn";
            GirisYapBtn.Size = new Size(94, 29);
            GirisYapBtn.TabIndex = 3;
            GirisYapBtn.Text = "Giriş Yap";
            GirisYapBtn.UseVisualStyleBackColor = true;
            GirisYapBtn.Click += GirişYapClick;
            // 
            // KullaniciAdiTextBox
            // 
            KullaniciAdiTextBox.Location = new Point(253, 185);
            KullaniciAdiTextBox.MaxLength = 49;
            KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            KullaniciAdiTextBox.Size = new Size(275, 27);
            KullaniciAdiTextBox.TabIndex = 1;
            // 
            // SifreTextBox
            // 
            SifreTextBox.Location = new Point(253, 217);
            SifreTextBox.Name = "SifreTextBox";
            SifreTextBox.PasswordChar = '*';
            SifreTextBox.Size = new Size(275, 27);
            SifreTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 189);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 221);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Şifre";
            // 
            // GirisPanel
            // 
            GirisPanel.Controls.Add(label1);
            GirisPanel.Controls.Add(SifreTextBox);
            GirisPanel.Controls.Add(GirisYapBtn);
            GirisPanel.Controls.Add(label2);
            GirisPanel.Controls.Add(KullaniciAdiTextBox);
            GirisPanel.Dock = DockStyle.Fill;
            GirisPanel.Location = new Point(219, 80);
            GirisPanel.Name = "GirisPanel";
            GirisPanel.Size = new Size(687, 721);
            GirisPanel.TabIndex = 16;
            // 
            // KayitOlPanel
            // 
            KayitOlPanel.Controls.Add(KayitEkraniBtn);
            KayitOlPanel.Controls.Add(label8);
            KayitOlPanel.Controls.Add(kullaniciSifreTekrariTextBox);
            KayitOlPanel.Controls.Add(label7);
            KayitOlPanel.Controls.Add(kullaniciMailTextBox);
            KayitOlPanel.Controls.Add(label6);
            KayitOlPanel.Controls.Add(kullaniciSifreTextBox);
            KayitOlPanel.Controls.Add(label5);
            KayitOlPanel.Controls.Add(label10);
            KayitOlPanel.Controls.Add(label4);
            KayitOlPanel.Controls.Add(label9);
            KayitOlPanel.Controls.Add(label3);
            KayitOlPanel.Controls.Add(BoyTextBox);
            KayitOlPanel.Controls.Add(isimTextBox);
            KayitOlPanel.Controls.Add(yasTextBox);
            KayitOlPanel.Controls.Add(soyisimTextBox);
            KayitOlPanel.Controls.Add(KiloTextBox);
            KayitOlPanel.Dock = DockStyle.Fill;
            KayitOlPanel.Location = new Point(219, 80);
            KayitOlPanel.Name = "KayitOlPanel";
            KayitOlPanel.Size = new Size(687, 721);
            KayitOlPanel.TabIndex = 17;
            // 
            // KayitEkraniBtn
            // 
            KayitEkraniBtn.Location = new Point(439, 421);
            KayitEkraniBtn.Name = "KayitEkraniBtn";
            KayitEkraniBtn.Size = new Size(114, 40);
            KayitEkraniBtn.TabIndex = 43;
            KayitEkraniBtn.Text = "Kayıt Ol";
            KayitEkraniBtn.UseVisualStyleBackColor = true;
            KayitEkraniBtn.Click += KayitOlEkraniClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(128, 220);
            label8.Name = "label8";
            label8.Size = new Size(143, 20);
            label8.TabIndex = 50;
            label8.Text = "Kullanıcı Şifre Tekrar";
            // 
            // kullaniciSifreTekrariTextBox
            // 
            kullaniciSifreTekrariTextBox.Location = new Point(278, 216);
            kullaniciSifreTekrariTextBox.Name = "kullaniciSifreTekrariTextBox";
            kullaniciSifreTekrariTextBox.Size = new Size(275, 27);
            kullaniciSifreTekrariTextBox.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(128, 385);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 48;
            label7.Text = "Kilo";
            // 
            // kullaniciMailTextBox
            // 
            kullaniciMailTextBox.Location = new Point(278, 149);
            kullaniciMailTextBox.MaxLength = 49;
            kullaniciMailTextBox.Name = "kullaniciMailTextBox";
            kullaniciMailTextBox.Size = new Size(275, 27);
            kullaniciMailTextBox.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 356);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 47;
            label6.Text = "Boy";
            // 
            // kullaniciSifreTextBox
            // 
            kullaniciSifreTextBox.Location = new Point(278, 181);
            kullaniciSifreTextBox.Name = "kullaniciSifreTextBox";
            kullaniciSifreTextBox.Size = new Size(275, 27);
            kullaniciSifreTextBox.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 324);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 46;
            label5.Text = "Yaş";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(128, 156);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 37;
            label10.Text = "Kullanıcı Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 295);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 45;
            label4.Text = "Soyisim";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(128, 188);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 38;
            label9.Text = "Kullanıcı Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 259);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 44;
            label3.Text = "İsim";
            // 
            // BoyTextBox
            // 
            BoyTextBox.Location = new Point(278, 349);
            BoyTextBox.MaxLength = 4;
            BoyTextBox.Name = "BoyTextBox";
            BoyTextBox.Size = new Size(275, 27);
            BoyTextBox.TabIndex = 41;
            // 
            // isimTextBox
            // 
            isimTextBox.Location = new Point(278, 252);
            isimTextBox.MaxLength = 29;
            isimTextBox.Name = "isimTextBox";
            isimTextBox.Size = new Size(275, 27);
            isimTextBox.TabIndex = 38;
            // 
            // yasTextBox
            // 
            yasTextBox.Location = new Point(278, 316);
            yasTextBox.MaxLength = 3;
            yasTextBox.Name = "yasTextBox";
            yasTextBox.Size = new Size(275, 27);
            yasTextBox.TabIndex = 40;
            // 
            // soyisimTextBox
            // 
            soyisimTextBox.Location = new Point(278, 284);
            soyisimTextBox.MaxLength = 29;
            soyisimTextBox.Name = "soyisimTextBox";
            soyisimTextBox.Size = new Size(275, 27);
            soyisimTextBox.TabIndex = 39;
            // 
            // KiloTextBox
            // 
            KiloTextBox.Location = new Point(278, 384);
            KiloTextBox.MaxLength = 4;
            KiloTextBox.Name = "KiloTextBox";
            KiloTextBox.Size = new Size(275, 27);
            KiloTextBox.TabIndex = 42;
            // 
            // button11
            // 
            button11.Location = new Point(6, 13);
            button11.Name = "button11";
            button11.Size = new Size(159, 29);
            button11.TabIndex = 29;
            button11.Text = "Yemek Çeşidi Raporu";
            button11.UseVisualStyleBackColor = true;
            button11.Click += YemekCesidiRaporClick;
            // 
            // KiyasRaporBtn
            // 
            KiyasRaporBtn.Location = new Point(2, 13);
            KiyasRaporBtn.Name = "KiyasRaporBtn";
            KiyasRaporBtn.Size = new Size(159, 29);
            KiyasRaporBtn.TabIndex = 28;
            KiyasRaporBtn.Text = "Kıyas Raporları";
            KiyasRaporBtn.UseVisualStyleBackColor = true;
            KiyasRaporBtn.Click += KiyasRaporuClick;
            // 
            // GunSonuRaporuBtn
            // 
            GunSonuRaporuBtn.Location = new Point(3, 11);
            GunSonuRaporuBtn.Name = "GunSonuRaporuBtn";
            GunSonuRaporuBtn.Size = new Size(159, 29);
            GunSonuRaporuBtn.TabIndex = 27;
            GunSonuRaporuBtn.Text = "Gün Sonu Raporu";
            GunSonuRaporuBtn.UseVisualStyleBackColor = true;
            GunSonuRaporuBtn.Click += GunSonuRaporuClick;
            // 
            // RaporPanel
            // 
            RaporPanel.Controls.Add(CesitLbl2);
            RaporPanel.Controls.Add(CesitLbl1);
            RaporPanel.Controls.Add(KiyasLbl1);
            RaporPanel.Controls.Add(KiyasLbl2);
            RaporPanel.Controls.Add(RaporLbl);
            RaporPanel.Controls.Add(AylikRadioBtn);
            RaporPanel.Controls.Add(HaftalikRadioBtn);
            RaporPanel.Controls.Add(RaporlarDateTimePicker);
            RaporPanel.Controls.Add(kiyasRaporOgunListBox);
            RaporPanel.Controls.Add(GunSonuKiyasRaporListBox);
            RaporPanel.Controls.Add(button11);
            RaporPanel.Controls.Add(KiyasRaporBtn);
            RaporPanel.Controls.Add(GunSonuRaporuBtn);
            RaporPanel.Dock = DockStyle.Fill;
            RaporPanel.Location = new Point(219, 80);
            RaporPanel.Name = "RaporPanel";
            RaporPanel.Size = new Size(687, 721);
            RaporPanel.TabIndex = 19;
            // 
            // CesitLbl2
            // 
            CesitLbl2.AutoSize = true;
            CesitLbl2.Location = new Point(7, 401);
            CesitLbl2.Name = "CesitLbl2";
            CesitLbl2.Size = new Size(349, 20);
            CesitLbl2.TabIndex = 53;
            CesitLbl2.Text = "En Çok Yenen Yemeklerin Kalori ve Porsiyon Bilgileri";
            // 
            // CesitLbl1
            // 
            CesitLbl1.AutoSize = true;
            CesitLbl1.Location = new Point(10, 140);
            CesitLbl1.Name = "CesitLbl1";
            CesitLbl1.Size = new Size(209, 20);
            CesitLbl1.TabIndex = 52;
            CesitLbl1.Text = "Yemeğin Öğünlere Göre Kıyası";
            // 
            // KiyasLbl1
            // 
            KiyasLbl1.AutoSize = true;
            KiyasLbl1.Location = new Point(7, 137);
            KiyasLbl1.Name = "KiyasLbl1";
            KiyasLbl1.Size = new Size(227, 20);
            KiyasLbl1.TabIndex = 51;
            KiyasLbl1.Text = "Öğünlerde Alınan Kcal Durumları";
            // 
            // KiyasLbl2
            // 
            KiyasLbl2.AutoSize = true;
            KiyasLbl2.Location = new Point(6, 400);
            KiyasLbl2.Name = "KiyasLbl2";
            KiyasLbl2.Size = new Size(234, 20);
            KiyasLbl2.TabIndex = 50;
            KiyasLbl2.Text = "Yemeklerde Alınan Kcal Durumları";
            // 
            // RaporLbl
            // 
            RaporLbl.AutoSize = true;
            RaporLbl.Location = new Point(7, 137);
            RaporLbl.Name = "RaporLbl";
            RaporLbl.Size = new Size(137, 20);
            RaporLbl.TabIndex = 49;
            RaporLbl.Text = "Gün Sonu Raporları";
            // 
            // AylikRadioBtn
            // 
            AylikRadioBtn.AutoSize = true;
            AylikRadioBtn.Location = new Point(266, 51);
            AylikRadioBtn.Margin = new Padding(3, 4, 3, 4);
            AylikRadioBtn.Name = "AylikRadioBtn";
            AylikRadioBtn.Size = new Size(62, 24);
            AylikRadioBtn.TabIndex = 32;
            AylikRadioBtn.TabStop = true;
            AylikRadioBtn.Text = "Aylık";
            AylikRadioBtn.UseVisualStyleBackColor = true;
            // 
            // HaftalikRadioBtn
            // 
            HaftalikRadioBtn.AutoSize = true;
            HaftalikRadioBtn.Location = new Point(178, 51);
            HaftalikRadioBtn.Margin = new Padding(3, 4, 3, 4);
            HaftalikRadioBtn.Name = "HaftalikRadioBtn";
            HaftalikRadioBtn.Size = new Size(82, 24);
            HaftalikRadioBtn.TabIndex = 31;
            HaftalikRadioBtn.TabStop = true;
            HaftalikRadioBtn.Text = "Haftalık";
            HaftalikRadioBtn.UseVisualStyleBackColor = true;
            // 
            // RaporlarDateTimePicker
            // 
            RaporlarDateTimePicker.Location = new Point(178, 13);
            RaporlarDateTimePicker.Name = "RaporlarDateTimePicker";
            RaporlarDateTimePicker.Size = new Size(150, 27);
            RaporlarDateTimePicker.TabIndex = 30;
            // 
            // kiyasRaporOgunListBox
            // 
            kiyasRaporOgunListBox.FormattingEnabled = true;
            kiyasRaporOgunListBox.ItemHeight = 20;
            kiyasRaporOgunListBox.Location = new Point(6, 431);
            kiyasRaporOgunListBox.Name = "kiyasRaporOgunListBox";
            kiyasRaporOgunListBox.Size = new Size(669, 204);
            kiyasRaporOgunListBox.TabIndex = 33;
            // 
            // GunSonuKiyasRaporListBox
            // 
            GunSonuKiyasRaporListBox.FormattingEnabled = true;
            GunSonuKiyasRaporListBox.ItemHeight = 20;
            GunSonuKiyasRaporListBox.Location = new Point(7, 167);
            GunSonuKiyasRaporListBox.Name = "GunSonuKiyasRaporListBox";
            GunSonuKiyasRaporListBox.Size = new Size(668, 204);
            GunSonuKiyasRaporListBox.TabIndex = 33;
            // 
            // OgunEkleBtn
            // 
            OgunEkleBtn.Location = new Point(291, 459);
            OgunEkleBtn.Name = "OgunEkleBtn";
            OgunEkleBtn.Size = new Size(114, 40);
            OgunEkleBtn.TabIndex = 50;
            OgunEkleBtn.Text = "Öğün Ekle";
            OgunEkleBtn.UseVisualStyleBackColor = true;
            OgunEkleBtn.Click += OgunEkleBtnClick;
            // 
            // YemekComboBox
            // 
            YemekComboBox.FormattingEnabled = true;
            YemekComboBox.Location = new Point(278, 397);
            YemekComboBox.Name = "YemekComboBox";
            YemekComboBox.Size = new Size(140, 28);
            YemekComboBox.TabIndex = 48;
            YemekComboBox.SelectedIndexChanged += YemekComboBox_SelectedIndexChanged;
            // 
            // OgunConboBox
            // 
            OgunConboBox.FormattingEnabled = true;
            OgunConboBox.Location = new Point(122, 397);
            OgunConboBox.Name = "OgunConboBox";
            OgunConboBox.Size = new Size(140, 28);
            OgunConboBox.TabIndex = 47;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(200, 113);
            label11.Name = "label11";
            label11.Size = new Size(87, 46);
            label11.TabIndex = 28;
            label11.Text = "Isim:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(200, 169);
            label12.Name = "label12";
            label12.Size = new Size(118, 46);
            label12.TabIndex = 29;
            label12.Text = "Soyad:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(200, 219);
            label13.Name = "label13";
            label13.Size = new Size(82, 46);
            label13.TabIndex = 30;
            label13.Text = "Boy:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(202, 324);
            label14.Name = "label14";
            label14.Size = new Size(83, 46);
            label14.TabIndex = 31;
            label14.Text = "Kilo:";
            // 
            // OgunEklePanel
            // 
            OgunEklePanel.Controls.Add(label26);
            OgunEklePanel.Controls.Add(pictureBox8);
            OgunEklePanel.Controls.Add(OgunEkleDateTimePicker);
            OgunEklePanel.Controls.Add(porsiyonyaztextBox1);
            OgunEklePanel.Controls.Add(label22);
            OgunEklePanel.Controls.Add(label21);
            OgunEklePanel.Controls.Add(label20);
            OgunEklePanel.Controls.Add(OgunConboBox);
            OgunEklePanel.Controls.Add(YemekComboBox);
            OgunEklePanel.Controls.Add(OgunEkleBtn);
            OgunEklePanel.Dock = DockStyle.Fill;
            OgunEklePanel.Location = new Point(219, 80);
            OgunEklePanel.Name = "OgunEklePanel";
            OgunEklePanel.Size = new Size(687, 721);
            OgunEklePanel.TabIndex = 18;
            OgunEklePanel.Paint += panel3_Paint;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(262, 304);
            label26.Name = "label26";
            label26.Size = new Size(175, 20);
            label26.TabIndex = 54;
            label26.Text = "Ekleme Yapacağınız Tarih";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Yemek;
            pictureBox8.Location = new Point(232, 99);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(222, 172);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 52;
            pictureBox8.TabStop = false;
            // 
            // OgunEkleDateTimePicker
            // 
            OgunEkleDateTimePicker.Location = new Point(262, 331);
            OgunEkleDateTimePicker.Name = "OgunEkleDateTimePicker";
            OgunEkleDateTimePicker.Size = new Size(170, 27);
            OgunEkleDateTimePicker.TabIndex = 46;
            // 
            // porsiyonyaztextBox1
            // 
            porsiyonyaztextBox1.Location = new Point(434, 397);
            porsiyonyaztextBox1.MaxLength = 3;
            porsiyonyaztextBox1.Name = "porsiyonyaztextBox1";
            porsiyonyaztextBox1.Size = new Size(140, 27);
            porsiyonyaztextBox1.TabIndex = 49;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(434, 371);
            label22.Name = "label22";
            label22.Size = new Size(90, 20);
            label22.TabIndex = 43;
            label22.Text = "Porsiyon Yaz";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(278, 371);
            label21.Name = "label21";
            label21.Size = new Size(79, 20);
            label21.TabIndex = 42;
            label21.Text = "Yemek Seç";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(122, 371);
            label20.Name = "label20";
            label20.Size = new Size(72, 20);
            label20.TabIndex = 21;
            label20.Text = "Öğün Seç";
            // 
            // YemekGuncellePanel
            // 
            YemekGuncellePanel.Controls.Add(label27);
            YemekGuncellePanel.Controls.Add(OpenFileDialog);
            YemekGuncellePanel.Controls.Add(MevcutYemekListBox);
            YemekGuncellePanel.Controls.Add(YemekSilBtn);
            YemekGuncellePanel.Controls.Add(YemekGuncelleBtn);
            YemekGuncellePanel.Controls.Add(pictureBox10);
            YemekGuncellePanel.Controls.Add(katagorilistcomboBox2);
            YemekGuncellePanel.Controls.Add(NewYemekEkleBtn);
            YemekGuncellePanel.Controls.Add(YemekAdiEktextBox2);
            YemekGuncellePanel.Controls.Add(KalorimikektextBox3);
            YemekGuncellePanel.Controls.Add(label19);
            YemekGuncellePanel.Controls.Add(label18);
            YemekGuncellePanel.Controls.Add(label17);
            YemekGuncellePanel.Controls.Add(label16);
            YemekGuncellePanel.Dock = DockStyle.Fill;
            YemekGuncellePanel.Location = new Point(219, 80);
            YemekGuncellePanel.Name = "YemekGuncellePanel";
            YemekGuncellePanel.Size = new Size(687, 721);
            YemekGuncellePanel.TabIndex = 20;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(399, 111);
            label27.Name = "label27";
            label27.Size = new Size(191, 20);
            label27.TabIndex = 62;
            label27.Text = "Mevcut Yüklenmiş Yemekler";
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.Location = new Point(217, 420);
            OpenFileDialog.Margin = new Padding(3, 4, 3, 4);
            OpenFileDialog.Name = "OpenFileDialog";
            OpenFileDialog.Size = new Size(126, 31);
            OpenFileDialog.TabIndex = 25;
            OpenFileDialog.Text = "Resim Ekle";
            OpenFileDialog.UseVisualStyleBackColor = true;
            OpenFileDialog.Click += OpenFileDialog_Click;
            // 
            // MevcutYemekListBox
            // 
            MevcutYemekListBox.FormattingEnabled = true;
            MevcutYemekListBox.ItemHeight = 20;
            MevcutYemekListBox.Location = new Point(399, 144);
            MevcutYemekListBox.Name = "MevcutYemekListBox";
            MevcutYemekListBox.Size = new Size(220, 344);
            MevcutYemekListBox.TabIndex = 60;
            MevcutYemekListBox.SelectedIndexChanged += MevcutYemekListBox_SelectedIndexChanged;
            // 
            // YemekSilBtn
            // 
            YemekSilBtn.Location = new Point(286, 471);
            YemekSilBtn.Name = "YemekSilBtn";
            YemekSilBtn.Size = new Size(94, 29);
            YemekSilBtn.TabIndex = 28;
            YemekSilBtn.Text = "Sil";
            YemekSilBtn.UseVisualStyleBackColor = true;
            YemekSilBtn.Click += YemekSilBtn_Click;
            // 
            // YemekGuncelleBtn
            // 
            YemekGuncelleBtn.Location = new Point(183, 471);
            YemekGuncelleBtn.Name = "YemekGuncelleBtn";
            YemekGuncelleBtn.Size = new Size(94, 29);
            YemekGuncelleBtn.TabIndex = 27;
            YemekGuncelleBtn.Text = "Güncelle";
            YemekGuncelleBtn.UseVisualStyleBackColor = true;
            YemekGuncelleBtn.Click += YemekGuncelleBtn_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Yemek;
            pictureBox10.Location = new Point(119, 145);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(224, 147);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 56;
            pictureBox10.TabStop = false;
            // 
            // katagorilistcomboBox2
            // 
            katagorilistcomboBox2.FormattingEnabled = true;
            katagorilistcomboBox2.Location = new Point(217, 384);
            katagorilistcomboBox2.Name = "katagorilistcomboBox2";
            katagorilistcomboBox2.Size = new Size(125, 28);
            katagorilistcomboBox2.TabIndex = 24;
            // 
            // NewYemekEkleBtn
            // 
            NewYemekEkleBtn.Location = new Point(83, 471);
            NewYemekEkleBtn.Name = "NewYemekEkleBtn";
            NewYemekEkleBtn.Size = new Size(94, 29);
            NewYemekEkleBtn.TabIndex = 26;
            NewYemekEkleBtn.Text = "Ekle";
            NewYemekEkleBtn.UseVisualStyleBackColor = true;
            NewYemekEkleBtn.Click += YemekEkleClick;
            // 
            // YemekAdiEktextBox2
            // 
            YemekAdiEktextBox2.Location = new Point(217, 313);
            YemekAdiEktextBox2.MaxLength = 24;
            YemekAdiEktextBox2.Name = "YemekAdiEktextBox2";
            YemekAdiEktextBox2.Size = new Size(125, 27);
            YemekAdiEktextBox2.TabIndex = 22;
            // 
            // KalorimikektextBox3
            // 
            KalorimikektextBox3.Location = new Point(217, 347);
            KalorimikektextBox3.MaxLength = 4;
            KalorimikektextBox3.Name = "KalorimikektextBox3";
            KalorimikektextBox3.Size = new Size(125, 27);
            KalorimikektextBox3.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(114, 427);
            label19.Name = "label19";
            label19.Size = new Size(52, 20);
            label19.TabIndex = 32;
            label19.Text = "Resim:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(115, 392);
            label18.Name = "label18";
            label18.Size = new Size(69, 20);
            label18.TabIndex = 31;
            label18.Text = "Kategori:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(115, 353);
            label17.Name = "label17";
            label17.Size = new Size(51, 20);
            label17.TabIndex = 30;
            label17.Text = "Kalori:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(115, 317);
            label16.Name = "label16";
            label16.Size = new Size(82, 20);
            label16.TabIndex = 29;
            label16.Text = "Yemek Adı:";
            // 
            // OgunGuncellePanel
            // 
            OgunGuncellePanel.Controls.Add(label15);
            OgunGuncellePanel.Controls.Add(pictureBox14);
            OgunGuncellePanel.Controls.Add(OgunGuncelleDateTimePicker);
            OgunGuncellePanel.Controls.Add(OgunUpdateDeleteYemekCombobox);
            OgunGuncellePanel.Controls.Add(label25);
            OgunGuncellePanel.Controls.Add(porsiyonYazTextBox);
            OgunGuncellePanel.Controls.Add(label23);
            OgunGuncellePanel.Controls.Add(label24);
            OgunGuncellePanel.Controls.Add(OgunUpdateDeleteOgunCombobox);
            OgunGuncellePanel.Controls.Add(Öğün_Sil);
            OgunGuncellePanel.Controls.Add(OgunUpdateDeleteListBox);
            OgunGuncellePanel.Controls.Add(OgunGetirBtn);
            OgunGuncellePanel.Controls.Add(Ögün_Güncelle);
            OgunGuncellePanel.Dock = DockStyle.Fill;
            OgunGuncellePanel.Location = new Point(219, 80);
            OgunGuncellePanel.Name = "OgunGuncellePanel";
            OgunGuncellePanel.Size = new Size(687, 721);
            OgunGuncellePanel.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(357, 67);
            label15.Name = "label15";
            label15.Size = new Size(114, 20);
            label15.TabIndex = 59;
            label15.Text = "Mevcut Öğünler";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.Yemek;
            pictureBox14.Location = new Point(94, 103);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(224, 147);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 58;
            pictureBox14.TabStop = false;
            // 
            // OgunGuncelleDateTimePicker
            // 
            OgunGuncelleDateTimePicker.Location = new Point(357, 461);
            OgunGuncelleDateTimePicker.Name = "OgunGuncelleDateTimePicker";
            OgunGuncelleDateTimePicker.Size = new Size(220, 27);
            OgunGuncelleDateTimePicker.TabIndex = 52;
            // 
            // OgunUpdateDeleteYemekCombobox
            // 
            OgunUpdateDeleteYemekCombobox.FormattingEnabled = true;
            OgunUpdateDeleteYemekCombobox.Location = new Point(119, 405);
            OgunUpdateDeleteYemekCombobox.Name = "OgunUpdateDeleteYemekCombobox";
            OgunUpdateDeleteYemekCombobox.Size = new Size(173, 28);
            OgunUpdateDeleteYemekCombobox.TabIndex = 49;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(119, 383);
            label25.Name = "label25";
            label25.Size = new Size(79, 20);
            label25.TabIndex = 50;
            label25.Text = "Yemek Seç";
            // 
            // porsiyonYazTextBox
            // 
            porsiyonYazTextBox.Location = new Point(119, 349);
            porsiyonYazTextBox.MaxLength = 3;
            porsiyonYazTextBox.Name = "porsiyonYazTextBox";
            porsiyonYazTextBox.Size = new Size(173, 27);
            porsiyonYazTextBox.TabIndex = 48;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(119, 325);
            label23.Name = "label23";
            label23.Size = new Size(90, 20);
            label23.TabIndex = 48;
            label23.Text = "Porsiyon Yaz";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(119, 263);
            label24.Name = "label24";
            label24.Size = new Size(72, 20);
            label24.TabIndex = 45;
            label24.Text = "Öğün Seç";
            // 
            // OgunUpdateDeleteOgunCombobox
            // 
            OgunUpdateDeleteOgunCombobox.FormattingEnabled = true;
            OgunUpdateDeleteOgunCombobox.Location = new Point(119, 285);
            OgunUpdateDeleteOgunCombobox.Name = "OgunUpdateDeleteOgunCombobox";
            OgunUpdateDeleteOgunCombobox.Size = new Size(173, 28);
            OgunUpdateDeleteOgunCombobox.TabIndex = 47;
            // 
            // Öğün_Sil
            // 
            Öğün_Sil.AutoSize = true;
            Öğün_Sil.Location = new Point(208, 449);
            Öğün_Sil.Name = "Öğün_Sil";
            Öğün_Sil.Size = new Size(127, 40);
            Öğün_Sil.TabIndex = 51;
            Öğün_Sil.Text = "Öğün Sil";
            Öğün_Sil.UseVisualStyleBackColor = true;
            Öğün_Sil.Click += Öğün_Sil_Click;
            // 
            // OgunUpdateDeleteListBox
            // 
            OgunUpdateDeleteListBox.FormattingEnabled = true;
            OgunUpdateDeleteListBox.ItemHeight = 20;
            OgunUpdateDeleteListBox.Location = new Point(357, 103);
            OgunUpdateDeleteListBox.Name = "OgunUpdateDeleteListBox";
            OgunUpdateDeleteListBox.Size = new Size(220, 344);
            OgunUpdateDeleteListBox.TabIndex = 0;
            OgunUpdateDeleteListBox.SelectedIndexChanged += OgunUpdateDeleteListBoxSelectedIndexChanged;
            // 
            // OgunGetirBtn
            // 
            OgunGetirBtn.AutoSize = true;
            OgunGetirBtn.Location = new Point(401, 504);
            OgunGetirBtn.Name = "OgunGetirBtn";
            OgunGetirBtn.Size = new Size(127, 40);
            OgunGetirBtn.TabIndex = 53;
            OgunGetirBtn.Text = "Öğün Getir";
            OgunGetirBtn.UseVisualStyleBackColor = true;
            OgunGetirBtn.Click += Öğün_Getir_Click;
            // 
            // Ögün_Güncelle
            // 
            Ögün_Güncelle.AutoSize = true;
            Ögün_Güncelle.Location = new Point(77, 448);
            Ögün_Güncelle.Name = "Ögün_Güncelle";
            Ögün_Güncelle.Size = new Size(133, 40);
            Ögün_Güncelle.TabIndex = 50;
            Ögün_Güncelle.Text = "Öğün Güncelle";
            Ögün_Güncelle.UseVisualStyleBackColor = true;
            Ögün_Güncelle.Click += Ögün_Güncelle_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MenüPanel
            // 
            MenüPanel.BackColor = SystemColors.ButtonShadow;
            MenüPanel.Controls.Add(CikisBtn);
            MenüPanel.Controls.Add(YardimBtn);
            MenüPanel.Controls.Add(HakkimizdeBtn);
            MenüPanel.Controls.Add(YemekCesidiBtnnn);
            MenüPanel.Controls.Add(KıyasRaporBtnnn);
            MenüPanel.Controls.Add(GunSonRaporBtn);
            MenüPanel.Controls.Add(OgunBtnnn);
            MenüPanel.Controls.Add(YemekBtnnn);
            MenüPanel.Controls.Add(ProfilBtnnn);
            MenüPanel.Controls.Add(Homebtnnn);
            MenüPanel.Controls.Add(kayıtbtnn);
            MenüPanel.Controls.Add(Girisbtnn);
            MenüPanel.Controls.Add(LogoPanel);
            MenüPanel.Dock = DockStyle.Left;
            MenüPanel.Location = new Point(0, 0);
            MenüPanel.Name = "MenüPanel";
            MenüPanel.Size = new Size(219, 801);
            MenüPanel.TabIndex = 22;
            // 
            // CikisBtn
            // 
            CikisBtn.BackColor = SystemColors.ButtonShadow;
            CikisBtn.Dock = DockStyle.Top;
            CikisBtn.FlatAppearance.BorderSize = 0;
            CikisBtn.FlatStyle = FlatStyle.Flat;
            CikisBtn.ForeColor = Color.White;
            CikisBtn.Image = Properties.Resources.icons8_exit_50;
            CikisBtn.ImageAlign = ContentAlignment.BottomLeft;
            CikisBtn.Location = new Point(0, 872);
            CikisBtn.Name = "CikisBtn";
            CikisBtn.Padding = new Padding(11, 0, 0, 0);
            CikisBtn.Size = new Size(219, 72);
            CikisBtn.TabIndex = 19;
            CikisBtn.Text = "Çıkış";
            CikisBtn.TextAlign = ContentAlignment.MiddleLeft;
            CikisBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CikisBtn.UseVisualStyleBackColor = false;
            CikisBtn.Click += CikisBtn_Click;
            // 
            // YardimBtn
            // 
            YardimBtn.BackColor = SystemColors.ButtonShadow;
            YardimBtn.Dock = DockStyle.Top;
            YardimBtn.FlatAppearance.BorderSize = 0;
            YardimBtn.FlatStyle = FlatStyle.Flat;
            YardimBtn.ForeColor = Color.White;
            YardimBtn.Image = Properties.Resources.icons8_help_50;
            YardimBtn.ImageAlign = ContentAlignment.BottomLeft;
            YardimBtn.Location = new Point(0, 800);
            YardimBtn.Name = "YardimBtn";
            YardimBtn.Padding = new Padding(11, 0, 0, 0);
            YardimBtn.Size = new Size(219, 72);
            YardimBtn.TabIndex = 20;
            YardimBtn.Text = "Yardım";
            YardimBtn.TextAlign = ContentAlignment.MiddleLeft;
            YardimBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            YardimBtn.UseVisualStyleBackColor = false;
            YardimBtn.Click += YardimBtn_Click;
            // 
            // HakkimizdeBtn
            // 
            HakkimizdeBtn.BackColor = SystemColors.ButtonShadow;
            HakkimizdeBtn.Dock = DockStyle.Top;
            HakkimizdeBtn.FlatAppearance.BorderSize = 0;
            HakkimizdeBtn.FlatStyle = FlatStyle.Flat;
            HakkimizdeBtn.ForeColor = Color.White;
            HakkimizdeBtn.Image = Properties.Resources.icons8_about_50;
            HakkimizdeBtn.ImageAlign = ContentAlignment.BottomLeft;
            HakkimizdeBtn.Location = new Point(0, 728);
            HakkimizdeBtn.Name = "HakkimizdeBtn";
            HakkimizdeBtn.Padding = new Padding(11, 0, 0, 0);
            HakkimizdeBtn.Size = new Size(219, 72);
            HakkimizdeBtn.TabIndex = 18;
            HakkimizdeBtn.Text = "Hakkımızda";
            HakkimizdeBtn.TextAlign = ContentAlignment.MiddleLeft;
            HakkimizdeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            HakkimizdeBtn.UseVisualStyleBackColor = false;
            HakkimizdeBtn.Click += HakkimizdeBtn_Click;
            // 
            // YemekCesidiBtnnn
            // 
            YemekCesidiBtnnn.BackColor = SystemColors.ButtonShadow;
            YemekCesidiBtnnn.Dock = DockStyle.Top;
            YemekCesidiBtnnn.Enabled = false;
            YemekCesidiBtnnn.FlatAppearance.BorderSize = 0;
            YemekCesidiBtnnn.FlatStyle = FlatStyle.Flat;
            YemekCesidiBtnnn.ForeColor = Color.White;
            YemekCesidiBtnnn.Image = Properties.Resources.icons8_multiple_options_64;
            YemekCesidiBtnnn.ImageAlign = ContentAlignment.BottomLeft;
            YemekCesidiBtnnn.Location = new Point(0, 656);
            YemekCesidiBtnnn.Name = "YemekCesidiBtnnn";
            YemekCesidiBtnnn.Padding = new Padding(11, 0, 0, 0);
            YemekCesidiBtnnn.Size = new Size(219, 72);
            YemekCesidiBtnnn.TabIndex = 14;
            YemekCesidiBtnnn.Text = "Yemek Çeşidi Raporları";
            YemekCesidiBtnnn.TextAlign = ContentAlignment.MiddleLeft;
            YemekCesidiBtnnn.TextImageRelation = TextImageRelation.ImageBeforeText;
            YemekCesidiBtnnn.UseVisualStyleBackColor = false;
            YemekCesidiBtnnn.Click += YemekCesidiBtnnn_Click;
            // 
            // KıyasRaporBtnnn
            // 
            KıyasRaporBtnnn.BackColor = SystemColors.ButtonShadow;
            KıyasRaporBtnnn.Dock = DockStyle.Top;
            KıyasRaporBtnnn.Enabled = false;
            KıyasRaporBtnnn.FlatAppearance.BorderSize = 0;
            KıyasRaporBtnnn.FlatStyle = FlatStyle.Flat;
            KıyasRaporBtnnn.ForeColor = Color.White;
            KıyasRaporBtnnn.Image = Properties.Resources.icons8_comparison_50;
            KıyasRaporBtnnn.ImageAlign = ContentAlignment.BottomLeft;
            KıyasRaporBtnnn.Location = new Point(0, 584);
            KıyasRaporBtnnn.Name = "KıyasRaporBtnnn";
            KıyasRaporBtnnn.Padding = new Padding(11, 0, 0, 0);
            KıyasRaporBtnnn.Size = new Size(219, 72);
            KıyasRaporBtnnn.TabIndex = 13;
            KıyasRaporBtnnn.Text = "Kıyas Raporları";
            KıyasRaporBtnnn.TextAlign = ContentAlignment.MiddleLeft;
            KıyasRaporBtnnn.TextImageRelation = TextImageRelation.ImageBeforeText;
            KıyasRaporBtnnn.UseVisualStyleBackColor = false;
            KıyasRaporBtnnn.Click += KıyasRaporBtnnn_Click;
            // 
            // GunSonRaporBtn
            // 
            GunSonRaporBtn.BackColor = SystemColors.ButtonShadow;
            GunSonRaporBtn.Dock = DockStyle.Top;
            GunSonRaporBtn.Enabled = false;
            GunSonRaporBtn.FlatAppearance.BorderSize = 0;
            GunSonRaporBtn.FlatStyle = FlatStyle.Flat;
            GunSonRaporBtn.ForeColor = Color.White;
            GunSonRaporBtn.Image = Properties.Resources.icons8_daily_50;
            GunSonRaporBtn.ImageAlign = ContentAlignment.BottomLeft;
            GunSonRaporBtn.Location = new Point(0, 512);
            GunSonRaporBtn.Name = "GunSonRaporBtn";
            GunSonRaporBtn.Padding = new Padding(11, 0, 0, 0);
            GunSonRaporBtn.Size = new Size(219, 72);
            GunSonRaporBtn.TabIndex = 12;
            GunSonRaporBtn.Text = "Gün Sonu Raporları";
            GunSonRaporBtn.TextAlign = ContentAlignment.MiddleLeft;
            GunSonRaporBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            GunSonRaporBtn.UseVisualStyleBackColor = false;
            GunSonRaporBtn.Click += GunSonRaporBtn_Click;
            // 
            // OgunBtnnn
            // 
            OgunBtnnn.BackColor = SystemColors.ButtonShadow;
            OgunBtnnn.Dock = DockStyle.Top;
            OgunBtnnn.Enabled = false;
            OgunBtnnn.FlatAppearance.BorderSize = 0;
            OgunBtnnn.FlatStyle = FlatStyle.Flat;
            OgunBtnnn.ForeColor = Color.White;
            OgunBtnnn.Image = Properties.Resources.icons8_daytime_50;
            OgunBtnnn.ImageAlign = ContentAlignment.BottomLeft;
            OgunBtnnn.Location = new Point(0, 440);
            OgunBtnnn.Name = "OgunBtnnn";
            OgunBtnnn.Padding = new Padding(11, 0, 0, 0);
            OgunBtnnn.Size = new Size(219, 72);
            OgunBtnnn.TabIndex = 11;
            OgunBtnnn.Text = "Öğün Ayarları";
            OgunBtnnn.TextAlign = ContentAlignment.MiddleLeft;
            OgunBtnnn.TextImageRelation = TextImageRelation.ImageBeforeText;
            OgunBtnnn.UseVisualStyleBackColor = false;
            OgunBtnnn.Click += OgunBtnnn_Click;
            // 
            // YemekBtnnn
            // 
            YemekBtnnn.BackColor = SystemColors.ButtonShadow;
            YemekBtnnn.Dock = DockStyle.Top;
            YemekBtnnn.Enabled = false;
            YemekBtnnn.FlatAppearance.BorderSize = 0;
            YemekBtnnn.FlatStyle = FlatStyle.Flat;
            YemekBtnnn.ForeColor = Color.White;
            YemekBtnnn.Image = Properties.Resources.icons8_meal_50;
            YemekBtnnn.ImageAlign = ContentAlignment.BottomLeft;
            YemekBtnnn.Location = new Point(0, 368);
            YemekBtnnn.Name = "YemekBtnnn";
            YemekBtnnn.Padding = new Padding(11, 0, 0, 0);
            YemekBtnnn.Size = new Size(219, 72);
            YemekBtnnn.TabIndex = 10;
            YemekBtnnn.Text = "Yemek Ayarları";
            YemekBtnnn.TextAlign = ContentAlignment.MiddleLeft;
            YemekBtnnn.TextImageRelation = TextImageRelation.ImageBeforeText;
            YemekBtnnn.UseVisualStyleBackColor = false;
            YemekBtnnn.Click += YemekBtnnn_Click;
            // 
            // ProfilBtnnn
            // 
            ProfilBtnnn.BackColor = SystemColors.ButtonShadow;
            ProfilBtnnn.Dock = DockStyle.Top;
            ProfilBtnnn.Enabled = false;
            ProfilBtnnn.FlatAppearance.BorderSize = 0;
            ProfilBtnnn.FlatStyle = FlatStyle.Flat;
            ProfilBtnnn.ForeColor = Color.White;
            ProfilBtnnn.Image = Properties.Resources.icons8_account_50;
            ProfilBtnnn.ImageAlign = ContentAlignment.BottomLeft;
            ProfilBtnnn.Location = new Point(0, 296);
            ProfilBtnnn.Name = "ProfilBtnnn";
            ProfilBtnnn.Padding = new Padding(11, 0, 0, 0);
            ProfilBtnnn.Size = new Size(219, 72);
            ProfilBtnnn.TabIndex = 15;
            ProfilBtnnn.Text = "Profil Bilgileri";
            ProfilBtnnn.TextAlign = ContentAlignment.MiddleLeft;
            ProfilBtnnn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ProfilBtnnn.UseVisualStyleBackColor = false;
            ProfilBtnnn.Click += ProfilBtnnn_Click;
            // 
            // Homebtnnn
            // 
            Homebtnnn.BackColor = SystemColors.ButtonShadow;
            Homebtnnn.Dock = DockStyle.Top;
            Homebtnnn.Enabled = false;
            Homebtnnn.FlatAppearance.BorderSize = 0;
            Homebtnnn.FlatStyle = FlatStyle.Flat;
            Homebtnnn.ForeColor = Color.White;
            Homebtnnn.Image = Properties.Resources.icons8_home_50;
            Homebtnnn.ImageAlign = ContentAlignment.BottomLeft;
            Homebtnnn.Location = new Point(0, 224);
            Homebtnnn.Name = "Homebtnnn";
            Homebtnnn.Padding = new Padding(11, 0, 0, 0);
            Homebtnnn.Size = new Size(219, 72);
            Homebtnnn.TabIndex = 16;
            Homebtnnn.Text = "Anasayfa";
            Homebtnnn.TextAlign = ContentAlignment.MiddleLeft;
            Homebtnnn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Homebtnnn.UseVisualStyleBackColor = false;
            Homebtnnn.Click += Homebtnnn_Click;
            // 
            // kayıtbtnn
            // 
            kayıtbtnn.BackColor = SystemColors.ButtonShadow;
            kayıtbtnn.Dock = DockStyle.Top;
            kayıtbtnn.FlatAppearance.BorderSize = 0;
            kayıtbtnn.FlatStyle = FlatStyle.Flat;
            kayıtbtnn.ForeColor = Color.White;
            kayıtbtnn.Image = Properties.Resources.icons8_sign_up_50;
            kayıtbtnn.ImageAlign = ContentAlignment.BottomLeft;
            kayıtbtnn.Location = new Point(0, 152);
            kayıtbtnn.Name = "kayıtbtnn";
            kayıtbtnn.Padding = new Padding(11, 0, 0, 0);
            kayıtbtnn.Size = new Size(219, 72);
            kayıtbtnn.TabIndex = 9;
            kayıtbtnn.Text = "Kayıt Ol";
            kayıtbtnn.TextAlign = ContentAlignment.MiddleLeft;
            kayıtbtnn.TextImageRelation = TextImageRelation.ImageBeforeText;
            kayıtbtnn.UseVisualStyleBackColor = false;
            kayıtbtnn.Click += kayıtbtnn_Click;
            // 
            // Girisbtnn
            // 
            Girisbtnn.BackColor = SystemColors.ButtonShadow;
            Girisbtnn.Dock = DockStyle.Top;
            Girisbtnn.FlatAppearance.BorderSize = 0;
            Girisbtnn.FlatStyle = FlatStyle.Flat;
            Girisbtnn.ForeColor = Color.White;
            Girisbtnn.Image = Properties.Resources.icons8_login_50__1_;
            Girisbtnn.ImageAlign = ContentAlignment.BottomLeft;
            Girisbtnn.Location = new Point(0, 80);
            Girisbtnn.Name = "Girisbtnn";
            Girisbtnn.Padding = new Padding(11, 0, 0, 0);
            Girisbtnn.Size = new Size(219, 72);
            Girisbtnn.TabIndex = 8;
            Girisbtnn.Text = "Giris Yap";
            Girisbtnn.TextAlign = ContentAlignment.MiddleLeft;
            Girisbtnn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Girisbtnn.UseVisualStyleBackColor = false;
            Girisbtnn.Click += Girisbtnn_Click;
            // 
            // LogoPanel
            // 
            LogoPanel.BackColor = SystemColors.ControlDarkDark;
            LogoPanel.Controls.Add(label30);
            LogoPanel.Dock = DockStyle.Top;
            LogoPanel.Location = new Point(0, 0);
            LogoPanel.Name = "LogoPanel";
            LogoPanel.Size = new Size(219, 80);
            LogoPanel.TabIndex = 0;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(29, 25);
            label30.Name = "label30";
            label30.Size = new Size(181, 29);
            label30.TabIndex = 1;
            label30.Text = "Sağlıklı Yaşam";
            // 
            // BaslikPanel
            // 
            BaslikPanel.BackColor = SystemColors.InactiveCaption;
            BaslikPanel.Controls.Add(EkranIsmiLbl);
            BaslikPanel.Dock = DockStyle.Top;
            BaslikPanel.Location = new Point(219, 0);
            BaslikPanel.Name = "BaslikPanel";
            BaslikPanel.Size = new Size(687, 80);
            BaslikPanel.TabIndex = 23;
            // 
            // EkranIsmiLbl
            // 
            EkranIsmiLbl.AutoSize = true;
            EkranIsmiLbl.Dock = DockStyle.Left;
            EkranIsmiLbl.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            EkranIsmiLbl.Location = new Point(0, 0);
            EkranIsmiLbl.Name = "EkranIsmiLbl";
            EkranIsmiLbl.Size = new Size(128, 39);
            EkranIsmiLbl.TabIndex = 0;
            EkranIsmiLbl.Text = "label29";
            // 
            // ProfilPanel
            // 
            ProfilPanel.Controls.Add(ProfilGuncelleBtn);
            ProfilPanel.Controls.Add(kilotxtBox);
            ProfilPanel.Controls.Add(YastxtBox);
            ProfilPanel.Controls.Add(boytxtBox);
            ProfilPanel.Controls.Add(SoyadtxtBox);
            ProfilPanel.Controls.Add(Isimtxtbox);
            ProfilPanel.Controls.Add(label11);
            ProfilPanel.Controls.Add(label12);
            ProfilPanel.Controls.Add(label31);
            ProfilPanel.Controls.Add(label13);
            ProfilPanel.Controls.Add(label14);
            ProfilPanel.Dock = DockStyle.Fill;
            ProfilPanel.Location = new Point(219, 80);
            ProfilPanel.Name = "ProfilPanel";
            ProfilPanel.Size = new Size(687, 721);
            ProfilPanel.TabIndex = 57;
            // 
            // ProfilGuncelleBtn
            // 
            ProfilGuncelleBtn.Location = new Point(266, 400);
            ProfilGuncelleBtn.Margin = new Padding(3, 4, 3, 4);
            ProfilGuncelleBtn.Name = "ProfilGuncelleBtn";
            ProfilGuncelleBtn.Size = new Size(86, 31);
            ProfilGuncelleBtn.TabIndex = 46;
            ProfilGuncelleBtn.Text = "Güncelle";
            ProfilGuncelleBtn.UseVisualStyleBackColor = true;
            ProfilGuncelleBtn.Click += ProfilGuncelleBtn_Click;
            // 
            // kilotxtBox
            // 
            kilotxtBox.Location = new Point(320, 343);
            kilotxtBox.Margin = new Padding(3, 4, 3, 4);
            kilotxtBox.Name = "kilotxtBox";
            kilotxtBox.Size = new Size(114, 27);
            kilotxtBox.TabIndex = 44;
            // 
            // YastxtBox
            // 
            YastxtBox.Location = new Point(318, 293);
            YastxtBox.Margin = new Padding(3, 4, 3, 4);
            YastxtBox.MaxLength = 3;
            YastxtBox.Name = "YastxtBox";
            YastxtBox.Size = new Size(114, 27);
            YastxtBox.TabIndex = 43;
            // 
            // boytxtBox
            // 
            boytxtBox.Location = new Point(318, 239);
            boytxtBox.Margin = new Padding(3, 4, 3, 4);
            boytxtBox.MaxLength = 6;
            boytxtBox.Name = "boytxtBox";
            boytxtBox.Size = new Size(114, 27);
            boytxtBox.TabIndex = 42;
            // 
            // SoyadtxtBox
            // 
            SoyadtxtBox.Location = new Point(318, 189);
            SoyadtxtBox.Margin = new Padding(3, 4, 3, 4);
            SoyadtxtBox.MaxLength = 29;
            SoyadtxtBox.Name = "SoyadtxtBox";
            SoyadtxtBox.Size = new Size(114, 27);
            SoyadtxtBox.TabIndex = 41;
            // 
            // Isimtxtbox
            // 
            Isimtxtbox.Location = new Point(320, 132);
            Isimtxtbox.Margin = new Padding(3, 4, 3, 4);
            Isimtxtbox.MaxLength = 29;
            Isimtxtbox.Name = "Isimtxtbox";
            Isimtxtbox.Size = new Size(114, 27);
            Isimtxtbox.TabIndex = 40;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(200, 273);
            label31.Name = "label31";
            label31.Size = new Size(74, 46);
            label31.TabIndex = 30;
            label31.Text = "Yaş:";
            // 
            // GirişEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 801);
            Controls.Add(GirisPanel);
            Controls.Add(ProfilPanel);
            Controls.Add(RaporPanel);
            Controls.Add(YemekGuncellePanel);
            Controls.Add(OgunEklePanel);
            Controls.Add(OgunGuncellePanel);
            Controls.Add(KayitOlPanel);
            Controls.Add(BaslikPanel);
            Controls.Add(MenüPanel);
            Name = "GirişEkranı";
            Text = "GirişEkranı";
            Load += GirişEkranı_Load;
            GirisPanel.ResumeLayout(false);
            GirisPanel.PerformLayout();
            KayitOlPanel.ResumeLayout(false);
            KayitOlPanel.PerformLayout();
            RaporPanel.ResumeLayout(false);
            RaporPanel.PerformLayout();
            OgunEklePanel.ResumeLayout(false);
            OgunEklePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            YemekGuncellePanel.ResumeLayout(false);
            YemekGuncellePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            OgunGuncellePanel.ResumeLayout(false);
            OgunGuncellePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            MenüPanel.ResumeLayout(false);
            LogoPanel.ResumeLayout(false);
            LogoPanel.PerformLayout();
            BaslikPanel.ResumeLayout(false);
            BaslikPanel.PerformLayout();
            ProfilPanel.ResumeLayout(false);
            ProfilPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button GirisYapBtn;
        private TextBox KullaniciAdiTextBox;
        private TextBox SifreTextBox;
        private Label label1;
        private Label label2;
        private Panel GirisPanel;
        private Panel KayitOlPanel;
        private Button KayitEkraniBtn;
        private Label label8;
        private TextBox kullaniciSifreTekrariTextBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox isimTextBox;
        private TextBox soyisimTextBox;
        private TextBox KiloTextBox;
        private TextBox yasTextBox;
        private TextBox BoyTextBox;
        private Label label9;
        private Label label10;
        private TextBox kullaniciSifreTextBox;
        private TextBox kullaniciMailTextBox;
        private Button button11;
        private Button KiyasRaporBtn;
        private Button GunSonuRaporuBtn;
        private Panel RaporPanel;
        private Button OgunEkleBtn;
        private ComboBox YemekComboBox;
        private ComboBox OgunConboBox;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Panel OgunEklePanel;
        private Panel YemekGuncellePanel;
        private Label label16;
        private TextBox YemekAdiEktextBox2;
        private TextBox KalorimikektextBox3;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label20;
        private Label label21;
        private Button NewYemekEkleBtn;
        private ComboBox katagorilistcomboBox2;
        private Label label22;
        private TextBox porsiyonyaztextBox1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Panel OgunGuncellePanel;
        private ListBox OgunUpdateDeleteListBox;
        private Button Öğün_Sil;
        private Button Ögün_Güncelle;
        private ListBox GunSonuKiyasRaporListBox;
        private TextBox porsiyonYazTextBox;
        private Label label23;
        private Label label24;
        private ComboBox OgunUpdateDeleteOgunCombobox;
        private ComboBox OgunUpdateDeleteYemekCombobox;
        private Label label25;
        private DateTimePicker RaporlarDateTimePicker;
        private DateTimePicker OgunEkleDateTimePicker;
        private RadioButton AylikRadioBtn;
        private RadioButton HaftalikRadioBtn;
        private ListBox kiyasRaporOgunListBox;
        private DateTimePicker OgunGuncelleDateTimePicker;
        private Label label26;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
        private ListBox MevcutYemekListBox;
        private Button YemekSilBtn;
        private Button YemekGuncelleBtn;
        private PictureBox pictureBox14;
        private Button OpenFileDialog;
        private OpenFileDialog openFileDialog1;
        private Panel MenüPanel;
        private Panel LogoPanel;
        private Button YemekCesidiBtnnn;
        private Button KıyasRaporBtnnn;
        private Button GunSonRaporBtn;
        private Button OgunBtnnn;
        private Button YemekBtnnn;
        private Button kayıtbtnn;
        private Button Girisbtnn;
        private Panel BaslikPanel;
        private Label label30;
        private Label EkranIsmiLbl;
        private Button ProfilBtnnn;
        private Panel ProfilPanel;
        private Button Homebtnnn;
        private Label KiyasLbl2;
        private Label RaporLbl;
        private Label CesitLbl2;
        private Label CesitLbl1;
        private Label KiyasLbl1;
        private Label label27;
        private Button HakkimizdeBtn;
        private Button OgunGetirBtn;
        private Button CikisBtn;
        private Button YardimBtn;
        private Label label15;
        private Button ProfilGuncelleBtn;
        private TextBox kilotxtBox;
        private TextBox boytxtBox;
        private TextBox SoyadtxtBox;
        private TextBox Isimtxtbox;
        private TextBox YastxtBox;
        private Label label31;
    }
}