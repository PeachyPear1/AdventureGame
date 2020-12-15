using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Pastel;

namespace PlayTestAdventureGame
{
    class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        private string PlayerMarker;
        private string PlayerColor;

        public Player(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            PlayerMarker = "O";
            PlayerColor = "#DE0F44";
        }

        public void DrawPlayer()
        {
            SetCursorPosition(X, Y);
            Write(PlayerMarker.Pastel(PlayerColor));
            ResetColor();
        }
    }
}
