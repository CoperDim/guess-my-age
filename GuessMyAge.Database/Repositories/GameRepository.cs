using GuessMyAge.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace GuessMyAge.Database.Repositories
{
    public class GameRepository: IGameRepository
    {
        private readonly GuessMyAgeDbContext _dbContext;

        private readonly DbSet<GameDatabaseEntity> _dbSet;

        public GameRepository(GuessMyAgeDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Games;
        }
        public void Create(GameDatabaseEntity game)
        {
            _dbSet.Add(game);
           _dbContext.SaveChanges();
        }

        public IEnumerable<GameDatabaseEntity> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}