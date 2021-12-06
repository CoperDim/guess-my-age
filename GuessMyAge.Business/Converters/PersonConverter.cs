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
                                databaseEntity.Description);
        }
    }
}
