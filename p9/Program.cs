using System;
using System.Collections.Generic;
using System.Linq;

namespace p9
{
    class Students
    {
        public string FacultyNumber { get; set; }
        public int[] Excellent { get; set; }

        public Students(string facultyNumber, int[] excellent)
        {
            this.FacultyNumber = facultyNumber;
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
                if (input.Length >= 2)
                {
                    string facultyNumber = input[0];
                    int[] excellent = new int[input.Length - 2];
                    for (int i = 0; i < excellent.Length; i++)
                    {
                        excellent[i] = int.Parse(input[i + 2]);
                    }
                    students.Add(new Students(facultyNumber, excellent));
                }
                else if (input.Length == 1 && input[0] == "END")
                {
                    end = true;
                }
            }

            var student = from s in students
                          where s.FacultyNumber.EndsWith("14") || s.FacultyNumber.EndsWith("15")
                          select s;

            foreach (var stud in student)
                Console.WriteLine(stud.FacultyNumber);
        }
    }
}
