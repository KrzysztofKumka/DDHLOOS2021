using System;
using System.Collections.Generic;
using System.Text;

namespace DDHLOOS_C6_waterDrop
{
    class RiverState : State
    {
        public override string Info() { return "River"; }

        public override void Breathing(WaterDrop waterDrop) {  }
        public override void Rainfall(WaterDrop waterDrop) {  }
        public override void Evaporation(WaterDrop waterDrop) { waterDrop.currentState = new CloudState(); }
        public override void Drinking(WaterDrop waterDrop) { waterDrop.currentState = new AnimalState(); }
        public override void Excretion(WaterDrop waterDrop) {  }
        public override void Flow(WaterDrop waterDrop) { waterDrop.currentState = new OceanState(); }
        public override void Purification(WaterDrop waterDrop) {  }
    }
}
