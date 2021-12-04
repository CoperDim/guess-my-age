// See https://aka.ms/new-console-template for more information
string userName = Environment.UserName;

Console.WriteLine("Bienvenue " + userName);
int currentMonth = DateTime.Now.Month;


if (currentMonth <= 3)
{
    Console.WriteLine("Premier trimestre");
}
else if (currentMonth <= 6)
{
    Console.WriteLine("Second trimestre");

}
else if (currentMonth <= 9)
{
    Console.WriteLine("Troisième trimestre");
}
else
{
    Console.WriteLine("Dernier trimestre");
}