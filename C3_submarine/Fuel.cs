using System;

namespace C3
{
    abstract class Fuel : ITransportable
    {
        protected double volume, weight, density;

        public string Type { get; set; }
        virtual public double GetDensity() { return 5.0; }  // ?
        abstract public string GetType();

        public Fuel()
        {
            density = 5.0;
        }
        
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
    }
}