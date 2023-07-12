using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    public class MobilePhone : BasePhone
    {
        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }

        public MobilePhone()
        {
            // * işareti protected olduğu anlamına gelir. Protected nesnelere sadece miras alan sınıflar üzerinden ulaşılabilir..
            _phoneType = "Mobile phone";
        }
        // :base() => Miras aldığı sınıf içerisinde constructor var ise bu şekilde miras alınan sınıf içerisindeki constructor'a atama yapabiliriz.
        public MobilePhone(bool hasCamera, bool isTouched ,string brand, string connectionType):base(brand, connectionType)
        {
            this.IsTouched = isTouched;
            this.HasCamera = hasCamera;
            base._phoneType = "Mobile Phone";
            //ctor yerine içeriden de atama yapabilirsiniz.
        }

        public string TakePhoto()
        {
            if (HasCamera) return "You can take a photo.";
            else return "There is no camera";
        }

        public override string ToString()
        {
            return Brand + " " + PhoneType;
        }

        // Virtual olan metotları override ederek görüntülüyebiliriz. Eğer içeriğini değiştirmiyecek isek Override etmemize gerek yoktur.
        public override string ConnectionStatus()
        {
            return base.ConnectionStatus();
        }

        public override string Cal() => "Polifonik yeter artık";
    }
}
