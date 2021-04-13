using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class IceCreamFactory
    {
        private int ProductionMode { get; set; }
        public IceCream DailySpecial()
        {
            switch(ProductionMode)
            {
                case 1:
                    return new FruitIceCream(5, "Strawberry", true, "Chocolate");
                case 2:
                    return new CreamIceCream(3, "Cream", true, "Chocolate", true);
                case 3:
                    return new FruitIceCream(5, "Peach", false, "Almond");
                case 4:
                    return new Sorbet(2, "Blueberry");
                case 5:
                    return new ItalianIceCream(7, "Cream", true, false);
                case 6:
                    return new ItalianIceCream(7, "Chocolate", true, true);
                case 7:
                    return new Sorbet(3, "Mango");
                default:
                    return new Sorbet(2, "Mango");
            }
        }

        public void SetProductionMode(int i)
        {
            ProductionMode = i;
        }
    }
}
