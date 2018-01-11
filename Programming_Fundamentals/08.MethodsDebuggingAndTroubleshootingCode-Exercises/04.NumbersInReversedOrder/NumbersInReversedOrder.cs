using System;
using System.Linq;

namespace _04.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            ReverseNumber(number);
        }

        static void ReverseNumber(string number)
        {
            string result = string.Join("", number.Reverse());
            Console.WriteLine(result);
        }
    }
}
