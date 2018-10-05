using System;
using System.Linq;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("", Console.ReadLine().ToCharArray().Reverse()));
        }
    }
}
