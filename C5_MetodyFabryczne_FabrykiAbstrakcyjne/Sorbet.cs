using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class Sorbet : IceCream
    {
        public Sorbet(int _price, string _flavour) : base(_price, _flavour) { }
    }
}
