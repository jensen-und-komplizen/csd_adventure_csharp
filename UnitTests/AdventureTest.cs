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
        public void that_I_can_look_around()
        {
            string actual = _adventure.tell("look around");
            actual.Should().Contain("You see a pretty dirty door");
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
    }
}