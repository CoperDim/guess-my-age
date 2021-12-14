// See https://aka.ms/new-console-template for more information
using GuessMyAge;
using GuessMyAge.Business.Models;
using GuessMyAge.Business.Services;

Console.WriteLine($"Bienvenue {Environment.UserName}");

<<<<<<< HEAD
IPersonService personService = new PersonService();
IGameService gameService = new GameService();
List<Game> games = new List<Game>();

var persons = personService.GetAll();

foreach (var person in persons)
{
    var game = gameService.Run(person);
    games.Add(game);

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
Console.WriteLine($"Victoire {games.Count(x => x.GameState == GameState.IsEqual)} / {games.Count()} ");
=======
bool continueGame = true;
IPersonService personService = new PersonService();
IGameService gameService = new GameService();

var persons = personService.GetAll();


foreach (Person person in persons)
{
    Console.WriteLine(Parameters.MaxTurns);

    Console.WriteLine($"Je m'appelle {person.Name} et je suis {person.Job}... ");
    var game = gameService.Run(person);
    if (game.GameState == GameState.isCancelled)
        return;

}
>>>>>>> Partie1-Exercice9-Models
