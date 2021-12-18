using GuessMyAge.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyAge.Database.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly GuessMyAgeDbContext _dbContext;

        private readonly DbSet<GameDatabaseEntity> _dbSet;
        public GameRepository(GuessMyAgeDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Games;
        }
        public void Create(GameDatabaseEntity Game)
        {
            _dbSet.Add(Game);

            _dbContext.SaveChanges();
        }
        public IEnumerable<GameDatabaseEntity> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
