using System;

namespace _07.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            Console.WriteLine($"{RaiseToPower(number, power)}");
        }

        static double RaiseToPower(double number, int power)
        {
            var result = 1d;
            for (int i = 1; i <= power; i++)
            {
                result = result * number;
            }
            return result;
        }
    }
}