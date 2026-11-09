using CsdTextAdventure;
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
        public void look_for_mirror()
        {
            Adventure a = new Adventure();
            string actual = _loo.Tell("look at mirror",a);
            actual.Should().Match("the mirror is dirty and full of grain");
        }
        [Test]
        public void look_at_scrum_guide()
        {
            Adventure a = new Adventure();
            string actual = _loo.Tell("open scrum guide", a);
            actual.Should().Match("The scrum guide is actually a waterflow guide");
        }
    }
}
