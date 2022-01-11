using System;

namespace ZooEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal black = new Horse("black", "carrots");
            Horse white = new Horse("white", "apple");
            Lion sleepy = new Lion("sleepy", "humanFlesch");

            Zoo cluj = new Zoo("Cluj");
            cluj.Bring(black);
            cluj.Bring(sleepy);
            cluj.Bring(white);
            cluj.PrintAnimalList();

            cluj.Transfer(sleepy);
            cluj.Transfer(white);
            cluj.PrintAnimalList();

        }
    }
}

/*
Model a ZOO keeping in mind that:
A zoo has a name and a list of animals
At a zoo they can bring new animals and transfer animals to new zoos
At a zoo the animals are daily fed with their favorite food, and each animal eats what it loves to eat.
Each animal knows to eat by itself, and not all animals of the same type prefer the same type of food. Eg; a horse prefers carrots, and another horse prefers apples
*/
