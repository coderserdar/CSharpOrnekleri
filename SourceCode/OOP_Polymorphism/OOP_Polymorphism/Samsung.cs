using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Samsung : BasePhone
    {
        public override void CallSound()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\samsung.wav"))
                {
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ses dosyası bulunamıyor");
            }
        }
    }
}
