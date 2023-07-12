using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    public class SmartPhone:MobilePhone
    {
        public bool FrontCam { get; set; }
        public SmartPhone()
        {
            HasCamera = true;
            _phoneType = "Smart Phone";
        }
        public SmartPhone(string brand,
                          string connectionType,
                          bool hasCamera,
                          bool isTouched,
                          bool frontCam)
            : base(hasCamera, isTouched, brand, connectionType)
        {
            _phoneType = "Smart Phone";
            FrontCam = frontCam;
        }

        public string DoVideoCall() => "Dialing...";
    }
}
