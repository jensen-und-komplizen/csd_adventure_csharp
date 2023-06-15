using CsdTextAdventure.Rooms;
using FluentAssertions;
using NUnit.Framework;

namespace TestProject1
{
    public class LooTest
    {
        private Loo _loo;


        [SetUp]
        public void SetUp()
        {
            _loo = new Loo();
        }
        [Test]
        public void help_for_loo()
        {
            string actual = _loo.Help();
            actual.Should().Match("Commands:*");
        }
    }
}
