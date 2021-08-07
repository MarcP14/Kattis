using System;
using System.Collections;
using System.Linq;

namespace CSharp___Solutions
{
    class Black_Friday
    {
        static void Old_Main(string[] args)
        {
            Console.ReadLine();

            try
            {
                var win = Console.ReadLine().Split(' ')
                    .Select((item, index) => new { Value = item, Zaporedna = index })
                    .GroupBy(item => item.Value, item => item.Zaporedna, (baseValue, Zaporedne) => new { Key = baseValue, Count = Zaporedne.Count(), Zaporedna = Zaporedne.Min() }) //enake številke skupaj
                    .Where(item => item.Count == 1) // samo unique
                    .OrderByDescending(item => item.Key) //urediti po vrsti padajoče
                    .First().Zaporedna ;//najvušja unique
                Console.WriteLine(win + 1);
            }
            catch
            {
                Console.WriteLine("none");
            }
        }

    }
}
