using GuessMyAge.Database.Entities;
using GuessMyAge.Models;

namespace GuessMyAge.Business.Converters
{
    public static class GameConverter
    {
        public static Game ToGame(this GameDatabaseEntity databaseEntity)
        {
            return new Game(
                databaseEntity.ToGame().Person,
                databaseEntity.ToGame().MaxTurn);
        }

        public static GameDatabaseEntity ToDatabaseEntity(this Game model)
        {
            var databaseEntity = new GameDatabaseEntity();
            databaseEntity.Start = model.ToDatabaseEntity().Start;
            databaseEntity.End = model.ToDatabaseEntity().End;
            databaseEntity.PersonId = model.ToDatabaseEntity().PersonId;
            databaseEntity.UserName = model.ToDatabaseEntity().UserName.ToString();

            return databaseEntity;
        }

        public static IEnumerable<Game> ToModels(this IEnumerable<GameDatabaseEntity> entities)
        {
            foreach (var entity in entities)
            {
                yield return ToGame(entity);
            }
        }
    }
}