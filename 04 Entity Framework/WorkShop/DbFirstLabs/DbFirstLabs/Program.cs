using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DbFirstLabEntities();
            
            var post = new Post {
                Title = "Title 3",
                Descripiton = "Description 3",
                Date = DateTime.Now
            };

            context.Posts.Add(post);
            context.SaveChanges();

        }
    }
}
