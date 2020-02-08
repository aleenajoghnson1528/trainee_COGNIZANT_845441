using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addusingclass
{
    class Program
    {

        public int add(int x,int y)
        {
            int result = x + y;
            return result;
        }
        static void Main(string[] args)
        {
            int x, y, s;
            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());

            Program obj = new Program();
            s = obj.add(x, y);
            Console.WriteLine("sum is " + s);
        }
    }
}
