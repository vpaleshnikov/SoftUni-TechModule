using System;
using System.Linq;
using System.Text;

namespace _07.MultiplyBigNumbers
{
    class MultiplyBigNumbers
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().TrimStart(new[] { '0' });
            var second = int.Parse(Console.ReadLine());

            if (first == "0" || second == 0 || first == "")
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();

            var sum = 0;
            var number = 0;
            var reminder = 0;

            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = (byte)(byte.Parse(first[i].ToString()) * second + reminder); ;

                number = sum % 10;
                reminder = sum / 10;
                sb.Append(number);

                if (i == 0 && reminder != 0)
                {
                    sb.Append(reminder);
                }
            }
            Console.WriteLine(new string(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
        }
    }
}