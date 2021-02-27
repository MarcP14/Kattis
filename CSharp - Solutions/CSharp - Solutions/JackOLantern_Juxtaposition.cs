using System;

namespace CSharp___Solutions
{
    class JackOLantern_Juxtaposition
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Console.WriteLine(zmnozi(input).ToString());
        }

        public static int zmnozi(string[] list)
        {
            int result = 1;
            foreach(string number in list)
            {
                result = result * int.Parse(number);
            }

            return result;
        }
    }
}
