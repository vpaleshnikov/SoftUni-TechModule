using System;
using System.Linq;

namespace _06.ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ",Console.ReadLine().Split().Reverse()));
        }
    }
}
