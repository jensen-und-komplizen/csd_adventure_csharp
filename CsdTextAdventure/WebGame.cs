using System.Net;

namespace CsdTextAdventure
{
    public class WebGame
    {
        private Adventure _adventure;

        public WebGame(Adventure adventure)
        {
            _adventure = adventure;
            _adventure.Begin();
        }

        public string Page()
        {
            /* every time the page is loaded, a new adventure begins */
            string welcome = _adventure.Begin();
            return "<!DOCTYPE html><html><head><meta charset=\"utf-8\" />"
                + "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\" />"
                + "<title>CSD Adventure</title>"
                + "<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\" />"
                + "<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin />"
                + "<link href=\"https://fonts.googleapis.com/css2?family=Space+Mono:wght@400;700&family=VT323&display=swap\" rel=\"stylesheet\" />"
                + "<link rel=\"stylesheet\" type=\"text/css\" href=\"/game.css\" />"
                + "<script src=\"/game.js\"></script>"
                + "</head><body><div class=\"container\"><div id=\"gameInfo\">"
                + Render(welcome)
                + "</div><form id=\"commandForm\"><input id=\"command\" type=\"text\" autocomplete=\"off\" /></form>"
                + "</div></body></html>";
        }

        public string Command(string command)
        {
            return Render(_adventure.tell(command ?? ""));
        }

        private string Render(string text)
        {
            string description = WebUtility.HtmlEncode(text).Replace("\r\n", "<br />").Replace("\n", "<br />");
            return "<h1>You are in the " + _adventure.WhereAreWe().ToLower() + "</h1><p>" + description + "</p>";
        }
    }
}
