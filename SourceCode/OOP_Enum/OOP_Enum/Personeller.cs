using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Enum
{
    public enum Departmanlar
    {
        Yazilim, SistemAgUzmanligi, GrafikTasarim, Ingilizce, Muhasebe, BulutMimarisi
    }
    public class Personeller
    {
        private string _adiSoyadi;

        public string AdiSoyadi { get => _adiSoyadi; set => _adiSoyadi = value; }
        public Departmanlar Departmanlar { get => _departmanlar; set => _departmanlar = value; }

        private Departmanlar _departmanlar;

        public override string ToString() => 
            $"{AdiSoyadi} kişisinin çalıştığı Departman => {Departmanlar} ";
    }
}
