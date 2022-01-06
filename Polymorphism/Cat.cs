using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Cat : Animal
    {
        public Cat(string favoriteFood, string name) : base(favoriteFood, name)
        {
        }

        public override void TellAboutYourself()
        {
            Console.WriteLine("I am cat");
            base.TellAboutYourself();
        }
    }
}
