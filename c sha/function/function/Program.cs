using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class Program
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter the first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b = int.Parse(Console.ReadLine());
            double pro = multiply(a, b);
            Console.WriteLine("product of {0} and {1} is {2}", a, b, pro);
            add(a, b);

        }
        public static double multiply(int a, int b)
        {
            double result = a * b;
            return result;
        }
        public static void add(int a,int b)
        {
            double res = a + b;
            Console.WriteLine("sum of {0} and {1} is {2}", a, b, res);
          

        }
    }
} 
