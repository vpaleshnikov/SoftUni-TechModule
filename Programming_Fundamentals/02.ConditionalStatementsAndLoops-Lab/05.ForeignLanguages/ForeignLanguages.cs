using System;

namespace _05.ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main()
        {
            var country = Console.ReadLine().ToLower();

            if (country == "england" || country == "usa")
            {
                Console.WriteLine("English");
            }
            else if (country == "spain" || country == "argentina" || country == "mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
