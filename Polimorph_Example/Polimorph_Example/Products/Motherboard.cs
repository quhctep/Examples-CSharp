using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorph_Example.Products
{
    class Motherboard : Product
    {
        public string Form { get; set; }
        public string Chipset { get; set; }
        public Motherboard(string name, int price, string brand, string form, string chipset)
        {
            Name = name;
            Price = price;
            Brand = brand;
            Form = form;
            Chipset = chipset;
        }
    }
}
