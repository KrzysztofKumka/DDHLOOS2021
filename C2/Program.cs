using System;
using System.Collections.Generic;

namespace DDHLOOS_C2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Inhabitant> inhabitantsL = new List<Inhabitant>();
            inhabitantsL.Add(new Civilian(2));
            inhabitantsL.Add(new Civilian(3));
            inhabitantsL.Add(new Crossbowman(6));
            inhabitantsL.Add(new Pikemen(8));

            Console.WriteLine("----- ToString() for all inhabitants -----");
            foreach (Inhabitant i in inhabitantsL) Console.WriteLine(i);                  // ToString function call (for all inhabitants)

            List<Defender> defendersL = new List<Defender>();
            defendersL.Add(new Crossbowman(4));
            defendersL.Add(new Pikemen(5));
            defendersL.Add(new Crossbowman(6));

            //foreach (Inhabitant i in defendersL) Console.WriteLine(i);                 // 2nd ToString function call (for all defenders)

            //List<Defender> crossbowmansL = new List<Defender>();
            //crossbowmansL.Add(new Crossbowman("Crossbowman", 4));
            //crossbowmansL.Add(new Crossbowman("Crossbowman", 6));
            //crossbowmansL.Add(new Crossbowman("Crossbowman", 8));

            List<Crossbowman> crossbowmansL = new List<Crossbowman>();
            crossbowmansL.Add(new Crossbowman(4));
            crossbowmansL.Add(new Crossbowman(6));
            crossbowmansL.Add(new Crossbowman(8));

            //foreach (Inhabitant i in crossbowmansL) Console.WriteLine(i);               // 3rd ToString function call (for crossbowman list)

            Console.WriteLine("\n----- Eat() for all inhabitants -----");
            foreach (Inhabitant i in inhabitantsL) Console.WriteLine("Inhabitant " + i.getStatus() + " eats: " + i.Eat() + " food rations.");                // Eat function call
            
            Console.WriteLine("\n----- ReadyToFight() for all defenders -----");
            foreach (Defender d in defendersL) Console.WriteLine(d.ReadyToFight());                                                                          // ReadyToFight function call (for all defenders)
            
            Console.WriteLine("\n----- ReadyToFight() for crossbowman group -----");
            foreach (Defender d in crossbowmansL) Console.WriteLine(d.ReadyToFight());                                                                       // ReadyToFight function call (only for crossbowman list)

        }
    }

    public abstract class Inhabitant
    {
        public int foodRations;

        public Inhabitant(int _foodRations)
        {
            foodRations = _foodRations;
        }
        public virtual int Eat()    //P1
        {
            return foodRations;
        }
        public virtual string getStatus()
        {
            return "Inhabitant";
        }
        public override string ToString()   //P3
        {
            return "Inhabitant is member of " + getStatus() + " group. Assigned number of food rations:  " + foodRations;
        }
    }

    class Civilian : Inhabitant
    {
        public Civilian(int _foodRations) : base(_foodRations) { }
        public override string getStatus()
        {
            return "Civilian";
        }
    }

    public abstract class Defender : Inhabitant
    {
        public Defender(int _foodRations) : base(_foodRations) { }
        public override string getStatus()
        {
            return "Defender";
        }
        public virtual string ReadyToFight()
        {
            return getStatus() + " is ready to fight.";   //P2
        }
    }

    public class Crossbowman : Defender
    {
        public Crossbowman(int _foodRations) : base(_foodRations) { }
        public override string getStatus()
        {
            return "Crossbowman";
        }
    }

    public class Pikemen : Defender
    {
        public Pikemen(int _foodRations) : base(_foodRations) { }
        public override string getStatus()
        {
            return "Pikemen";
        }
    }
}
