using GuessMyAge.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyAge.Database
{
    public class GuessMyAgeDbContext : DbContext
    {
        public DbSet<PlayerDatabaseEntity> Players { get; set; }
        public DbSet<GameDatabaseEntity> Games { get; set; }
        public DbSet<PersonDatabaseEntity> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=c:\\Datas\\GuessMyAgeDB.db;");
        }

        public GuessMyAgeDbContext(DbContextOptions<GuessMyAgeDbContext> options)
               : base(options)
        {
        }
    }
}
