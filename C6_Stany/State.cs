using System;
using System.Collections.Generic;
using System.Text;

namespace DDHLOOS_C6_waterDrop
{
    abstract class State
    {
        // kazdy stan musi wiedziec kto go uzywa, na wypadek gdyby potrzebowal wywolac metode ChangeState 
        //protected WaterDrop waterDrop;

        // dlatego bedziemy podawali obiekt typu GameApp w konstruktorze
        //public State(App app)
        //{
        //    parentApp = app;
        //}

        // ponizej znajduja sie metody ktore kazdy stan bedzie musial zaimplementowac na inny sposob

        public abstract string Info();

        public abstract void Breathing(WaterDrop waterDrop);
        public abstract void Rainfall(WaterDrop waterDrop);
        public abstract void Evaporation(WaterDrop waterDrop);
        public abstract void Drinking(WaterDrop waterDrop);
        public abstract void Excretion(WaterDrop waterDrop);
        public abstract void Flow(WaterDrop waterDrop);
        public abstract void Purification(WaterDrop waterDrop);
    }
}
