using System;
using System.Windows.Forms;

namespace VoidMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
            Geriye değer döndürmeyen, yalnızca üzerine düşen işi yapan işlemlere void metotlar ya da subrutinler denir..
            1) Tekrarlı kodları engellemek..
            2) Kod kalabalığından kurtulup daha esnek kodlar yazabilmek..
            3) merkeziyetçi kod yapısını hedef haline getirebilmek. Yani, herhangi bir problem ya da değişiklik durumunda birden fazla yeri kontrol etmek yerine, merkez yapaıya müdahele ederek en kısa ve en net şekilde sorunları çözmek..
            Seçtiğiniz kod bloğunu kısayoldan method haline getirmek isterseni Ctrl + (R)efactor + (M)ethod
        */
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Text = "";
            textBox3.Text = string.Empty;
            textBox4.Text = null;
            textBox5.Text = default(string);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
