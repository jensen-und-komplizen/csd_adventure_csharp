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
    }
}
