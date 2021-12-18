using GuessMyAge.Business.Converters;
using GuessMyAge.Database;
using GuessMyAge.Database.Entities;
using GuessMyAge.Models;
using Microsoft.EntityFrameworkCore;


namespace GuessMyAge.Business.Services
{
    public class PersonService : IPersonService
    {
        private readonly DbSet<PersonDatabaseEntity> _dbSet;

        private readonly GuessMyAgeDbContext _context;

        private IQueryable<PersonDatabaseEntity> ReadOnlyQueryable => _dbSet.AsNoTracking();
        public PersonService(GuessMyAgeDbContext context)
        {
            _dbSet = context.Persons;
            _context = context;
        }
        public Person Create(Person model)
        {
            var databaseEntity = model.ToDatabaseEntity();

            _dbSet.Add(databaseEntity);
            _context.SaveChanges();

            return databaseEntity.ToPerson();
        }

        public IEnumerable<Person> GetAll()
        {
            return ReadOnlyQueryable.ToList().ToModels();
        }

        public void Update(Person model)
        {
            var databaseEntity = model.ToDatabaseEntity();

            _dbSet.Update(databaseEntity);
            _context.SaveChanges();
        }
    }
}
