using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsEx
{
    class Animal : ISoundProduceable
    {
        private string name;
        private int age;
        private Genders gender;

        public string Name { get => name; }
        public Genders Gender { get => gender; }
        public int Age { get => age; }

        public Animal(string name, int age, Genders gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public virtual void ProduceSound()
        {
            Console.WriteLine("some sound");
        }

        public void Print()
        {
            if (name == "" || age < 0)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine(this.GetType().Name);
                Console.WriteLine($"{Name} {Age} {Gender}");
                ProduceSound();
            }
        }
    }
}
