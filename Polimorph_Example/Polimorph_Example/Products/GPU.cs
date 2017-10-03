using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorph_Example.Products
{
    class GPU : Product
    {
        public GPU(string name, int price, string brand)
        {
            Name = name;
            Price = price;
            Brand = brand;
        }
    }
}
