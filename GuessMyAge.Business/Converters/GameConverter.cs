using GuessMyAge.Database.Entities;
using GuessMyAge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyAge.Business.Converters
{
    public static class GameConverter
    {
        public static Game ToGame(this GameDatabaseEntity databaseEntity)
        {
            return new Game(databaseEntity.Start,
                                databaseEntity.End,
                                databaseEntity.PersonId,
                                databaseEntity.UserName,
                                databaseEntity.Id);
        }

        public static GameDatabaseEntity ToDatabaseEntity(this Game model)
        {
            var databaseEntity = new GameDatabaseEntity();
            databaseEntity.Start = model.Start;
            databaseEntity.End = model.End;
            databaseEntity.PersonId = model.PersonId;
            databaseEntity.UserName = model.UserName.ToString();


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