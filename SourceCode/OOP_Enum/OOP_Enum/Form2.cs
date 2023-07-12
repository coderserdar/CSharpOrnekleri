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
    public partial class Form2:Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        enum Sehirler : byte
        {
            İstanbul, Ankara, İzmir,Bursa, Eskişehir
        }
        private void button1_Click(object sender, EventArgs e)
        {
            byte seciliIndex = (byte)Enum.Parse(typeof(Sehirler), listBox1.Text);
            MessageBox.Show("Seçili şehrin Index => " + seciliIndex);

            Sehirler gelen = (Sehirler)Enum.Parse(typeof(Sehirler), "2");
            MessageBox.Show(gelen.ToString());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Enum.GetNames(typeof(Sehirler)));
        }
    }
}
