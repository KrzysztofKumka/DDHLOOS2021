using System;

namespace C3
{
	class FuelTank : IVisitPort
	{
		private Fuel fuel;
		protected double volume, weight;

        public double MaxCapacity { get; set; }
        public string GetFuelType() { return fuel.GetType(); }
        public double GetCapacity() { return MaxCapacity; }
        public FuelTank(double _capacity, Fuel _fuel)
        {
            MaxCapacity = _capacity;
            fuel = _fuel;
        }

		public double VisitPort()
        {
            double costs = (MaxCapacity - volume) * 50;
            volume = MaxCapacity;
            return costs;
        }

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * fuel.GetDensity();
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / fuel.GetDensity();
            }
        }
    }
}