using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class ItalianIceCream : IceCream
    {
        public bool Serving { get; set; }
        public bool Sprinkles { get; set; }

        public ItalianIceCream(int _price, string _flavour, bool _serving, bool _sprinkles) : base(_price, _flavour)
        {
            Serving = _serving;
            Sprinkles = _sprinkles;
        }
    }
}
