using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialtest
{
    class Program
    {



        partial class A
        {
            public  void Substract(int x, int y)
            {
                Console.WriteLine("difference is {0}", x - y);
            }
        }

        partial class A
        {
            public void Add(int x,int y)
            {
                Console.WriteLine("sum is {0}", x + y);
            }
        }
        class Demo
        {
            public static void Main()

            {
                A obj = new A();
                obj.Add(7, 3);
                obj.Substract(15, 12);
            }

        }
        
    }
}
