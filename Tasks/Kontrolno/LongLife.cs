using System;

namespace LongLife
{
    class LongLife
    {
        static void Main()
        {
            int currentYear = 2021;

            // We have a years int array
            int[] years = new int[] { 1944, 681, 2000, 1989, 2012, 33, 2030 };

            // Find the smallest year
            int smallestYear = years[0];

            for (int i = 1; i < years.Length; i++)
            {
                if (years[i] < smallestYear)
                {
                    smallestYear = years[i];
                }
            }

            // Write result
            Console.WriteLine($"If I was born in { smallestYear }, now I would be { currentYear - smallestYear } years old");
        }
    }
}
