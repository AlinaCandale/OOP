using System;

namespace EncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person ana = new Person("Ana", -12);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The age can't be negative!");
            }
            Person maria = new Person("Maria", 25);
            Child ionut = new Child("Ionut", 7);
            try
            {
                Child ion = new Child("Ion", 17);
            }
            catch (ArgumentException)
            {

                Console.WriteLine("A child can't be older than 15"); 
            }


        }
    }

    class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            Age = age;
        }

        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("The age can't be negative!");
                }
            }
        }
    }

    class Child : Person
    {
        string name;
        int age;

        public Child(string name, int age) : base(name, age)
        {
            this.name = name;
            Age = age;
        }
        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (value <= 15)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("A child can't be older than 15");
                }
            }
        }
    }
}
/*
People
You are asked to model an application for storing data about people. 
You should be able to have a person and a child. 
The child is derived of the person. 
Your task is to model the application. The only constraints are:
People should not be able to have negative age
Children should not be able to have age more than 15.
• Person – represents the base class by which all others are implemented 
• Child - represents a class which is derived by the Person. 
Validate each member by throwing an ArgumentException.
*/
