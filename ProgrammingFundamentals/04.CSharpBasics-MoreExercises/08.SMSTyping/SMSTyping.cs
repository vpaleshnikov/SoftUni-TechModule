﻿using System;

namespace _08.SMSTyping
{
    public class SMSTyping
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        Console.Write(" ");
                        break;
                    case 2:
                        Console.Write("a");
                        break;
                    case 22:
                        Console.Write("b");
                        break;
                    case 222:
                        Console.Write("c");
                        break;
                    case 3:
                        Console.Write("d");
                        break;
                    case 33:
                        Console.Write("e");
                        break;
                    case 333:
                        Console.Write("f");
                        break;
                    case 4:
                        Console.Write("g");
                        break;
                    case 44:
                        Console.Write("h");
                        break;
                    case 444:
                        Console.Write("i");
                        break;
                    case 5:
                        Console.Write("j");
                        break;
                    case 55:
                        Console.Write("k");
                        break;
                    case 555:
                        Console.Write("l");
                        break;
                    case 6:
                        Console.Write("m");
                        break;
                    case 66:
                        Console.Write("n");
                        break;
                    case 666:
                        Console.Write("o");
                        break;
                    case 7:
                        Console.Write("p");
                        break;
                    case 77:
                        Console.Write("q");
                        break;
                    case 777:
                        Console.Write("r");
                        break;
                    case 7777:
                        Console.Write("s");
                        break;
                    case 8:
                        Console.Write("t");
                        break;
                    case 88:
                        Console.Write("u");
                        break;
                    case 888:
                        Console.Write("v");
                        break;
                    case 9:
                        Console.Write("w");
                        break;
                    case 99:
                        Console.Write("x");
                        break;
                    case 999:
                        Console.Write("y");
                        break;
                    case 9999:
                        Console.Write("z");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}