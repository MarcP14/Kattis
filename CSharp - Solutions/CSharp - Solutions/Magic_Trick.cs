using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Magic_Trick
    {
        static void Old_Main(string[] args)
        {
            char[] data = Console.ReadLine().ToCharArray();

            Console.WriteLine(String.Format("{0}", data.Distinct().Count() == data.Count() ? 1 : 0));
        }

    }
}
