﻿using System;

namespace CONNECT_FOUR_GAME_MS
{
    abstract class Player
    {
        public string Name { get; set; }
        public char Symbol { get; set; }


        public Player(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }
     public abstract int GetMove(Board board);
    }
}
