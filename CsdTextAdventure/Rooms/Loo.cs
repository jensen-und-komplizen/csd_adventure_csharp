using System;
using System.Collections.Generic;

namespace CsdTextAdventure.Rooms
{
    public class Loo : Room
    {
        private Boolean _pantsUp = false;
        private Boolean _coinOnFloor = true;
        private List<string> jokes = new();
        private int jokeIdx = 0;

        public Loo ()
        {
            _description = "You wake up on the loo. You have no idea where or who you are.";
            _detailed_description = "You see a pretty dirty door, with some nasty jokes on it. Next to you is some toilet paper, a coin and a few magazines." + " When you look down, you see your dropped pants. In one of the pockets, you find a business card.";
            _help =
                "Commands:" + Environment.NewLine +
                "quit" + Environment.NewLine +
                "look around" + Environment.NewLine +
                "go through door" + Environment.NewLine +
                "look at" + Environment.NewLine +
                "pick up" + Environment.NewLine +
                "where am i" + Environment.NewLine;
            WriteJokes();
        }

        override public string Name()
        {
            return "Loo";
        }

        private void WriteJokes()
        {
            /* add some jokes to the central list of jokes. these will be used when the user types "look at jokes" */
            jokes.Add("\"Knock knock.\"" + Environment.NewLine + "Who\'s there?" + Environment.NewLine + "\"Carrie.\"" + Environment.NewLine + "Carrie who?" + Environment.NewLine + "\"Carrie over to next sprint.\"");
            jokes.Add("We need three more programs!" + Environment.NewLine + "Use Agile program \"Ming method\".");
            jokes.Add("We are going to try something which is called Agile programming." + Environment.NewLine + "\"That mean no more planning no more documentation just start writing code and complaining\"." + Environment.NewLine + "I\'m Glad it has a name.");
            jokes.Add("Because the requirements said so. The trebuchet was the most efficient method. Oh, she had to get to the other side alive? Where was that in the requirements? ");
            jokes.Add("Let’s iterate, people. Let’s get the chicken to the center line today, and we’ll talk about the rest of the way tomorrow.");
            jokes.Add("Kanbanista: Someone who is aggressively, revolutionarily passionate about colored tape on whiteboards.");
        }

        private String TellJoke()
        {
            /* return a joke from the central list of jokes. each time a joke is returned. 
            the index is increased by 1 and the next time a joke is requested, the user will see the next joke in the list.
            if the index reaches the end of the list, we start from the beginning of the list */
            return jokes[jokeIdx++ % jokes.Count] + Environment.NewLine;
        }

        public override string Tell(string input, Adventure adventure)
        {
            switch(input)
            {
                case "look at magazines":
                    return
                        "You see a very much used Micky Mouse magazine, a very old and unusable playboy and what seems to be a scrum guide 2009 in mint condition.";

                case "go through door":
                    var descr = "Pull your pants up!!! You pig!";
                    if (this is Loo && _pantsUp)
                    {
                        var tmp = new Restroom();
                        adventure.SetRoom(tmp);
                        descr = tmp.Description();
                    }
                    return descr;

                case "look at card":
                    return "The card says that you are a Scrum Master";

                case "pick up coin":
                    if(_coinOnFloor == true)
                    {
                        _coinOnFloor = false;
                        return "You picked up the coin and put it in your pocket.";
                    }
                    return "There are no more coins on the floor.";


                case "look at jokes":
                    return TellJoke();


                case "pull down pants":
                    _pantsUp = false;
                    return "Your pants are down.";


                case "pull up pants":
                    _pantsUp = true;
                    return "Your pants are up.";

                case "open playboy":
                    return "sorry, the pages seem to stick together";

                default:
                    return "";
            }
        }
    }

}
