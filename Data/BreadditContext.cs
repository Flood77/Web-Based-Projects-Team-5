using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Breaddit.Models;

namespace Breaddit.Data
{
    public class BreadditContext : DbContext
    {
        public BreadditContext (DbContextOptions<BreadditContext> options)
            : base(options)
        {
        }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<Post> Post { get; set; }

        public DbSet<Slice> Slice { get; set; }
    }
}
