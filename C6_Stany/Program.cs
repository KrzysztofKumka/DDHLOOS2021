using System;

namespace DDHLOOS_C6_waterDrop
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterDrop wd = new WaterDrop();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(wd.currentState.Info());
                switch(wd.currentState.Info())
                {
                    case "Cloud":
                        wd.Rainfall();
                        break;
                    case "Plant":
                        wd.Breathing();
                        break;
                    case "Well":
                        wd.Drinking();
                        break;
                    case "Sewage":
                        wd.Purification();
                        break;
                    case "Ocean":
                        wd.Evaporation();
                        break;
                    case "River":
                        Random rndR = new Random();
                        int nextStateR = rndR.Next(0, 3);
                        switch (nextStateR)
                        {
                            case 0:
                                wd.Evaporation();
                                break;
                            case 1:
                                wd.Flow();
                                break;
                            case 2:
                                wd.Drinking();
                                break;

                        }
                        break;
                    case "Human":
                        Random rndHuman = new Random();
                        int nextStateHuman = rndHuman.Next(0, 2);
                        switch (nextStateHuman)
                        {
                            case 0:
                                wd.Breathing();
                                break;
                            case 1:
                                wd.Excretion();
                                break;
                        }
                        break;               
                    case "Animal":
                        Random rndAnimal = new Random();
                        int nextStateAnimal = rndAnimal.Next(0, 2);
                        switch (nextStateAnimal)
                        {
                            case 0:
                                wd.Breathing();
                                break;
                            case 1:
                                wd.Excretion();
                                break;
                        }
                        break;
                }
            }
        }
    }
}
