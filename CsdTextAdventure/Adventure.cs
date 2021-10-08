using System;
using CsdTextAdventure.Rooms;

namespace CsdTextAdventure
{
    public class Adventure
    {
        private Loo _room;

        public string Begin()
        {
            _room = new Loo();
            return "Welcome to our new Adventure!" + Environment.NewLine + "#############################";
        }

        public string tell(string input)
        {
            if (input == "quit")
            {
                return "Bye bye";
            } else if (input == "look around")
            {
                return _room.DetailedDescription();
            } else if (input == "look at magazines")
            {
                return "You see a very much used Micky Mouse magazine, a very old and unusable playboy and what seems to be a scrum guide 2009 in mint condition.";
            }
            else
            {
                return "What????";
            }
        }
    }
}