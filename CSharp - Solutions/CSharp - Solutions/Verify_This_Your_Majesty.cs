using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp___Solutions
{
    class Verify_This_Your_Majesty
    {
        static void Old_main(string[] args)
        {
            bool result = false;

            int n = int.Parse(Console.ReadLine());
            List<(int x, int y)> vse_kraljice = new List<(int x, int y)>();

            List<int> pozicija;
            (int x, int y) nova_kraljica;
            for(int i = 0; i < n; i++)
            {
                pozicija = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
                nova_kraljica = (pozicija[0], pozicija[1]);

                result = preveri_novo_kraljico(vse_kraljice, nova_kraljica);
                if (result)
                    vse_kraljice.Add(nova_kraljica);
                else
                    break;
            }

            if (result)
                Console.WriteLine("CORRECT");
            else
                Console.WriteLine("INCORRECT");
        }

        public static bool preveri_novo_kraljico(List<(int x, int y)> vse_kraljice, (int x, int y) nova_kraljica)
        {
            if (vse_kraljice.Where(x => x.Item1 == nova_kraljica.Item1 || x.Item2 == nova_kraljica.Item2).Any())
                return false;
            else if (vse_kraljice.Where(x => x.Item1 - nova_kraljica.Item1 == x.Item2 - nova_kraljica.Item2).Any())
                return false;
            else if (vse_kraljice.Where(x => x.Item1 + x.Item2 == nova_kraljica.Item1 + nova_kraljica.Item2).Any())
                return false;
            else
                return true;
        }

    }
}
