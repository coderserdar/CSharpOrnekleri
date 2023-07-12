using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TernaryOperator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Ternary Operatörü
        //Tek satırda ufak bir karar mekanizması ile yolunuza devam etmek istiyorsanız, soru işareti operatörü size bu pratikliği sağlar.
        //Sytnax'ı =>
        // kontrolEdilecekDeger(KarşılaştırmaOperatörü) ? Durumun olumlu olma durumu : durumun olumsuz olma durumu
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string girilenDeger = "Bilge Adam";
            this.Text = girilenDeger == "Bilge Adam" ? "Doğru Değer" : "Hatalı Değer";

            string sonuc = 10 < 0 ? "Küçüktür" : "Büyüktür";
            MessageBox.Show(sonuc);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Eğer kullanıcı bir değer girdiyse MessageBox'la göster. Girmeşisse de default bir değer gösterelim.
            string gelenDeger = textBox1.Text.Length > 0 ? textBox1.Text : "Default Değer";
            MessageBox.Show(gelenDeger);
        }
    }
}
