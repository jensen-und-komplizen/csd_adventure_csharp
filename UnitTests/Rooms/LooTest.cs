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

        [Test]
        public void pants_in_description()
        {
	        var actual = _loo.DetailedDescription();
	        actual.Should().Contain("you see your dropped pants");

	        _loo.Tell("pull up pants", null);
	        actual = _loo.DetailedDescription();
			actual.Should().NotContain("you see your dropped pants");

	        _loo.Tell("pull down pants", null);
	        actual = _loo.DetailedDescription();
			actual.Should().Contain("you see your dropped pants");
		}
    }
}