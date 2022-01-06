using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("everything", "Mitzi");
            cat.TellAboutYourself();

            GrassFedAnimal genericAnimal = new Sheep();
            genericAnimal.EatGrass();
            genericAnimal.DiegestGrass();
        }
    }
}
