using Moq;
using TechTalk.SpecFlow;

namespace CsdTextAdventure.Specs
{
    [Binding]
    public class GameConsoleBasiscs
    {
        private GameConsole _game;
        private Mock<IOInterface> _ioInterfaceMock;

        [When(@"I start the console game")]
        [Given(@"I started the console game")]
        public void WhenIStartTheAdventure()
        {
            _ioInterfaceMock = new Mock<IOInterface>();
            _ioInterfaceMock.SetupSequence(x => x.ReadLine())
                .Returns("quit");
            _game = new GameConsole(_ioInterfaceMock.Object);
            _game.Begin();
        }

        [Then(@"I see a welcome message on the console")]
        public void ThenISeeAWelcomeMessage()
        {
            _ioInterfaceMock.Verify(x => x.WriteLine(It.IsRegex("Welcome to our new Adventure!")));
        }


    }
}