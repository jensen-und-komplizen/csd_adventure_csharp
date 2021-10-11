using System;
using CsdTextAdventure.Rooms;

namespace CsdTextAdventure
{
    public class Adventure
    {
        private Room _room;
        private Boolean _coinOnFloor;

        public string Begin()
        {
            _room = new Loo();
            _coinOnFloor = true;
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
                return
                    "You see a very much used Micky Mouse magazine, a very old and unusable playboy and what seems to be a scrum guide 2009 in mint condition.";
            } else if (input == "go through door")
            {
                _room = new Restroom();
                return _room.Description();
            }
            else if (input == "look at card")
            {
                return "The card says that you are a Scrum Master";
            }
            else if (input == "pick up coin" && _coinOnFloor == true)
            {
                _coinOnFloor = false;
                return "You picked up the coin and put it in your pocket.";
            }
            else if (input == "pick up coin" && _coinOnFloor == false)
            {
                return "There are no more coins on the floor.";
            }
            else
            {
                return "What????";
            }
        }
    }
}