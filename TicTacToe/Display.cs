namespace TicTacToe
{
    internal class Display
    {

        public Display()
        {

        }

        public static void showQuestion(Game game)
        {
            Console.WriteLine($"{game.Player1.Name} What square would you like to place your {game.Player1.Mark} on? ");
            string input = Console.ReadLine() ?? "";
        }

        public static void showBoard(Board board) //get the board object in to do work
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
                    if (board.GetSquare(n) == Mark.Empty)
                    {
                        Console.Write($"[{n+1}] ");  //write the numbers for easy selection
                    }
                    else
                    {
                        Console.Write($"[{board.GetSquare(n)}] "); //write the mark that is there
                    }
                    n++;

                }
            }
        }
    }
}
