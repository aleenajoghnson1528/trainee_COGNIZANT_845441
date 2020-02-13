using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirstDemoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //  InsertData();
           //  Showallemployees();
            //  selectonerowquery();

            //selectonerow();

            // update();
           removerow();

        }

        private static void removerow()
        {
            Employeecontext empnew = new Employeecontext();
            var employees = empnew.Employees;
            Console.WriteLine("Enter employee id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var query = from aq in employees
                        where aq.Eid == id
                        select aq;

            empnew.Employees.Remove(empnew.Employees.Find(id));
            empnew.SaveChanges();

            foreach (var emp in employees)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);

            }
        }

        private static void update()
        {
            Employeecontext empnew = new Employeecontext();
            var employees = empnew.Employees;
            Console.WriteLine("Enter employee id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new Designation::");
            string desg = Console.ReadLine();
            Console.WriteLine("Enter new salary:");
            double sal = Convert.ToDouble(Console.ReadLine());

            var query = from aq in employees

                        where aq.Eid == id

                        select aq;
            foreach (var e in query)
            {
                e.Designation = desg;
                e.Salary = sal;
            }
            empnew.SaveChanges();


            foreach (var emp in query)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);

            }
        }

        private static void selectonerowquery()
        {
            Employeecontext empnew = new Employeecontext();
            var employees = empnew.Employees;
            Console.WriteLine("Enter employee id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var query = from aq in employees
                        where aq.Eid == id
                        select aq;

            foreach (var emp in query)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);

            }
        }

        private static void selectonerow()
        {
            Employeecontext ect = new Employeecontext();
            Console.WriteLine("Enter employee id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var employees = ect.Employees;
            foreach (var emp in employees)
            {
                if (id == emp.Eid)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);
                }
            }
        }

        private static void Showallemployees()
        {
            Employeecontext empctx = new Employeecontext();
            var employees = empctx.Employees;
            foreach (var emp in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);
            }
        }

        private static void InsertData()
        {
            Employeecontext ect = new Employeecontext();
            Console.WriteLine("Enter employee name:");  //eid is declare as identity. so no need to provide value
            string name = Console.ReadLine();
            Console.WriteLine("Enter Designation::");
            string desg = Console.ReadLine();
            Console.WriteLine("Enter salary:");
            double sal = Convert.ToDouble(Console.ReadLine());
            ect.Employees.Add(new Employee { Ename = name, Designation = desg, Salary = sal });

            ect.SaveChanges();
        }
    }
}
