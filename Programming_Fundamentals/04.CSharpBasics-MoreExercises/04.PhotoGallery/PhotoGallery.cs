using System;

namespace _04.PhotoGallery
{
    public class PhotoGallery
    {
        public static void Main()
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var sizeInBytes = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D4} {hours:D2}:{minutes:D2}");
            
            if (sizeInBytes >= 1000 && sizeInBytes < 1000000)
            {
                sizeInBytes = sizeInBytes / 1000;
                Console.WriteLine($"Size: {sizeInBytes}KB");
            }
            else if (sizeInBytes >= 1000000)
            {
                sizeInBytes = sizeInBytes / 1000000;
                Console.WriteLine($"Size: {sizeInBytes}MB");
            }
            else
            {
                Console.WriteLine($"Size: {sizeInBytes}B");
            }

            if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (width < height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
        }
    }
}