using GuessMyAge.Business.Converters;
using GuessMyAge.Database;
using GuessMyAge.Database.Entities;
using GuessMyAge.Models;
using Microsoft.EntityFrameworkCore;


namespace GuessMyAge.Business.Services
{
    public class GameService : IGameService
    {
        private readonly DbSet<GameDatabaseEntity> _dbSet;

        private readonly GuessMyAgeDbContext _context;

        private IQueryable<GameDatabaseEntity> ReadOnlyQueryable => _dbSet.AsNoTracking();
        
        public GameService(GuessMyAgeDbContext context)
        {
            _dbSet = context.Games;
            _context = context;
        }
        public Game Create(Game model)
        {
            var databaseEntity = model.ToDatabaseEntity();

            _dbSet.Add(databaseEntity);
            _context.SaveChanges();

            return databaseEntity.ToGame();
        }

        public IEnumerable<Game> GetAll()
        {
            return ReadOnlyQueryable.ToList().ToModels();
        }
    }
}