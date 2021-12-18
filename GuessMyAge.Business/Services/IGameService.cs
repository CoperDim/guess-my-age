using GuessMyAge.Models;

namespace GuessMyAge.Business.Services
{
    public interface IGameService
    {
        Game Create(Game GameModel, Person PersonModel);

        IEnumerable<Game> GetAll();
    }
}
