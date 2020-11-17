using System;
using System.Collections.Generic;
using static System.Console;

namespace PlayTestAdventureGame
{
    class Game
    {
        public static string PlayerName = "";
        static List<string> Inventory = new List<string>();

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
                    Choice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    DisplayCreditInfo();
                    break;
                case 3:
                    EndGame();
                    break;
            }
        }

        private static void DisplayCreditInfo()
        {
            //PLACEHOLDER MESSAGE
            WriteLine("This is the credit section.");
            ReadKey();

        }

        private static void DisplayAboutInfo()
        {
            //PLACEHOLDER MESSAGE
            WriteLine("This is the about section.");
            ReadKey();
        }

        static void Choice()
        {
            Story.Intro();
            Story.LeaveForKirholm();
            Story.ArriveAtKirholm();
            Story.CoachmanDisappears();
            Story.BeachWithCurse();
        }

        public static void EndGame()
        {
            //end of game text
            Item randomItem1 = new Item();
            randomItem1.Name = "Billy";
            randomItem1.Description = "A silly yet cheerful horse.";
            Inventory.Add(randomItem1.Name);
            Console.WriteLine("End of story text here.....");
            Console.WriteLine("Congratulations " + PlayerName + "!");

            Console.WriteLine(PlayerName + " you found some items in your journey:");

            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }
            if (Inventory.Contains("First-Aid Kit"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Congratulations you accomplished the goal! You found the first-aid kit!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("You didn't find the first-aid kit... better luck next time!");
            }
            WriteLine("This is the end of the game.");
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
