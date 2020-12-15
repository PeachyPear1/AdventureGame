using System;
using static System.Console;
using Pastel;

namespace PlayTestAdventureGame
{
    class Story : Game
    {
        public static int ending = 0;

        public static void Intro()
        {
            Clear();
            int packing = 0;
            string result = "";
            WriteLine("One day, on a calm midsummer evening, you recieve a letter in the mail from your dear friend Russell.\nYou read over the envelope, discovering that Russell was inviting you over for a short vacation!\n'Just a few days, you've earned it!' as he had written. You smile slightly as you consider his offering.");
            Utility.Continue();
            WriteLine("\nA few summers ago, you had visited Russell in his rural town of Kirholm Point.\nIt was a cheery little town with a population of 100.\nEveryone there knew one another and it provided a unique yet friendly experience.");
            Utility.Continue();
            WriteLine("\nAfter mulling it over a cup of tea, you came to the conclusion that you shall go.");
            Utility.Continue();
            WriteLine("\nWhile packing, you realized you were running out of room and only had space for one more item.");
            Utility.Continue();
            WriteLine("\nWill you pack the");
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("1.) first-aid kit");
            ResetColor();
            WriteLine("or the");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("2.) emergency flashlight?");
            ResetColor();
            while (packing == 0)
            {
                result = ReadLine();
                switch (result)
                {
                    case "1":
                        Inventory.Add("First-Aid Kit");
                        WriteLine("You chose the first-aid kit.");
                        WriteLine("You highly doubted you would need a flashlight, considering you were going to be in a town, not the woods.");
                        Utility.Continue();
                        packing = 1;
                        break;
                    case "2":
                        Inventory.Add("Emergency Flashlight");
                        WriteLine("You chose the emergency flashlight.");
                        WriteLine("Despite the first-aid kit seeming more logical, you assumed most people had the common sense to have\nmedical supplies for emergencies. You are extra prepared for anything with a flashlight!");
                        Utility.Continue();
                        packing = 1;
                        break;

                    default:
                        WriteLine("Please type the number 1 or 2.");
                        break;
                }
            }
            if (packing == 1)
            {
                LeaveForKirholm();
            }
        }

        static void LeaveForKirholm()
        {
            Clear();
            int leaving = 0;
            string horse = "";
            WriteLine("The day to go finally arrives after a peaceful sleep. Little did you know how that peace was about to be shattered...\nYour coachman approaches your home and knocks on the door, with horses behind him standing idle.\n'Hello, ah... uhm.. What was your name again? My apologies.'");
            ForegroundColor = ConsoleColor.Green;
            Write("\nEnter your name here: ");
            PlayerName = ReadLine();
            while(PlayerName == "")
            {
                WriteLine("Please enter a name.");
                PlayerName = ReadLine();
            }
            ResetColor();
            WriteLine($"\n'Oh, that's right! {PlayerName}! You're heading to Kirholm Point, correct?'");
            WriteLine("You nod your head, the weight of your suitcase in hand becoming apparent.");
            Utility.Continue();
            WriteLine("\n'Well then, hand me your luggage and climb on in to the coach!'\nYou hand over your suitcase and walk over to the horses.");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Do you pet them? Y or N.");
            while (leaving == 0)
            {
                horse = ReadLine();
                horse = horse.ToUpper();
                switch (horse)
                {
                    case "Y":
                        WriteLine("You chose to pet the horses.");
                        ResetColor();
                        WriteLine("\nOne of the horses seemed to appreciate the pets more than the others. You turn and ask the coachman about the horse.");
                        Item randomHorse = new Item();
                        Inventory.Add(randomHorse.Name);
                        Utility.Continue();
                        WriteLine("\nYou and the horse exchange one last look, a sort of friendship now established, before hopping onto the coach.");
                        Utility.Continue();
                        leaving = 1;
                        break;
                    case "N":
                        WriteLine("You chose not to pet the horses.");
                        ResetColor();
                        Utility.Continue();
                        leaving = 1;
                        break;
                    default:
                        WriteLine("Please type either Y or N.");
                        break;
                }
            }
            if (leaving == 1)
            {
                ArriveAtKirholm();
            }
        }

