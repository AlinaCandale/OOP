using System;
using System.Linq;
using System.Collections.Generic;

namespace AnimalsEx
{
    enum Genders
    {
        Male,
        Female
    }

    class Program
    {
        static Genders StringToGender(string gender)
        {
            if (gender == "male" || gender == "MALE" || gender == "Male")
            {
                return Genders.Male;
            }

            return Genders.Female;
        }

        static void Main(string[] args)
        {
            string type = "";
            List<Animal> myAnimals = new List<Animal>();
            while (true)
            {
                Console.WriteLine("Please select one of the following Animal Types : " +
                       "\"Dog, Frog, Cat, Kitten or Tomcat\"");
                type = Convert.ToString(Console.ReadLine());
                if (type == "Beast!")
                {
                    break;
                }
                Console.WriteLine("Please enter name, age and gender");
                string detailes = Convert.ToString(Console.ReadLine());
                string[] animalsDetailes = detailes.Split(" ");
                myAnimals = CreateAnimalList(type, animalsDetailes, myAnimals);
            }
            PrintAnimals(myAnimals);
        }

        static List<Animal> CreateAnimalList(string type, string[] animalsDetailes, List<Animal> myAnimals)
        {
            switch (type)
            {
                case "Dog":
                    myAnimals.Add(new Dog(animalsDetailes[0], Convert.ToInt32(animalsDetailes[1]), StringToGender(animalsDetailes[2])));
                    break;
                case "Frog":
                    myAnimals.Add(new Frog(animalsDetailes[0], Convert.ToInt32(animalsDetailes[1]), StringToGender(animalsDetailes[2])));
                    break;
                case "Cat":
                    myAnimals.Add(new Cat(animalsDetailes[0], Convert.ToInt32(animalsDetailes[1]), StringToGender(animalsDetailes[2])));
                    break;
                case "Kitten":
                    myAnimals.Add(new Kitten(animalsDetailes[0], Convert.ToInt32(animalsDetailes[1])));
                    break;
                case "Tomcat":
                    myAnimals.Add(new Tomcat(animalsDetailes[0], Convert.ToInt32(animalsDetailes[1])));
                    break; 
            }

            return myAnimals;
        }

        static void PrintAnimals(List<Animal> myAnimals)
        {
            foreach (var item in myAnimals)
            {
                item.Print();
                Console.WriteLine();
                //if (item.Name == "" || item.Age < 0)
                //{
                //    Console.WriteLine("Invalid input!");
                //}
                //else
                //{
                //    Console.WriteLine(item.GetType().Name);
                //    Console.WriteLine($"{item.Name} {item.Age} {item.Gender}");
                //    item.ProduceSound();
                //}
            }
        }
    }
}
