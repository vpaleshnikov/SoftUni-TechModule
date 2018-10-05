using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    public class Student
    {
        public string Name { get; set; }

        public List<double> Grade { get; set; }

        public double Average
        {
            get
            {
                return Grade.Average();
            }
        }
        //public double Average => Grades.Average();
    }
    public class AverageGrades
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var studentData = Console.ReadLine().Split(' ').ToList();
                var student = new Student();
                student.Name = studentData[0];
                student.Grade = studentData.Skip(1).Select(double.Parse).ToList();
                students.Add(student);
            }

            //foreach (var student in students.Where(g => g.Average >= 5.00).OrderBy(a => a.Name).ThenByDescending(a => a.Average))
            //{
            //    Console.WriteLine($"{student.Name} -> {student.Average:F2}");
            //}
            students
                .Where(g => g.Average >= 5.00)
                .OrderBy(a => a.Name)
                .ThenByDescending(a => a.Average)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.Average:F2}"));
        }
    }
}
