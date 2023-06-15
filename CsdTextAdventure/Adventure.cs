using System;
using CsdTextAdventure.Rooms;

namespace CsdTextAdventure
{
    public class Adventure
    {
        private Room _room;
        private Boolean _coinOnFloor;
        private Boolean _pantsUp;

        public string Begin()
        {
            _room = new Loo();
            _coinOnFloor = true;
            _pantsUp = false;
            return "Welcome to our new Adventure!" + Environment.NewLine + "#############################" 
                + Environment.NewLine + "You wake up on the loo." + Environment.NewLine + "You have no idea who or where you are";

        }

        public string tell(string input)
        {
            if (input == "quit")
            {
                return "Bye bye";
            }
            else if (input == "look around")
            {
                return _room.DetailedDescription();
            }
            else if (input == "look at magazines")
            {
                return
                    "You see a very much used Micky Mouse magazine, a very old and unusable playboy and what seems to be a scrum guide 2009 in mint condition.";
            }
            else if (input == "go through door")
            {
                var descr = "Pull your pants up!!! You pig!";
                if (_room is Loo && _pantsUp)
                {
                    _room = new Restroom();
                    descr = _room.Description();
                }

                return descr;
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
            else if (input == "pull up pants")
            {
                _pantsUp = true;
                return "Your pants are up.";
            }
            else if (input == "pull down pants")
            {
                _pantsUp = false;
                return "Your pants are down.";
            }
            else if (input == "where am i")
            {
                return "I am in the " + _room.Name();
            }
            else
            {
                return "What????";
            }
        }
    }
}