using System;

namespace _06.DNASequences
{
    class DNASequences
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        if (i + j + k >= n)
                        {
                            Console.Write("O");
                            if (i == 1)
                            {
                                Console.Write("A");
                            }
                            if (i == 2)
                            {
                                Console.Write("C");
                            }
                            if (i == 3)
                            {
                                Console.Write("G");
                            }
                            if (i == 4)
                            {
                                Console.Write("T");
                            }
                            if (j == 1)
                            {
                                Console.Write("A");
                            }
                            if (j == 2)
                            {
                                Console.Write("C");
                            }
                            if (j == 3)
                            {
                                Console.Write("G");
                            }
                            if (j == 4)
                            {
                                Console.Write("T");
                            }
                            if (k == 1)
                            {
                                Console.Write("A");
                            }
                            if (k == 2)
                            {
                                Console.Write("C");
                            }
                            if (k == 3)
                            {
                                Console.Write("G");
                            }
                            if (k == 4)
                            {
                                Console.Write("T");
                            }
                            Console.Write("O");
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("X");
                            if (i == 1)
                            {
                                Console.Write("A");
                            }
                            if (i == 2)
                            {
                                Console.Write("C");
                            }
                            if (i == 3)
                            {
                                Console.Write("G");
                            }
                            if (i == 4)
                            {
                                Console.Write("T");
                            }
                            if (j == 1)
                            {
                                Console.Write("A");
                            }
                            if (j == 2)
                            {
                                Console.Write("C");
                            }
                            if (j == 3)
                            {
                                Console.Write("G");
                            }
                            if (j == 4)
                            {
                                Console.Write("T");
                            }
                            if (k == 1)
                            {
                                Console.Write("A");
                            }
                            if (k == 2)
                            {
                                Console.Write("C");
                            }
                            if (k == 3)
                            {
                                Console.Write("G");
                            }
                            if (k == 4)
                            {
                                Console.Write("T");
                            }
                            Console.Write("X");
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
