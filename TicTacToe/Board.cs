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

        public bool MarkSquare(int index, Mark mark)
        {
            if (GetSquare(index) == Mark.Empty)
            {
                board[index] = mark;  //need to remove one for the board to update correctly
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasWinner()
        {
            //check if the board has a winner
            //squares 2,4,5,6,8 have to be used for a win to happen, they are the middle of the 3's
            //if a player has 3 in a row the game is over
            return false;
        }

        public bool IsFull()
        {
            //check if the board is full
            //if all squares are full, there are no more turns
            return false;
        }
    }
}
