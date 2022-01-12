using System;

namespace CitizenRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen one = new Citizen("alina", new DateTime(1986,10,31));
            Console.WriteLine(one.GetIds());
            Console.WriteLine(one.Age);

            Citizen two = new Citizen("ana", new DateTime(1983,07,30));
            Console.WriteLine(two.GetIds());

            Robot three = new Robot("robo");
            Console.WriteLine(three.GetIds());
        }
    }

    class Mars
    {
        public static int Id = 1;
    }

    class Pets : IAge
    {
        string name;
        public string Name { get => name; }
        public int Age { get { return DateTime.Now.Year - Birthday.Year; } }
        public DateTime Birthday { get; }

        public Pets(string name, DateTime birthday)
        {
            this.name = name;
            Birthday = birthday;
        }
    }
    class Citizen : Mars, IIds, IAge
    {
        string name;
        public string Name { get => name; }
        public int Age { get { return DateTime.Now.Year - Birthday.Year; } }
        public DateTime Birthday { get; }

        public Citizen(string name, DateTime birthday)
        {
            this.name = name;
            Birthday = birthday;
        }
        public int GetIds()
        {
            return Id++;
        }
    }

    class Robot : Mars, IIds
    {
        string model;
        public string Model { get => model; }
        public Robot(string model)
        {
            this.model = model;
        }

        public int GetIds()
        {
            return Id++;
        }
    }

    interface IIds
    {
        int GetIds();
    }

    interface IAge
    {
        int Age { get; }
    }

}

/*
In the future Citizens and Robots will live on the planet Mars as brothers. The only thing that citizens and robots in common is their Ids. 
A Citizen has 2 extra characteristics, age and name. 
A Robot has an extra characteristic, named Model. Define and implement this ‘models’.
*/

/*
It is a well known fact that people celebrate birthdays, it is also known that some people also celebrate their pets’ birthdays. 
Extend the program from your last task to add birthdates to citizens and include a class Pet, pets have a name and a birthdate. 
Encompass repeated functionality into interfaces and implement them in your classes.
*/


