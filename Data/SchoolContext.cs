using Microsoft.EntityFrameworkCore;
using StudentDatabase.Models;

namespace StudentDatabase.Data
{
    // this class connects our app to the databse
    // it inherits from DbContext (Entity Framework thing)
    public class SchoolContext : DbContext
    {
        // this represents the Students table in the databse
        public DbSet<Student> Students { get; set; }

        // configure the database connection here
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // using SQLite so we dont need to install a big database
            optionsBuilder.UseSqlite("Data Source=school.db");
        }
    }
}
