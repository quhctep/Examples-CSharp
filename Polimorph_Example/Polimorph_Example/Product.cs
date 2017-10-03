namespace Polimorph_Example
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 500)
            {
                return Price;
            }

            if (user.Spent < 1000)
            {
                return Price * 0.9;
            }

            return Price * 0.8;
        }
    }
}
