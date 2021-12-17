using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Flyables
{
    class Plane : IPlayable
    {
        public void Fly()
        {
            Console.WriteLine("Plane - Fly()");        
        }
    }
}
