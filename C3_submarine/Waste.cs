using System;

namespace C3
{
	class Waste : IVisitPort
	{
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 18.0;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 18.0;
            }
        }

        public double VisitPort()
        {
            volume = 0.0;
            return volume;
            //double costs = volume * 3;
            //volume = 0.0;
            //return costs
        }
    }
}
