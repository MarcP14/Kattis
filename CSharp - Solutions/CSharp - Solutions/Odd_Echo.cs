using System;

namespace CSharp___Solutions
{
    class Odd_Echo
    {
        static void Old_Main(string[] args)
        {
            Console.ReadLine();
            
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                Console.WriteLine(line);
                line = Console.ReadLine();
            }
        }

    }
}
