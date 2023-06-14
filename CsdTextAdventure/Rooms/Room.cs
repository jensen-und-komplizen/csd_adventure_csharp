namespace CsdTextAdventure.Rooms
{
    public class Room
    {
        public string Description() {return _description;}
        public string DetailedDescription() {return _detailed_description;}
        public string Help() {return _help;}
        
        protected string _description = "";
        protected string _detailed_description = "";
        protected string _help = "";
    }
}