using System;

namespace moshExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Image width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            ImageOrientation orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }


        
    }
}
