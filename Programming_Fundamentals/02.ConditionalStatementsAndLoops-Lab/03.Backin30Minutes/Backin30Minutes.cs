using System;

namespace _03.Backin30Minutes
{
    public class Backin30Minutes
    {
        public static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;
            
            if (minutes > 59)
            {
                hours++;
                minutes = minutes - 60;
            }
            if (hours > 23)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
