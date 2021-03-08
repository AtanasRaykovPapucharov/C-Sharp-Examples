using System;
using System.IO;

namespace _8March
{
    class Girls
    {
        static void Main(string[] args)
        {
            // We have a text file "../../../Girls.txt". On each line there is a girl data formated as "StringName-IntNumber".

            // Read all girls from the text file 
            string[] girls = File.ReadAllLines("../../../Girls.txt");

            // For each girl in girls, split it by '-' and write the result formated as "{StringName} takes {IntNumber} flowers for March 8th.".
            foreach (string gl in girls)
            {
                string[] girl = gl.Split('-');

                Console.WriteLine($"{girl[0]} takes {girl[1]} flowers for March 8th.");
            }
        }
    }
}
