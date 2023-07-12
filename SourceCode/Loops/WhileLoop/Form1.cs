using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Açıklamalar
        /*
            WHILE
            1) For'un parçalanmış halidir.
            2) For ile yapabildiğiniz herşeyi While ile de rahatlıkla yapabilirsiniz.
            3) For'dan farkı, metotlardan gelen cevaplara göre işlem yapabilme yeteneğine sahip olması.
        */
        #endregion
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            //Aşağıdaki örnek bir sonsuz döngü örneğidir.
            //Anlatılmaya çalışılan şey ise, metotların döndüreceği bool değerlere göre while'ın karar verebilme yeteneğidir.
            //bool sonuc = false;
            //while (!sonuc)
            //{
            //    listBox1.Items.Add('a');
            //}

            int i = 0;
            while (i < 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            //Formun üzerinde yer alan kontrolleri gezelim eğer yakalan kontorl buton ise genişliklerini 100px olarak ayarlayım ve yukarıya olan uzaklıklarını 20px arttıralım.
            int index = 0;
            while (index < this.Controls.Count)
            {
                if (this.Controls[index] is Button)
                {
                    this.Controls[index].Width = 100;
                    this.Controls[index].Top += 20;
                }
                index++;
            }

            //for (int i = 0; i < Controls.Count; i++)
            //{
            //    if (this.Controls[i] is Button)
            //    {
            //        this.Controls[i].Width = 100;
            //        this.Controls[i].Top += 20;
            //    }
            //}
        }
    }
}
