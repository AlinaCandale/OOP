using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal
    {
        private string favoriteFood;
        private string name;

        public Animal(string favoriteFood, string name)
        {
            this.favoriteFood = favoriteFood;
            this.name = name;
        }

        public virtual void TellAboutYourself()
        {
            Console.WriteLine($"I am animal - {name} and I like to eat {this.favoriteFood}");
        }

    }
}
