using System;
using System.Text;
using System.Threading;

namespace DateTimeExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Console.CursorVisible = false;

            //Console.WriteLine(now.DayOfWeek);
            //Console.WriteLine(now.Day);
            //Console.WriteLine(now.Year);
            //Console.WriteLine(now.Hour);
            //Console.WriteLine(now.Minute);
            //Console.WriteLine(now.Second);


            while (true)
            {
                Console.SetCursorPosition(0, 0);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("hour ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" min");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" sec");

                Console.ForegroundColor = ConsoleColor.Black; 

                Console.WriteLine($" {now.Hour} | {now.Minute} | {now.Second} ");

                Thread.Sleep(1000);

                now = DateTime.Now;

                Console.Clear();
            }
        }
    }
}
