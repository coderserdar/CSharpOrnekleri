using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIsim_Click(object sender, EventArgs e)
        {
            //Instance'ını alıyorum.
            //tanımlı olan bir sınıf tipide, bir nesne oluşturmaya instance almak denir.
            FirstClass fc = new FirstClass();
            //1- fc dedikten sonra hiçbir nesne gelmedi(private olarak işaretlenenler) çünkü herhangi bir erişim belirleyici belirtmediğimn için default olarak private tanımlandı.
            fc.Isim = "Barkın";
            fc.Soyisim = "Bayzin";
            MessageBox.Show(fc.Isim + " " + fc.Soyisim);
        }

        private void btnBilgiler_Click(object sender, EventArgs e)
        {
            FirstClass fc = new FirstClass();
            fc.Isim = "bilge";
            fc.Soyisim = "adam";
            fc.Id = 1;
            fc.Kilo = 70;
            fc.Boy = 180;
            fc.Yas = 19;
            if (fc.Yas < 1)
                MessageBox.Show("Verdiğiniz yaş kriteri geçerisizdir");
            else
            MessageBox.Show($"{fc.Isim} {fc.Soyisim} adlı kişinin özellikleri : \nID : {fc.Id}\nKilo : {fc.Kilo}\nBoy : {fc.Boy}\nYaş : {fc.Yas}");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            FirstClass fc = new FirstClass();
            fc.Yas = Convert.ToInt32(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ctor Öncesi
            //Araba araba1 = new Araba();
            //araba1.Motor = 3500;
            //araba1.Marka = "Mercedes";
            //araba1.Model = "E350";

            //Ctor Sonrası
            Araba araba = new Araba("Mercedes", "E350", 3500);
        }
    }
}
