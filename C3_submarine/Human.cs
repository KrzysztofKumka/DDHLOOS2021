﻿using System;

namespace C3
{
    abstract class Human : ITransportable
    {
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 0.5;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 0.5;
            }
        }
    }
}