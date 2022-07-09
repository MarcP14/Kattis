using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp___Solutions
{
    class Which_is_Greater
    {
        static void Old_Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            List<int> result = numbers.Select(x => Int32.Parse(x)).ToList();

            if (result[0] > result[1])
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }

    }
}
