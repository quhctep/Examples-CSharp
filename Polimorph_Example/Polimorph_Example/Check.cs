using System;

namespace Polimorph_Example
{
    class Check
    {
        public void Buy(User user, Product product)
        {
            double price = product.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine(new String('-', 25));
            Console.WriteLine($"{user.Name} купил {product.Name} за {price}. Заказ отправлен на склад");
            Console.WriteLine(new String('-', 25));
        }
    }
}
