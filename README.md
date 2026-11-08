# csd_adventure_csharp Project

## Vorbereitungen

Um bestens auf den bevorstehenden Kurs vorbereitet zu sein, kannst du folgendes tun:
1. Installiere das [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (auf dem Mac z.B. mit `brew install dotnet`)
2. Klone dieses Projekt und prüfe, ob du das Projekt bauen und ausführen kannst (s. [run dev server with hot reload for development](#run-dev-server-with-hot-reload-for-development))
3. Gib uns Bescheid, damit wir dich zum GitHub-Projekt hinzufügen können (kontaktiere uns dafür über E-Mail z.B. [Björn](mailto:bjoern@jensen.coach))

## On your machine
### build
```shell script
dotnet build
```

### run tests
#### run all tests
```shell script
dotnet test
```

#### run unit tests
```shell script
dotnet test UnitTests
```

#### run feature tests
```shell script
dotnet test CsdTextAdventure.Specs
```

### run dev server with hot reload for development
```shell script
dotnet watch --project CsdTextAdventure
```

The adventure is now running at http://localhost:8081.

### package
```shell script
dotnet publish CsdTextAdventure -c Release -o publish
```

### run the application
```shell script
cd publish
dotnet CsdTextAdventure.dll
```

## On the remote machine
```
Wir setzen uns an die Integrationsmaschine
cd csd_adventure_csharp/
git pull
dotnet test
dotnet publish CsdTextAdventure -c Release -o publish
cd publish
dotnet CsdTextAdventure.dll
```

---
This project uses ASP.NET Core, the web framework of .NET.

If you want to learn more about ASP.NET Core, please visit its website: https://dotnet.microsoft.com/apps/aspnet .

## Project structure

- `CsdTextAdventure`: the game and the web application
  - `Adventure.cs` and `Rooms/`: the game logic
  - `WebGame.cs`: renders the game page and the answers to commands
  - `Program.cs`: the web endpoints
    - `/game`: starts a new adventure and shows the game page
    - `/command?command=...`: sends a command to the adventure
  - `wwwroot/`: `game.js` and `game.css` for the browser
  - `appsettings.json`: configuration, e.g. the port (`Urls`)
- `UnitTests`: unit tests with NUnit
- `CsdTextAdventure.Specs`: feature tests with SpecFlow

## Changing the port

The port is configured in `CsdTextAdventure/appsettings.json`. You can also override it when starting the application:

```shell script
cd publish
dotnet CsdTextAdventure.dll --urls http://0.0.0.0:4711
```

## Related Guides

- Minimal APIs ([guide](https://learn.microsoft.com/aspnet/core/fundamentals/minimal-apis)): the way the web endpoints are defined in `Program.cs`
- Static files ([guide](https://learn.microsoft.com/aspnet/core/fundamentals/static-files)): how `wwwroot/` is served
- SpecFlow ([guide](https://docs.specflow.org/projects/specflow/en/latest/)): writing feature tests
