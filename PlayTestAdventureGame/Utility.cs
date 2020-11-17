using System;
using static System.Console;

namespace PlayTestAdventureGame
{
    class Utility
    {
        public static void Continue()
        {
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("\nPress enter to continue the story...");
            ResetColor();
            ReadKey();
        }
    }
}
