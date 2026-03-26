using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class Game
    {

        public Player Player { get; private set; }  //property to hold the players

        public Board Board { get; private set; } //property to hold the board
        public Game(Player player1, Player player2, Board Board)
        {
            Player Player1 = player1;
            Player Player2 = player2;
            Board = new Board();  //create a new board
        }

        public void turn()
        {
            Display.showBoard(Board); //send the board object
        }
    }
}
