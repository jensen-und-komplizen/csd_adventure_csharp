namespace CsdTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            GameConsole gameConsole = new GameConsole(new IOController());
            gameConsole.Begin();
        }
    }
}