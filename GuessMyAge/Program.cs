// See https://aka.ms/new-console-template for more information
using GuessMyAge;
using GuessMyAge.Business.Models;
using GuessMyAge.Business.Services;

Console.WriteLine($"Bienvenue {Environment.UserName}");

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
