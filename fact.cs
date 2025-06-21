using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a number as an argument.");
                return;
            }

            if (int.TryParse(args[0], out int number))
            {
                if (number < 0)
                {
                    Console.WriteLine("Factorial is not defined for negative numbers.");
                    return;
                }
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }
    }
}