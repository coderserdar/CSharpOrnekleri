using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Siparis> siparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu {MenuAdi = "SteakHouse", Fiyati = 18.25m},
            new Menu {MenuAdi = "McFish", Fiyati = 12.25m},
            new Menu {MenuAdi = "Whooper", Fiyati = 15},
            new Menu {MenuAdi = "BigKing", Fiyati = 13.75m},
            new Menu {MenuAdi = "Chicken Royal", Fiyati = 14},
            new Menu {MenuAdi = "King Chicken", Fiyati = 17.25m}
        };

        public static List<ExtraMalzeme> extralar = new List<ExtraMalzeme>()
        {
            new ExtraMalzeme {ExtraMalzemeAdi = "Hardal", Fiyati = 0.50m},
            new ExtraMalzeme {ExtraMalzemeAdi = "Ketçap", Fiyati = 0.30m},
            new ExtraMalzeme {ExtraMalzemeAdi = "Mayonez", Fiyati = 0.30m},
            new ExtraMalzeme {ExtraMalzemeAdi = "Ranch", Fiyati = 0.72m},
            new ExtraMalzeme {ExtraMalzemeAdi = "BBQ", Fiyati = 0.75m},
            new ExtraMalzeme {ExtraMalzemeAdi = "Ballı Hardal", Fiyati = 1}
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
                cmbMenuler.Items.Add(item);

            foreach (ExtraMalzeme ex in extralar)
                flpExtraMalzemeler.Controls.Add(new CheckBox() { Text = ex.ExtraMalzemeAdi, Tag = ex });

            foreach (Siparis item in mevcutSiparisler)
                lstSiparisler.Items.Add(item);

            TutarHesapla();

            cmbMenuler.SelectedIndex = 0;
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                Siparis gelen = (Siparis)lstSiparisler.Items[i];
                toplamTutar += gelen.ToplamTutar;
            }

            lblToplamTutar.Text = toplamTutar.ToString("C2");

            return toplamTutar;
        }
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cmbMenuler.SelectedItem;

            if (rcKucuk.Checked) yeniSiparis.Boyut = Boyut.Kucuk;
            else if (rbOrta.Checked) yeniSiparis.Boyut = Boyut.Orta;
            else yeniSiparis.Boyut = Boyut.Buyuk;

            yeniSiparis.ExtraMalzemeler = new List<ExtraMalzeme>();
            foreach (CheckBox item in flpExtraMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    yeniSiparis.ExtraMalzemeler.Add((ExtraMalzeme)item.Tag);
                }
            }
            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla();
            mevcutSiparisler.Add(yeniSiparis);
            siparisler.Add(yeniSiparis);
            lstSiparisler.Items.Add(yeniSiparis);

            TutarHesapla();

            Fonksiyon.Temizle(this.Controls);


        }

        private void button1_Click(object sender, EventArgs e) //btnSiparisTamamla
        {
            DialogResult dr = MessageBox.Show("Toplam Satış Ücreti : " + TutarHesapla().ToString("C2")+ " Satın almayı tamamlamak istemisini?","Sipariş Bilgisi",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                lstSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Sipariş Tamamlandı");
            }
            else
                MessageBox.Show("İptal Edildi!");
        }

       
    }
}
