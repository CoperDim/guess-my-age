using GuessMyAge.Database.Entities;
using GuessMyAge.Models;

namespace GuessMyAge.Business.Converters
{
    public static class GameConverter
    {
        public static Game ToGame(this GameDatabaseEntity databaseEntity)
        {
            var game =  new Game();
            game.End = databaseEntity.End;
            game.Start = databaseEntity.Start;
            game.UserName = databaseEntity.UserName;

            return game;
        }

        public static GameDatabaseEntity ToDatabaseEntity(this Game model)
        {
            var databaseEntity = new GameDatabaseEntity();
            databaseEntity.Start = model.Start;
            databaseEntity.End = model.End;
            databaseEntity.UserName = model.UserName;
            databaseEntity.PersonId = model.Person.Id;
            databaseEntity.UserName = model.UserName;
            databaseEntity.Player = new PlayerDatabaseEntity
            {
                UserName = model.UserName
            };

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