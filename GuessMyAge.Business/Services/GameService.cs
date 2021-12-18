using GuessMyAge.Business.Converters;
using GuessMyAge.Database.Repositories;
using GuessMyAge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyAge.Business.Services
{
    public class GameService : IGameService
    {
        public IGameRepository _gameRepository;
        public PersonService personService;

        public Game Create(Game gameModel)
        {
            var databaseEntity = gameModel.ToDatabaseEntity();
            var person = personService.Create(new Person());
            databaseEntity.PersonId = person.Id;

            _gameRepository.Create(databaseEntity);

            return databaseEntity.ToGame();
        }

        public IEnumerable<Game> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
