using GuessMyAge.Business.Models;

namespace GuessMyAge.Business.Services
{
    public interface IGameService
    {
        Game Run(Person person);
    }
}
