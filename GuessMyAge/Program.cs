// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Bienvenue {Environment.UserName}");

string? userInput = null;

do
{
    int age = new Random().Next(1, 120);

    string questionLabel = "Quel est mon age ?";
    bool hasWin = false;

    for (int counter = 9; userInput != age.ToString() && counter >= 0; counter--)
    {
        Console.WriteLine(questionLabel);
        userInput = Console.ReadLine();

        if (userInput == "q") break;

        try
        {
            int userInputNumber = int.Parse(userInput);
            if (userInputNumber > age)
            {
                Console.WriteLine("Vous êtes trop haut !");
                Console.WriteLine($"Il vous reste {counter} essai(s)");
            }
            else if (userInputNumber < age)
            {
                Console.WriteLine("Vous êtes trop bas !");
                Console.WriteLine($"Il vous reste {counter} essai(s)");
            }
            else
            {
                hasWin = true;
                break;
            }
        }
        catch
        {
            Console.WriteLine($"La valeur {userInput} est incorrecte");
            Console.WriteLine($"Il vous reste {counter} essai(s)");
        }
    }
    if (hasWin)
    {
        Console.WriteLine("Bravo, vous avez gagné !!");
    }
    else
    {
        Console.WriteLine("Désolé, peut être la prochaine fois !!");
    }
}
while (string.IsNullOrEmpty(userInput) || userInput != "q");