namespace TicTacToe
{
    enum Mark
    {
        Empty, X, O
    }

    internal class Board
    {
        //keeps track of the 3x3 board
        //Knows which ones are empty and which ones are occupied by the players marks

        private Mark[] board = new Mark[9];
        
        public Board()
        {
        }
        
        public Mark GetSquare(int index)
        {
            return board[index];
        }

    }
}
