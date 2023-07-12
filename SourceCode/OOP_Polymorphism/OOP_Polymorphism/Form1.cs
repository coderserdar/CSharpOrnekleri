using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNokia_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
            nokia.Brand = "Nokia";
            nokia.Model = "N720";
            nokia.CallSound();
            MessageBox.Show("Telefon Marka : " + nokia.Brand + "\nTelefon Model : " + nokia.Model);
            MessageBox.Show(nokia.ToString());
        }

        private void btnSamsung_Click(object sender, EventArgs e)
        {

        }

        private void btnIPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
