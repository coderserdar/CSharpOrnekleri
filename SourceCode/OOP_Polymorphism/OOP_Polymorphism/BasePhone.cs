using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class BasePhone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual void CallSound()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\default.wav"))
                {
                    player.PlaySync();
                }
                // using içerisinde kullanılarak nesnenin Garbage Collector tarafından temizlenmesi beklenmz. Kullanım bittikten sonra ram'den silinir.
                //Enviroment.CurrentDirectory => bin içerisindeki Debug klasörünü ana dizin olarak baz alır
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ses dosyası bulunamıyor");
            }

        }
    }
}
