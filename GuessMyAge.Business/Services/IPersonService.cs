using GuessMyAge.Models;

namespace GuessMyAge.Business.Services
{
    public interface IPersonService
    {
        Person Create(Person model);

        IEnumerable<Person> GetAll();

        void Update(Person model);
    }
}
