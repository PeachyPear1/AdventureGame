using System;
using static System.Console;

//Author: Hannah Hamilton
//Date of Creation: 09/08/2020
//Credits: ASCII Art by Niall from https://www.asciiart.eu/buildings-and-places/lighthouses
/* This work is a derivative of
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 * 
 * I followed the video: https://www.youtube.com/watch?v=qAWhGEPMlS8&list=PL-LDQE9x9hLwcBUPLBvPffYFO7AROPAxR&index=12
 * by Michael Hadley to create and understand an interactive menu that is controlled by the arrow keys.
 * 
 * "The Shrouded Shores of Kirholm Point" is licensed under
 * https://creativecommons.org/licenses/by-nc/4.0/?ref=chooser-v1 by Hannah Hamilton
 */

namespace PlayTestAdventureGame
{
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Game.EndGame();
        }
    }
}
