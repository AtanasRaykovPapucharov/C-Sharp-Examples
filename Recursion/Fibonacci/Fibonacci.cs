using System;

namespace Fibonacci
{
    class Fibonacci
    {
        // 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 ...
        // n - members count
        static long FibRecusive(int n)
        {
            if (n < 2)
            {
                return 1;
            }

            return FibRecusive(n - 1) + FibRecusive(n - 2);
        }

        static long FibIterative(int n)
        {
            if (n < 2)
            {
                return 1;
            }

            long a = 0;
            long b = 1;
            long c = 1;

            for (int i = 2; i <= n; i++)
            {
                a = b + c;
                c = b;
                b = a;
            }

            return a;
        }

        static void Main(string[] args)

        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            DateTime start = DateTime.Now;

            Console.Write("Recursive: ");
            for (int i = 0; i <= n; i++)
            {
                Console.Write($"{FibRecusive(i)} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Console.Write("Iterative: ");
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.Write($"{FibIterative(i)} ");
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            DateTime end = DateTime.Now;

            Console.WriteLine($"Time: {end.Millisecond - start.Millisecond}ms");
            Console.WriteLine();
        }
    }
}
