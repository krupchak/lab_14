using System;
using System.Collections.Generic;
using System.Linq;

namespace p1
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupNumber { get; set; }

        public Students (string firstName, string lastName, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.GroupNumber = groupNumber;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students> ();

            bool end = false;
            while (!end)
            {
                var input = Console.ReadLine().Split(" ");
                if (input.Length == 3)
                {
                    string firstName = input[0];
                    string lastName = input[1];
                    int groupNumber = int.Parse(input[2]);   
                    students.Add(new Students(firstName, lastName, groupNumber));
                }
                else if (input.Length == 1 && input[0] == "END")
                {
                    end = true;
                }
            }

            var student = from s in students
                          where s.GroupNumber == 2
                          orderby s.FirstName
                          select s;

            foreach(var stud in student)
            Console.WriteLine(stud.FirstName + " " + stud.LastName);
        }
    }
}
