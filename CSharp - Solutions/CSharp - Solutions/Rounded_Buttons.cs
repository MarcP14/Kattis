using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp___Solutions
{
    class Rounded_Buttons
    {
        static void Old_Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string vrstica;
            List<double> parametri;
            double x, y, w, h, r, m;
            for(int i = 0; i < n; i++)
            {
                vrstica = Console.ReadLine();
                parametri = vrstica.Split(" ").Select( item => double.Parse(item)).ToList();

                x = parametri[0];
                y = parametri[1];
                w = parametri[2];
                h = parametri[3];
                r = parametri[4];

                List<(double x, double y)> tocke = poisci_tocke(parametri);
                tocke = premakni_tocke(tocke, x, y, w, h);
                preveri_tocke(tocke, w, h, r);
            }

        }

        public static List<(double x, double y)> poisci_tocke(List<double> parametri)
        {
            int m = (int)parametri[5];
            List<(double x, double y)> tocke = new List<(double x, double y)>();

            parametri.RemoveRange(0, 6);
            for(int i = 0; i < m; i ++)
            {
                tocke.Add((parametri[0], parametri[1]));
                parametri.RemoveRange(0, 2);
            }
            return tocke;
        }

        public static List<(double x, double y)> premakni_tocke(List<(double x, double y)> tocke, double x, double y, double w, double h)
        {
            tocke = tocke.Select(t => (Math.Abs(t.Item1 - x - w / 2), Math.Abs(t.Item2 - y - h * 1.0 / 2))).ToList();
            return tocke;
        }

        public static void preveri_tocke(List<(double x, double y)> tocke, double w, double h, double r)
        {
            w = w / 2;
            h = h / 2;

            foreach((double, double) tocka in tocke)
            {
                if(tocka.Item1 <= (w -r) && tocka.Item2 <= (h))
                {
                    Console.WriteLine("inside");
                }
                else if(tocka.Item1 <= (w) && tocka.Item2 <= (h - r))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    double t1 = tocka.Item1 - w + r;
                    double t2 = tocka.Item2 - h + r;

                    if (Math.Sqrt(t1*t1+t2*t2)<=r)
                    {
                        Console.WriteLine("inside");
                    }
                    else
                    {
                        Console.WriteLine("outside");
                    }
                }
            }
        }
    }
}
