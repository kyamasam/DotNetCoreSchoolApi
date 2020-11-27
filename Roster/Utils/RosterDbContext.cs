using Microsoft.EntityFrameworkCore;

namespace Roster.Models
{
    public class RosterDbContext : DbContext
    {
        public RosterDbContext(DbContextOptions<RosterDbContext> options) : base (options) {}
        
        public DbSet<School> School { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<ClassRoom> Classes { get; set; }
        public DbSet<Student> Students { get; set; }

       
    }
}