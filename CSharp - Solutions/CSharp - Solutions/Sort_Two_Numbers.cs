using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Sort_Two_Numbers
    {
        static void Old_Main (string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            var result = numbers.OrderBy(x => Int32.Parse(x)).Aggregate((partialPhrase, word) => String.Format("{0} {1}", partialPhrase, word));
            Console.WriteLine(String.Format("{0}", result));
        }

    }
}
