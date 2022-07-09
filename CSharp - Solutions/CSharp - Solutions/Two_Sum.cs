using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Two_Sum
    {
        static void Old_Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int result = numbers.Select(x => Int32.Parse(x)).Sum();
            
            Console.WriteLine(String.Format("{0}", result));
        }

    }
}
