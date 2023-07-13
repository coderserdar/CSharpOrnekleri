using SOLID.DIP.Validated.Abstract;
using System.Collections.Generic;

namespace SOLID.DIP.Validated.Concrete
{
    class Restaurant
    {
        //Bu versiyonda ise reaturant sınıfı alt seviye modüllerden bağımsız hale gelmiştir.
        private List<IProduct> _products;

        public Restaurant(List<IProduct> products) //ctor injection
        {
            _products = products;
        }

        public string GenerateInstruction()
        {
            string instructions = string.Empty;

            foreach (IProduct item in _products)
                instructions += item.GetCookingInstructions();

            return instructions;
        }
    }
}
