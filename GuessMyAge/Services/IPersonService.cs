using GuessMyAge.Models;

namespace GuessMyAge.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAll();

        void AddPerson(Person person);
    }
}
