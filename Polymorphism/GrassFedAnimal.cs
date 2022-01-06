using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class GrassFedAnimal
    {
        public abstract void DiegestGrass();
        public void EatGrass()
        {
            Console.WriteLine("I am eating grass");
        }

    }
}
