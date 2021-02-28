using System;

namespace CSharp___Solutions
{

    //Identifying Map Tiles
    class Identifying_Map_Tiles
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Tuple<int, int> result = Koordinates(input);
            Console.WriteLine(input.Length.ToString() + " " + result.Item1 + " " + result.Item2 );
            
        }

        public static Tuple<int, int> Koordinates(string quadkey)
        {
            int len = quadkey.Length;
            if (len == 1)
            {
                switch (quadkey)
                {
                    case "0":
                        return Tuple.Create(0, 0);
                    case "1":
                        return Tuple.Create(1, 0);
                    case "2":
                        return Tuple.Create(0, 1);
                    default:
                        return Tuple.Create(1, 1);
                }
            }
            else
            {
                
                Tuple<int, int> koordinates1 = Koordinates(quadkey.Substring(0, 1)); 
                Tuple<int, int> koordinates2 = Koordinates(quadkey.Substring(1, len - 1));

                int x = (int)Math.Round(koordinates1.Item1 * Math.Pow(2, (len - 1))  + koordinates2.Item1 ,0 );
                int y = (int)Math.Round(koordinates1.Item2 * Math.Pow(2, (len - 1)) + koordinates2.Item2, 0);

                return Tuple.Create(x, y);
            }
        }
    }

}
