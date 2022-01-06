using System;

namespace Encaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("2861031", "Maria", "Popescu");
            Console.WriteLine(person.Cnp);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.Salary);

            person.GetMarried("Ionescu");
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.Salary);
        }
    }
}
