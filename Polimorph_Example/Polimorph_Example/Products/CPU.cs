using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorph_Example.Products
{
    class CPU : Product
    {
        public CPU(string name, int price, string brand)
        {
            Name = name;
            Price = price;
            Brand = brand;
        }
    }
}
