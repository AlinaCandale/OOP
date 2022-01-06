using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Mammal
    {
        //private int size; - de facut Enum
        private decimal weight;
        private string name;


        public void Eat()
        {
            Console.WriteLine("I am a mammal and I Eat");
        }
        public void Move()
        {
            Console.WriteLine("I am a mammal and I Move");
        }
        public void Talk()
        {
            Console.WriteLine("I am a mammal and I 'Talk'");
        }
        public void Sleep()
        {
            Console.WriteLine("I am a mammal and I Sleep");
        }

        protected void SaySomething()
        {
            Console.WriteLine("Say Something");
        }
    }
}
