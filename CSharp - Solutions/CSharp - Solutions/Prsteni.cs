using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Prsteni
    {
        static void Old_Main (string[] args)
        {
            Console.ReadLine();
            int[] radii = Console.ReadLine().Split(' ').Select(item => int.Parse(item)).ToArray();
            Tuple<int,int>[] razmerja = radii.Select(item => reduce_fraction(new Tuple<int,int>(radii[0],item))).ToArray();
            razmerja = razmerja.Skip(1).ToArray();

            foreach (Tuple<int, int> fraction in razmerja)
            {
                Console.WriteLine(string.Format("{0}/{1}", fraction.Item1, fraction.Item2));
            }
        }

        private static Tuple<int, int> reduce_fraction(Tuple<int, int> fraction)
        {
            int gcd = GDC(fraction.Item1, fraction.Item2);

            return new Tuple<int, int>(fraction.Item1 / gcd, fraction.Item2 / gcd);
        }

        public static int GDC(int num1, int num2)
        {
            int difference;
            while ((difference = Math.Abs(num1 - num2)) > 0)
            {
                num1 = Math.Min(num1, num2);
                num2 = difference;
            }

            return num1;
        }
    }
}
