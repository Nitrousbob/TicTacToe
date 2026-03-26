using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class Game
    {

        public Player player { get; private set; }  //property to hold the players

        public Game(Player player1, Player player2)
        {
            this.player = player1;
            this.player = player2;
        }

        public void turn()
        {
            Display.showBoard();
        }
    }
}
