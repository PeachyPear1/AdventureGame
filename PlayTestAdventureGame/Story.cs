using System;
using static System.Console;

namespace PlayTestAdventureGame
{
    class Story : Game
    {
        public static void Intro()
        {
            int packing = 0;
            int result = -1;
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
            packing = Convert.ToInt32(ReadLine());
            //do
            //{

            //}
            //while ();

            switch (result)
            {
                case 1:
                    WriteLine("You chose the first-aid kit.");
                    WriteLine("You highly doubted you would need a flashlight, considering you were going to be in a town, not the woods.");
                    Utility.Continue();
                    break;
                case 2:
                    WriteLine("You chose the emergency flashlight.");
                    WriteLine("Despite the first-aid kit seeming more logical, you assumed most people hadthe common sense to have\nmedical supplies for emergencies. You are extra prepared for anything with a flashlight!");
                    Utility.Continue();
                    break;
                default:
                    WriteLine("Please type the number 1 or 2.");
                    ReadKey();
                    break;

            }
            //if (int.TryParse(packing, out result))
            //{
            //    if (result == 1)
            //    {
                    
            //    }
            //    if (result == 2)
            //    {
                    
            //    }
            //}
            //else
            //{

            //    packing = ReadLine();
            //}
            //Clear();
        }

        public static void LeaveForKirholm()
        {
            string horse = "";
            WriteLine("The day to go finally arrives after a peaceful sleep. Little did you know how that peace was about to be shattered...\nYour coachman approaches your home and knocks on the door, with horses behind him standing idle.\n'Hello, ah... uhm.. What was your name again? My apologies.'");
            ForegroundColor = ConsoleColor.Green;
            Write("\nEnter your name here: ");
            PlayerName = ReadLine();
            ResetColor();
            WriteLine($"\n'Oh, that's right! {PlayerName}! You're heading to Kirholm Point, correct?'");
            WriteLine("You nod your head, the weight of your suitcase in hand becoming apparent.");
            Utility.Continue();
            WriteLine("\n'Well then, hand me your luggage and climb on in to the coach!'\nYou hand over your suitcase and walk over to the horses. Do you pet them? Y or N.");
            horse = ReadLine();
            horse = horse.ToUpper();
            if (horse == "Y")
            {
                WriteLine("You chose to pet the horses.");
                Utility.Continue();
            }
            else
            {
                WriteLine("You chose not to pet the horses.");
                Utility.Continue();
            }
            Clear();
        }

        public static void ArriveAtKirholm()
        {
            WriteLine("Time passes...");
            Utility.Continue();
            WriteLine("\nAs you approach the small village, you and the coachman notice a thick fog spanning across the entirety of the area.\n'That's strange...I don't remember anything about there being a storm here...' mutters the coachman.\nYou, too, are alaramed.");
            Utility.Continue();
            WriteLine("\nDespite the uneasiness in the air, the horses continue trotting along towards the town.\nUpon arrival, the two of you look around and see nobody.\nYou are now beginning to grow fearful. Where was Russell?\nSurely, he would have been waiting for you.");
            Utility.Continue();
            WriteLine("\nYou tell the coachman to wait here and that you were going to check inside the nearest building for assistance.\nYour eyes settle on the general store. With a slight sense of urgency, you walk over and pull open the door.");
            Utility.Continue();
            WriteLine("\nAll the lights were turned off, and once again, there was not a single person in sight.\n'Hello?!' you call out in desperation.");
            Utility.Continue();
            Clear();
        }

        public static void CoachmanDisappears()
        {
            WriteLine("No one responds. Silence lingers in the air. You try to make out if there were any light switches,\nbut the dark in combination with the fog was too much to tell.");
            Utility.Continue();
            Clear();
        }

        public static void BeachWithCurse()
        {
            string orb = "";
            WriteLine("Traversing through dense fog and an even denser gloom, you make your way to the beach.\nIn the distance, you can barely make out the shape of some jutting rocks that form a platform.\nThe platform seemed to have an eerie blue glow to it while the waves crashed heavily around it.");
            Utility.Continue();
            WriteLine("\nIf you listened hard enough, you could hear a multitude of whispers,\nsome sounding familiar,\nand others sounding completely inhuman.");
            Utility.Continue();
            WriteLine("\nThis was it.\nIt had to be.");
            Utility.Continue();
            WriteLine("\nYou think back to the strange papers strewn throughout Russell's home, and how they mentioned a sea curse.\nSurely, a strange platform with a pedestal seemingly to be pulsating with blue-ish energy had to be the source!\nYou decide you'll have to swim through the rough currents of the ocean to get there.");
            Utility.Continue();
            WriteLine("\nDo you search the beach before you begin your swim? Y or N.");
            orb = ReadLine();
            orb = orb.ToUpper();
            if (orb == "Y")
            {
                WriteLine("You chose to explore the beach.");
                Utility.Continue();
            }
            else
            {
                WriteLine("You chose not to explore the beach.");
                Utility.Continue();
            }
            Clear();
        }
    }
}
