using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorph_Example.Products
{
    class Power : Product
    {
        public int Value { get; private set; }
        public Power(string name, int price, string brand, int value)
        {
            Name = name;
            Price = price;
            Brand = brand;
            Value = value;
        }
    }
}
