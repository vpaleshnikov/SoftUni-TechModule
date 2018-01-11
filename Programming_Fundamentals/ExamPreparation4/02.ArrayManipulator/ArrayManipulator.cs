using System;
using System.Linq;

namespace _02.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var inputTokens = input.Split();
                var command = inputTokens[0];

                if (command == "exchange")
                {
                    var index = int.Parse(inputTokens[1]);

                    if (index >= 0 && index < numbers.Length)
                    {
                        numbers = Exchange(numbers, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    
                }

                else if (command == "max")
                {
                    var index = IndexOfMaxElement(numbers, inputTokens[1]);
                    if (index < 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }

                else if (command == "min")
                {
                    var index = IndexOfMinElement(numbers, inputTokens[1]);

                    if (index < 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }

                else if (command == "first")
                {
                    var count = int.Parse(inputTokens[1]);

                    if (count >= 0 && count <= numbers.Length)
                    {
                        Console.WriteLine($"[{string.Join(", ", FirstElements(numbers, count, inputTokens[2]))}]");
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }

                else if (command == "last")
                {
                    var count = int.Parse(inputTokens[1]);

                    if (count >= 0 && count <= numbers.Length)
                    {
                        Console.WriteLine($"[{string.Join(", ", LastElements(numbers, count, inputTokens[2]))}]");
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
        private static int[] LastElements(int[] numbers, int count, string v)
        {
            var result = new int[numbers.Length];

            if (v == "even")
            {
                var evens = numbers.Where(n => n % 2 == 0).ToArray();
                result = evens.Reverse().Take(count).Reverse().ToArray();

            }
            else if (v == "odd")
            {
                var evens = numbers.Where(n => n % 2 != 0).ToArray();
                result = evens.Reverse().Take(count).Reverse().ToArray();
            }

            return result;
        }
        private static int[] FirstElements(int[] numbers, int count, string v)
        {
            var result = new int[numbers.Length];

            if (v == "even")
            {
                var evens = numbers.Where(n => n % 2 == 0).ToArray();
                result = evens.Take(count).ToArray();

            }
            else if (v == "odd")
            {
                var evens = numbers.Where(n => n % 2 != 0).ToArray();
                result = evens.Take(count).ToArray();
            }

            return result;
        }
        private static int IndexOfMinElement(int[] numbers, string v)
        {
            var min = 0;
            var index = -1;

            if (v == "even")
            {
                var evens = numbers.Where(n => n % 2 == 0).ToArray();

                if (evens.Length < 1)
                {
                    return index = -1;
                }
                else
                {
                    min = evens.Min();
                    index = numbers.ToList().LastIndexOf(min);
                }
            }
            else if (v == "odd")
            {
                var odds = numbers.Where(n => n % 2 != 0).ToArray();

                if (odds.Length < 1)
                {
                    return index = -1;
                }
                else
                {
                    min = odds.Min();
                    index = numbers.ToList().LastIndexOf(min);
                }
            }

            return index;
        }
        private static int IndexOfMaxElement(int[] numbers, string v)
        {
            var max = 0;
            var index = -1;

            if (v == "even")
            {
                var evens = numbers.Where(n => n % 2 == 0).ToArray();

                if (evens.Length < 1)
                {
                    return index = -1;
                }
                else
                {
                    max = evens.Max();
                    index = numbers.ToList().LastIndexOf(max);
                }
            }
            else if (v == "odd")
            {
                var odds = numbers.Where(n => n % 2 != 0).ToArray();

                if (odds.Length < 1)
                {
                    return index = -1;
                }
                else
                {
                    max = odds.Max();
                    index = numbers.ToList().LastIndexOf(max);
                }
            }

            return index;
        }
        private static int[] Exchange(int[] numbers, int index)
        {
            
            var firstDigits = numbers.Take(index + 1).ToArray();
            var lastDigits = numbers.Skip(index + 1).ToArray();

            return numbers = lastDigits.Concat(firstDigits).ToArray();
        }
    }
}