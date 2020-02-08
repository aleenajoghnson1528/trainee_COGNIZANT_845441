using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listsortexample
{
    class Program
    {
        public delegate string Mydel(int x, int y);
        static void Main(string[] args)
        {
            List<Student> lst = new List<Student>
            {

                 new Student{ID=3,StudentNAme="adarsh",Course="c#"},
                 new Student{ID=1,StudentNAme="aleena",Course="java"},
                 new Student{ID=2,StudentNAme="anand",Course="python"},
                 new Student{ID=4,StudentNAme="lovely",Course="c"},
            };
            /*   lst.Sort();
               foreach (Student n in lst)
               {
                   Console.WriteLine("{0}  {1} {2}",n.ID,n.StudentNAme,n.Course);
               }
               */
            Student obj = new Student();
            List<Student> ls = obj.ListDemo(lst);
            foreach (var c in ls)
            {
                Console.WriteLine("{0}\n{1}\n{2}", c.ID, c.StudentNAme, c.Course);
            }
        }
    }
}
