using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class Player
    {
        public string Name { get; private set;  }

        public Player(string name)
        {
            Name = name;
        }
    }
}
