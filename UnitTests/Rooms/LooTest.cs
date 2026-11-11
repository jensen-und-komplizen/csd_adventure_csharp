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
		
        [Test]
        public void look_for_mirror()
        {
            Adventure a = new Adventure();
            string actual = _loo.Tell("look at mirror",a);
            actual.Should().Match("the mirror is dirty and full of grain");
        }
		
        [Test]
        public void look_at_door()
        {
            Adventure a = new Adventure();
            string actual = _loo.Tell("look at door",a);
            actual.Should().Match("The door is closed but unlocked. There are some dirty jokes here. Also several stains of bodily fluids are splattered across it. It is not a pretty sight.");
        }
		
        [Test]
        public void look_at_pants()
        {
            Adventure a = new Adventure();
            string actual = _loo.Tell("look at pants",a);
            actual.Should().Match("Your trusty slightly worn blue jeans. Inside there is a pair of underpants. I will not describe them further.");
        }

        [Test]
        public void look_at_pants_pulled_up()
        {
	        Adventure a = new Adventure();
	        _loo.Tell("pull up pants", a);
	        string actual = _loo.Tell("look at pants", a);
	        actual.Should().Match("Your trusty slightly worn blue jeans. You are now fully wearing them and proud of yourself.");
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