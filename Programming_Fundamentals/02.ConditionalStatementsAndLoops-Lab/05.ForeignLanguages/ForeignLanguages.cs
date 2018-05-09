using System;

namespace _05.ForeignLanguages
{
    public class ForeignLanguages
    {
        public static void Main()
        {
            var countryInput = Console.ReadLine().ToLower();

            var language = string.Empty;

            if (countryInput == "england" || countryInput == "usa")
            {
                language = "English";
            }
            else if (countryInput == "spain" || countryInput == "argentina" || countryInput == "mexico")
            {
                language = "Spanish";
            }
            else
            {
                language = "unknown";
            }

            Console.WriteLine(language);
        }
    }
}
