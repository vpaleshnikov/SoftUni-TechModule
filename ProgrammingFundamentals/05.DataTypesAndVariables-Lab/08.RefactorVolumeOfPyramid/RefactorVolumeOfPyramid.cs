using System;

namespace _08.RefactorVolumeOfPyramid
{
    class RefactorVolumeOfPyramid
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            var lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var volume = double.Parse(Console.ReadLine());
            volume = (lenght * width * volume) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
