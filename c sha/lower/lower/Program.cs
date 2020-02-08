using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lower
{
    class Program
    {
        static void Main(string[] args)
        {

            string ename;
            Console.WriteLine("enter your name:");
            ename = Console.ReadLine();
            string upper = ename.ToUpper();

            Console.WriteLine(upper);
            Console.ReadKey();

        }

    }
    }

