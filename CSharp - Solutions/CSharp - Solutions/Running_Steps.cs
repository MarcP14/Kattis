using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Running_Steps
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());

            int S, max_x, min_x;
            long ways;
            for(long i = 1; i <= K; i++)
            {
                S = int.Parse(Console.ReadLine().Split(" ")[1]);

                max_x = S / 4;
                min_x = (int)Math.Ceiling((S - (S / 6) * 2) / 4.0);

                ways = (long)Enumerable.Range(min_x, max_x - min_x + 1)
                    .Select(x => new { x = x, y = (S - 4 * x) / 2 })
                    .Select(k => Math.Pow(
                        Izracun(k.x, k.y), 2))
                    .Sum();

                Console.WriteLine(string.Format("{0} {1}", i, ways));
            }
        }

        public static long Izracun(int n, int m)
        {
            var k = Enumerable.Range(n + 1, m).OrderByDescending(x => x).ToArray();

            int result = 1;
            int d = m;
            foreach (int i in k)
            {
                result = result * i;
                int o = result % d;
                while (o == 0 && 1<d)
                {
                    result = result / d;
                    d -= 1;
                    o = result % d;
                }
            }

            while (1 < d)
            {
                result = result / d;
                d -= 1;
            }

            return result;
        }
    }
}
