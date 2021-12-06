using GuessMyAge.Models;

namespace GuessMyAge.Services
{
    public class GameService : IGameService
    {
        public Game Run(Person person)
        {
            Game currentGame = new Game(person, Parameters.MaxTurns);

            string questionLabel = "Quel est mon age ?";
            Console.WriteLine($"Je m'appelle {person.Name}");
            Console.WriteLine(person.Description);
            Console.WriteLine("--------------------------------------------------");

            for (currentGame.CurrentTurn = 0; currentGame.CurrentTurn < currentGame.MaxTurn && currentGame.GameState != GameState.IsEqual && currentGame.GameState != GameState.isCancelled; currentGame.CurrentTurn++)
            {
                Console.WriteLine(questionLabel);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Il vous reste {currentGame.MaxTurn - currentGame.CurrentTurn} essai(s)");
                Console.WriteLine($"Réponse n° {currentGame.CurrentTurn + 1} : ");
                try
                {
                    currentGame.InputUser = Console.ReadLine();
                    currentGame.ValidateInputNumber();
                    switch (currentGame.GameState)
                    {
                        case GameState.IsUp:
                            Console.WriteLine("Vous êtes trop haut !");
                            break;
                        case GameState.IsDown:
                            Console.WriteLine("Vous êtes trop bas !");
                            break;
                        case GameState.IsUnValidOrNull:
                            Console.WriteLine($"La valeur {currentGame.InputUser} est incorrecte");
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine($"Une erreur est survenue");
                }
            }
            return currentGame;
        }
    }
}