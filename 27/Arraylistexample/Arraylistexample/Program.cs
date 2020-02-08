using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arraylistexample
{
    class Program
    {

       // ArrayList alist = new ArrayList();
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            {
                "aleena","anand","adarsh"
            };

            foreach(string a in al)
            {
                Console.WriteLine(a);
               
            }
            Console.WriteLine();

            al.Sort();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            al.Add("lovely");
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();


            al.Insert(4, "johnson");
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            al.Reverse();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }

            string[] r = new string[] { " cat", "mat" };
            al.SetRange(1, r);
            Console.WriteLine();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            al.RemoveRange(2, 2);
            Console.WriteLine();

            foreach (string a in al)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine();
        }
    }
}
