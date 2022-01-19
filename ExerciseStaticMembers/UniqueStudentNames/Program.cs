using System;
using System.Collections.Generic;

namespace UniqueStudentNames
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentGroup group = new StudentGroup();
            string name = "";
            
            while (true)
            {
                name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }

                Student student = new Student(name);
                group.AddStudent(student);
            }
            Console.WriteLine(group.CountUnique());
        }
    }

    public class Student
    {
        string name;
        public string Name { get => name; }

        public Student(string name)
        {
            this.name = name;
        }
    }

    public class StudentGroup
    {
        HashSet<string> allUniqueStuents = new HashSet<string>();
        
        public void AddStudent(Student student)
        {
            allUniqueStuents.Add(student.Name);
        }

        public int CountUnique()
        {
            return allUniqueStuents.Count;
        }
    }
}

/*
Unique Student Names
Define class Student containing a single field – name. 
Now Define class StudentGroup with HashSet<String> field that will keep all unique students. 
You are going to receive user input containing student’s names as single parameter on the line until you receive command “End”. 
Create new instances of Students class and keep track of all unique names using static counter within the StudentGroup class. 
Then print the count of unique names.
*/
