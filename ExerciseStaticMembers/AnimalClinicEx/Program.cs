using System;
using System.Collections.Generic;

namespace AnimalClinicEx
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    AnimalClinic.Print();
                    break;
                }
                else
                {
                    string[] result = input.Split(" ");
                    Animal animal = new Animal(result[0], result[1]);
                    if (result[2] == "heal")
                    {
                        AnimalClinic.Healed(animal);
                    }
                    else
                    {
                        AnimalClinic.Rehabilitated(animal);
                    }
                }
            }
            Command();
        }

        static void Command()
        {
            Console.WriteLine("Please choose one of the following commands: heal / rehabilitate");
            string command = Console.ReadLine();

            if (command == "heal")
            {
                AnimalClinic.CommandHealed();
            }
            else
            {
                AnimalClinic.CommandRehabilitated();
            }
        }
    }

    public class Animal
    {
        string name;
        string breed;
        public string Breed { get => breed; }
        public string Name { get => name; }

        public Animal(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"{Name} {Breed}");
        }
    }

    public class AnimalClinic
    {
        static int patientId = 0;
        static int healedAnimalsCount = 0;
        static int rehabilitatedAnimalsCount = 0;
        static List<Animal> healedAnimales = new List<Animal>();
        static List<Animal> rehabilitatedAnimales = new List<Animal>();

        public static void Healed(Animal animal)
        {
            patientId++;
            healedAnimales.Add(animal);
            healedAnimalsCount++;
            Console.WriteLine($"Patient {patientId} [{animal.Name} ({animal.Breed})] has been healed!");
        }

        public static void Rehabilitated(Animal animal)
        {
            patientId++;
            rehabilitatedAnimales.Add(animal);
            rehabilitatedAnimalsCount++;
            Console.WriteLine($"Patient {patientId} [{animal.Name} ({animal.Breed})] has been rehabilitated!");
        }

        public static void Print()
        {
            Console.WriteLine($"Total healed animals: {healedAnimalsCount}");
            Console.WriteLine($"Total rehabilitated animals: {rehabilitatedAnimalsCount}");
        }

        public static void CommandHealed()
        {
            foreach (var item in healedAnimales)
            {
                item.PrintAnimal();
            }
        }

        public static void CommandRehabilitated()
        {
            foreach (var item in rehabilitatedAnimales)
            {
                item.PrintAnimal();
            }
        }
    }
}



/*
Animal Clinic
Define two classes: Animal (name, breed) and AnimalClinic (static field patientId, static field healedAnimalsCount and static field rehabilitedAnimalsCount). 
You will be given animal data (name and breed) and information whether the animal should be healed or rehabilitated. 
Keep track on the rehabilitated animals, on the healed animals and overall patients. 
If the animal has been healed, you need to print on the console the following message:
Patient {patientID} [{name} ({breed})] has been healed!
Otherwise print:
Patient {patientID} [{name} ({breed})] has been rehabilitated!
You will receive information about animals until you receive command “End”.
After you receive command “End” print total healed animals and total rehabilitated animals in format:
Total healed animals: {count}
Total rehabilitated animals: {count}
After that you will receive one of the following commands heal or rehabilitate and you must print all the names and breed of the healed or rehabilitated animals 
in format {name} {breed} each animal on new line.
*/
