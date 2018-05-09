using System;

namespace _11.FiveDifferentNumbers
{
    public class FiveDifferentNumbers
    {
        public static void Main()
        {
            var firstNumberInput = int.Parse(Console.ReadLine());
            var secondNumberInput = int.Parse(Console.ReadLine());

            bool isValid = false;

            for (int n1 = firstNumberInput; n1 <= secondNumberInput; n1++)
            {
                for (int n2 = n1; n2 <= secondNumberInput; n2++)
                {
                    for (int n3 = n2; n3 < secondNumberInput; n3++)
                    {
                        for (int n4 = n3; n4 < secondNumberInput; n4++)
                        {
                            for (int n5 = n4; n5 <= secondNumberInput; n5++)
                            {
                                if (firstNumberInput <= n1
                                    && n1 < n2
                                    && n2 < n3
                                    && n3 < n4
                                    && n4 < n5
                                    && n5 <= secondNumberInput)
                                {
                                    isValid = true;

                                    if (isValid)
                                    {
                                        Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!isValid)
            {
                Console.WriteLine("No");
            }
        }
    }
}