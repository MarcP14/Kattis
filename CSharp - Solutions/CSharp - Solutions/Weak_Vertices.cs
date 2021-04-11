using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp___Solutions
{
    class Weak_Vertices
    {
        static void Main(string[] args)
        {
            int vertex_num;

            while ((vertex_num = int.Parse(Console.ReadLine()))!=-1)
            {
                Dictionary<int, List<int>> sosedi = new Dictionary<int, List<int>>();

                foreach (int num in Enumerable.Range(0, vertex_num))
                {
                    sosedi.Add(num, poisci_sosede(num, Console.ReadLine()));
                }

                string output = "";
                foreach (int num in Enumerable.Range(0, vertex_num))
                {
                    if (!preveri_pogoje(num, sosedi))
                        output += num + " ";
                }

                Console.WriteLine(output.Trim());
            }
        }

        public static List<int> poisci_sosede(int line_num, string line)
        {
            List<int> result = new List<int>();

            line = line.Replace(" ", "");
            int index = 0;

            while((index = (line.IndexOf("1"))) != -1)
            {
                result.Add((result.Count==0?0:result.Last()+1) + index);
                line = line.Substring(index+1);
            }

            return result;
        }

        public static bool preveri_pogoje(int line_num, Dictionary<int, List<int>> sosedi)
        {
            foreach (int sosed1 in sosedi[line_num].SkipLast(1))
            {
                foreach (int sosed2 in sosedi[line_num].Where(sosed => sosed>sosed1))
                {
                    if (sosedi[sosed1].Contains(sosed2))
                        return true;
                }
            }

            return false;
        }
    }
}

