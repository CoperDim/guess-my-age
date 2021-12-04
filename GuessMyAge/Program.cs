// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Bienvenue {Environment.UserName}");

string age = "21";
string userInput = "";
string questionLabel = "Quel est mon age ?";

Console.WriteLine(questionLabel);
userInput = Console.ReadLine();

for (int counter = 9; userInput != age && counter > 0; counter--)
{
    Console.WriteLine($"Il vous reste {counter} essai(s)");
    Console.WriteLine(questionLabel);
    userInput = Console.ReadLine();
}

