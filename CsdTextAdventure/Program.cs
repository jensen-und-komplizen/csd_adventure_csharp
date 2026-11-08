using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CsdTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            /* one adventure for everybody, like the AdventureService in the quarkus version */
            WebGame webGame = new WebGame(new Adventure());

            app.UseStaticFiles();
            app.MapGet("/", () => Results.Redirect("/game"));
            app.MapGet("/game", () => Results.Content(webGame.Page(), "text/html"));
            app.MapGet("/command", (HttpRequest request) => Results.Content(webGame.Command(request.Query["command"]), "text/html"));

            app.Run();
        }
    }
}
