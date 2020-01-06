using System.Data.Entity;

namespace CodeFirst
{
    public class AppDbContext : DbContext
    {
        public AppDbContext():base("name=Default")
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
