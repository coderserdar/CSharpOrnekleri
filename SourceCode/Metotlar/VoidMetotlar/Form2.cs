using System;
using System.Drawing;
using System.Windows.Forms;

namespace VoidMetotlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        #region Örnek 1
        private void Saydirici()
        {
            for (int i = 0; i < 1000; i++) listBox1.Items.Add(i);
        }

        private void btnMetot_Click(object sender, EventArgs e)
        {
            Saydirici();
        }
        #endregion
        #region Örnek 2
        public void Tadilatci()
        {
            this.BackColor = Color.DarkBlue;
            this.Size = new Size(400, 400);
        }
        private void btnTamirci_Click(object sender, EventArgs e)
        {
            //Butona basıldığında formun arkaplan rengini ve boyutlarını değiştirecek bir metot yazısınız. Arka plan rengi darkblue, formun boyutu 400:400
            Tadilatci();
        }
        #endregion
    }
}
