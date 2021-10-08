using Moq;
using TechTalk.SpecFlow;

namespace CsdTextAdventure.Specs
{
    [Binding]
    public class AdventureBasics
    {
        private Adventure _adventure;
        private Mock<IOInterface> _ioInterfaceMock;

        [When(@"I start the adventure")]
        public void WhenIStartTheAdventure()
        {
            _ioInterfaceMock = new Mock<IOInterface>();
            _ioInterfaceMock.SetupSequence(x => x.ReadLine())
                .Returns("quit");
            _adventure = new Adventure(_ioInterfaceMock.Object);
            _adventure.Begin();
        }

        [Then(@"I see a welcome message")]
        public void ThenISeeAWelcomeMessage()
        {
            _ioInterfaceMock.Verify(x => x.WriteLine(It.IsRegex("Welcome to our new Adventure!")));
        }
    }
}