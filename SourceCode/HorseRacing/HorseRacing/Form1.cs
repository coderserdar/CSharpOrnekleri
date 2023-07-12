using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bir kontrolün "Left" propertysi, o kontrolün sola olan uzaklığını verir.
            // Bir kontrolün Left ve Top özelliklerine atama yapabilirsiniz ancak Right ve Bottom özelliklerinden yalnızca o anki değerlerini alabilirsiniz.
            pcbBirinciAt.Left += rnd.Next(5, 16);
            pcbIkinciAt.Left += rnd.Next(5, 16);
            pcbUcuncuAt.Left += rnd.Next(5, 16);

            if (pcbBirinciAt.Left > pcbIkinciAt.Left && pcbBirinciAt.Left > pcbUcuncuAt.Left)
                lblBilgilendirme.Text = "Birinci kulvardaki Şah Batur önde götürüyor";
            else if (pcbIkinciAt.Left > pcbBirinciAt.Left && pcbIkinciAt.Left > pcbUcuncuAt.Left)
                lblBilgilendirme.Text = "İkinci kulvardaki Gül Batur önde götürüyor";
            else if (pcbUcuncuAt.Left > pcbIkinciAt.Left && pcbUcuncuAt.Left > pcbBirinciAt.Left)
                lblBilgilendirme.Text = "Üçüncü kulvardaki Beyaz Saray önde götürüyor";
            else lblBilgilendirme.Text = "Yarış başa baş gidiyor!!!";

            //Bir kontrolün "width" propertysi, size o kontrolün genişliğini verir.
            //Bir kontrolün "height" propertysi, size o kontrülün yüksekliğini verir.

            // yani ilgili kontrolün left  + width propertyleri bana right'ı teslim etmez mi??
            if (pcbBirinciAt.Left + pcbBirinciAt.Width >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Şah Batur Kazandı");
            }
            else if(pcbIkinciAt.Left + pcbIkinciAt.Width >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Gül Batur Kazandı");
            }
            else if (pcbUcuncuAt.Left + pcbUcuncuAt.Width >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Beyaz Saray Kazandı");
            }

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) timer1.Stop();
            else timer1.Start();

            rnd = new Random();

            //pcbBirinciAt.SizeMode = PictureBoxSizeMode.StretchImage;
            //pcbBirinciAt.Image = Image.FromFile(@"c:\users\barkin.bayzin\documents\....\horse1.gif");
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            pcbBirinciAt.Left = pcbIkinciAt.Left = pcbUcuncuAt.Left = 0;
            timer1.Stop();
            lblBilgilendirme.Text = "";
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //2. ata gaz verir..
            pcbIkinciAt.Left += rnd.Next(10,16);
        }
    }
}
