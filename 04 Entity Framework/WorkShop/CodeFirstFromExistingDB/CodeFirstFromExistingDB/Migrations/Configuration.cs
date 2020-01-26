namespace CodeFirstFromExistingDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstFromExistingDB.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstFromExistingDB.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Courses.AddOrUpdate(e => e.Id,
                new Course
                {
                    Id = 4,
                    Name = "C#.NET",
                    Date = new DateTime(2009, 01, 03),
                    Description ="Training"
                  
                },
                 new Course
                 {
                     Id = 5,
                     Name = "EF",
                     Date = new DateTime(2009, 01, 05),
                     Description = "Training"
                 }
                );
        }
    }
}
