namespace CsdTextAdventure.Rooms
{
    public class Loo : Room
    {
        public string Description()
        {
            return "You wake up on the loo. You have no idea where or who you are.";
        }

        public string DetailedDescription()
        {
            return
                "You see a pretty dirty door, with some nasty jokes on it. Next to you is some toilet paper, a coin and a few magazines." + " When you look down, you see your dropped pants. In one of the pockets, you find a business card.";
        }

        public string Name()
        {
            return "Loo";
        }
    }

}