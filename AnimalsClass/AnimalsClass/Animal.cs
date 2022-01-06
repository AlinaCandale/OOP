using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsClass
{
    public class Animal
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public Animal(string name)
        {
            this.name = name;
        }
    }

    public abstract class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
            Console.WriteLine("I am mammal.");
        }
        public abstract int GetSpeed();
    }

    public abstract class Fish : Animal
    {
        public Fish(string name) : base(name)
        {
            Console.WriteLine("I am fish.");
        }
        public abstract int GetSpeed();
    }

    public abstract class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
            Console.WriteLine("I am bird.");
        }
        public abstract int GetSpeed();
    }
    public abstract class Reptile : Animal
    {
        public Reptile(string name) : base(name)
        {
            Console.WriteLine("I am reptile.");
        }
        public abstract int GetSpeed();
    }
    public abstract class Insect : Animal
    {
        public Insect(string name) : base(name)
        {
            Console.WriteLine("I am Insect.");
        }
        public abstract int GetSpeed();
    }

    public class Platypus : Mammal, ISwim, IWalk
    {
        public Platypus(string name) : base(name) { }
        public void Swim()
        {
            Console.WriteLine("I am a Platypus and I can swim");
        }

        public override int GetSpeed()
        {
            return 30;
        }

        public void Walk()
        {
            Console.WriteLine("I am a Platypus and I can walk");
        }
    }

    public class WildDuck : Bird, ISwim, IFly, IWalk
    {
        public WildDuck(string name) : base(name) { }
        public void Swim()
        {
            Console.WriteLine("I am a WildDuck and I can swim");
        }
        public void Fly()
        {
            Console.WriteLine("I am a WildDuck and I can fly");
        }

        public override int GetSpeed()
        {
            return 40;
        }

        public void Walk()
        {
            Console.WriteLine("I am a WildDuck and I can walk");
        }
    }

    public class Bat : Mammal, IFly
    {
        public Bat(string name) : base(name) { }
        public void Fly()
        {
            Console.WriteLine("I am a Bat and I can fly");
        }

        public override int GetSpeed()
        {
            return 20;
        }
    }

    public class Ostrich : Bird, IWalk
    {
        public Ostrich(string name) : base(name) { }
        public void Walk()
        {
            Console.WriteLine("I am a ostrich and I can walk");
        }

        public override int GetSpeed()
        {
            return 10;
        }
    }
}
