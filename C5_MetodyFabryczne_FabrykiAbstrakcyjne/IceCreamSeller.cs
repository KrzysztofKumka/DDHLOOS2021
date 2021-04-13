using System;
using System.Collections.Generic;
using System.Text;

namespace C5
{
    class IceCreamSeller
    {
        private IceCreamFactory iceCreamFactory;

        public IceCreamSeller(ref IceCreamFactory _iceCreamFactory)
        {
            iceCreamFactory = _iceCreamFactory;
        }

        public void SuggestDailySpecial()
        {
            IceCream iceCream = iceCreamFactory.DailySpecial();

            Console.WriteLine("Price: " + iceCream.Price);
            Console.WriteLine("Flavour: " + iceCream.Flavour);

            if (iceCream.GetType() == typeof(CreamIceCream))
            {
                CreamIceCream creamIceCream = (CreamIceCream)iceCream;
                Console.WriteLine("Waffle: " + creamIceCream.Serving);
                Console.WriteLine("Icing: " + creamIceCream.Icing);
                Console.WriteLine("Sprinkles: " + creamIceCream.Sprinkles);
            }

            else if (iceCream.GetType() == typeof(FruitIceCream))
            {
                FruitIceCream fruitIceCream = (FruitIceCream)iceCream;
                Console.WriteLine("Waffle: " + fruitIceCream.Serving);
                Console.WriteLine("Icing: " + fruitIceCream.Icing);
            }

            else if (iceCream.GetType() == typeof(ItalianIceCream))
            {
                ItalianIceCream italianIceCream = (ItalianIceCream)iceCream;
                Console.WriteLine("Waffle: " + italianIceCream.Serving);
                Console.WriteLine("Sprinkles: " + italianIceCream.Sprinkles);
            }

            Console.WriteLine("--------------------");
        }
    }
}
