using System;
using System.Collections.Generic;
using CsdTextAdventure.Rooms;

namespace CsdTextAdventure
{
    public class Adventure
    {
        private Room _room;
        private Boolean _coinOnFloor;
        private Boolean _pantsUp;

        private List<string> jokes = new();
        private int jokeIdx = 0;

        public string Begin()
        {
            _room = new Loo();
            _coinOnFloor = true;
            _pantsUp = false;            /* initialize the list of jokes to tell */
            WriteJokes();
            return "Welcome to our new Adventure!" + Environment.NewLine + "#############################" 
                + Environment.NewLine + "You wake up on the loo." + Environment.NewLine + "You have no idea who or where you are";
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

        public string tell(string input)
        {
            if (input == "quit")
            {
                return "Bye bye";
            }
            else if (input == "look around")
            {
                return _room.DetailedDescription();
            }
            else if (input == "look at magazines")
            {
                return
                    "You see a very much used Micky Mouse magazine, a very old and unusable playboy and what seems to be a scrum guide 2009 in mint condition.";
            }
            else if (input == "go through door")
            {
                var descr = "Pull your pants up!!! You pig!";
                if (_room is Loo && _pantsUp)
                {
                    _room = new Restroom();
                    descr = _room.Description();
                }

                return descr;
            }
            else if (input == "look at card")
            {
                return "The card says that you are a Scrum Master";
            }
            else if (input == "pick up coin" && _coinOnFloor == true)
            {
                _coinOnFloor = false;
                return "You picked up the coin and put it in your pocket.";
            }
            else if (input == "pick up coin" && _coinOnFloor == false)
            {
                return "There are no more coins on the floor.";
            }
			else if (input == "read list" || input == "look at list" || input == "show list")
			{
				return " - wash hands \n - pull up pants\n - dry hair";
			}
            else if(input == "look at jokes")
            {
                return TellJoke();
            }
			else if (input == "open playboy")
			{
				return ("sorry, the pages seem to stick together");
			}
            else if (input == "pull up pants")
            {
                _pantsUp = true;
                return "Your pants are up.";
            }
            else if(input == "help")
            {
                return _room.Help();
            }
            else if (input == "pull down pants")
            {
                _pantsUp = false;
                return "Your pants are down.";
            }
            else if (input == "where am i")
            {
                return "I am in the " + _room.Name();
            }
            else
            {
                return "What????";
            }
        }
    }
}