using GuessMyAge.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyAge.Database.Repositories
{
    public interface IGameRepository
    {
        void Create(GameDatabaseEntity game);
        IEnumerable<GameDatabaseEntity> GetAll();

    }
}
