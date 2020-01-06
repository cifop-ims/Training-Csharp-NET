using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new AppDbContext();

            //Restriction
            //var query00 =
            //    from c in context.Courses
            //    where c.Author.Id == 1
            //    select c;

            //Ordering
            //var query01 =
            //  from c in context.Courses
            //  where c.Author.Id == 1
            //  orderby c.Level descending, c.Name
            //  select c;

            //Projection
            //var query02 =
            //   from c in context.Courses
            //   where c.Author.Id == 1
            //   orderby c.Level descending, c.Name
            //   select new { Name = c.Name, Level = c.Level, AuthorName = c.Author.Name };

            //Grouping
            //var query03 =
            //   from c in context.Courses
            //   group c by c.Level
            //   into g
            //   select g;

            //foreach (var group in query03)
            //{
            //    System.Console.WriteLine(group.Key);
            //    foreach (var course in group)
            //    {
            //        System.Console.WriteLine($"\t {course.Name}");
            //    }
            //}

            //Join
            //var query04 =
            //    from c in context.Courses
            //    join a in context.Authors on c.AuthorId equals a.Id
            //    select new { Name = c.Name, AuthorName = a.Name };

            //Group Join
            //var query05 =
            //    from a in context.Authors
            //    join c in context.Courses on a.Id equals c.AuthorId into g
            //    select new { AuthorName = a.Name, Count = g.Count() };

            //Cross Join
            //var query05 =
            //    from a in context.Authors
            //    from c in context.Courses
            //    select new { AuthorName = a.Name, CourseName = c.Name };

            //var courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderBy(c => c.Level)
            //    .ThenByDescending(c => c.Name);
            //var courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderBy(c => c.Level)
            //    .ThenByDescending(c => c.Name)
            //    .Select(c=>new { Name = c.Name, AuthorName = c.Author.Name });
            //var courses = context.Courses
            //   .Where(c => c.Level == 1)
            //   .OrderBy(c => c.Level)
            //   .ThenByDescending(c => c.Name)
            ////   .SelectMany(c => c.Tags);
            //var groups = context.Courses.GroupBy(c => c.Level);
            //var join = context.Courses.Join(context.Authors,
            //    c => c.AuthorId,
            //    a => a.Id,
            //    (course, author) => new { CourseName = course.Name, AuthorName = author.Name });
            //var groupJoin = context.Authors.GroupJoin(context.Courses,
            //    a => a.Id,
            //    c => c.AuthorId,
            //    (author, course) => new { Courses = course.Count(), AuthorName = author.Name });
            //var crossJoin = context.Authors.SelectMany(c => c.Courses,
            //    (author, course) => new { AuthorName = author.Name, CourseName = course.Name });
            //Additional Methods
            //Partioning
            var page = context.Courses.Skip(2).Take(5);
            var element = context.Courses.OrderBy(c => c.Level).FirstOrDefault(c => c.Level == 1);
            var istrue = context.Courses.All(c => c.FullPrice > 10);
            istrue = context.Courses.Any(c => c.Level == 1);
            var count = context.Courses.Count();
            var max = context.Courses.Max(c => c.FullPrice);
        }
    }
}
