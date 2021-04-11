using System;

namespace C3
{
    class FuelNuclear : Fuel
    {
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * GetDensity();
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / GetDensity();
            }
        }
        public override string GetType() 
        { 
            Type = "Nuclear";  
            return Type; 
        }
        public override double GetDensity() { return 6.0; }
    }
}