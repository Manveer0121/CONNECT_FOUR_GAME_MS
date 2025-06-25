using System;


namespace CONNECT_FOUR_GAME_MS
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer(string name, char symbol) : base(name, symbol) { }

        public override int GetMove(Board board)
        {
            for (int col = 0; col < 7; col++)
            {

                if (!board.IsColumnFull(col))
                {
                    Console.WriteLine($"{Name} ({Symbol}) Chooses Column {col + 1}");
                    return col;
                }
            }

            return -1;
        }
    }
}
