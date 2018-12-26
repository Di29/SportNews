using System;
using System.Data.Entity;
using System.Linq;

namespace SportNews
{
    public class NewsContext : DbContext
    {
        public NewsContext()
            : base("name=NewsContext")
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }

    
}