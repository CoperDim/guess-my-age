using GuessMyAge.Models;

namespace GuessMyAge.Business.Services
{
    public interface IGameService
    {
        Game Create(Game game);
        IEnumerable<Game> GetAll();
    }   
}