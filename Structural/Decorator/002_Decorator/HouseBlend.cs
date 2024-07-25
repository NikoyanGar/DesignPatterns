namespace _002_Decorator
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "House Blend";
        }

        public override string Description => _description;

        public override double Cost()
        {
            return 2.49;
        }
    }
}
