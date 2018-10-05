using System;
using System.Linq;

namespace _06.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                string.Join(" ",Console.ReadLine()
                .Split()
                .Select(e => new string(e.Reverse().ToArray()))
                .Sum(e => int.Parse(e))));   
        }
    }
}
