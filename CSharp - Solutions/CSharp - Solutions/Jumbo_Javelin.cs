using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Jumbo_Javelin
    {
        static void Old_Main (string[] args)
        {
            int[] dolzine = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < dolzine.Length; i++)
            {
                dolzine[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(dolzine.Sum()-dolzine.Count()+1);
        }

    }
}
