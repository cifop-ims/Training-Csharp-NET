using System.Data.Entity;
using Queries.EntityConfigurations;

namespace Queries
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());
        }
    }
}
