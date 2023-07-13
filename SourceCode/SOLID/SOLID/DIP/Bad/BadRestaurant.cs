namespace SOLID.DIP.Bad
{
    class BadRestaurant
    {
        //Restaurant sınıfı high-level bir modüldür. Yalnız low-level modüllerden fish ve poultry sınıflarına bağımlılığı vardır. Dependence Inversion prensibine göre değişikleri gerçekleştirelim.
        private BadFish nemo = new BadFish();
        private BadPoultry duck = new BadPoultry();

        public string GenerateCookingIstructions()
        {
            return nemo.GetFishCookingInstructions() + " " + duck.GetPoultryCookingInstructions();
        }
    }
}
