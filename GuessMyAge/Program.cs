// See https://aka.ms/new-console-template for more information
using GuessMyAge;

Console.WriteLine($"Bienvenue {Environment.UserName}");

bool continueGame = true;

do
{
    var game = RunGame();
    if (game.HasQuit) break;
    if (game.HasWon)
    {
        Console.WriteLine($"Bravo, vous avez deviné mon age: {game.AgeToGuess} an(s)");
    }
    else
    {
        Console.WriteLine($"Dommage, vous n'avez pas deviné mon age, c'était {game.AgeToGuess} an(s)");
    }
    Console.WriteLine($"Tapez q pour quitter, sinon repartons pour une nouvelle partie...");

    continueGame = Console.ReadLine() != "q";
}
while (continueGame);


Game RunGame()
{
    Game currentGame = new Game(StaticClass.Turns);

    string questionLabel = "Quel est mon age ?";
    for (currentGame.CurrentTurn = 0; !currentGame.isFinishedGame(); currentGame.CurrentTurn++)
    {
        Console.WriteLine($"Il vous reste {StaticClass.Turns - currentGame.CurrentTurn} essai(s)");

        Console.WriteLine(questionLabel);
        string? inputUser = Console.ReadLine();

        if (inputUser == "q")
        {
            currentGame.HasQuit = true;
            return currentGame;
        }

        try
        {
            currentGame.InputUser = inputUser;
            var turnState = StaticClass.ValidateInputNumber(currentGame);
            switch (turnState)
            {
                case StaticClass.InputNumberState.IsUp:
                    Console.WriteLine("Vous êtes trop haut !");
                    break;
                case StaticClass.InputNumberState.IsDown:
                    Console.WriteLine("Vous êtes trop bas !");
                    break;
                case StaticClass.InputNumberState.IsEqual:
                    currentGame.HasWon = true;
                    break;
                case StaticClass.InputNumberState.IsUnValidOrNull:
                    Console.WriteLine($"La valeur {inputUser} est incorrecte");
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