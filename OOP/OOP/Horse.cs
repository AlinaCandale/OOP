using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Horse : Mammal
    {
        public void Run()
        {
            Console.WriteLine("Horse - I run");
        }

        //redefine something in the parent class
        public new void Talk()
        {
            Console.WriteLine("I am a horse and I 'Talk'");
        }

    }
}
