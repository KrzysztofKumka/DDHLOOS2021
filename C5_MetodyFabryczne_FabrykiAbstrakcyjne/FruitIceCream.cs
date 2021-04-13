using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class FruitIceCream : IceCream
    {
        public bool Serving { get; set; }
        public string Icing { get; set; }

        public FruitIceCream(int _price, string _flavour, bool _serving, string _icing) : base(_price, _flavour)
        {
            Serving = _serving;
            Icing = _icing;
        }
    }
}
