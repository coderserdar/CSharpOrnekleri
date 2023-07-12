using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Enum
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        enum Sehirler
        {
            Ankara = 6,
            Istanbul = 34,
            Adana = 1,
            Izmir = 35,
            Malatya = 44
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            //Ankara - 6
            //İstanbul - 34
            foreach (string sehir in Enum.GetNames(typeof(Sehirler)))
                listBox1.Items.Add(sehir + " - " + Convert.ToInt32(Enum.Parse(typeof(Sehirler), sehir)));
        }

        private void btnEnum_Click(object sender, EventArgs e)
        {
            int enumDegeri = int.Parse(txtSayi.Text);
            Sehirler sehir = (Sehirler)enumDegeri;
            MessageBox.Show(sehir.ToString());
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            //Textbox üzerinden index numarası girildiğinde Enum değeri teslim edilir. Var olmayan bir index numaası girdiğinizde size sadce girdiğiniz index numaraısnı geriye teslim eder.
            // Enum içerisinde var olan değerin kontrolünü sağlamak için "IsDefined" metodu kullanılır.

            int enumDegeri = int.Parse(txtSayi.Text);
            if (Enum.IsDefined(typeof(Sehirler),enumDegeri))
            {
                Sehirler sehir = (Sehirler)enumDegeri;
                MessageBox.Show(sehir.ToString());
            }
            else
                MessageBox.Show("Girdiğiniz Index numarasına ait Şehir bulunmamaktadır.!");
        }
    }
}
