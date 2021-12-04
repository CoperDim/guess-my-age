using GuessMyAge.Business.Models;

namespace GuessMyAge.Business.Services
{
    public class GameService : IGameService
    {
        public Game Run(Person person)
        {
            Game currentGame = new Game(person, Parameters.MaxTurns);

            string questionLabel = "Quel est mon age ?";
            for (currentGame.CurrentTurn = 0; currentGame.CurrentTurn < currentGame.MaxTurn && currentGame.GameState != GameState.IsEqual && currentGame.GameState != GameState.isCancelled; currentGame.CurrentTurn++)
            {
                Console.WriteLine($"Il vous reste {currentGame.MaxTurn - currentGame.CurrentTurn} essai(s)");

                Console.WriteLine(questionLabel);

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