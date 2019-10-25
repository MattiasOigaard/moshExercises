using System;

namespace moshExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 10: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        static void Exercise2()
        {
            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
