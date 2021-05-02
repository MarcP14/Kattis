using System;

namespace CSharp___Solutions
{
    class Laptop_Sticker
    {
        static void Old_Main (string[] args)
        {
            string[] vrstica = Console.ReadLine().Split(' ');
            
            if(int.Parse(vrstica[0])> int.Parse(vrstica[2]) + 1 && int.Parse(vrstica[1]) > int.Parse(vrstica[3])+1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }

    }
}
