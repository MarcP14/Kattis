using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp___Solutions
{
    class Turtle_Master
    {
        static void Old_Main(string[] args)
        {
            bool result = true;

            char[][] board = new char[8][];
            for (int i = 0; i < 8; i++)
            {
                board[i] = Console.ReadLine().ToCharArray();
            }

            char[] instructions = Console.ReadLine().ToCharArray();

            (int x, int y) turtle_direction = (0, 1);
            (int x, int y) turtle_position = (7, 0);
            char? next_position_value = null;
            next_position_value = get_facing_field_value(board, turtle_position, turtle_direction);
            foreach (char instruction in instructions)
            {
                next_position_value = get_facing_field_value(board, turtle_position, turtle_direction);
                if (instruction == 'F')
                {
                    if (next_position_value == '.' | next_position_value == 'D')
                    {
                        turtle_position = move_foward(turtle_position, turtle_direction);
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
                else if(instruction == 'R' | instruction == 'L')
                {
                    turtle_direction = change_direction(turtle_direction, instruction);
                }
                else if(instruction == 'X')
                {
                    if (next_position_value == 'I')
                    {
                        destroj_ice_castle(board, turtle_position, turtle_direction);
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }

            if (result && board[turtle_position.x][turtle_position.y] == 'D')
                Console.WriteLine("Diamond!");
            else
                Console.WriteLine("Bug!");

        }

        public static (int x, int y) change_direction((int x, int y) odl_direction, char instructions)
        {
            List<(int x, int y)> all_directions = new List<(int x, int y)> { (0, 1), (1, 0), (0, -1), (-1, 0) };

            int index = all_directions.IndexOf(odl_direction);

            if (instructions == 'R')
            {
                index = (index + 1) % 4;
            }
            else
            {
                index = ((index - 1) + 4) % 4;
            }

            return all_directions[index];
        }

        public static (int x, int y) move_foward((int x, int y) position, (int x, int y) direction)
        {
            return (position.x + direction.x, position.y + direction.y);
        }

        public static void destroj_ice_castle(char[][] board, (int x, int y) position, (int x, int y) direction)
        {
            (int x, int y) next_position = (position.x + direction.x, position.y + direction.y);
            board[next_position.x][next_position.y] = '.';
        }

        public static char? get_facing_field_value(char[][] board, (int x, int y) position, (int x, int y) direction)
        {
            (int x, int y) next_position = (position.x + direction.x, position.y + direction.y);
            if (!(0 <= next_position.x && next_position.x <= 7))
                return null;
            else if (!(0 <= next_position.y && next_position.y <= 7))
                return null;
            else
                return board[next_position.x][next_position.y];
        }
    }
}
