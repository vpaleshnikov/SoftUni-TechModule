using System;

namespace _05.TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            var fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine($"{ConvertFahrenheitToCelsius(fahrenheit):F2}");
        }

        static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}