﻿using Queries.Core.Domain;
using Queries.Core.Repositories;
using System.Data.Entity;
using System.Linq;

namespace Queries.Persistence.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(AppDbContext context) : base(context)
        {
        }

        public Author GetAuthorWithCourses(int id)
        {
            return PlutoContext.Authors.Include(a => a.Courses).SingleOrDefault(a => a.Id == id);
        }

        public AppDbContext PlutoContext
        {
            get { return Context as AppDbContext; }
        }
    }
}