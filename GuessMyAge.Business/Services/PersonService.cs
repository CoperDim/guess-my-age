using GuessMyAge.Business.Converters;
using GuessMyAge.Database.Repositories;
using GuessMyAge.Models;

namespace GuessMyAge.Business.Services
{
    public class PersonService : IPersonService
    {
        public IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person Create(Person model)
        {
            var databaseEntity = model.ToDatabaseEntity();

            _personRepository.Create(databaseEntity);

            return databaseEntity.ToPerson();
        }

        public IEnumerable<Person> GetAll()
        {
            return _personRepository.GetAll().ToModels();
        }

        public void Update(Person model)
        {
            var databaseEntity = model.ToDatabaseEntity();

            _personRepository.Update(databaseEntity);
        }
    }
}
