using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuessMyAge.Database.Entities
{
    [Table("Person")]
    public class PersonDatabaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }

        public string Name { get; set; }
        public string Job { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }

        public IEnumerable<GameDatabaseEntity> Games { get; set; }
    }
}
