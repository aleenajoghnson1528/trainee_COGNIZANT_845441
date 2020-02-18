using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Newdemo
{
    class Contextclass: DbContext
    {

         public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
