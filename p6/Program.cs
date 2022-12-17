using System;
using System.Collections.Generic;
using System.Linq;

namespace p6
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public Students(string firstName, string lastName, string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
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
                    string phone = input[2];
                    students.Add(new Students(firstName, lastName, phone));
                }
                else if (input.Length == 1 && input[0] == "END")
                {
                    end = true;
                }
            }

            var student = from s in students
                          where s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592")
                          select s;

            foreach (var stud in student)
                Console.WriteLine(stud.FirstName + " " + stud.LastName);
        }
    }
}
