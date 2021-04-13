using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    abstract class IceCream
    {
        public int Price { get; set; }
        public string Flavour { get; set; }

        public IceCream(int _price, string _flavour)
        {
            Price = _price;
            Flavour = _flavour;
        }
    }
}
