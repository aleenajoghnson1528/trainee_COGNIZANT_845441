using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlegateexample
{
    class Program
    {
        //delegate  declaration
        public delegate string Mydel(int x, int y);
        static void Main(string[] args)
        {
           /* Mydel delg = new Mydel(Add);
            Console.WriteLine(delg(12, 25));
            delg += new Mydel(Substract);
            delg += new Mydel(Mul);
            Console.WriteLine(delg(5,6));
            delg -= new Mydel(Mul);
            Console.WriteLine(delg(20, 50));  */

            Action<int, int> Multiply = (x, y) => Console.WriteLine("{0}", x * y);
            Multiply(2, 5);
            Func<int, int, double> ad = (x, y) => x + y;
            Console.WriteLine(ad(3, 4));  

            List<Student> lst = new List<Student>
            {
                new Student{ID=1,StudentNAme="aleena",Course="c#"},
                new Student{ID=2,StudentNAme="anand",Course="c#"},
                new Student{ID=3,StudentNAme="adarsh",Course="c#"},
                new Student{ID=1,StudentNAme="lovely",Course="c#"},
            };


            Predicate<Student> fst = x => x.ID == 3;
            Student st = lst.Find(fst);  //or  Student st = lst.Find(fst); 
            Console.WriteLine("{0}\t{1}\t{2}", st.ID, st.StudentNAme, st.Course);
        }
        static string Add(int x, int y)

        {
            int result = x + y;
            return (string.Format("{0}+{1}={2}", x, y, result));
        }
        static string Substract(int x, int y)
        {
            int result = x - y;
            return (string.Format("{0}-{1}={2}", x, y, result));

        }
        static string Mul(int x, int y)
        {
            int result = x * y;
            return (string.Format("{0}*{1}={2}", x, y, result));
        }
    }

   
}
