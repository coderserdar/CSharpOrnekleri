using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Nokia : BasePhone
    {
        public override void CallSound()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\nokia.wav"))
                {
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ses dosyası bulunamıyor");
            }
        }
        //Sisteme dahil olan çeşitli virtual methodlar vardır, ToString()'de bunlardan biridir. Mesela biz burada Nokia classında tostring kullanılırsa, Marka ve modeli dönmesi için default ToString() methodunu ezerek ona yeni bir davranış kazandırdık.
        /// <summary>
        /// Bu method Telefonun markasını ve modelini birlikte döner
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Brand + ' ' + Model;
        }
    }
}
