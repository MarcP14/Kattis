using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Rating_Problems
    {
        static void Old_Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');

            int number_of_judges = int.Parse(data[0]);
            int number_of_judges_known_rates = int.Parse(data[1]);

            int known_rates_sum = 0;

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                known_rates_sum += int.Parse(line);
            }

            Console.WriteLine(String.Format("{0} {1}"
                , (known_rates_sum + -3.0 * (number_of_judges- number_of_judges_known_rates))/ number_of_judges
                , (known_rates_sum + 3.0 * (number_of_judges - number_of_judges_known_rates))/ number_of_judges));
        }
    }
}
