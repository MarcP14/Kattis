using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Odd_Gnome
    {
        static void Old_Main (string[] args)
        {
            Console.ReadLine();

            string line;
            int[] genomes, genomes_ordered, genomes_compare;
            while ((line = Console.ReadLine()) != null)
            {
                genomes = line.Split(' ').Skip(1).Select(genom => int.Parse(genom)).ToArray();
                genomes_ordered = genomes.Where(genom => genom >= genomes.First()).OrderBy(genom => genom).ToArray();

                genomes_compare = genomes.Zip(genomes_ordered, (g1, g2) => g2 == g1? 1:0).ToArray();
                Console.WriteLine(Array.IndexOf(genomes_compare, 0)+1);
            }


        }

    }
}
