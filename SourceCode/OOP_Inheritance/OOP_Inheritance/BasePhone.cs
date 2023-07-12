using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    public class BasePhone
    {
        private string _brand;
        protected string _phoneType;
        protected string _connectionType;
        //protected readonly string _connectionType;
        public BasePhone()
        {
            _phoneType = "Ahizeli Telefon";
        }

        public BasePhone(string brand, string connectionType)
        {
            _brand = brand;
            _connectionType = connectionType;
            _phoneType = "Ahizeli Telefon";
        }


        public string Brand { get => _brand; set => _brand = value; }
        protected string PhoneType {
            get => _phoneType; //Read-only
            //private set => _phoneType = value;  //Write-Only
        }
        protected string ConnectionType { get => _connectionType; set => _connectionType = value; }

        public virtual string Cal() => "";

        //Virtual Methods(sanal methodlar), base class(temel sınıf) içinde bildirilmiş ve derived class(türemiş sınıf) içinde de tekrar bildirilebilen metotlardır.
        //Böylelikle sanal metotlar kullanılarak nesne yönelimli programlama da çok sık başvuralan çok biçimcilik(Polymorphsim) uygulanmış olur. Yani temel sınıfta bir sanal metot bildirildiğinde bu temel sınıftan türeyen sınıflardaki metotlar override edilerek, temel sınıfıtaki sanal metodu devre dışı bırakabilirler.

        public virtual string ConnectionStatus() => "Kablo Bağlantısı Mevcut";

    }
}
