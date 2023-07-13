using System;
using System.Windows.Forms;

namespace DateTimeMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DateTime => Zamanla ilgili yapabileceğiniz tüm işlemleri ve tüm verileri size teslim eden nesnemizdir.
        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //Günün tarihini ve suanki saati alma..
            label1.Text = DateTime.Now.ToString();

            //Günü tarihini alma
            label1.Text = DateTime.Now.ToLongDateString();
            Text = DateTime.Now.ToShortDateString();

            // Şu anki zamanı alma.
            label1.Text = DateTime.Now.ToLongTimeString();
            Text = DateTime.Now.ToShortTimeString();

            //Tarih Formatlama
            label1.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

            //Artık yıl kontrolü
            bool artikYilMi = DateTime.IsLeapYear(2020);
            MessageBox.Show(artikYilMi == true ? "Şubat 29 Çeker":"Şubat 28 Çeker");

            //haftanın hünü
            string haftaninGunu = DateTime.Now.DayOfWeek.ToString();
            Text = haftaninGunu;

            //Yilin kaçıncı günü
            string yilinKacinciGunu = DateTime.Now.DayOfYear.ToString();
            label1.Text = "Bugün yılın " + yilinKacinciGunu + ". günüdür";
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //İki zaman arasındaki farkı alıp size teslim eden nesnemizdir..

            DateTime yeniZaman = new DateTime(1990, 01, 01, 00, 00, 00);

            DateTime bugun = DateTime.Now;

            TimeSpan zamanFarki = bugun - yeniZaman;
            int toplamGun = Convert.ToInt32(zamanFarki.TotalDays);
            MessageBox.Show("Siz toplam "+ toplamGun + " gündür yaşıyorsunuz");
        }
    }
}
