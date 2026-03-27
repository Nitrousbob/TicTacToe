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
        public int[,] winLines = 
            {
             {0,1,2}, 
             {3,4,5},
             {6,7,8}, 
             {0,3,6},
             {1,4,7}, 
             {2,5,8},
             {0,4,8}, 
             {2,4,6}
            };

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
            for (int i = 0; i < 8; i++)
            {
                int firstIndex = winLines[i, 0];
                int secondIndex = winLines[i, 1];
                int thirdIndex = winLines[i, 2];

                Mark mark = GetSquare(firstIndex);
                Mark mark2 = GetSquare(secondIndex);
                Mark mark3 = GetSquare(thirdIndex);

                if (mark == Mark.Empty || mark2 == Mark.Empty || mark3 == Mark.Empty)
                {
                    continue; 
                } 
                else if (mark == mark2 && mark == mark3)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsFull()
        {
            for (int i = 0; i < 9; i++)
            {
                if (GetSquare(i) == Mark.Empty)
                { return false;}
            }
            //check if the board is full
            //if all squares are full, there are no more turns
            return true;
        }
    }
}
