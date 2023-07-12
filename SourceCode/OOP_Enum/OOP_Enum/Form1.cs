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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbDepartmanlar.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));
            cmbDepartmanlar.SelectedIndex = 0;
        }
        #region Açıklamalar
        /*
            ENUM
            
            Kişilere sabit seçenekler sunmak için kullanılan bir değer tipidir. Seçenekleri kontrol altında tutup, uygulamanızı da kendi kontrolünüz çerçevesinde yönetebilirsinizi. Bu sebeple uygulamanızda herhangi bir sürprize yer bırakmadan çok daha performanslı ve çok daha güvenli bir yapıyı oluşturmuş olursunuz.
            Enumlar tamamıyla geliştiriciye yönelik nesnelerdir...
            Bir ENUM'ın yazılı değerlerini teslim alabilmek için kullanılan metot, Enum.GetNames()
            Yazılı hale getirilmiş ENUM'ın değerini, tekrar ENUM şeklinde geri alabilmek için kullanılan metotsa Enum.Parse() metodudur.
            Bir ENUM arkaplanda sayısal değerler tutar. Bu değerler varsayılan olarak seçilen değerin index değeridir ve veri tipi int'dir. Ancak siz isterseniz bu tipi değiştirebilir (sbyte,byte,short, ushot...) yada bütün enum değerlerine tek tek değer atayabilisiniz(ilk eleman 5 olsun gerisini enum atasın.) Ancak bilinmesi gereken tek şey, benzersislik diye bir kavram yoktur!!
            Bu arkaplandaki değerden ötürü Enum.Parse işlemi size object tipinde değer döner. Yaızlı halini teslim almak için o enum'ın tipine, sayısal değerini almak içinse hangi tipe tanımladıysanız o sayısal tipe cast edebilirsiniz...
        */
        #endregion
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personeller personel = new Personeller();
            personel.AdiSoyadi = txtAd.Text;
            personel.Departmanlar = (Departmanlar)Enum.Parse(typeof(Departmanlar), cmbDepartmanlar.Text);

            int seciliEnumIndexi = (int)Enum.Parse(typeof(Departmanlar), cmbDepartmanlar.Text);

            Departmanlar cikacak;
            bool sonuc = Enum.TryParse<Departmanlar>(cmbDepartmanlar.Text, out cikacak);

            if (sonuc)
                MessageBox.Show(personel.ToString());
            else
                MessageBox.Show("Böyle bir departman yok");

            switch (personel.Departmanlar)
            {
                case Departmanlar.Yazilim:
                    MessageBox.Show("Hoşgeldin Bilgisayarın Tanrısı");
                    break;
                case Departmanlar.SistemAgUzmanligi:
                    break;
                case Departmanlar.GrafikTasarim:
                    break;
                case Departmanlar.Ingilizce:
                    break;
                case Departmanlar.Muhasebe:
                    break;
                case Departmanlar.BulutMimarisi:
                    break;
                default:
                    break;
            }
        }
    }
}
