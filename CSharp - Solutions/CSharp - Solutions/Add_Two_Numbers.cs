using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Add_Two_Numbers
    {
        static void Old_Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int result = numbers.Select(x => Int32.Parse(x)).Sum();
            
            Console.WriteLine(String.Format("{0}", result));
        }

    }
}
