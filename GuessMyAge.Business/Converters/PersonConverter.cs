using GuessMyAge.Database.Entities;
using GuessMyAge.Models;

namespace GuessMyAge.Business.Converters
{
    public static class PersonConverter
    {
        public static Person ToPerson(this PersonDatabaseEntity databaseEntity)
        {
            return new Person(databaseEntity.BirthDate,
                                databaseEntity.Name, 
                                databaseEntity.Job, 
                                databaseEntity.Genre, 
                                databaseEntity.Description, 
                                databaseEntity.Id);
        }

        public static PersonDatabaseEntity ToDatabaseEntity(this Person model)
        {
            var databaseEntity = new PersonDatabaseEntity();
            databaseEntity.BirthDate = model.BirthDate;
            databaseEntity.Job = model.Job;
            databaseEntity.Name = model.Name;
            databaseEntity.Genre = model.Genre.ToString();
            databaseEntity.Description = model.Description;
            databaseEntity.Games = new List<GameDatabaseEntity>();

            return databaseEntity;
        }

        public static IEnumerable<Person> ToModels(this IEnumerable<PersonDatabaseEntity> entities)
        {
            foreach (var entity in entities)
            {
               yield return ToPerson(entity);
            }
        }
    }
}
