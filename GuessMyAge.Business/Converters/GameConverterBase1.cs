using GuessMyAge.Database.Entities;
using GuessMyAge.Models;

namespace GuessMyAge.Business.Converters
{
    public static class GameConverterBase1
    {
        public static Game ToGame(this GameDatabaseEntity databaseEntity)
        {
            return new Game(databaseEntity.Start,
                                databaseEntity.End,
                                databaseEntity.PersonId,
                                databaseEntity.UserName,
                                databaseEntity.Id);
        }
    }
}