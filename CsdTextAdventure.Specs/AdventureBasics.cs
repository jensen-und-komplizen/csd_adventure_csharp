using FluentAssertions;
using Moq;
using TechTalk.SpecFlow;

namespace CsdTextAdventure.Specs
{
    [Binding]
    public class AdventureBasics
    {
        private Adventure _adventure;
        private string _lastAdventureOutput;

        [When(@"I start the adventure")]
        [Given(@"I started the adventure")]
        public void WhenIStartTheAdventure()
        {
            _adventure = new Adventure();
            _lastAdventureOutput = _adventure.Begin();
        }

        [Then(@"I see a welcome message")]
        public void ThenISeeAWelcomeMessage()
        {
            _lastAdventureOutput.Should().Contain("Welcome to our new Adventure!");
        }


        [Given(@"I am in the Loo")]
        public void GivenIAmInTheLoo()
        {
            
        }

        [When(@"I go through the door")]
        public void WhenIGoThroughTheDoor()
        {
            _lastAdventureOutput = _adventure.tell("go through door");
        }

        [Then(@"I am in the Restroom")]
        public void ThenIAmInTheRestroom()
        {
            _lastAdventureOutput.Should().Match("*Restroom*");
        }
    }
}