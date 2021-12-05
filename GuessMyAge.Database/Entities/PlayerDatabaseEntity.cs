using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuessMyAge.Database.Entities
{
    [Table("Player")]
    public class PlayerDatabaseEntity
    {
        [Key]
        public string UserName { get; set; }

        public IEnumerable<GameDatabaseEntity> Games { get; set; }
    }
}