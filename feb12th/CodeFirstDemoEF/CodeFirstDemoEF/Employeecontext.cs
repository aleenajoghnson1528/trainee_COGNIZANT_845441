using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDemoEF
{
    class Employeecontext: DbContext//collection of entitties  // Dbcontext is a class from using System.Data.Entity; namespace
    {
       public DbSet<Employee> Employees { get; set; }  //dbset type propery is 'Employees'. it is the collection of employees
    }
}
