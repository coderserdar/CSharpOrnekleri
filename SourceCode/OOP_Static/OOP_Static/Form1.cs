using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math; //Static sınıflar C# 6 ile gelen özellikle using'lere sınıfı tanımlayarak methodu kullanabilirsini.
using static OOP_Static.ExtensionMethod;

namespace OOP_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = FizikKutuphanesi.YerCekimiKuvveti.ToString();
            //FizikKutuphanesi.YerCekimiKuvveti = 12;
            double kuvvet = Pow(4, 5);

            string isim = "BilGE aDAM ŞUBEsi";
            string yeniIsim = isim.ClearString();
            MessageBox.Show(yeniIsim);
        }
    }
}
