using GuessMyAge.Models;

namespace GuessMyAge.Services
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll();

        void AddPerson(Person person);
    }
}
