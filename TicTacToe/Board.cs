namespace TicTacToe
{
    internal class Board
    {
        //keeps track of the 3x3 board
        //Knows which ones are empty and which ones are occupied by the players marks

        internal enum Mark
        {
            Empty, X, O
        }

        private Mark[] board = new Mark[9];
        private int boardIndex = 0;

        public Board()
        {
            for (int i = 0;  i < 9; i++) 
                { 
                board[i] = new Mark(); 
                }
        }
        

    }
}
