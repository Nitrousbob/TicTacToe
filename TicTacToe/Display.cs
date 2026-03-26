using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class Display
    {

        public Display()
        {

        }


        public static void showBoard()
        {
            int n = 0;

            for (int i = 0; i < 3; i++)
            {
                //Console.WriteLine($"[{n}]");
                if (i == 0)
                {

                }
                else
                {
                    Console.Write("\n");
                }
                
                
                for (int j = 0; j < 3; j++)
                {
                    if (board.Mark[n] == Board.Mark.Empty)
                    {
                        Console.Write($"[{n}] ");  //write the numbers for easy selection
                    }
                    else
                    {
                        Console.Write($"{Board.Mark[n]}"); //write the mark that is there
                    }
                    n++;

                }
            }
        }
    }
}
