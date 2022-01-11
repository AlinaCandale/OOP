using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooEx
{
    public class Animal
    {
        string name;
        string favoriteFood;

        public string Name { get => name; }
        public string FavoriteFood { get => favoriteFood; }

        public Animal(string name, string favoriteFood)
        {
            this.name = name;
            this.favoriteFood = favoriteFood;
        }
        public void Eat(string favoriteFood)
        {
            Console.WriteLine($"I eat my favorite food, {favoriteFood}");
        }

        public void Print()
        {
            Console.WriteLine($"I am {Name} and I love to eat {FavoriteFood}");
        }
    }
}
