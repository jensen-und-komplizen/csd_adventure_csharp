using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace TextAdventure
{
    internal class Adventure
    {
        private readonly IOInterface _io;
        private bool _exit;

        public Adventure(IOInterface io)
        {
            _io = io;

            _exit = false;
        }

        public void Begin()
        {
            _io.WriteLine("Welcome to our new Adventure!");
            _io.WriteLine("#############################");
            _io.WriteLine("You wake up on the loo. You have no idea where or who you are.");
            while (!_exit)
            {
                string input = _io.ReadLine();
                if (input == "quit")
                {
                    _exit = true;
                } else if (input == "look around")
                {
                    _io.WriteLine("You see a pretty dirty door, with some nasty jokes on it. Next to you is some toilet paper, a coin and a few magazines.");
                } else if (input == "look at magazines")
                {
                    _io.WriteLine("You see a very much used Micky Mouse magazine, a very old and unusable playboy and what seems to be a scrum guide 2009 in mint condition.");
                }
                else
                {
                    _io.WriteLine("What????");
                }
            }
        }
    }
}