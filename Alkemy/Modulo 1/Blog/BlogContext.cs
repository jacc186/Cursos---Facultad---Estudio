using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Blog
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {

        }

        public DbSet<Comments> Comments { get; set;}
        public DbSet<Posts> Posts { get; set;}
        public DbSet<Usuario> Users { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Yisus;Database=Alkemy1;Trusted_Connection=True;");
        }
    }
}
