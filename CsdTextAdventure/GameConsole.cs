using System;

namespace CsdTextAdventure
{
    public class GameConsole
    {
        private IOInterface _io;

        public GameConsole(IOInterface io)
        {
            _io = io;
        }

        public void Begin()
        {
            Adventure adventure = new Adventure();
            _io.WriteLine(adventure.Begin());
            
            string input;
            string output;
            do
            {
                input = _io.ReadLine();
                output = adventure.tell(input);
                _io.WriteLine(output);
            } while (input != "quit");
         
        }
    }
}