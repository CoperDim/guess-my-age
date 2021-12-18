using GuessMyAge.Database.Entities;
using GuessMyAge.Models;

namespace GuessMyAge.Business.Converters
{
    public static class GameConverterBase
    {
        public static GameDatabaseEntity ToDatabaseEntity(this Game model)
        {
            var databaseEntity = new GameDatabaseEntity();
            databaseEntity.Start = model.Start;
            databaseEntity.End = model.End;
            databaseEntity.PersonId = model.PersonId;
            databaseEntity.UserName = model.UserName.ToString();
        }
    }
}