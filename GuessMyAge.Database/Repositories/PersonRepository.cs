using GuessMyAge.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyAge.Database.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly GuessMyAgeDbContext _dbContext;

        private readonly DbSet<PersonDatabaseEntity> _dbSet;
        public PersonRepository(GuessMyAgeDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Persons;
        }
        public void Create(PersonDatabaseEntity person)
        {
            _dbSet.Add(person);

            _dbContext.SaveChanges();
        }

        public IEnumerable<PersonDatabaseEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(PersonDatabaseEntity person)
        {
            _dbSet.Update(person);
            _dbContext.SaveChanges();
        }
    }
}
