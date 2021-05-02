using System;

namespace CSharp___Solutions
{
    class Greedy_Polygons
    {
        static void Old_Main (string[] args)
        {
            int koliko = int.Parse(Console.ReadLine());

            string[] polygon;
            for (int i = 0; i < koliko; i++)
            {
                polygon = Console.ReadLine().Split();
                int n = int.Parse(polygon[0]);
                int s = int.Parse(polygon[1]);
                int r = int.Parse(polygon[2]) * int.Parse(polygon[3]);

                Console.WriteLine(izracunaj_poscino_n_kotnika(n, s) + izracunaj_ploscino_razsiritve(n, s, r));
            }
        }

        public static double izracunaj_poscino_n_kotnika(int n, int s)
        {
            double R = Math.Sqrt(Math.Pow(s, 2) / (2 * (1 - Math.Cos(2*Math.PI/n))));
            return n * (0.5) * Math.Pow(R, 2) * Math.Sin(2 * Math.PI / n);
        }

        public static double izracunaj_ploscino_razsiritve(int n, int s, double r)
        {
            return n * r * s + Math.PI * Math.Pow(r, 2);
        }
    }
}
