using System;

namespace SOLID.SRP.Model
{
    class Employee
    {
        //[Required(ErrorMessage = "Id Boş olamaz")]
        public int Id { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
    }
}
