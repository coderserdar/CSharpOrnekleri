using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Açıklamalar
        /*
            ARRAYLIST
            
            Şuana dek gördüğümüz ilkel dizilerin(veriTipi[] olarak tanımlanan) en büyük iki özelliği;
            TİP BAĞIMLILIĞI ve ELEMAN SAYISI ZORUNLULUĞU idi..

            Ancak, ArrayList nesnesiyle birlikte bu bağımlıklar ortadan kalktı. Bir ArrayList'i meydana getirirken ne eleman sayısı vermek zorundasınız ne de bir veri tipi belirlemek zorundasız.

            Dezavantajı Nedir?
            ArrayList içeirisndeki elemanları otomatik olarak object veri tipine dönüştürüyor. Dolayısıyla bu verileri geri almak istediğiniz de mecburen bir "cast" ya da "convert" işlemine gerek duymaktasınız.. Bu da ekstra iki kat iş demektir. (object => bilinene : unboxing işlemi)

            ArrayList'i kullanıma açabilmek için namespace'lere using System.Collections; ibaresini eklemelisiniz.
        */

        ArrayList yeniDizi = new ArrayList();
        #endregion
        private void btnElemanEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnMetotlar_Click(object sender, EventArgs e)
        {

        }
    }
}
