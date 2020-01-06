using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var post = new Post()
                {
                    Title = "Title 1",
                    Description = "Description 1",
                    Date = DateTime.Now
                };

                context.Posts.Add(post);
                context.SaveChanges();
            }
        }
    }
}
