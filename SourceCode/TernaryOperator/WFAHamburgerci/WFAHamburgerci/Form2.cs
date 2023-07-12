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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Menu yeniMenu = new Menu()
            {
                MenuAdi = txtMenuAdi.Text,
                Fiyati = nmrFiyat.Value
            };
            Form1.menuler.Add(yeniMenu);
            MessageBox.Show(yeniMenu + " eklenen menü");
            Fonksiyon.Temizle(this.Controls);
        }
    }
}
