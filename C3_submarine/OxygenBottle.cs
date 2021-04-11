using System;

namespace C3
{
    class OxygenBottle : IVisitPort
    {
        protected double volume, weight;

        public double MaxCapacity { get; set; }
        public OxygenBottle(double _capacity) { MaxCapacity = _capacity; }
        public double GetCapacity() { return MaxCapacity; }

        public double VisitPort()
        {
            double costs = (MaxCapacity - volume) * 17;
            volume = MaxCapacity;
            return costs;
        }

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 10.0;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 10.0;
            }
        }
    }
}
