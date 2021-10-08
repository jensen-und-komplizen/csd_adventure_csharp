namespace CsdTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventure Adventure = new Adventure(new IOController());
            Adventure.Begin();
        }
    }
}