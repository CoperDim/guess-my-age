using GuessMyAge.Models;

namespace GuessMyAge.Services
{
    public interface IGameService
    {
        Game Run(Person person);
    }
}
