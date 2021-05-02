using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Forced_Choice
    {
        static void Old_Main (string[] args)
        {
            string[] pravila_igre = Console.ReadLine().Split(' ');
            string P = pravila_igre[1];

            for (int i = 0; i < int.Parse(pravila_igre[2]); i++)
            {
                if (Console.ReadLine().Split().Skip(1).ToArray().Contains(P))
                    Console.WriteLine("KEEP");
                else
                    Console.WriteLine("REMOVE");
            }
        }

    }
}
