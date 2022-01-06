using System;

namespace RabbitClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit(Eyes.Black, Fur.Brown, Gender.Male, new DateTime(2020,10,01), "carrots");
            rabbit.Moves();
            rabbit.Sleeps();
            rabbit.Eats();
            Console.WriteLine(rabbit.Age);
        }
    }
}

//Model the Rabbit class knowing that:

//a rabbit can have Blue, Red or Black eyes
//a rabbit's fur can be white, brown, black or grey
//it has a gender
//has a birth date, and based on that you should be able to see how
//old the rabbit is
//we also know that a rabbit is a mammal that moves, sleeps and eats certain foods
