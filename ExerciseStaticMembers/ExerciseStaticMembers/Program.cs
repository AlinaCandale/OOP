using System;

namespace ExerciseStaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            while (true)
            {
                name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                else
                {
                    Student student = new Student(name);
                }
            }
            Console.WriteLine(Student.nrOfStudents);
        }
    }

    public class Student
    {
        string name;
        public static int nrOfStudents = 0;

        public Student(string name)
        {
            this.name = name;
            nrOfStudents++;
        }
    }
}


/*
Problem 1. Students
Define class Student. Add string field for a student’s name that you are going to receive as a console input. 
Then add a static Integer field to keep track of how many students’ instances are created. 
Initialize the static field with 0 (zero) and increment in the constructor. 
When you receive command “End” stop reading more students names and print their total count on the console.
*/
