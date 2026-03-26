namespace TicTacToe
{
    internal class Game
    {

        public Player Player1 { get; private set; }  //property to hold the players
        public Player Player2 { get; private set; }
        public Board Board { get; private set; } //property to hold the board

        public Game(Player player1, Player player2)
        {
            Player Player1 = player1; //Add player 1 to game
            Player Player2 = player2; //Add player 2 to game
            Board = new Board();  //create a new board
        }

        public void Turn(Game game)
        {
            Display.showBoard(Board); //send the board object
            Display.showQuestion(game);
        }
    }
}
