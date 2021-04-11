using System;
using System.Collections.Generic;

namespace C3
{
    class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles;
        private FoodContainer foodContainer;
        private Waste waste;
        private List<Human> crew;

        public LifeSupportSystem(List<OxygenBottle> _oxygenBottles, FoodContainer _foodContainer, Waste _waste, List<Human> _crew)
        {
            oxygenBottles = _oxygenBottles;
            foodContainer = _foodContainer;
            waste = _waste;
            crew = _crew;
        }

        public bool CheckSuppliesBeforeTravel(double travelTime)
        {
            foodContainer.Volume = foodContainer.Volume - travelTime * 56;
            if (foodContainer.Volume > 0) { return true; }
            else { return false; }
        }

        public void Run(double travelTime)
        {
            foodContainer.Volume = foodContainer.Volume - travelTime * 56;
            waste.Volume = waste.Volume + travelTime * 15;
            oxygenBottles[0].Volume = oxygenBottles[0].Volume - travelTime * 17 * crew.Count;
        }
    }
}