using System;

namespace _08.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"First name: {Console.ReadLine()}");
            Console.WriteLine($"Last name: {Console.ReadLine()}");
            Console.WriteLine($"Age: {int.Parse(Console.ReadLine())}");
            Console.WriteLine($"Gender: {char.Parse(Console.ReadLine())}");
            Console.WriteLine($"Personal ID: {double.Parse(Console.ReadLine())}");
            Console.WriteLine($"Unique Employee number: {double.Parse(Console.ReadLine())}");
        }
    }
}