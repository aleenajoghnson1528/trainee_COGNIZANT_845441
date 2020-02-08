using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_prgm
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push("cake");
            stk.Push("biscut");
            stk.Push("choclate");
            foreach( string s in stk)
            {
                Console.WriteLine(s);
           }

            Console.WriteLine();
            stk.Pop();
            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }


        }
    }
}
