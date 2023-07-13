using System;
using System.Windows.Forms;

namespace MetotOverload
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        /*
            Bir METODA OVERLOAD (FAZLA YÜK) yapabilmek için;
            İlgili metodu aynı adla tekrar oluşturmalısınız.
            Metodu overload edecekseniz, metot imzalarına(metod ismi, parametre adet/sıralama) dikkat etmelisiniz. Farklı paramatre tipleri almak zorundadır..

            Eğer metotlarınızın açıklamaları ve metot parametrelenini kısa bilgilendirmeleri olsun isterseniz , metodun hemen üst satırana gelerek ardarda üç defa slash(/) tuşuna basmanız yeterlidir. Geriye sadece boşlukları doldurak kalır. Açılan alana summary alanı, metot özeti; param alanı ise paramtrelere verilecek açıklamalar içindir.
        */
        /// <summary>
        /// Girilen adı @hotmail.com şeklinde mail adresine çevirildi.
        /// </summary>
        /// <param name="adi">Sunucu adının öncesinde gelen ad parametresi</param>
        void MailOlusturucu(string adi)
        {
            MessageBox.Show(adi+"@hotmail.com");
        }
        /// <summary>
        /// Girilen isim ve uzantıyı birleştirerek mail adresi formatına dönüştürür.
        /// </summary>
        /// <param name="adi">Kişi Adı</param>
        /// <param name="uzanti">Sunucu Uzantı</param>
        void MailOlusturucu(string adi, string uzanti)
        {
            MessageBox.Show(adi+uzanti);
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            // kullanıcıdan tercih ettiği adı ve tercih ettiği sunucu bilgisini alan, ve eğer sunucu adı seçildiyde seçilen sunucu adıyla birlikte, seçili değilse de default @hotmail.com yazarak mail adresini oluşturalım.
            if (comboBox1.SelectedIndex == -1) MailOlusturucu(textBox1.Text);
            else MailOlusturucu(textBox1.Text, comboBox1.SelectedItem.ToString());
        }
    }
}
