using GuessMyAge.Business.Models;
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> Partie1-Exercice9-Models

namespace GuessMyAge.Business.Services
{
    public class GameService : IGameService
    {
        public Game Run(Person person)
        {
            Game currentGame = new Game(person, Parameters.MaxTurns);

            string questionLabel = "Quel est mon age ?";
<<<<<<< HEAD
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
=======

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
>>>>>>> Partie1-Exercice9-Models
