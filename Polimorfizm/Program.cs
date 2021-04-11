using System;
using System.Collections.Generic;

namespace Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train("e", 111);
            Console.WriteLine(train);

            List<Vehicle> myVehicles = new List<Vehicle>();
            myVehicles.Add(new Train("electric", 120));
            myVehicles.Add(new Car("hybrid", 200));
            myVehicles.Add(new Bus("electric", 70));
            foreach (Vehicle v in myVehicles) Console.WriteLine(v);

            Ticket t = new Ticket();
            t.BuyTicket();
        }
    }

    public abstract class Vehicle
    {
        public string engine;
        public int velocityLimit;

        public virtual string GetVehicleType()
        {
            return "Unspecified vehicle";
        }

        public override string ToString()
        {
            return "Vehicle type: " + GetVehicleType() + ". Engine: " + engine + ". Velocity limit: " + velocityLimit + " km/h.";
        }
    }

    public class Train : Vehicle
    {
        public override string GetVehicleType()
        {
            return "train";
        }

        public Train(string _engine, int _velocityLimit)
        {
            engine = _engine;
            velocityLimit = _velocityLimit;
        }
    }

    public class Car : Vehicle
    {
        public override string GetVehicleType()
        {
            return "Car";
        }

        public Car(string _engine, int _velocityLimit)
        {
            engine = _engine;
            velocityLimit = _velocityLimit;
        }
    }

    public class Bus : Vehicle
    {
        public override string GetVehicleType()
        {
            return "Bus";
        }

        public Bus(string _engine, int _velocityLimit)
        {
            engine = _engine;
            velocityLimit = _velocityLimit;
        }
    }

    public interface IBuyTicket
    {
        public abstract void BuyTicket();
    }

    public class Ticket : IBuyTicket
    {
        public Ticket() { }
        public void BuyTicket()
        {
            Console.WriteLine("1$ ticket");
        }
    }
}
