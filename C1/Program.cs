using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird b = new Bird();
            b.changeBName("jerzyk");
            b.changeBWeight(2);
            //b.changeAge(3);

            Flamingo f = new Flamingo();
            f.changeFName("american flamingo");
            f.changeFWeight(4);
            //f.changeFAge(6);

            //f.LayEggs(4);
            f.Incubation(6, 1000);
           
            // EX. 5
            //Bird b3 = new Bird("wrona", 2);
        }
    }
    
    class Animal
    {
        public string name;
        protected int weight;
        private int age;

        public Animal() { }
        public Animal(string _name, int _weight)
        {
            name = _name;
            weight = _weight;
        }
    }

    class Bird : Animal
    {
        public int numberOfFeathers;

        public Bird() { }
        public Bird(string _name, int _weight, int _feathers) : base(_name, _weight)
        {
            numberOfFeathers = _feathers;
        }
        public void changeBName(string n)
        {
            name = n;
        }
        public void changeBWeight(int w)
        {
            weight = w;
        }
        //public void changeBAge(int a)
        //{
        //    age = a;
        //}

        public void LayEggs(int number)
        {
            Console.WriteLine("Number of eggs laid: " + number);
        }
    }

    class Flamingo : Bird
    {
        public Flamingo() { }
        public Flamingo(string _name, int _weight, int _feathers) : base(_name, _weight, _feathers) { }     //?

        public void changeFName(string n)
        {
            name = n;
        }
        public void changeFWeight(int w)
        {
            weight = w;
        }
        //public void changeFAge(int a)
        //{
        //    age = a;
        //}

        public void Incubation(int number, int days)
        {
            LayEggs(number);
            Console.WriteLine("Incubation time: " + days);
        }
    }

}