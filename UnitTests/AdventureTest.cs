using System;
using System.Collections.Generic;
using CsdTextAdventure;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace TestProject1
{
    public class AdventureTest
    {
        private Adventure _adventure;


        [SetUp]
        public void SetUp()
        {
            _adventure = new Adventure();
            _adventure.Begin();
        }

        [Test]
        public void Adventure_can_be_started()
        {
            Adventure adventure = new Adventure();
            Assert.IsInstanceOf<Adventure>(adventure);
        }

        [Test]
        public void running_shows_Introduction()
        {
            string actual = _adventure.Begin();
            actual.Should().Contain("Welcome to our new Adventure!");
        }
        
        [Test]
        public void running_shows_Where_am_i()
        {
            string actual = _adventure.Begin();
            actual.Should().MatchRegex("\\sloo[\\s\\.!]");
        }

        [Test]
        public void that_I_can_look_around()
        {
            string actual = _adventure.tell("look around");
            actual.Should().Contain("You see a pretty dirty door");
        }

        [Test]
        public void that_Restroom_has_a_second_door()
        {
            _adventure.tell("go through door");
            string actual = _adventure.tell("look around");
            actual.Should().Contain("The second door is leading to outside of the restroom");
        }
        
        [Test]
        public void i_see_a_card_in_the_toilet()
        {
            string actual = _adventure.tell("look around");
            actual.Should().Contain("business card");
        }

        [Test]
        public void pick_up_coin_first()
        {
            _adventure.Begin();
            string actual = _adventure.tell("pick up coin");
            actual.Should().Contain("picked up");
        }

        [Test]
        public void pick_up_coin_second()
        {
            _adventure.Begin();
            string actual = _adventure.tell("pick up coin");
            actual = _adventure.tell("pick up coin");        
            actual.Should().Contain("no more coins");
        }

        [Test]
        public void that_I_can_look_at_magazines()
        {
            string actual = _adventure.tell("look at magazines");
            actual.Should().Match("*see *Micky Mouse magazine*");
        }
        

        [Test]
        public void that_I_learn_my_role_looking_at_card()
        {
            string actual = _adventure.tell("look at card");
            actual.Should().Match("The card says that you are a Scrum Master");
        }

        [Test]
        public void that_I_can_look_at_jokes()
        {
            List<string> expectedJokes = new()
            {
                "\"Knock knock.\"" + Environment.NewLine + "Who\'s there?" + Environment.NewLine + "\"Carrie.\"" + Environment.NewLine + "Carrie who?" + Environment.NewLine + "\"Carrie over to next sprint.\"" + Environment.NewLine,
                "We need three more programs!" + Environment.NewLine + "Use Agile program \"Ming method\"." + Environment.NewLine,
                "We are going to try something which is called Agile programming." + Environment.NewLine + "\"That mean no more planning no more documentation just start writing code and complaining\"." + Environment.NewLine + "I\'m Glad it has a name." + Environment.NewLine,
                "Because the requirements said so. The trebuchet was the most efficient method. Oh, she had to get to the other side alive? Where was that in the requirements? " + Environment.NewLine,
                "Let’s iterate, people. Let’s get the chicken to the center line today, and we’ll talk about the rest of the way tomorrow." + Environment.NewLine,
                "Kanbanista: Someone who is aggressively, revolutionarily passionate about colored tape on whiteboards." + Environment.NewLine
            };

            string actual = _adventure.tell("look at jokes");
            Assert.True(expectedJokes.Contains(actual));
        }
    }
}