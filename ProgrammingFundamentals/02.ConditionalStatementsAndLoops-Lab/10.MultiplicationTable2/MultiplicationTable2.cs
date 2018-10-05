using System;

namespace _10.MultiplicationTable2
{
    public class MultiplicationTable2
    {
        public static void Main()
        {
            var numberInput = int.Parse(Console.ReadLine());
            var multiplierInput = int.Parse(Console.ReadLine());

            var sum = 0;

            if (multiplierInput > 10)
            {
                sum = numberInput * multiplierInput;
                var result = $"{numberInput} X {multiplierInput} = {sum}";
                Console.WriteLine(result);
            }
            else
            {
                for (int i = multiplierInput; i <= 10; i++)
                {
                    sum = numberInput * i;
                    var result = $"{numberInput} X {i} = {sum}";
                    Console.WriteLine(result);
                }
            }
        }
    }
}