// See https://aka.ms/new-console-template for more information
using GuessMyAge;
using GuessMyAge.Business.Models;
using GuessMyAge.Business.Services;

Console.WriteLine($"Bienvenue {Environment.UserName}");

IPersonService personService = new PersonService();
IGameService gameService = new GameService();

var persons = personService.GetAll();

foreach (var person in persons)
{
    var game = gameService.Run(person);

    if (game.GameState == GameState.isCancelled)
        break;

    switch (game.GameState)
    {
        case GameState.IsUp:
        case GameState.IsDown:
        case GameState.IsUnValidOrNull:
            Console.WriteLine($"Dommage, vous n'avez pas deviné mon age, c'était {game.Person.Age} an(s)");
            break;
        case GameState.IsEqual:
            Console.WriteLine($"Bravo, vous avez deviné mon age: {game.Person.Age} an(s)");
            break;
        default:
            break;
    }

    Console.WriteLine($"Tapez q pour quitter, sinon repartons pour une nouvelle partie...");
    string? continueGame = Console.ReadLine();

    if (continueGame == "q")
        break;
}

Console.WriteLine($"Tapez q pour quitter, sinon repartons pour une nouvelle partie...");
