using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventure Adventure = new Adventure(new IOController());
            var _AdventureContinues = Adventure.Begin();
        }
    }
}