using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbfirstconsoleapp
{
    class Program
    {
        static EmployeenewdbEntities mdb = new EmployeenewdbEntities();
        static void Main(string[] args)
        {
            insertdata();

            //  allemployees();
            // alldep();

            //insertdep();
        }

        private static void insertdep()
        {
            Console.WriteLine("Enter dep id");
            int did = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter department name");
            string dname = Console.ReadLine();
            var depnew = new Department
            {
                DepID = did,
                DepName = dname

            };
            mdb.Departments.Add(depnew);
            mdb.SaveChanges();
        }

        private static void insertdata()
        {
            Console.WriteLine("Enter Employeee id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter salary");
            double salary = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Enter ssn");
            long ssn = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter department id");
            int did = Convert.ToInt32(Console.ReadLine());


            var employeenew = new employee
            {
                EmpID = id,
                EmpName = name,
               SSN = ssn,
                Salary = salary,
                DepID = did

            };
            mdb.employees.Add(employeenew);
            mdb.SaveChanges();
        }

        private static void alldep()
        {
            Console.WriteLine("all available employees....");
            var employee = mdb.employees;
            foreach (var e in employee)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", e.EmpID, e.EmpName, e.Salary, e.SSN, e.DepID);

            }
        }

        private static void allemployees()
        {
            Console.WriteLine("all available departments....");
            var department = mdb.Departments;
            foreach (var c in department)
            {
                Console.WriteLine("{0}\t{1}", c.DepID, c.DepName);

            }
        }
    }
}
