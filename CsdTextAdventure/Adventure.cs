using System;
using System.Collections.Generic;
using CsdTextAdventure.Rooms;

namespace CsdTextAdventure
{
    public class Adventure
    {
        private Room _room;

        public void SetRoom(Room newRoom)
        {
            _room = newRoom;
        }

        public string Begin()
        {
            _room = new Loo();
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
            else if (input == "where am i")
            {
                return "I am in the " + _room.Name();
            }
            else if(input == "help")
            {
                return _room.Help();
            }
            else
            {
                var output = _room.Tell(input, this);
                if(output == "")
                {
                    return "What???";
                }
                return output;
            }

            

        }
    }
}