using System;
using System.Collections.Generic;
using System.Linq;

namespace p5
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailUsername { get; set; }
        public string EmailDomain { get; set; }

        public Students(string firstName, string lastName,  string emailUsername, string emailDomain)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailUsername = emailUsername;
            this.EmailDomain = emailDomain;
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
                    var input1 = input[2].Split('@');
                    string username = input1[0];
                    string domain = input1[1];
                    students.Add(new Students(firstName, lastName, username, domain));
                }
                else if (input.Length == 1 && input[0] == "END")
                {
                    end = true;
                }
            }

            var student = from s in students
                          where s.EmailDomain == "gmail.com"
                          select s;

            foreach (var stud in student)
                Console.WriteLine(stud.FirstName + " " + stud.LastName + " " + stud.EmailUsername);
        }
    }
}
