using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp___Solutions
{
    class Adding_Words
    {
        static void Old_Main(string[] args)
        {
            Dictionary<string, int> defs = new Dictionary<string, int>();

            string line;
            string[] command;
            while ((line = Console.ReadLine()) != null)
            {
                command = line.Split(' ');

                if(command[0] == "def")
                {
                    defs[command[1]] = int.Parse(command[2]);
                }
                else if (command[0] == "clear")
                {
                    defs.Clear();
                }
                else
                {
                    command = command.Skip(1).ToArray();
                    Console.WriteLine(Evaluate(command, defs));
                }
            }
        }

        public static string Evaluate(string[] commands, Dictionary<string, int> defs)
        {
            int current_result;
            int current_operator = 1;
            string result;
            try
            {
                current_result = 0;
                foreach(string command in commands)
                {
                    switch(command)
                    {
                        case "-":
                            current_operator = -1;
                            break;
                        case "+":
                            current_operator = 1;
                            break;
                        case "=":
                            break;
                        default:
                            current_result = current_result + current_operator * defs[command];
                            break;
                    }
                }
                result = defs.Select(item => new { x = item.Key, y = item.Value}).Where(item => item.y == current_result).First().x;
            }
            catch
            {
                result = "unknown";
            }


            return string.Format("{0} {1}", string.Join(" ", commands), result);
        }
    }
}
