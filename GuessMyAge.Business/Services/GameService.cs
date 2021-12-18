using GuessMyAge.Business.Converters;
using GuessMyAge.Database.Repositories;
using GuessMyAge.Models;

namespace GuessMyAge.Business.Services
{
    public class GameService : IGameService
    {
        public IGameRepository _gameRepository;


        public Game Create(Game Gamemodel, Person PersonModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
