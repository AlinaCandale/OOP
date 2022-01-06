using System;

namespace AnimalsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Platypus lulu = new Platypus("Lulu");
            lulu.Swim();
            Console.WriteLine("My name is {0} and I can have a speed of {1} km/hour.", lulu.Name, lulu.GetSpeed()); 
        }
    }

    interface IFly
    {
        void Fly();
    }
    interface ISwim
    {
        void Swim();
    }
    interface IWalk
    {
        void Walk();
    }
    interface ICrowl
    {
        void Crowl();
    }
}

/*
Make an application where to model animals, keeping in mind that:
any kind you model is an animal
any animal has a name

there are multiple animal categories like : mammals, fish, birds, reptile, insects
no matter the category, animal are : flying, walking, swim or crawl.
depending on the way they move, they have a maximum speed.

there are animals that can swim and walk (Platypus)
there are animals that can swim, fly and walk (Wild Duck)
Not any animal that can fly is a bird, the bat is a mammal that flys, 
and not evey bird flys - the ostrich is a bird but doesn't fly
*/