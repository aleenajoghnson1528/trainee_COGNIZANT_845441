using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valrefe
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10; int  b = 20;
            showdata(a, b);
            Console.WriteLine("value after call by value method a= " + a + "b= " + b);
            showdata(ref a, ref b);
            Console.WriteLine("value after call by reference method a= " + a + " b = " + b);
            Console.ReadKey();
        }
        public static void showdata( int a, int b)
        {
            a = a + 10;
            b = b + 10;
            Console.WriteLine("sum of {0} and {1} = {2}", a, b, a + b);

        }
        public static void showdata(ref int m, ref int n)
        {
            m = m + 20;
            n = n + 20;
            Console.WriteLine("sum of {0} and {1}={2}", m, n, n + m);
            Console.WriteLine();
        }
    }
}
