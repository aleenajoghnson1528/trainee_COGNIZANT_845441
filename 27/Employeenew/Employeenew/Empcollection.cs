using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeenew
{
    
       
        class Empcollection
        {

                 List<Employee> emplist = new List<Employee>();
        public void Adddata(int Eid1, string Ename1, string Designation1, double Salary1)
        {
            emplist.Add(new Employee
            {
                Eid = Eid1,
                Ename = Ename1,
                Designation = Designation1,
                Salary = Salary1

            });

        }
            public void Display()
            {
                foreach (Employee emp in emplist)
                {
                     Console.WriteLine("{0} \t {1} \t {2}\t{3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);
                       // return string.Format("{0} \t {1} \t {2}\t{3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);
                
                }
            }
            public void Removedata(int index)
           {
                emplist.RemoveAt(index);
            }
       
        }
        
   
}
