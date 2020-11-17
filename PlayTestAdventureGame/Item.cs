using System;
using static System.Console;

namespace PlayTestAdventureGame
{
    public class Item
    {
        public string Name = "";
        public string Description = "";
        public string[] Items = { "Billy", "Trisha", "Ron" };
        public string[] Descriptions = { "A silly yet cheerful horse.", "A mellow and calm horse.", "A large, brooding horse." };

        public Item()
        {
            // Instantiate random 
            Random randomNumber = new Random();
            int number;

            //Next(Int32) returns a non-negative random number less than the maximum
            number = randomNumber.Next(Items.Length);
            Name = Items[number];
            Description = Descriptions[number];
            Write("\nYou found a " + Name + " (" + Description + ").\n");
        }
    }
}
