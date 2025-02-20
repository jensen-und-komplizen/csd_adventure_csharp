using System;

namespace CsdTextAdventure.Rooms
{
    public class Restroom : Room
    {

        public Restroom ()
        {
            _description = "You are in the Restroom.";
            _detailed_description = "Beside the mirror you see a list with things to do. You see two doors. One is leading to the Loo. The second door is leading to outside of the restroom";
            _help =
                "Commands:" + Environment.NewLine +
                "quit" + Environment.NewLine +
                "look around" + Environment.NewLine +
                "go through door" + Environment.NewLine +
                "look at" + Environment.NewLine +
                "where am i" + Environment.NewLine;
        }

        override public string Name()
        {
            return "Restroom";
        }

        public override string Tell(string input, Adventure adventure)
        {
            switch(input)
            {
                case "read list":
                case "look at list":
                case "show list":
				    return " - wash hands \n - pull up pants\n - dry hair";


                default:
                    return "";
            }
        }
    }
}
