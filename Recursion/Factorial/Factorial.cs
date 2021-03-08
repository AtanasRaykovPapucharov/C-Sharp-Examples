using System;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        // n! = 1,            n = 0
        // n! = n.(n - 1)!,   n > 0

        static BigInteger FactRecursive(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * FactRecursive(n - 1);
        }

        static BigInteger FactIterative(int n)
        {
            BigInteger result = n;

            for (int i = 1; i < n; i++)
            {
                result *= i;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Recursive: n! = ");
            Console.WriteLine(FactRecursive(n));

            Console.WriteLine();

            Console.Write("Iterative: n! = ");
            Console.WriteLine(FactIterative(n));
        }
    }
}
