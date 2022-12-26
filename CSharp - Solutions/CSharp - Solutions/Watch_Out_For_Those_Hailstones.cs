using System;

namespace CSharp___Solutions
{
    class Watch_Out_For_Those_Hailstones
    {
        static void Old_Main(string[] args)
        {
            Console.WriteLine(hailstone_sequence(Int64.Parse(Console.ReadLine())));
        }

        public static Int64 hailstone_sequence(Int64 n)
        {
            if (n == 1)
                return 1;
            else if (n % 2 == 0)
                return n + hailstone_sequence(n / 2);
            else
                return n + hailstone_sequence(n * 3 + 1);
        }
    }
}
