namespace CsdTextAdventure.Rooms
{
    public abstract class Room
    {
        abstract public string Name();
        public string Description() {return _description;}
        public string DetailedDescription() {return _detailed_description;}
        public string Help() {return _help;}

        public abstract string Tell(string input, Adventure adventure);
        
        protected string _description = "";
        protected string _detailed_description = "";
        protected string _help = "";
    }
}