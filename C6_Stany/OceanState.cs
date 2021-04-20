using System;
using System.Collections.Generic;
using System.Text;

namespace DDHLOOS_C6_waterDrop
{
    class OceanState : State
    {
        public override string Info() { return "Ocean"; }

        public override void Breathing(WaterDrop waterDrop) {  }
        public override void Rainfall(WaterDrop waterDrop) {  }
        public override void Evaporation(WaterDrop waterDrop) { waterDrop.currentState = new CloudState(); }
        public override void Drinking(WaterDrop waterDrop) {  }
        public override void Excretion(WaterDrop waterDrop) {  }
        public override void Flow(WaterDrop waterDrop) { }
        public override void Purification(WaterDrop waterDrop) { }

    }
}
