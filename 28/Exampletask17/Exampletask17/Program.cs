using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exampletask17
{
    class Program
    {
        public delegate string Mydel(int x, int y);
        static void Main(string[] args)
        {
            var obj = new Sample<string>();
            obj[0] = "employee details";
            Console.WriteLine(obj[0]);
            var obj1 = new Sample<Employee>();
            obj1[0] = new Employee
            {
               Id=123,
               Ename="aleena",
               Price=4500,
               Description="car"

            };
           
            obj1[1] = new Employee
            {
                Id = 123,
                Ename = "ANAND",
                Price = 4500,
                Description = "AUTO"

            };
            Console.WriteLine("{0}  {1}  {2} {3} ", obj1[0].Id, obj1[0].Ename,obj1[0].Price,obj1[0].Description);
            Console.WriteLine("{0}  {1}  {2} {3} ", obj1[1].Id, obj1[1].Ename, obj1[1].Price, obj1[1].Description);


        }
    }
}
