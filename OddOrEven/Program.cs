using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            IsOdd();
        }

        public static bool IsOdd()
        {
            int num;

            Console.WriteLine("Enter a number");

            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Your number is even");
                return false;
            }
            else
            {
                Console.WriteLine("Your number is odd");
                return true;
            }
        }
    }
}
