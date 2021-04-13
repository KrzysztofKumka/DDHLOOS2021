using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class CreamIceCream : IceCream
    {
        public bool Serving { get; set; }
        public string Icing { get; set; }
        public bool Sprinkles { get; set; }

        public CreamIceCream(int _price, string _flavour, bool _serving, string _icing, bool _sprinkles) : base(_price, _flavour)
        {
            Serving = _serving;
            Icing = _icing;
            Sprinkles = _sprinkles;
        }
    }
}
