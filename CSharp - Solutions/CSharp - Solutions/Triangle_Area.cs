using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp___Solutions
{
    class Triangle_Area
    {
        static void Old_Main(string[] args)
        {
           List<int> input = Console.ReadLine().Split(" ").Select(x =>  int.Parse(x)).ToList();

            Console.WriteLine(input[0]*input[1]/2.0);
        }

    }
}
