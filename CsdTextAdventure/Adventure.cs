using CsdTextAdventure.Rooms;

namespace CsdTextAdventure
{
    public class Adventure
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
            var room = new Loo();
            _io.WriteLine(room.Description());
            while (!_exit)
            {
                string input = _io.ReadLine();
                if (input == "quit")
                {
                    _exit = true;
                } else if (input == "look around")
                {
                    _io.WriteLine(room.DetailedDescription());
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