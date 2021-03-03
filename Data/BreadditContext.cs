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

        public DbSet<Breaddit.Models.Comment> Comment { get; set; }

        public DbSet<Breaddit.Models.Post> Post { get; set; }
    }
}
