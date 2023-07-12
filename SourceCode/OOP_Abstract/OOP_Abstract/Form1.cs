using OOP_Abstract.Abstract;
using OOP_Abstract.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGitar_Click(object sender, EventArgs e)
        {
            Gitar gitar = new Gitar();
            gitar.Markasi = "Fender";
            gitar.Aciklamasi = "Telecaster";
            string ses = gitar.Cal();

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Hamza";
            muzisyen.Soyadi = "Gitarsoy";
            muzisyen.CaldigiEnstruman = gitar;

            MessageBox.Show($"Gitaristin Adı : {muzisyen.Adi}\nGitaristin Soyadı : {muzisyen.Soyadi}\nÇaldığı Enstrümanın Sesi : {ses}\nÇaldığı Enstrümanın Markası : {muzisyen.CaldigiEnstruman.Markasi}");
        }

        private void btnBateri_Click(object sender, EventArgs e)
        {
            Bateri bateri = new Bateri();
            bateri.Markasi = "Yamaha";
            bateri.Aciklamasi = "ZX5500";
            string ses = bateri.Cal();

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Barkın";
            muzisyen.Soyadi = "Bayzin";
            muzisyen.CaldigiEnstruman = bateri;

            MessageBox.Show($"Bateristin Adı : {muzisyen.Adi}\nBateristin Soyadı : {muzisyen.Soyadi}\nÇaldığı Enstrümanın Sesi : {ses}\nÇaldığı Enstrümanın Markası : {muzisyen.CaldigiEnstruman.Markasi}");
        }

        private void btnYanFlut_Click(object sender, EventArgs e)
        {
            YanFlut yanFlut = new YanFlut();
            yanFlut.Markasi = "Yamaha";
            yanFlut.Aciklamasi = "ZX5500";
            string ses = yanFlut.Cal();

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Barkın";
            muzisyen.Soyadi = "Bayzin";
            muzisyen.CaldigiEnstruman = yanFlut;

            MessageBox.Show($"Flütçünün Adı : {muzisyen.Adi}\nFlütçünün Soyadı : {muzisyen.Soyadi}\nÇaldığı Enstrümanın Sesi : {ses}\nÇaldığı Enstrümanın Markası : {muzisyen.CaldigiEnstruman.Markasi}");
        }
    }
}
