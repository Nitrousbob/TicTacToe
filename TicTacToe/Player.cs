namespace TicTacToe
{
    internal class Player
    {
        public string Name { get; private set; }
        public Mark Mark { get; private set; }

        public Player(string name, Mark mark)
        {
            Name = name;
            Mark = mark;
            
        }
    }
}
