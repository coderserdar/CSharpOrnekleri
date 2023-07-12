using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHamburgerci
{
    //Bir menünün ...... özelliği vardır?
    public class Menu
    {
        public string MenuAdi { get; set; }
        public decimal Fiyati { get; set; }
        public override string ToString() => MenuAdi + " Menu";
    }
}
