using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHamburgerci
{
    public class Siparis
    {
        public int Id { get; set; }
        public Menu SeciliMenu { get; set; }
        public int Adet { get; set; }
        public Boyut Boyut { get; set; }
        public List<ExtraMalzeme> ExtraMalzemeler { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;

            switch (Boyut)
            {
                case Boyut.Orta: ToplamTutar += ToplamTutar * 0.10m;break;
                case Boyut.Buyuk: ToplamTutar += ToplamTutar * 0.20m; break;
            }

            foreach (ExtraMalzeme malzeme in ExtraMalzemeler)
                ToplamTutar += malzeme.Fiyati;

            ToplamTutar = ToplamTutar * Adet;
        }

        public override string ToString()
        {
            if (ExtraMalzemeler.Count < 1)
                return string.Format("{0} Menu, x{1}, {2} Boy, Toplam : {3}", SeciliMenu.MenuAdi, Adet, Boyut.ToString(), ToplamTutar.ToString("C2"));
            else
            {
                string exMalzemeler = null;
                foreach (ExtraMalzeme item in ExtraMalzemeler)
                    exMalzemeler += item.ExtraMalzemeAdi + ",";

                exMalzemeler = exMalzemeler.Trim(',');

                return string.Format("{0} Menu, x{1}, {2} Boy, ({3}) Toplam : {4}", SeciliMenu.MenuAdi, Adet, Boyut.ToString(), exMalzemeler, ToplamTutar.ToString("C2"));

            }
        }
    }
}
