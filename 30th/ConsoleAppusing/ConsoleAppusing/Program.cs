using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryExample;

namespace ConsoleAppusing
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();
            c1.NO1 = 20;
            c1.NO2 = 5;
            Console.WriteLine(c1.Add());
            Console.WriteLine(c1.Difference());
            Console.WriteLine(c1.Multiply());
            Console.WriteLine(c1.Division());


        }
    }
}
