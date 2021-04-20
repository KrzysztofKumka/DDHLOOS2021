using System;
using System.Collections.Generic;
using System.Text;

namespace DDHLOOS_C6_waterDrop
{
    class CloudState : State
    {
        public override string Info() { return "Cloud"; }

        public override void Breathing(WaterDrop waterDrop) {  }
        public override void Rainfall(WaterDrop waterDrop) 
        {
            Random rnd = new Random();
            int nextState = rnd.Next(0, 3);
            switch(nextState)
            {
                case 0:
                    waterDrop.currentState = new PlantState();
                    break;
                case 1:
                    waterDrop.currentState = new WellState();
                    break;
                case 2:
                    waterDrop.currentState = new RiverState();
                    break;
            }
        }
        public override void Evaporation(WaterDrop waterDrop) {  }
        public override void Drinking(WaterDrop waterDrop) {  }
        public override void Excretion(WaterDrop waterDrop) {  }
        public override void Flow(WaterDrop waterDrop) { }
        public override void Purification(WaterDrop waterDrop) { }

    }
}
