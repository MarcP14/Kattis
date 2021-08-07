using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Train_Passengers
    {
        static void Odl_Main(string[] args)
        {
            int[] train = Console.ReadLine().Split(' ').Select(item => int.Parse(item)).Append(0).ToArray();

            int station_num = 0;
            string line;
            int[] station;
            bool result = true;
            while (result && station_num < train[1] && (line = Console.ReadLine()) != null)
            {
                station_num += 1;
                station = line.Split(' ').Select(item => int.Parse(item)).ToArray();


                if (train_try_leave(train, station[0]) && train_try_enter(train, station[0], station[1]))
                {
                    train = train_change(train, station[0], station[1]);
                }
                else
                {
                    result = false;
                }

                if (!train_check_stay(train, station[2]))
                {
                    result = false;
                }

                if ((train[2] != 0 || station[2] != 0) && station_num == train[1])
                {
                    result = false;
                }

                //Console.WriteLine(string.Format("{0} {1}", train[2] , result));
            }

            if (result)
                Console.WriteLine("possible");
            else
                Console.WriteLine("impossible");
        }

        public static bool train_try_leave(int[] train, int left)
        {
            if (left <= train[2])
                return true;
            else
                return false;
        }
        public static bool train_try_enter(int[] train, int left, int entered)
        {
            if (train[2] - left + entered <= train[0])
                return true;
            else
                return false;
        }
        public static int[] train_change(int[] train, int left, int entered)
        {
            train[2] = train[2] - left + entered;

            return train;
        }


        public static bool train_check_stay(int[] train, int stayed)
        {
            int s = train[2] + stayed;

            if (train[2] != train[0] && stayed > 0)
                return false;
            else
                return true;
        }
    }
}