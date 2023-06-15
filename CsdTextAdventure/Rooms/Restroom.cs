namespace CsdTextAdventure.Rooms
{
    public class Restroom : Room
    {
        public string Description()
        {
            return "You are in the Restroom.";
        }

        public string DetailedDescription()
        {
            return "You see two doors. One is leading to the Loo. The second door is leading to outside of the restroom";
        }

        public string Name()
        {
            return "Restroom";
        }
    }
}