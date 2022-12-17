using System;
using System.Collections.Generic;
using System.Linq;

namespace p7
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Excellent { get; set; }

        public Students(string firstName, string lastName, int[] excellent)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            Excellent = excellent;
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
                if (input.Length >= 3)
                {
                    string firstName = input[0];
                    string lastName = input[1];
                    int[] excellent = new int[input.Length - 2];
                    for (int i = 0; i < excellent.Length; i++)
                    {
                        excellent[i] = Convert.ToInt32(input[i + 2]);
                    }
                    students.Add(new Students(firstName, lastName, excellent));
                }   
                else if (input.Length == 1 && input[0] == "END")
                {
                    end = true;
                }
            }

            var student = from s in students
                          where s.Excellent.Where(e => e == 6).Any()
                          select s;

            foreach (var stud in student)
                Console.WriteLine(stud.FirstName + " " + stud.LastName);
        }
    }
}
