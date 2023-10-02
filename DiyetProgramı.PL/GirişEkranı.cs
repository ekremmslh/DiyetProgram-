using DiyetProgramı.BLL.Concrete;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Abstract;
using DiyetProgramı.Entities.Concrete;
using DiyetProgramı.Entities.Enum;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DiyetProgramı.PL
{
    public partial class GirişEkranı : Form
    {

        private int UserId;
        private KullaniciManager kullaniciManager;
        private OgunManager ogunManager;
        private YemekManager yemekManager;
        private List<Yemek> yemekListesi;
        private List<Ogun> ogunListesi;
        private string secilenResimYolu;
        private Kullanici kullanici;
        public GirişEkranı()
        {
            InitializeComponent();
            kullaniciManager = new KullaniciManager(new KullaniciRepo());
            ogunListesi = new List<Ogun>();
            yemekListesi = new List<Yemek>();
            OgunEkleDateTimePicker.MaxDate = DateTime.Now;
            RaporlarDateTimePicker.MaxDate = DateTime.Now;
            OgunGuncelleDateTimePicker.MaxDate = DateTime.Now;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            CikisBtn.Visible = false;
            YardimBtn.Visible = false;
            this.Text = "Kalori Takip Programı";
            EkranIsmiLbl.Text = "Giriş Yap";
        }

        private void GirişEkranı_Load(object sender, EventArgs e)
        {

            KayitOlPanel.Visible = false;
            OgunEklePanel.Visible = false;
            RaporPanel.Visible = false;
            YemekGuncellePanel.Visible = false;
            OgunGuncellePanel.Visible = false;

            var kategoriler = Enum.GetNames(typeof(YemekKategorileri));
            foreach (var item in kategoriler)
            {
                katagorilistcomboBox2.Items.Add(item);
            }

            var ogunIsimleri = Enum.GetNames(typeof(OgunIsmi));
            // OgunComboBox.DataSource = ogunIsimleri;
            foreach (var item in ogunIsimleri)
            {
                OgunConboBox.Items.Add(item);

            }
        }

        private void GirişYapClick(object sender, EventArgs e)
        {
            string kullaniciAdi = KullaniciAdiTextBox.Text;
            string sifre = SifreTextBox.Text;
            string termpSitring = string.Empty;
            var tempInt = kullaniciManager.UserLogin(kullaniciAdi, sifre);
            if (tempInt != -1)
            {
                UserId = tempInt;
                MessageBox.Show("giriş başarılı");
                GirisPanel.Visible = false;
                OgunEklePanel.Visible = true;
                yemekManager = new YemekManager(new YemekRepo(UserId));
                ogunManager = new OgunManager(new OgunRepo(UserId));
                yemekListesi = yemekManager.GetAll();
                yemekListesi.ForEach(x => YemekComboBox.Items.Add(x.YemekAdi));
                kayıtbtnn.Visible = false;
                Girisbtnn.Visible = false;
                Homebtnnn.Enabled = true;
                ProfilBtnnn.Enabled = true;
                YemekBtnnn.Enabled = true;
                OgunBtnnn.Enabled = true;
                GunSonRaporBtn.Enabled = true;
                KıyasRaporBtnnn.Enabled = true;
                YemekCesidiBtnnn.Enabled = true;
                CikisBtn.Visible = true;
                YardimBtn.Visible = true;
                EkranIsmiLbl.Text = "Anasayfa";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
                {
                    termpSitring += "Lütfen tüm alanları doldurun.";
                    return;
                }
                if (termpSitring == string.Empty)
                {
                    termpSitring += "kullanici adi veya sifre hatasi";
                }
                MessageBox.Show(termpSitring);
            }
        }

        private void KayitOlEkraniClick(object sender, EventArgs e)
        {
            KayitOlPanel.BringToFront();

            string kullaniciMail = kullaniciMailTextBox.Text.Trim();
            string kullaniciSifre = kullaniciSifreTextBox.Text.Trim();
            string kullaniciSifreTekrari = kullaniciSifreTekrariTextBox.Text.Trim();
            string isim = isimTextBox.Text;
            string soyisim = soyisimTextBox.Text;
            bool resultYas = int.TryParse(yasTextBox.Text, out var yas);
            bool resutBoy = int.TryParse(BoyTextBox.Text, out var boy);
            bool resultKilo = decimal.TryParse(KiloTextBox.Text, out var kilo);

            var termpString = string.Empty;
            if (!kullaniciManager.ValidUser(kullaniciMail) || !kullaniciManager.ValidMail(kullaniciMail))
            {
                termpString += "Kullanıcı mail hatalı\r\n";
            }
            if (string.IsNullOrWhiteSpace(kullaniciSifre) || string.IsNullOrWhiteSpace(kullaniciMail) || string.IsNullOrWhiteSpace(kullaniciSifreTekrari) || string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(soyisim))
            {
                termpString += "Lütfen tüm alanları doldurun.\r\n";
            }
            if (!resultYas || !resutBoy || !resultKilo || yas < 1 || boy < 20 || kilo < 4)
            {
                termpString += "yaş,boy veya kilo değişken tanımlama hatası.\r\n";
            }
            if (!kullaniciManager.ValidPassword(kullaniciSifre))
            {
                termpString += "sifre tanımlama hatasi.\r\n";
            }
            if (kullaniciSifre != kullaniciSifreTekrari)
            {
                termpString += "sifre tekrarı tanımlama hatasi.\r\n";
            }
            if (termpString == string.Empty)
            {
                MessageBox.Show("kayıt olusturuldu");
                kullanici = new Kullanici()
                {
                    KullaniciAdi = isim,
                    KullaniciBoy = boy,
                    KullaniciKilo = kilo,
                    KullaniciMail = kullaniciMail,
                    KullaniciSifre = kullaniciSifre,
                    KullaniciSoyadi = soyisim,
                    KullaniciYasi = yas,
                };
                kullaniciManager.InsertManager(kullanici);
                KayitOlPanel.Visible = false;
                GirisPanel.Visible = true;

            }
            else
            {
                MessageBox.Show(termpString);
            }

            GirisPanel.BringToFront();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            kullanici = kullaniciManager.GetByIdManager(UserId);

            if (kullanici != null)
            {
                Isimtxtbox.Text = kullanici.KullaniciAdi;
                SoyadtxtBox.Text = kullanici.KullaniciSoyadi;
                YastxtBox.Text = kullanici.KullaniciYasi.ToString();
                boytxtBox.Text = kullanici.KullaniciBoy.ToString();
                kilotxtBox.Text = kullanici.KullaniciKilo.ToString();
            }
        }

        private void YemekEkleClick(object sender, EventArgs e)
        {
            string yemekAdi = YemekAdiEktextBox2.Text;
            decimal kalori;
            if (yemekListesi.Any(x => x.YemekAdi == yemekAdi))
            {
                MessageBox.Show("Aynı yemek girilemez");
                return;
            }
            if (decimal.TryParse(KalorimikektextBox3.Text, out kalori))
            {
                var yemek = new Yemek()
                {
                    YemekAdi = yemekAdi,
                    Kalori = kalori,
                    Kategorileri = (YemekKategorileri)Enum.Parse(typeof(YemekKategorileri),
                        katagorilistcomboBox2.SelectedItem.ToString()),
                    ResimYolu = secilenResimYolu,
                };
                if (yemek.Kalori < 0)
                {
                    MessageBox.Show("Kalori negatif değer olamaz");
                    return;
                }
                yemekManager.InsertManager(yemek);
                yemekListesi.Add(yemek);

                YemekComboBox.Items.Clear();
                foreach (var item in yemekListesi)
                {
                    YemekComboBox.Items.Add(item.YemekAdi);
                }
                YemekEkleGuncelleCleaner();
            }
            else
            {
                MessageBox.Show("Alanların doğru doldurulduğundan emin olunuz");
            }

        }



        private void OgunListBoxUpdate()
        {
            ogunListesi.Clear();
            OgunUpdateDeleteListBox.Items.Clear();
            OgunUpdateDeleteOgunCombobox.Items.Clear();
            OgunUpdateDeleteYemekCombobox.Items.Clear();
            porsiyonYazTextBox.Clear();
            ogunListesi = ogunManager.GetAllDaily(OgunGuncelleDateTimePicker.Value.Date);
            foreach (var ogun in ogunListesi)
            {
                string formattedYenilenKalori = ogun.YenilenKalori.ToString("N2");


                OgunIsmi ogunIsmi = (OgunIsmi)Enum.ToObject(typeof(OgunIsmi), ogun.OgunIsmi);

                OgunUpdateDeleteListBox.Items.Add(Enum.GetName(typeof(OgunIsmi), ogunIsmi) + " - " + ogun.Yemek.YemekAdi + " - " + formattedYenilenKalori);
            }

            foreach (var yemek in yemekListesi)
            {
                OgunUpdateDeleteYemekCombobox.Items.Add(yemek.YemekAdi);
            }

            foreach (var ogunIsmi in Enum.GetValues<OgunIsmi>())
            {
                OgunUpdateDeleteOgunCombobox.Items.Add(ogunIsmi);
            }
        }

        private void OgunEkleBtnClick(object sender, EventArgs e)
        {
            Ogun ogun = new Ogun();

            try
            {
                ogun.YemekPorsiyon = Convert.ToDecimal(porsiyonyaztextBox1.Text);
                string ogunIsmiStr = OgunConboBox.SelectedItem.ToString();
                var ogunIsmiObj = Enum.Parse(typeof(OgunIsmi), ogunIsmiStr);
                OgunIsmi ogunIsmi = (OgunIsmi)ogunIsmiObj;
                ogun.OgunIsmi = ogunIsmi;
                ogun.OgunVakti = OgunEkleDateTimePicker.Value.Date;
                if (ogun.YemekPorsiyon < 0)
                    throw new Exception();
            }
            catch (Exception a)
            {
                MessageBox.Show("Lütfen tüm alanların düzgün bir şekilde doldurulduğundan emin olunuz");
                return;
            }


            var selectedYemek = yemekListesi.SingleOrDefault(x => x.YemekAdi == YemekComboBox.SelectedItem);

            if (selectedYemek != null)
            {
                ogun.YemekId = selectedYemek.Id;
                ogun.YenilenKalori = selectedYemek.Kalori * ogun.YemekPorsiyon;
                ogunManager.InsertManager(ogun);
                OgunListBoxUpdate();
            }
            else
            {
                MessageBox.Show("Lütfen bir yemek seçin.");
            }

            OgunConboBox.SelectedIndex = -1;
            YemekComboBox.SelectedIndex = -1;
            porsiyonyaztextBox1.Clear();
        }

        private void Geri_panel6_Click(object sender, EventArgs e)
        {
            OgunGuncellePanel.Visible = false;
            OgunEklePanel.Visible = true;
        }

        private void OgunUpdateDeleteListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = OgunUpdateDeleteListBox.SelectedIndex;
            Ogun tempOgun;
            if (selectedIndex >= 0 && selectedIndex < ogunListesi.Count)
            {
                tempOgun = ogunListesi[selectedIndex];
                OgunTextBoxUpdate(tempOgun);
                try
                {
                    if (!string.IsNullOrEmpty(tempOgun.Yemek.ResimYolu))
                    {
                        using (Image resim = Image.FromFile(tempOgun.Yemek.ResimYolu))
                        {
                            pictureBox14.Image = new Bitmap(resim);
                        }
                    }
                    else
                    {
                        pictureBox14.Image = Properties.Resources.Yemek;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Fotoğraf bulunamadi");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğün seçin.");
            }

        }

        private void OgunTextBoxUpdate(Ogun tempOgun)
        {
            OgunUpdateClear();
            porsiyonYazTextBox.Text = tempOgun.YemekPorsiyon.ToString();
            OgunUpdateDeleteOgunCombobox.SelectedItem = tempOgun.OgunIsmi;
            OgunUpdateDeleteYemekCombobox.SelectedItem = yemekListesi.FirstOrDefault(x => x.Id == tempOgun.YemekId)?.YemekAdi;
        }


        private void Öğün_Sil_Click(object sender, EventArgs e)
        {
            int selectedIndex = OgunUpdateDeleteListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < ogunListesi.Count)
            {
                var tempOgun = ogunListesi[selectedIndex];
                ogunManager.DeleteManager(tempOgun);
                OgunListBoxUpdate();
                OgunUpdateClear();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğün seçin.");
            }
        }

        private void Öğün_Getir_Click(object sender, EventArgs e)
        {
            OgunListBoxUpdate();
        }

        private void OgunUpdateClear()
        {
            OgunUpdateDeleteOgunCombobox.SelectedIndex = -1;
            porsiyonYazTextBox.Clear();
            OgunUpdateDeleteYemekCombobox.SelectedIndex = -1;
        }

        private void Ögün_Güncelle_Click(object sender, EventArgs e)
        {
            if (OgunUpdateDeleteListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen öğün seçiniz");
                return;
            }
            var tempOgun = ogunListesi[OgunUpdateDeleteListBox.SelectedIndex];
            tempOgun = ogunManager.GetByIdManager(tempOgun.Id);
            tempOgun.YemekId = yemekListesi[OgunUpdateDeleteYemekCombobox.SelectedIndex].Id;
            tempOgun.YemekPorsiyon = Convert.ToDecimal(porsiyonYazTextBox.Text);
            tempOgun.OgunIsmi = (OgunIsmi)OgunUpdateDeleteOgunCombobox.SelectedIndex;
            tempOgun.OgunVakti = OgunGuncelleDateTimePicker.Value.Date;
            if (tempOgun.YemekPorsiyon < 0)
            {
                MessageBox.Show("Yemek porsiyonu negatif değer olamaz");
                return;
            }
            ogunManager.UpdateManager(tempOgun);
            OgunUpdateClear();
            OgunListBoxUpdate();
        }

        private void Öğün_TarihGetir(object sender, EventArgs e)
        {
            OgunUpdateDeleteListBox.Items.Clear();
            ogunListesi.Clear();
            foreach (var ogun in ogunManager.GetAllDaily(OgunGuncelleDateTimePicker.Value))
            {
                ogunListesi.Add(ogun);
                OgunIsmi ogunIsmi = (OgunIsmi)Enum.ToObject(typeof(OgunIsmi), ogun.OgunIsmi);
                OgunUpdateDeleteListBox.Items.Add(Enum.GetName(typeof(OgunIsmi), ogunIsmi) + " - " + ogun.Yemek.YemekAdi + " - " +
                                                  ogun.YenilenKalori);
            }
        }

        private void GunSonuRaporuClick(object sender, EventArgs e)
        {
            kiyasRaporOgunListBox.Visible = false;
            DateTime secilenTarih = RaporlarDateTimePicker.Value.Date;
            var tempInt = ogunManager.GunSonuToplamKalori(RaporlarDateTimePicker.Value.Date);
            if (tempInt == 0)
            {
                GunSonuKiyasRaporListBox.Items.Clear();
                return;
            }
            var gunSonuRaporlar = ogunManager.GünSonuRapor(secilenTarih);

            GunSonuKiyasRaporListBox.Items.Clear();
            foreach (var ogun in gunSonuRaporlar)
            {
                GunSonuKiyasRaporListBox.Items.Add($"Yemek Adı: {ogun.Yemek.YemekAdi}, Öğün vakti: {ogun.OgunIsmi}, Yenilen Kalori: {ogun.YenilenKalori} ");
            }

            GunSonuKiyasRaporListBox.Items.Add("Gün Sonu Toplam Kalori : " + tempInt);

        }

        private void KiyasRaporuClick(object sender, EventArgs e)
        {
            int days;
            GunSonuKiyasRaporListBox.Items.Clear();
            kiyasRaporOgunListBox.Items.Clear();
            if (HaftalikRadioBtn.Checked)
            {
                days = 7;
            }
            else
            {
                days = 30;
            }

            int aralik = 1;

            foreach (var value in Enum.GetValues(typeof(OgunIsmi)))
            {
                var temp = $"{Enum.GetName(typeof(OgunIsmi), value)} :";
                temp += $" Max: {ogunManager.HaftalikAylikRaporMax(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (OgunIsmi)value).ToString("0.0")} Kcal";
                temp += $" Avg: {ogunManager.HaftalikAylikRaporAvg(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (OgunIsmi)value).ToString("0.0")} Kcal";
                temp += $" Min: {ogunManager.HaftalikAylikRaporMin(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (OgunIsmi)value).ToString("0.0")} Kcal";
                temp += $" UserAvg: {ogunManager.HaftalikAylikRaporKullaniciAvg(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (OgunIsmi)value).ToString("0.0")} Kcal";

                GunSonuKiyasRaporListBox.Items.Add(temp);

                if (value.GetHashCode() < Enum.GetValues(typeof(OgunIsmi)).Length - 1)
                {
                    for (int j = 0; j < aralik; j++)
                    {
                        GunSonuKiyasRaporListBox.Items.Add("");
                    }
                }
            }

            for (int i = 0; i < Enum.GetValues(typeof(YemekKategorileri)).Length; i++)
            {
                var value = Enum.GetValues(typeof(YemekKategorileri)).GetValue(i);
                var maxKcal = yemekManager.HaftalikAylikRaporKategoriMax(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (YemekKategorileri)value);
                var avgKcal = yemekManager.HaftalikAylikRaporKategoriAvg(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (YemekKategorileri)value);
                var minKcal = yemekManager.HaftalikAylikRaporKategoriMin(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (YemekKategorileri)value);
                var userAvgKcal = yemekManager.HaftalikAylikRaporKullanici(RaporlarDateTimePicker.Value.AddDays(-days), RaporlarDateTimePicker.Value, (YemekKategorileri)value);

                string temp = $"{Enum.GetName(typeof(YemekKategorileri), value)} :";
                temp += $" Max: {maxKcal.ToString("0.0")} Kcal";
                temp += $" Avg: {avgKcal.ToString("0.0")} Kcal";
                temp += $" Min: {minKcal.ToString("0.0")} Kcal";
                temp += $" UserAvg: {userAvgKcal.ToString("0.0")} Kcal";

                kiyasRaporOgunListBox.Items.Add(temp);

                if (i < Enum.GetValues(typeof(YemekKategorileri)).Length - 1)
                {
                    for (int j = 0; j < aralik; j++)
                    {
                        kiyasRaporOgunListBox.Items.Add("");
                    }
                }
            }


        }

        private void YemekCesidiRaporClick(object sender, EventArgs e)
        {
            kiyasRaporOgunListBox.Items.Clear();
            GunSonuKiyasRaporListBox.Items.Clear();
            foreach (var yemek in yemekManager.EnCokYenenYemek())
            {
                kiyasRaporOgunListBox.Items.Add(yemek.YemekAdi + " Porsiyon : " + yemek.KacPorsiyon + " Alınan Kalori : " + yemek.AlinanKalori);
            }
            GunSonuKiyasRaporListBox.Items.Clear();
            foreach (var yemekRaporu in yemekManager.YemekRaporu())
            {
                GunSonuKiyasRaporListBox.Items.Add(yemekRaporu);
            }
        }

        private void Geri_panel1_Click(object sender, EventArgs e)
        {
            KayitOlPanel.Visible = false;
            GirisPanel.Visible = true;
        }
        private void YemekSilBtn_Click(object sender, EventArgs e)
        {
            if (MevcutYemekListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silinecek yemeği seçiniz");
                return;
            }
            var tempYemek = yemekListesi[MevcutYemekListBox.SelectedIndex];
            try
            {

                yemekManager.DeleteManager(tempYemek);
                yemekListesi.Remove(tempYemek);
                YemekEkleGuncelleCleaner();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Öğüne bağlı yemek silinemez");
                return;
            }

        }

        private void YemekGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var tempYemek = yemekListesi[MevcutYemekListBox.SelectedIndex];
                tempYemek.YemekAdi = YemekAdiEktextBox2.Text;
                tempYemek.Kalori = Convert.ToDecimal(KalorimikektextBox3.Text);
                tempYemek.Kategorileri = (YemekKategorileri)katagorilistcomboBox2.SelectedIndex;
                tempYemek.ResimYolu = secilenResimYolu;
                if (tempYemek.Kalori < 0)
                    throw new Exception();
                yemekManager.UpdateManager(tempYemek);
                YemekEkleGuncelleCleaner();
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show("Lütfen tüm alanların doğru doldurulduğundan emin olunuz");
            }

        }

        private void YemekEkleGuncelleCleaner()
        {
            MevcutYemekListBox.Items.Clear();
            foreach (var yemek in yemekListesi)
            {
                MevcutYemekListBox.Items.Add(yemek.YemekAdi);
            }
            YemekAdiEktextBox2.Text = string.Empty;
            KalorimikektextBox3.Text = string.Empty;
            katagorilistcomboBox2.SelectedIndex = -1;
            secilenResimYolu = String.Empty;
            pictureBox10.Image = Properties.Resources.Yemek;
        }

        private void MevcutYemekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MevcutYemekListBox.SelectedIndex != -1)
            {
                var selectedYemek = yemekListesi[MevcutYemekListBox.SelectedIndex];
                katagorilistcomboBox2.SelectedItem = selectedYemek.Kategorileri;
                KalorimikektextBox3.Text = selectedYemek.Kalori.ToString();
                YemekAdiEktextBox2.Text = selectedYemek.YemekAdi;
                string resimYolu = selectedYemek.ResimYolu;

                try
                {
                    if (!string.IsNullOrEmpty(resimYolu))
                    {
                        // Resmi yükle
                        using (Image resim = Image.FromFile(resimYolu))
                        {
                            pictureBox10.Image = new Bitmap(resim);
                        }
                    }
                    else
                    {
                        pictureBox10.Image = Properties.Resources.Yemek;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Fotoğraf bulunamadı.");
                }
            }
        }

        private void OpenFileDialog_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    secilenResimYolu = openFileDialog.FileName;
                    string secilenResimAdi = Path.GetFileName(secilenResimYolu);
                    pictureBox10.Image = new Bitmap(secilenResimYolu);
                }
            }
        }

        private void YemekComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (YemekComboBox.SelectedIndex == -1)
                { pictureBox8.Image = Properties.Resources.Yemek; return; }
                var tempYemek = yemekListesi[YemekComboBox.SelectedIndex];
                if (string.IsNullOrEmpty(tempYemek.ResimYolu))
                    pictureBox8.Image = Properties.Resources.Yemek;
                else
                {
                    using (Image resim = Image.FromFile(tempYemek.ResimYolu))
                    {
                        pictureBox8.Image = new Bitmap(resim);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Fotoğraf bulunamadı.");
            }

        }

        private void Girisbtnn_Click(object sender, EventArgs e)
        {
            OgunEklePanel.Visible = false;
            ProfilPanel.Visible = false;
            YemekGuncellePanel.Visible = false;
            OgunGuncellePanel.Visible = false;
            RaporPanel.Visible = false;
            KayitOlPanel.Visible = false;
            GirisPanel.Visible = true;

            EkranIsmiLbl.Text = "Giriş Yap";


        }

        private void kayıtbtnn_Click(object sender, EventArgs e)
        {
            OgunEklePanel.Visible = false;
            ProfilPanel.Visible = false;
            YemekGuncellePanel.Visible = false;
            OgunGuncellePanel.Visible = false;
            RaporPanel.Visible = false;
            KayitOlPanel.Visible = true;
            GirisPanel.Visible = false;
            EkranIsmiLbl.Text = "Kayıt Ol";
        }

        private void Homebtnnn_Click(object sender, EventArgs e)
        {
            OgunEklePanel.Visible = true;
            ProfilPanel.Visible = false;
            YemekGuncellePanel.Visible = false;
            OgunGuncellePanel.Visible = false;
            RaporPanel.Visible = false;
            KayitOlPanel.Visible = false;
            GirisPanel.Visible = false;
            YemekComboBox.Items.Clear();
            yemekListesi.ForEach(x => YemekComboBox.Items.Add(x.YemekAdi));
            EkranIsmiLbl.Text = "Anasayfa";
        }

        private void YemekBtnnn_Click(object sender, EventArgs e)
        {
            EkranIsmiLbl.Text = "Yemek Ayarları";
            OgunEklePanel.Visible = false;
            ProfilPanel.Visible = false;
            YemekGuncellePanel.Visible = true;
            OgunGuncellePanel.Visible = false;
            RaporPanel.Visible = false;
            KayitOlPanel.Visible = false;
            GirisPanel.Visible = false;
            pictureBox10.Image = Properties.Resources.Yemek;
            katagorilistcomboBox2.SelectedIndex = -1;
            MevcutYemekListBox.Items.Clear();
            katagorilistcomboBox2.Items.Clear();
            YemekAdiEktextBox2.Clear();
            KalorimikektextBox3.Clear();
            foreach (var yemek in yemekListesi)
            {
                MevcutYemekListBox.Items.Add(yemek.YemekAdi);
            }

            foreach (var name in Enum.GetValues(typeof(YemekKategorileri)))
            {
                katagorilistcomboBox2.Items.Add(name);
            }
        }

        private void OgunBtnnn_Click(object sender, EventArgs e)
        {
            EkranIsmiLbl.Text = "Öğün Ayarları";
            OgunEklePanel.Visible = false;
            ProfilPanel.Visible = false;
            YemekGuncellePanel.Visible = false;
            OgunGuncellePanel.Visible = true;
            RaporPanel.Visible = false;
            KayitOlPanel.Visible = false;
            GirisPanel.Visible = false;

            OgunUpdateDeleteOgunCombobox.SelectedIndex = -1;
            porsiyonYazTextBox.Text = string.Empty;
            OgunUpdateDeleteYemekCombobox.SelectedIndex = -1;
            pictureBox14.Image = Properties.Resources.Yemek;
            OgunUpdateDeleteYemekCombobox.Items.Clear();
            yemekListesi.ForEach(x => OgunUpdateDeleteYemekCombobox.Items.Add(x.YemekAdi));
        }

        private void ProfilBtnnn_Click(object sender, EventArgs e)
        {
            if (kullanici != null)
            {
                Isimtxtbox.Text = kullanici.KullaniciAdi;
                SoyadtxtBox.Text = kullanici.KullaniciSoyadi;
                YastxtBox.Text = kullanici.KullaniciYasi.ToString();
                boytxtBox.Text = kullanici.KullaniciBoy.ToString();
                kilotxtBox.Text = kullanici.KullaniciKilo.ToString();
            }
            EkranIsmiLbl.Text = "Profil Bilgileri";
            OgunEklePanel.Visible = false;
            ProfilPanel.Visible = true;
            YemekGuncellePanel.Visible = false;
            OgunGuncellePanel.Visible = false;
            RaporPanel.Visible = false;
            KayitOlPanel.Visible = false;
            GirisPanel.Visible = false;
        }

        private void GunSonRaporBtn_Click(object sender, EventArgs e)
        {
            EkranIsmiLbl.Text = "Gün Sonu Raporları";
            GunSonuKiyasRaporListBox.Items.Clear();
            OgunEklePanel.Visible = false;
            ProfilPanel.Visible = false;
            YemekGuncellePanel.Visible = false;
            OgunGuncellePanel.Visible = false;
            RaporPanel.Visible = true;
            KayitOlPanel.Visible = false;
            GirisPanel.Visible = false;

            GunSonuRaporuBtn.Visible = true;
            RaporLbl.Visible = true;
            GunSonuKiyasRaporListBox.Visible = true;
            KiyasLbl1.Visible = false;
            CesitLbl1.Visible = false;
            KiyasLbl2.Visible = false;
            CesitLbl2.Visible = false;
            HaftalikRadioBtn.Visible = false;
            AylikRadioBtn.Visible = false;
            RaporlarDateTimePicker.Visible = true;
            KiyasRaporBtn.Visible = false;
            button11.Visible = false;
            kiyasRaporOgunListBox.Visible = false;
        }

        private void KıyasRaporBtnnn_Click(object sender, EventArgs e)
        {
            EkranIsmiLbl.Text = "Kıyas Raporları";
            OgunEklePanel.Visible = false;
            ProfilPanel.Visible = false;
            YemekGuncellePanel.Visible = false;
            OgunGuncellePanel.Visible = false;
            RaporPanel.Visible = true;
            KayitOlPanel.Visible = false;
            GirisPanel.Visible = false;
            GunSonuRaporuBtn.Visible = false;
            RaporLbl.Visible = false;
            CesitLbl1.Visible = false;
            CesitLbl2.Visible = false;
            button11.Visible = false;

            GunSonuKiyasRaporListBox.Visible = true;
            KiyasLbl1.Visible = true;
            KiyasLbl2.Visible = true;
            HaftalikRadioBtn.Visible = true;
            AylikRadioBtn.Visible = true;
            RaporlarDateTimePicker.Visible = true;
            KiyasRaporBtn.Visible = true;
            kiyasRaporOgunListBox.Visible = true;
            HaftalikRadioBtn.Checked = true;


            GunSonuKiyasRaporListBox.Items.Clear();
            kiyasRaporOgunListBox.Items.Clear();

        }
        private void YemekCesidiBtnnn_Click(object sender, EventArgs e)
        {
            EkranIsmiLbl.Text = "Yemek Çeşidi Raporları";
            kiyasRaporOgunListBox.Items.Clear();
            GunSonuKiyasRaporListBox.Items.Clear();
            OgunEklePanel.Visible = false;
            ProfilPanel.Visible = false;
            YemekGuncellePanel.Visible = false;
            OgunGuncellePanel.Visible = false;
            RaporPanel.Visible = true;
            KayitOlPanel.Visible = false;
            GirisPanel.Visible = false;

            GunSonuRaporuBtn.Visible = false;
            RaporLbl.Visible = false;
            GunSonuKiyasRaporListBox.Visible = true;
            KiyasLbl1.Visible = false;
            CesitLbl1.Visible = true;
            KiyasLbl2.Visible = false;
            CesitLbl2.Visible = true;
            RaporlarDateTimePicker.Visible = false;
            KiyasRaporBtn.Visible = false;
            button11.Visible = true;
            kiyasRaporOgunListBox.Visible = true;
            HaftalikRadioBtn.Visible = false;
            AylikRadioBtn.Visible = false;
        }
        private void CikisBtn_Click(object sender, EventArgs e)
        {
            DialogResult yeniOyun = MessageBox.Show("Çıkış mı yapmak istersiniz?", "Kalori Takip Programı", MessageBoxButtons.YesNo);
            if (yeniOyun == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }
        private void YardimBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kalori Takip Uygulamasına Hoş Geldiniz!\n\n" +
                            "Bu uygulama ile günlük kalori alımınızı ve öğünlerinizi takip edebilirsiniz.\n\n" +
                            "Ana Özellikler:\n" +
                            "- Kayıt Ol: Yeni bir kullanıcı olarak kaydınızı oluşturun.\n" +
                            "- Giriş Yap: Kayıtlı bir kullanıcı olarak uygulamaya giriş yapın.\n" +
                            "- Ana Ekran: Giriş yaptıktan sonra ana ekranı görüntüleyebilirsiniz. Bu ekranda günlük öğünlerinizi ekleyebilirsiniz.\n" +
                            "- Yemekler: Yemek eklemek ve güncellemek için bu bölümü kullanabilirsiniz. Her yemeği adı, kalori değeri ve kategoriye göre kaydedebilirsiniz.\n" +
                            "- Öğünler: Günlük öğünlerinizi eklemek ve güncellemek için bu bölümü kullanabilirsiniz. Öğün adı, yemek seçimi ve porsiyon miktarını kaydedebilirsiniz.\n" +
                            "- Profil: Kullanıcı profilinizi görüntüleyebilirsiniz\n" +
                            "- Raporlar: Günlük ve haftalık/aylık raporlarınızı görüntüleyebilirsiniz. Tükettiğiniz kalorileri, öğünleri ve yemek türlerini inceleyebilirsiniz.\n" +
                            "- Yardım: Şu an gördüğünüz bu yardım penceresini görüntüler.\n" +
                            "- Çıkış: Uygulamadan çıkış yapabilirsiniz.\n\n" +
                            "Uygulamanın her bölümünü kullanırken lütfen bilgilerinizi eksiksiz ve doğru bir şekilde girdiğinizden emin olun.\n\n" +
                            "Sağlıklı bir yaşam için kalori takibinizi bu uygulama ile daha kolay yapabilirsiniz. İyi kullanımlar dileriz!");
        }
        private void HakkimizdeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hakkımızda\r\n\r\nBiz, \"Diyet Programı\" ekibi olarak size hizmet vermek için buradayız. İşte ekibimizden kısa bir tanıtım:\r\n\r\nProje Lideri: Burak Özkaya\r\nYazılım Geliştirici: Burak Özkaya,Sergen Aktaş,Ekrem Salih Ünlü\r\n\r\nBizler, bu projeyi bir araya gelerek hayata geçirdik. Projenin her aşamasında birlikte çalışarak, projenin nasıl şekilleneceği ve hangi katmanlardan oluşacağı konusunda ortak kararlar aldık. Burak DAL'ı yazdı, Sergen PL'i oluşturdu ve Ekrem BL'i oluşturdu. Sizin için en iyi kalori takip deneyimini sunabilmek için çaba sarf ediyoruz.\r\n\r\nTeşekkür ederiz,\r\n\"Kalori Takip Programı\" Ekibi");
        }

        private void ProfilGuncelleBtn_Click(object sender, EventArgs e)
        {
            string isim = Isimtxtbox.Text;
            string soyisim = SoyadtxtBox.Text;
            bool resultYas = int.TryParse(YastxtBox.Text, out var yas);
            bool resultBoy = int.TryParse(boytxtBox.Text, out var boy);
            bool resultKilo = decimal.TryParse(kilotxtBox.Text, out var kilo);
            var tempString = "";
            if (!resultYas || !resultBoy || !resultKilo || yas < 1 || boy < 20 || kilo < 4)
                tempString += "Boy yaş ve kilonun doğru olduğundan emin olunuz\n";

            if (tempString != String.Empty)
            {
                MessageBox.Show(tempString);
            }
            else
            {
                kullanici.KullaniciAdi = isim;
                kullanici.KullaniciSoyadi = soyisim;
                kullanici.KullaniciYasi = yas;
                kullanici.KullaniciBoy = boy;
                kullanici.KullaniciKilo = kilo;
                kullaniciManager.UpdateManager(kullanici);
                MessageBox.Show("Güncelleme Başarılı");
            }
        }
    }
}
