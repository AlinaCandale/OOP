using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooEx
{
    class Zoo
    {
        string name;
        List<Animal> animalsList = new List<Animal>();

        public Zoo(string name)
        {
            this.name = name;
        }

        public void Bring(Animal animal)
        {
            animalsList.Add(animal);
        }

        public void Transfer(Animal animal)
        {
            animalsList.Remove(animal);
        }

        public void PrintAnimalList()
        {
            Console.WriteLine("Our Zoo has the following animals");
            foreach (var item in animalsList)
            {
                Console.WriteLine(item.GetType().Name);
            }
        }
    }
}