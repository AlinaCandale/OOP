using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitClass
{
    public class Mammal
    {
        public string food; 

        public Mammal(string food)
        {
            this.food = food;
        }

        public virtual void Moves()
        {
            Console.WriteLine("I am a Mammal and I move");
        }

        public virtual void Sleeps()
        {
            Console.WriteLine("I am a Mammal and I sleep");
        }

        public virtual void Eats()
        {
            Console.WriteLine($"I am a Mammal and I eat {food}");
        }
    }
}

