namespace TicTacToe
{
    internal class Game
    {

        public Player Player1 { get; private set; }  //property to hold the players
        public Player Player2 { get; private set; }
        public Board Board { get; private set; } //property to hold the board
        public Player CurrentPlayer { get; internal set; }

        public Game(Player player1, Player player2)
        {
            
            Player1 = player1; //Add player 1 to game
            CurrentPlayer = Player1;  //Start with player 1 at the beginning of the game
            Player2 = player2; //Add player 2 to game
            Board = new Board();  //create a new board
        }

        public void Turn()
        {

            while (true)
            {
                Display.ShowBoard(Board); //send the board object
                int boardSelection = Display.ShowQuestion(this);
                Board.MarkSquare(boardSelection, CurrentPlayer.Mark);
                if (CurrentPlayer == Player1)
                {
                    CurrentPlayer = Player2;
                } 
                else
                {
                    CurrentPlayer = Player1;
                }
                //check win condition, if winner then false
                //change Player
            }
        }
    }
}
