using System;
namespace C3
{
	class FoodContainer : IVisitPort
	{
		protected double volume, weight;

        public double MaxCapacity { get; set; }
        public FoodContainer(double _capacity) { MaxCapacity = _capacity; }
        public double GetCapacity() { return MaxCapacity; }

        public double VisitPort()
        {
            double costs = (MaxCapacity - volume) * 10;
            volume = MaxCapacity;
            return costs;
        }

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 9.0;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 9.0;
            }
        }
    }
}