        static void ArriveAtKirholm()
        {
            Clear();
            ForegroundColor = ConsoleColor.DarkRed;
            Write(@"~         ~~          __
       _T      .,,.    ~--~ ^^
 ^^   // \                    ~
      ][O]    ^^      ,-~ ~
   /''-I_I         _II____
__/_  /   \ ______/ ''   /'\_,__
  | II--'''' \,--:--..,_/,.-{ },
; '/__\,.--';|   |[] .-.| O{ _ }
:' |  | []  -|   ''--:.;[,.'\,/
'  |[]|,.--'' '',   ''-,.    |
  ..    ..-''    ;       ''. '");
            ResetColor();
            WriteLine("\n\n\nTime passes...");
            Utility.Continue();
            Clear();
            WriteLine("As you approach the small village, you and the coachman notice a thick fog spanning across the entirety of the area.\n'That's strange...I don't remember anything about there being a storm here...' mutters the coachman.\nYou, too, are alaramed.");
            Utility.Continue();
            WriteLine("\nDespite the uneasiness in the air, the horses continue trotting along towards the town.\nUpon arrival, the two of you look around and see nobody.\nYou are now beginning to grow fearful. Where was Russell?\nSurely, he would have been waiting for you.");
            Utility.Continue();
            WriteLine("\nYou tell the coachman to wait here and that you were going to check inside the nearest building for assistance.\nYour eyes settle on the general store. With a slight sense of urgency, you walk over and pull open the door.");
            Utility.Continue();
            WriteLine("\nAll the lights were turned off, and once again, there was not a single person in sight.\n'Hello?!' you call out in desperation.");
            Utility.Continue();

            CoachmanDisappears();
        }

        static void CoachmanDisappears()
        {
            Clear();
            WriteLine("No one responds. Silence lingers in the air. You try to make out if there were any light switches,\nbut the dark in combination with the fog was too much to tell.");
            Utility.Continue();
            WriteLine("\nYou turn back and exit the building. You begin to speak, 'This is wrong... we should-'\nTo your dismay, you quickly realize the coachman was gone. And so were the horses.");
            Utility.Continue();
            WriteLine("\nAn eerie silence grows the longer you stand there in shock. You try to process what could\npossibly be going on. Was this some elaborate prank?");
            WriteLine("It must be!... Right?");
            Utility.Continue();
            WriteLine("\nFrom what little you remembered of the layout of the village, you attempted to make your way to Russell's home.");
            WriteLine("After roaming through the abandoned town for a bit, you finally recognize one of the quaint cottages.\nIt was Russell's place! You were glad to go inside somewhere familiar, as the whispers were\nstarting to get unbearable out here.");
            Utility.Continue();

            ExploreRussells();
        }

        static void ExploreRussells()
        {
            Clear();
            WriteLine("You tried the door handle. Surprisingly (or perhaps unsurprisingly), it was unlocked.\nYou stepped inside, only to be greeted by darkness. You were going to have to rely on muscle memory\nto make it to Russell's room.\nYou were sure there would be some kind of clues in there to what was going on.");
            Utility.Continue();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("\nIn this next portion, use the ARROW KEYS to navigate through Russell's house.\nYou are going to be represented by a circle.\nMove to the X in order to find the clues you're looking for and to continue the story.");
            ResetColor();
            Utility.Continue();
            Clear();
            Game currentGame = new Game();
            currentGame.Maze();
        }

        public static void CurseRevealed()
        {
            Clear();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("'Aha!'");
            ResetColor();
            WriteLine("you proclaim, as you reach Russell's office.");
            Utility.Continue();
            WriteLine("\nThere was a small latern eminatting light sitting atop his wooden desk. All throughout the room,\npaper was scattered, as if there had been a struggle.\nYou shiver at the thought of what could've happened here and hope everyone was okay, wherever they went.");
            WriteLine("You picked up some of papers and started reading up under the light.");
            Utility.Continue();
            WriteLine("\nTime slowly crawled on as you read...\nNow it was night outside. Not like there was much of a difference. Whatever properties this fog has,\nit seems to keep the town frozen at one time of day.");
            Utility.Continue();
            Clear();
            WriteLine("From what you could determine, there was some kind of sea curse on Kirholm Point.\nNormally, you would never believe such a thing.\nHowever... as you were currently living through out, you couldn't really deny it.");
            WriteLine("The way to break the curse had to do with some monument in the ocean.\nIt, of course, didn't say how to break said curse.");
            Utility.Continue();
            WriteLine("\nYou decided you should head to the beach as soon as possible. Everyone in the town was counting on you,\nwhether they knew it or not!\nYou backtracked your way out of Russell's, pocketing the papers.\nAs a spur of the moment decision, you started sprinting towards the water line!");
            Inventory.Add("Russell's Notes");
            Utility.Continue();
            BeachWithCurse();
        }

        public static void BeachWithCurse()
        {
            Clear();
            int beach = 0;
            string orb = "";
            string cave = "";
            ForegroundColor = ConsoleColor.DarkCyan;
            Write(@"                                                |>>>
                                                |
                                            _  _|_  _
                                           |;|_|;|_|;|
                                           \\.    .  /
                                            \\:  .  /
                                             ||:   |
                                             ||:.  |
                                             ||:  .|
                                             ||:   |       \,/
                                             ||: , |            /`\
                                             ||:   |
                                             ||: . |
              __                            _||_   |
     ____--`~    '--~~__            __ ----~    ~`---,              ___
-~--~                   ~---__ ,--~'                  ~~----_____-~'   `~----~~
");
            ResetColor();
            WriteLine("\nTraversing through dense fog and an even denser gloom, you make your way to the beach.\nIn the distance, you can barely make out the shape of some jutting rocks that form a platform.\nThe platform seemed to have an eerie blue glow to it while the waves crashed heavily around it.");
            Utility.Continue();
            Clear();
            WriteLine("If you listened hard enough, you could hear a multitude of whispers,\nsome sounding familiar,\nand others sounding completely inhuman.");
            Utility.Continue();
            WriteLine("\nThis was it.\nIt had to be.");
            Utility.Continue();
            WriteLine("\nYou think back to the strange papers strewn throughout Russell's home, and how they mentioned a sea curse.\nSurely, a strange platform with a pedestal seemingly to be pulsating with blue-ish energy had to be the source!\nYou decide you'll have to swim through the rough currents of the ocean to get there.");
            Utility.Continue();
            WriteLine("\nDo you search the beach before you begin your swim? Y or N.");
            while (beach == 0)
            {
                orb = ReadLine();
                orb = orb.ToUpper();
                switch (orb)
                {
                    case "Y":
                        Clear();
                        ResetColor();
                        WriteLine("You decide it would be best to check around the beach for anything that might help you remove the curse.\nAs you walked along the beach, you noticed a large rock formation with an opening.\nA cave!");
                        Utility.Continue();
                        ForegroundColor = ConsoleColor.DarkCyan;
                        WriteLine("\nGo inside? Y or N.");
                        cave = ReadLine();
                        cave = cave.ToUpper();
                        switch (cave)
                        {
                            case "Y":
                                ResetColor();
                                Clear();
                                WriteLine("Apprehensively, you step inside the cave. Once your eyes adjusted to the dark,\nyou could see a faint glow in the distance.");
                                ForegroundColor = ConsoleColor.DarkCyan;
                                WriteLine("\nA blue glow.\n");
                                ResetColor();
                                WriteLine("'Booyah!' you thought to yourself. You knew it was worth checking your surroundings.");
                                Utility.Continue();
                                WriteLine("\nAs well as you could, you walk towards the glow. The closer you get, the more obvious\nit became what was emitting the glow.\n'An orb...?' you mutter to yourself.");
                                Utility.Continue();
                                WriteLine("\nConvinced this was the way to fix all the wrongs in Kirholm Point, you pick up the orb.\nThankfully, no traps or strange magic are activated when you remove it.\nDetermined to finish this, you walk out of the cave and back to the pillar in the sea.");
                                Utility.Continue();
                                Inventory.Add("Mystical Orb");
                                beach = 1;
                                ending = 2;
                                break;
                            case "N":
                                ResetColor();
                                Clear();
                                WriteLine("It seemed dangerous inside, so you turn away from the cave and head back to the pillar in the ocean.");
                                ending = 1;
                                beach = 1;
                                break;
                            default:
                                WriteLine("Please type either Y or N.");
                                break;
                        }
                        break;
                    case "N":
                        Clear();
                        WriteLine("You don't think it's worth wasting the time dilly-dallying on the important task at hand.");
                        Utility.Continue();
                        ending = 1;
                        beach = 1;
                        break;
                    default:
                        WriteLine("Please type either Y or N.");
                        break;
                }
            }
            if (beach == 1)
            {
                PillarEndGame();
            }
        }

        static void PillarEndGame()
        {
            Clear();
            WriteLine("With a grimace on your face, you brave the waters and start your swim over.\nThe waves were not kind, feeling almost as if they didn't want you to reach the pedestal.");
            Utility.Continue();
            WriteLine("\nAfter an immense struggle, you manage to get to the rocks and climb up onto them.\nYou cautiously approach the pedestal.");
            Utility.Continue();
            switch (ending)
            {
                case 1:
                    WriteLine("\nYou stare at it. There appeared to be an outline cut out in the stone for something circular.\nAll you had on you was Russell's notes about the curse, not anything that would fit in the hole.\nFrustrated, you kick at the pillar. It doesn't seem to budge or break.\nAs a final attempt, you try pushing it off the rocks into the water below.\nIt refused to move, as if it was glued to the ground.");
                    Utility.Continue();
                    WriteLine("\nSuddenly, there was a shrill scream from the water!\nYou turn towards it immediately, out of surprise and fear.");
                    Utility.Continue();
                    Clear();
                    string mermaid = @"              /:.:,
   O          \::/
 o            /|`
 _ '  sSSs   /:|
  \\__\_SSSs/::|
   `--((S\SSSs/
       SS\\SSSs
      sSS//SSs
         `Ss'";
                    string mermaidColor = "#53804C";
                    WriteLine(mermaid.Pastel(mermaidColor));
                    WriteLine("\nA hideous mermaid emerges!");
                    Utility.Continue();
                    WriteLine("\nYou freeze in place. What were you supposed to do now?!\nThe mermaid, however, did not stay still. It started to try and climb out of the water, swinging its arms at you!");
                    Utility.Continue();
                    WriteLine("\nRealizing it was trying to get you, you decide to book it. It wasn't worth your life to break the curse!\nYou jump into the water and swim as fast as you can, the waves working in your favor this time.");
                    Utility.Continue();
                    WriteLine("\nYou safely make it to the shore. However, the mermaid was not giving up!\nYou continue to run away, going back to where the coachman had dropped you off.\nScreams started echoing throughout the empty village.\nNot wanting to be here any longer, you run and run and run until the fog finally starts to give way...");
                    Utility.Continue();
                    Clear();
                    WriteLine("You eventually return to the safety of the normal world, where there are no curses and mermaids.\nThe disapperance of everyone in Kirholm Point becomes an unsolveable mystery and legend,\nyou becoming known as the sole survivor.");
                    Utility.Continue();
                    EndGame();
                    break;
                case 2:
                    WriteLine("\nYou stare at it. There appeared to be an outline cut out in the stone for something circular.\nYou look down at the orb you're hold in your hands.\nThe closer you brought it to the pedestal, the more both of the items seemed to glow.");
                    Utility.Continue();
                    WriteLine("\nCarefully, you set the orb into place. A bright light grows and grows,\nbefore it flashes intensely, blinding you temporarily.\nWhen your vision comes back, you're standing on the beach.");
                    Utility.Continue();
                    Clear();
                    WriteLine("You look around with confusion, only to see that the fog was gone.");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine($"\n'Hey!! {PlayerName}! Thank god, it's you!'");
                    ResetColor();
                    WriteLine("\nYour head sharply swings towards the sound of a familiar voice.\n'Russell?!' you stammer.");
                    Utility.Continue();
                    WriteLine("\n'Yes, it's me! You saved us!' he replies.\nThat's when you spot all the other townspeople sprawled across the beach.");
                    WriteLine("\n'What the hell was this curse thing?!' you exclaim to him.");
                    Utility.Continue();
                    WriteLine("\n'I have a lot of explaining to do, don't I?' he chuckles.\n\nYou frown and shake your head at him.\n\n'Hey now, don't look so gloomy, you just stopped an ancient evil!' he said, lightly punching your arm.");
                    Utility.Continue();
                    WriteLine("\n'You owe me for this, you know... It wasn't easy!' you huff.\n\n'I know, I know...' Russell replies.\n'Let's discuss over a cup of tea, shall we?'");
                    Utility.Continue();
                    EndGame();
                    break;
            }
        }
    }
}
