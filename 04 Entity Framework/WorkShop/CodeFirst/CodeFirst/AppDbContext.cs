using System.Data.Entity;

namespace CodeFirst
{
    public class AppDbContext : DbContext
    {
        public AppDbContext():base("name=DefaultConnection")
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}
