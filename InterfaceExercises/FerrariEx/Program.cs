using System;

namespace FerrariEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferrari myCar = new Ferrari(2020);
            Console.WriteLine(myCar.model);
            myCar.Accelerate();
            myCar.Brak();
        }
    }

    class Ferrari : ICar
    {
        public string model;
        public int fabricationYear;

        public Ferrari(int fabricationYear)
        {
            this.model = "488-Spider";
            this.fabricationYear = fabricationYear;
        }
        public void Accelerate()
        {
            Console.WriteLine("Wruuuuuuummmmm!");
        }

        public void Brak()
        {
            Console.WriteLine("Brakes!");
        }
    }

    interface ICar
    {
        void Brak();
        void Accelerate();
    }
}
/*
Model an application which contains a class Ferrari and an interface. Your Ferrari should have functionality to use brakes and push the gas pedal. 
When the brakes are pushed down print "Brakes!", and when the gas pedal is pushed down - "Wruuuuuuummmmm!". 
This functionality is typical for all cars, so you should implement an interface to describe it. You also should have a Model propery for your Ferrari. 
Your class should have a constructor.

Make sure that your Ferrari Model is only "488-Spider" There is no need to read input from console. 
Just make sure you instantiate and populate the class with everything it needs to be valid. 
*/