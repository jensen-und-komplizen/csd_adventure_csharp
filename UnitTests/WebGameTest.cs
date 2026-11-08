using CsdTextAdventure;
using FluentAssertions;
using NUnit.Framework;

namespace TestProject1
{
    public class WebGameTest
    {
        private WebGame _webGame;

        [SetUp]
        public void Setup()
        {
            _webGame = new WebGame(new Adventure());
        }

        [Test]
        public void that_the_page_shows_a_welcome_message()
        {
            _webGame.Page().Should().Contain("Welcome to our new Adventure!");
        }

        [Test]
        public void that_the_page_tells_me_I_am_in_the_loo()
        {
            _webGame.Page().Should().Contain("<h1>You are in the loo</h1>");
        }

        [Test]
        public void that_the_page_has_a_command_input()
        {
            _webGame.Page().Should().Contain("<input id=\"command\"");
        }

        [Test]
        public void that_a_command_returns_the_answer_of_the_adventure()
        {
            _webGame.Command("where am i").Should().Contain("I am in the Loo");
        }

        [Test]
        public void that_a_command_shows_the_new_room()
        {
            _webGame.Command("pull up pants");
            _webGame.Command("go through door").Should().Contain("<h1>You are in the restroom</h1>");
        }

        [Test]
        public void that_new_lines_become_line_breaks()
        {
            _webGame.Command("help").Should().Contain("Commands:<br />quit<br />");
        }

        [Test]
        public void that_quotes_are_html_encoded()
        {
            _webGame.Command("look at jokes").Should().Contain("&quot;");
        }

        [Test]
        public void that_a_missing_command_does_not_crash()
        {
            _webGame.Command(null).Should().Contain("Try &#39;Help&#39;");
        }

        [Test]
        public void that_reloading_the_page_starts_a_new_adventure()
        {
            _webGame.Command("pull up pants");
            _webGame.Command("go through door");
            _webGame.Page().Should().Contain("<h1>You are in the loo</h1>");
        }
    }
}
