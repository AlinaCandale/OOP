using OOP.Flyables;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Eat();
            mammal.Move();
            mammal.Sleep();
            mammal.Talk();

            Horse horse = new Horse();
            horse.Talk();
            horse.Run();

            Mammal horseAsMammal = horse;
            //vad doar metodele din mammal
            horseAsMammal.Eat();
            if (horse is Mammal)
            {
                var smallMammal = (Mammal)horse; //downcasting
            }


            Bird bird = new Bird();
            bird.Fly();
            bird.Nest();

            IPlayable fly = bird;
            fly.Fly(); //doar la functia Fly am acces

            Plane plane = new Plane();
            plane.Fly();

            Toy toy = new Toy();
            toy.Fly();
        }
    }
}
