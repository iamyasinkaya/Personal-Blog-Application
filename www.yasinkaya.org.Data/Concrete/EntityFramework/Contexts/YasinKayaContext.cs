using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.Concrete;

namespace www.yasinkaya.org.Data.Concrete.EntityFramework.Contexts
{
    public class YasinKayaContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=YasinKayaDb;Integrated Security=True");
        }
    }
}
