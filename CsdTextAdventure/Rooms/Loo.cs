using System;

namespace CsdTextAdventure.Rooms
{
    public class Loo : Room
    {
        public Loo ()
        {
            _description = "You wake up on the loo. You have no idea where or who you are.";
            _detailed_description = "You see a pretty dirty door, with some nasty jokes on it. Next to you is some toilet paper, a coin and a few magazines." + " When you look down, you see your dropped pants. In one of the pockets, you find a business card.";
            _help =
                "Commands:" + Environment.NewLine +
                "quit" + Environment.NewLine +
                "look around" + Environment.NewLine +
                "go through door" + Environment.NewLine +
                "look at" + Environment.NewLine +
                "pick up" + Environment.NewLine;
        }
    }

}