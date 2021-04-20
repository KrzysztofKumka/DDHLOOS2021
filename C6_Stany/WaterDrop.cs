using System;
using System.Collections.Generic;
using System.Text;

namespace DDHLOOS_C6_waterDrop
{
    class WaterDrop
    {
        public State currentState = new CloudState();

        // public WaterDrop()
        //{
        //    currentState = new CloudState(this);
        //}

        //public void ChangeState(State newState)
        //{
        //    currentState = newState;
        //}

        public void Breathing() { currentState.Breathing(this); }
        public void Rainfall() { currentState.Rainfall(this); }
        public void Evaporation() { currentState.Evaporation(this); }
        public void Drinking() { currentState.Drinking(this); }
        public void Excretion() { currentState.Excretion(this); }
        public void Flow() { currentState.Flow(this); }
        public void Purification() { currentState.Purification(this); }
    }
}
