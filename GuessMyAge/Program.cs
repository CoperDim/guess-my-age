// See https://aka.ms/new-console-template for more information
string userName = Environment.UserName;

Console.WriteLine("Bienvenue " + userName);

string age = "21";
string userInput = "";

for (int counter = 1; userInput != age; counter++)
{
    Console.WriteLine("Essai n° " + counter);
    Console.WriteLine("Quel est mon age ?");
    userInput = Console.ReadLine();
}

