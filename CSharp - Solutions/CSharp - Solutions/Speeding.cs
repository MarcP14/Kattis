using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Speeding
    {
        static void Old_Main (string[] args)
        {
            Console.ReadLine();
            Console.ReadLine();

            int max_speed = 0;

            int t = 0;
            int d = 0;

            string line;
            string[] data;

            while ((line = Console.ReadLine()) != null)
            {
                data = line.Split(' ');
                t = int.Parse(data[0]) - t;
                d = int.Parse(data[1]) - d;

                if (d/t > max_speed)
                    max_speed = d / t;

                t = int.Parse(data[0]);
                d = int.Parse(data[1]);

            }
            Console.WriteLine(String.Format("{0}", max_speed));
        }

    }
}
