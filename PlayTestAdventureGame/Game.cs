using System;
using System.Collections.Generic;
using static System.Console;
using Pastel;

namespace PlayTestAdventureGame
{
    class Game
    {
        public static string PlayerName = "";
        public static List<string> Inventory = new List<string>();

        private World MyWorld;
        private Player CurrentPlayer;

        public static void StartGame()
        {
            Title = "The Shrouded Shores of Kirholm Point by Hannah Hamilton";
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine(@"            +             /
\           |           /
  \         |         /
    \      / \      /
      \  /_____\  /
      /  |__|__|  \
    /  |;|     |;|  \
  /    \\.    .  /    \
        ||:     |         \
        ||:.    |           \
        ||:    .|
        ||:   , |         /`\
        ||:     |                                          /`\
        ||: _ . |                             /`\
       _||_| |__|                      ____
  ____~    |_|  |___           __-----~    ~`---,__             ___
-~                  ~---___,--~'                  ~~----_____-~'
`~----,____");
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine(String.Format("{0, -10}   {1, -10}", " ", "The Shrouded Shores of"));
            WriteLine(@"
  ,             _         _                , __                  
 /|   /o       | |       | |              /|/  \    o            
  |__/     ,_  | |    __ | |  _  _  _      |___/ __     _  _ _|_ 
  | \  |  /  | |/ \  /  \|/  / |/ |/ |     |    /  \|  / |/ | |  
  |  \_|_/   |_|   |_\__/|__/  |  |  |_/   |    \__/|_/  |  |_|_/
                                                                 
                                                                 
");
            ForegroundColor = ConsoleColor.Red;
            WriteLine(String.Format("{0, -10}   {1, -10}  {2, -10}  {3, -10}", " ", " ", " ", "Press enter to begin!"));
            ResetColor();
            ReadKey();
            Clear();
            RunMainMenu();
        }

        private static void RunMainMenu()
        {
            string prompt = "Welcome to The Shrouded Shores of Kirholm Point. What would you like to do?";
            string directions = "((Use the arrow keys to move up and down through the menu. Press enter to select the current option highlighted.))";
            string[] options = { "Play", "About", "Credits", "Exit" };
            Menu mainMenu = new Menu(prompt, directions, options);
            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    Story.Intro();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    DisplayCreditInfo();
                    break;
                case 3:
                    MainMenuQuit();
                    break;
            }
        }

        public void Maze()
        {
            CursorVisible = false;

            // y = row, x = column
            string[,] grid = LevelParser.ParseFileToArray("Level1.txt");

            MyWorld = new World(grid);

            CurrentPlayer = new Player(1,1);

            MazeLoop();
        }

        private void DrawMaze()
        {
            Clear();
            MyWorld.Draw();
            CurrentPlayer.DrawPlayer();
        }

        private void HandlePlayerInput()
        {
            ConsoleKey key;
            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                key = keyInfo.Key;
            } while (KeyAvailable);

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if(MyWorld.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y - 1))
                    {
                        CurrentPlayer.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X, CurrentPlayer.Y + 1))
                    {
                        CurrentPlayer.Y += 1;
                    }  
                    break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X + 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.X - 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X -= 1;
                    }
                    break;
                default:
                    break;
            }
        }

        private void MazeLoop()
        {
            while (true)
            {
                DrawMaze();
                HandlePlayerInput();

                string elementAtPlayerPos = MyWorld.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y);
                if(elementAtPlayerPos == "X")
                {
                    Story.CurseRevealed();
                    break;
                }

                System.Threading.Thread.Sleep(20);
                //break;
            }
        }

        private static void DisplayCreditInfo()
        {
            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("The Shrouded Shores of Kirholm Point");
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("=====================================");
            ResetColor();
            WriteLine("Credits:");
            WriteLine("Title Screen ASCII Art by Niall from https://www.asciiart.eu/buildings-and-places/lighthouses");
            WriteLine("\nExit Game ASCII Art by jgs from https://www.asciiart.eu/nature/beach");
            WriteLine("\nVillage ASCII Art by Steven Maddison from https://www.asciiart.eu/buildings-and-places/cities");
            WriteLine("\nCastle Pillar with Waves ASCII Art by unknown from https://www.asciiart.eu/buildings-and-places/castles");
            WriteLine("\nMermaid ASCII Art by Joan G. Stark from https://www.asciiart.eu/mythology/mermaids");
            WriteLine("\nThis work is a derivative of 'C# Adventure Game' by http://programmingisfun.com,\nused under CC BY https://creativecommons.org/licenses/by/4.0/");
            WriteLine("\nI followed the video: https://www.youtube.com/watch?v=qAWhGEPMlS8&list=PL-LDQE9x9hLwcBUPLBvPffYFO7AROPAxR&index=12");
            WriteLine("by Michael Hadley to create and understand an interactive menu that is controlled by the arrow keys.");
            WriteLine("\nI followed the videos: https://www.youtube.com/watch?v=T0MpWTbwseg & https://www.youtube.com/watch?v=U623BUA5Jq4");
            WriteLine("by Michael Hadley to create the basis for explorable rooms and buildings.");
            WriteLine("\n'The Shrouded Shores of Kirholm Point' is licensed\nunder https://creativecommons.org/licenses/by-nc/4.0/?ref=chooser-v1 by Hannah Hamilton");
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("\nPress any key to return to the main menu.");
            ResetColor();
            ReadKey();
            RunMainMenu();
        }

        private static void DisplayAboutInfo()
        {
            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("The Shrouded Shores of Kirholm Point");
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("=====================================");
            ResetColor();
            WriteLine("\nAbout:");
            WriteLine("This game is a story-driven mystery that allows the user to make choices and explore areas within the game.");
            WriteLine("The user will type their answers for choices, and use the arrow keys to explore.");
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("\nPress any key to return to the main menu.");
            ResetColor();
            ReadKey();
            RunMainMenu();
        }

        public static void MainMenuQuit()
        {
            Clear();
            string endArt = @"
          |
        \ _ /
      -= (_) =-
        /   \         _\/_
          |           //o\  _\/_
   _____ _ __ __ ____ _ | __/o\\ _
 =-=-_-__=_-= _=_=-=_,-'|""'""""-|-,_
  =- _=-=- -_=-=_,-""          |
    =- =- -=.--""
";
            string endArtColor = "#F0F3A5";
            Write(endArt.Pastel(endArtColor));
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Thanks for playing The Shrouded Shores of Kirholm Point!");
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("\nPress any key to exit.");
            Environment.Exit(0);
        }

        public static void EndGame()
        {
            Clear();
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Thanks for playing The Shrouded Shores of Kirholm Point!\n");
            ResetColor();

            WriteLine(PlayerName + ", you found some items in your journey:");

            foreach (string item in Inventory)
            {
                WriteLine(item);
            }
            if (Inventory.Contains("Mystical Orb"))
            {
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("Congratulations, you accomplished the goal! You saved Kirholm Point from the curse!");
                ResetColor();
            }
            else
            {
                WriteLine("You didn't find the mystical orb... better luck next time!");
            }
            WriteLine("\nThis is the end of the game.");
            ReadKey();
            Environment.Exit(0);
        }

        //First-aid kit will come in handy when you fall and hurt yourself/find another person injured
        //Flashlight will come in handy for navigating in the fog, allowing you to see items you otherwise couldn't

        //Petting them will make you befriend one, which can help you escape Kirholm Point/travel around faster.
        //Not petting them means they all will scatter and none will return.

        //Checking the beach will cause you to find a cave. Inside the cave is an orb spraying out blue light and mist. You need this to break the curse.
        //Not checking the beach will cause you to get to the pedestal with no way to break it. You will be chased by sirens as you leave the pedestal and try to escape.
    }
}
