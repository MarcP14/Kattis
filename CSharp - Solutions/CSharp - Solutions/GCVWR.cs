using System;
using System.Linq;

namespace CSharp___Solutions
{
    class GCVWR
    {
        static void Old_Main(string[] args)
        {
            string[] GCVWR_and_T = Console.ReadLine().Split(' ');

            int towing_capacity = (int.Parse(GCVWR_and_T[0]) - int.Parse(GCVWR_and_T[1])) / 10 * 9;
            int item_weight_sum = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).Sum();
            int result = towing_capacity - item_weight_sum;

            Console.WriteLine(String.Format("{0}", result));
        }

    }
}
