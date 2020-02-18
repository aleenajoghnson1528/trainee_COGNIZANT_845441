using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Bookapp
{
    class ContextClass:DbContext
    {
        public ContextClass() :base("Contextclass") { }
        public DbSet<Author> Authores { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Detail>Details { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}
