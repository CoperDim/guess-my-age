using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuessMyAge.Database.Entities
{
    [Table("Game")]
    public class GameDatabaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public int PersonId { get; set; }
        public string UserName { get; set; }

        [ForeignKey("PersonId")]
        public PersonDatabaseEntity Person { get; set; }

        [ForeignKey("UserName")]
        public PlayerDatabaseEntity Player { get; set; }
    }
}
