using System;
using TextAdventure.UnitTests;

namespace TextAdventure
{
    public class IOController : IOInterface
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string Line)
        {
            Console.WriteLine(Line);
        }
        
    }
}