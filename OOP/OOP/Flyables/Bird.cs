using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Flyables
{
    sealed class Bird : Mammal, IPlayable //daca vrem ca Bird sa nu poata fi mostenita
    {
        public void Fly()
        {
            Console.WriteLine("Bird - Fly()");
        }

        public void Nest()
        {

        }
    }
}
