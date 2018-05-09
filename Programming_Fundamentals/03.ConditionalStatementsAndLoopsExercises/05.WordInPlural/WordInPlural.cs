using System;

namespace _05.WordInPlural
{
    public class WordInPlural
    {
        public static void Main()
        {
            var inputWord = Console.ReadLine();

            if (inputWord.EndsWith("y"))
            {
                inputWord = inputWord.Remove(inputWord.Length - 1);
                inputWord += "ies";
            }
            else if (inputWord.EndsWith("o") || inputWord.EndsWith("ch") || inputWord.EndsWith("s")
                || inputWord.EndsWith("sh") || inputWord.EndsWith("x") || inputWord.EndsWith("z"))
            {
                inputWord += "es";
            }
            else
            {
                inputWord += "s";
            }
            Console.WriteLine(inputWord);
        }
    }
}
