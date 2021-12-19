using GuessMyAge.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyAge.Database.Repositories
{
    // On hérite de notre classe de base BaseRepository
    public class PersonRepository : BaseRepository<PersonDatabaseEntity>, IPersonRepository
    {
        // Regarde le nouveau constructeur qui fait un base pour construire la classe de base avec le contexte
        public PersonRepository(GuessMyAgeDbContext context) : 
            base(context)
        {
            // Comme on assigne le dbSet et context dans la classe de base, on n'en n'a plus besoin ici
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
