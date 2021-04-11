using System;
using System.Collections.Generic;

namespace C3
{
    class Engine
    {
        private FuelTank tank;
        private Waste waste;

        public Engine(FuelTank _tank, Waste _waste)
        {
            tank = _tank;
            waste = _waste;
        }

        public double GetVelocity(double submarineWeight) { return submarineWeight / 100; }

        public bool CheckFuelBeforeTravel(double travelTime)
        {
            if (tank.Volume - travelTime * 80 > 0) { return true; }
            else { return false; }
        }

        public void Travel(double travelTime)
        {
            tank.Volume = tank.Volume - travelTime * 80;
            waste.Volume = waste.Volume + travelTime * 15;
        }
    }
}