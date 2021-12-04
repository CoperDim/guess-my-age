using GuessMyAge.Business.Models;

namespace GuessMyAge.Business.Services
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll();
    }
}
