namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tic - Tac - Toe";
            Console.WriteLine("Welcome to Tic - Tac - Toe!");
            
            //create two players and start the game
            Player[] players = new Player[2];
                        
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Player {i+1}, What is your name? ");
                string playername = Console.ReadLine() ?? "";
                if (i == 0)
                { players[i] = new Player(playername, Mark.X); }
                else { players[i] = new Player(playername, Mark.O); } 
            }

            Game game = new Game(players[0], players[1]);
            game.Turn(game);
        }
    }
}
