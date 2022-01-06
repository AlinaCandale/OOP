using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Flyables
{
    class Toy : IPlayable
    {
        public void Fly()
        {
            Console.WriteLine("Toy - Fly()");
        }

        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
