namespace CsdTextAdventure.Rooms
{
    internal interface Room
    {
        public string Description();
        public string DetailedDescription();

        public string Name();
    }
}