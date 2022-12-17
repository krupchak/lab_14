using System;
using System.Collections.Generic;
using System.Linq;

namespace p2
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Students(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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
                if (input.Length == 2)
                {
                    string firstName = input[0];
                    string lastName = input[1];
                    students.Add(new Students(firstName, lastName));
                }
                else if (input.Length == 1 && input[0] == "END")
                {
                    end = true;
                }
            }

            var student = students.OrderBy(s => s.LastName).OrderByDescending(s => s.FirstName);

            foreach (var stud in student)
                Console.WriteLine(stud.FirstName + " " + stud.LastName);
        }
    }
}
