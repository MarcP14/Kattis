using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp___Solutions
{
    class Stopwatch
    {
        static void Main(string[] args)
        {
            int stop_num = int.Parse(Console.ReadLine());

            int number_of_seconds = 0;
            bool sodo = true;

            int zacetek = -1;
            foreach (int num in Enumerable.Range(0, stop_num))
            {
                if (sodo)
                    zacetek = int.Parse(Console.ReadLine());
                else
                    number_of_seconds += int.Parse(Console.ReadLine()) - zacetek;
                
                sodo = !sodo;
            }

            if (sodo)
                Console.WriteLine(number_of_seconds.ToString());
            else
                Console.WriteLine("still running");

        }
    }
}
