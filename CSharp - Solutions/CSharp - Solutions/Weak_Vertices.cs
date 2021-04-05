using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp___Solutions
{
    class Weak_Vertices
    {
        static void Old_Main(string[] args)
        {
            string line;
            int vertex_num = int.Parse(Console.ReadLine());
            List<string[]> sosedi = new List<string[]>();

            foreach (int num in Enumerable.Range(0, vertex_num))
            {
                sosedi.Add(Console.ReadLine().Split(' '));
            }

        }

        public static bool ima_vsaj_dva_soseda(string vozlisce, int st_vozlisc)
        {
            vozlisce = vozlisce.Replace("0", "");
            return vozlisce.Length >= (2 + st_vozlisc - 1);
        }


    }
}

