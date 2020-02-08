using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_example
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue qu = new Queue();

            qu.Enqueue(123);
            qu.Enqueue(134);
            qu.Enqueue(345);
            foreach (int i in qu)
            {
                Console.WriteLine(i);
            }
            
            qu.Dequeue();
            Console.WriteLine();
            foreach (int i in qu)
            {
                Console.WriteLine(i);
            }


        }
    }
}
