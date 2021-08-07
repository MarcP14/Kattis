using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharp___Solutions
{
    class Booking_a_Room
    {
        static void Old_Main (string[] args)
        {
            int[] data = Console.ReadLine().Split(' ').Select(item => int.Parse(item)).ToArray();

            int[] proste_sobe = Enumerable.Range(1, data[0]).ToArray();

            string line;
            while((line = Console.ReadLine()) != null)
            {
                proste_sobe = proste_sobe.Where(item => item.ToString() != line).ToArray();
            }

            if (proste_sobe.Count() == 0)
            {
                Console.WriteLine(string.Format("too late"));
            }
            else
            {
                int prosta_soba = proste_sobe.First();
                Console.WriteLine(string.Format("{0}", prosta_soba));
            }

        }
    }
}
