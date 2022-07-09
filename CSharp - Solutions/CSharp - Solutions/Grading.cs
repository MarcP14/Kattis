using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp___Solutions
{
    class Grading

    {
        static void Old_Main(string[] args)
        {
            char[] grades = new char[] { 'A', 'B', 'C', 'D', 'E' };
            char grade = 'F';

            string[] numbers = Console.ReadLine().Split(' ');
            int scored = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 4; i++)
            {
                if (scored >= int.Parse(numbers[4 - i]))
                    grade = grades[4 - i];
                else
                    break;
            }

            Console.WriteLine(String.Format("{0}", grade));
        }

    }
}
