using GuessMyAge.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyAge.Business.Services
{
    public class GameService : IGameService
    {
        public Game Run(Person person)
        {
            Game currentGame = new Game(person, Parameters.MaxTurns);

            string questionLabel = "Quel est mon age ?";

            for (currentGame.CurrentTurn = 0; currentGame.CurrentTurn < currentGame.MaxTurn; currentGame.CurrentTurn++)
            {
                Console.WriteLine(questionLabel);
                Console.WriteLine($"Il vous reste {currentGame.MaxTurn - currentGame.CurrentTurn} tour(s)");
                string inputUser = Console.ReadLine();

                currentGame.ValidateInputNumber(inputUser);

                switch (currentGame.GameState)
                {
                    case GameState.IsUp:
                        Console.WriteLine("C'est trop haut");
                        break;
                    case GameState.IsDown:
                        Console.WriteLine("C'est trop bas");
                        break;
                    case GameState.IsEqual:
                        Console.WriteLine("Bravo");
                        return currentGame;
                    case GameState.isCancelled:
                        Console.WriteLine("Au revoir");
                        return currentGame;
                    case GameState.IsUnValidOrNull:
                        Console.WriteLine($"La valeur {inputUser} n'est pas valide");
                        break;
                }

            }
            return currentGame;

        }
    }
}
