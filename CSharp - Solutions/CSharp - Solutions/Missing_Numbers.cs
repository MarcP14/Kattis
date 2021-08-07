using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Missing_Numbers
    {
        static void Old_Main (string[] args)
        {
            Console.ReadLine();

            int number;
            int current_number = 0;
            bool error = false;

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                number = int.Parse(line);
                current_number += 1;

                if (number != current_number)
                {
                    error = true;

                    while (current_number < number)
                    {
  
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(current_number.ToString());
                        current_number += 1;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            if (!error) Console.WriteLine("good job");
        }
    }
}
