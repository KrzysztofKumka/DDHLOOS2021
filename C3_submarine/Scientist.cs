using System;

namespace C3
{
    class Scientist : Human
    {
        private Equipment equipment;

        public Scientist(Equipment _equipment)
        {
            equipment = _equipment;
        }
            
        public void Work(double time)
        {
            for (int i = 0; i < time; i++)
            {
                Console.WriteLine(equipment.GatherData()); 
            }
        }
    }
}
