using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaps
{
    class Person
    {
        private readonly string cnp;
        private string firstName;
        private string lastName;
        private decimal salary;

        public Person(string cnp, string firstName, string lastName)
        {
            this.cnp = cnp;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = 1000;
        }

        public string Cnp { get => cnp; }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string FullName { get { return firstName + " " + lastName; } }
        public decimal Salary { get => salary; }

        private void IncreaseSalary()
        {
            this.salary = this.salary * (decimal)1.3;
        }

        public void GetMarried(string newLastName)
        {
            this.lastName = newLastName;
            this.IncreaseSalary();
            Console.WriteLine("Congrats, you got a bonus!");
        }
    }
}
