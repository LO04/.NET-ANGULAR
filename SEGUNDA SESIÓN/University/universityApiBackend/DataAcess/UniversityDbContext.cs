using Microsoft.EntityFrameworkCore;
using universityApiBackend.Models.DataModels;

namespace universityApiBackend.DataAcess
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {

        }
        //TODO: Add DbSets(TABLES OF OUT DATA BASE)
        public DbSet<User>? users { get; set; }
        public DbSet<Course>? courses { get; set; }
        public DbSet<Category>? categories { get; set; }
        public DbSet<Chapter>? Chapters{ get; set; }
        public DbSet<Student>? Students { get; set; }

    }
}
