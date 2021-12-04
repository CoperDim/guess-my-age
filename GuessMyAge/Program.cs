string userName = Environment.UserName;

Console.WriteLine("Bienvenue " + userName);
int currentMonth = DateTime.Now.Month;

switch (currentMonth)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine("Premier trimestre");
        break;
    case 4:
    case 5:
    case 6:
        Console.WriteLine("Second trimestre");
        break;
    case 7:
    case 8:
    case 9:
        Console.WriteLine("Troisième trimestre");
        break;
    default:
        Console.WriteLine("Dernier trimestre");
        break;
}