using System;

namespace InterfaceExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen maria = new Citizen("Maria", 30, "Ro");
            //maria.
            IResident mia = new Citizen("Mia", 30, "DN");
            Console.WriteLine(mia.GetName());
            IPerson mara = new Citizen("Mara", 25, "UK");
            Console.WriteLine(mara.GetName());
        }
    }
    class Citizen : IResident, IPerson
    {
        public Citizen(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;

        }
        public string Name { get; }

        public string Country { get; }

        public int Age { get; }

        string IResident.GetName() => "Mr/Ms/Mrs " + Name;

        string IPerson.GetName() => Name;
       
    }
    interface IResident
    {
        string Name { get; }
        string Country { get; }
        string GetName();
    }

    interface IPerson
    {
        string Name { get; }
        int Age { get; }
        string GetName();
    }
}
/*
Create 2 interfaces IResident and IPerson. 
IResident should have a name, country and a method GetName(). 
IPerson should have a name, an age and a method GetName(). 
Create a class Citizen which implements both IResident and IPerson, explicitly declare that IResident’s GetName() method should return “Mr/Ms/Mrs ” 
before the name while IPerson’s GetName() method should return just the name.
*/