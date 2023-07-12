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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal exMalzemeGeliri = 0;
            int satisAdeti = 0;
            foreach (Siparis siparis in Form1.siparisler)
            {
                ciro += siparis.ToplamTutar;

                foreach (ExtraMalzeme ex in siparis.ExtraMalzemeler)
                    exMalzemeGeliri += ex.Fiyati;

                satisAdeti += siparis.Adet;

                lstSiparisler.Items.Add(siparis);
            }

            lblSiparis.Text = lstSiparisler.Items.Count.ToString();
            lblCiro.Text = ciro.ToString("C2");
            lblExtraMalzeme.Text = exMalzemeGeliri.ToString("C2");
            lblSatisAdeti.Text = satisAdeti.ToString();
        }
    }
}
