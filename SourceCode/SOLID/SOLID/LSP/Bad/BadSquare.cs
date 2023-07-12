using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Bad
{
    //Karelerde birer dörtgen olduğu için alttaki yöntemi izlememiz yanlış olmayacktır.
    //Yalnız dörtgen yerine kare sınıfını kullandığımızda işlemler pek istediğimiz gibi sonuçlanmayacaktır.
    //Bunun nedeni ise aslında kodun yazım şeklindedir.
    public class BadSquare:BadRectangle
    {
        int _height;
        int _width;

        public override int Height 
        { 
            get => _height; 
            set
            {
                _height = value;
                _width = value;
            }
        }

        public override int Width
        {
            get => _width;
            set
            {
                _height = value;
                _width = value;
            }
        }
    }
}
