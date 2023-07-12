using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces
{
    public class Kaleci : IFutbolcu
    {
        public string AdiSoyadi { get; set; }
        public string FormaNumarasi { get; set; }
        public byte SutGucu { get; set; }
        public byte Refleks { get; set; }
        public byte Agresiflik { get; set; }
        public byte Boyu { get; set; }
        public bool MilliMi { get; set; }
        public byte ElleTopKontrolu { get; set; }

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
