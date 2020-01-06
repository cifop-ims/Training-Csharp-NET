using Queries.Core.Domain;
using Queries.Core.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Queries.Persistence.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(AppDbContext context) 
            : base(context)
        {
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return Container.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        {
            return Container.Courses
                .Include(c => c.Author)
                .OrderBy(c => c.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public AppDbContext Container
        {
            get { return Context as AppDbContext; }
        }
    }
}