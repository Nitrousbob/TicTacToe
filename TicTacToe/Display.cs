namespace TicTacToe
{
    internal class Display
    {

        public Display()
        {

        }

        public static int ShowQuestion(Game game)
        {
            Console.WriteLine($"\n{game.Player1.Name} What square would you like to place your \"{game.Player1.Mark}\" on? ");
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Please enter an available number.");
            }
            return value;
        }

        public static void ShowBoard(Board board) //get the board object in to do work
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
