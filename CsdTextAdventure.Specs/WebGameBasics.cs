using FluentAssertions;
using TechTalk.SpecFlow;

namespace CsdTextAdventure.Specs
{
    [Binding]
    public class WebGameBasics
    {
        private WebGame _webGame;
        private string _lastHtml;

        [When(@"I open the game in the browser")]
        [Given(@"I opened the game in the browser")]
        public void WhenIOpenTheGameInTheBrowser()
        {
            _webGame = new WebGame(new Adventure());
            _lastHtml = _webGame.Page();
        }

        [When(@"I send the command ""(.*)""")]
        public void WhenISendTheCommand(string command)
        {
            _lastHtml = _webGame.Command(command);
        }

        [Then(@"I see a welcome message in the browser")]
        public void ThenISeeAWelcomeMessageInTheBrowser()
        {
            _lastHtml.Should().Contain("Welcome to our new Adventure!");
        }

        [Then(@"the browser shows ""(.*)""")]
        public void ThenTheBrowserShows(string text)
        {
            _lastHtml.Should().Contain(text);
        }
    }
}
