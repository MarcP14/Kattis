using System;

namespace CSharp___Solutions
{
    class Finding_An_A
    {
        static void Old_Main(string[] args)
        {
            string stringWithA = Console.ReadLine();
            int indexA = stringWithA.IndexOf("a");
            
            Console.WriteLine(String.Format("{0}", stringWithA.Substring(indexA)));
        }

    }
}
