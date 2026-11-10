using CsdTextAdventure;
using CsdTextAdventure.Rooms;
using FluentAssertions;
using NUnit.Framework;

namespace TestProject1
{
    public class RestroomTest
    {
        private Restroom _restroom;


        [SetUp]
        public void SetUp()
        {
            _restroom = new Restroom();
        }
        [Test]
        public void help_for_restroom()
        {
            string actual = _restroom.Help();
            actual.Should().Match("Commands:*");
        }

        [Test]
        public void return_to_loo_changes_current_room()
        {
            var adventure = new Adventure();
            adventure.SetRoom(_restroom);

            string actual = adventure.tell("return to loo");

            adventure.WhereAreWe().Should().Be("Loo");
            actual.Should().Be(new Loo().Description());
        }
    }
}
