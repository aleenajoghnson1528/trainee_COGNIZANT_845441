using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age
{
    class Program
    {
        public static void method(int age, string name)
        {
            Console.WriteLine(" hi " + name + " birthday wishes now your age is " + age);
           
        }
        static void Main(string[] args)
        {
           
            method(22, "aleena");

            Console.ReadKey();

        }
    }
}
