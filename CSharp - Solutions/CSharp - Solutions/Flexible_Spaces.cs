using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp___Solutions
{
    class Flexible_Spaces
    {
        static void Old_Main(string[] args)
        {
            string data = Console.ReadLine().Split(" ")[0];
            data = data + " " + Console.ReadLine();

            List<int> partitions = data.Split(" ").Select(x => int.Parse(x)).ToList();
            partitions.Add(0);
            partitions = partitions.OrderBy(x => x).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < partitions.Count() - 1; i++)
                for (int j = i + 1; j < partitions.Count(); j++)
                    result.Add(partitions[j] - partitions[i]);

            Console.WriteLine(string.Join(" ", result.Distinct().OrderBy(x => x)));
        }

    }
}