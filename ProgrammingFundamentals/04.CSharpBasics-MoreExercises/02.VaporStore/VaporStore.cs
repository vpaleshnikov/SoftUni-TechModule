using System;

namespace _02.VaporStore
{
    public class VaporStore
    {
        public static void Main()
        {
            var balance = double.Parse(Console.ReadLine());

            double moneySpent = 0;

            string input;
            while ((input = Console.ReadLine()) != "Game Time")
            {
                if (input == "OutFall 4")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 39.99;
                        balance -= 39.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else if (input == "CS: OG")
                {
                    if (balance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 15.99;
                        balance -= 15.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else if (input == "Zplinter Zell")
                {
                    if (balance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 19.99;
                        balance -= 19.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else if (input == "Honored 2")
                {
                    if (balance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 59.99;
                        balance -= 59.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else if (input == "RoverWatch")
                {
                    if (balance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 29.99;
                        balance -= 29.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 39.99;
                        balance -= 39.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${moneySpent:F2}. Remaining: ${balance:F2}");
        }
    }
}