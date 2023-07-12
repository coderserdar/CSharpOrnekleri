using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces
{
    public class Defans : IFutbolcu
    {
        public string AdiSoyadi { get; set; }
        public string FormaNumarasi { get; set; }
        private byte _sutGucu;
        public byte SutGucu
        {
            get => _sutGucu;
            set
            {
                if (value > 70) System.Windows.Forms.MessageBox.Show("Defans oyuncusunun şut gücü 70'den yukarı olmaz");
                else
                    _sutGucu = value;
            }
        }
        public byte Refleks { get; set; }
        public byte Agresiflik { get; set; }
        public byte Boyu { get; set; }
        public bool MilliMi { get; set; }

        public void SutCek()
        {
            throw new NotImplementedException();
        }

        public void TopKurtar()
        {
            throw new NotImplementedException();
        }

        public override string ToString() => AdiSoyadi;
    }
}
