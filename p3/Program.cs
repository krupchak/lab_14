using System;
using System.Collections.Generic;
using System.Linq;

namespace p3
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Students(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            bool end = false;
            while (!end)
            {
                var input = Console.ReadLine().Split(" ");
                if (input.Length == 3)
                {
                    string firstName = input[0];
                    string lastName = input[1];
                    int age = int.Parse(input[2]);
                    students.Add(new Students(firstName, lastName, age));
                }
                else if (input.Length == 1 && input[0] == "END")
                {
                    end = true;
                }
            }

            var student = from s in students
                          where s.Age >= 18 && s.Age <= 24
                          select s;

            foreach (var stud in student)
                Console.WriteLine(stud.FirstName + " " + stud.LastName + " " + stud.Age);
        }
    }
}
