using System;

namespace moshExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);

        }

        
    }
}
