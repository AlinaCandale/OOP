using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsEx
{
    class Kitten: Cat
    {
        public Kitten(string name, int age) : base(name, age, Genders.Female)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
