// See https://aka.ms/new-console-template for more information
string userName = Environment.UserName;

Console.WriteLine("Bienvenue " + userName);

string age = "21";
string? userInput;

do
{
    userInput = Console.ReadLine();

}
while (userInput != age);

