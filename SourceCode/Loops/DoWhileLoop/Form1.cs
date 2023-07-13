using System;
using System.Windows.Forms;

namespace DoWhileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Açıklamalar
        /*
            DO WHILE
            While'ın işleyiş prensibi olarak tam tersi mantıkta çalışır.
            Öncelikle işleminin şarta bakmazsızın en az bir defa çalıştırır, daha sonraki tüm işlemlerini şarta bağımlı olarak gerçekleştirir.
            Bu sepeble, DİKKATLİ KULLANMAKTA FAYDA VAR.
            Çok sık tercih edilen bir döngü değildir.
        */
        #endregion
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            int i = 100;
            while (i < 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            int i = 100;
            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i < 100);
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            int faktoriyel = 1;
            int i = 5;
            while (i > 0)
            {
                faktoriyel *= i;
                i--;
            }
            MessageBox.Show(faktoriyel.ToString());
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            int faktoriyel = 1;
            int i = 5;
            do
            {
                faktoriyel *= i;
                i--;
            }
            while (i > 0);
            MessageBox.Show(faktoriyel.ToString());
        }
    }
}
