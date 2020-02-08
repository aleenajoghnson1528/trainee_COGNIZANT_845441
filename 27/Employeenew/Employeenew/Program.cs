using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeenew
{
    class Program
    {
        static void Main(string[] args)
        {

            Empcollection e1 = new Empcollection();
            e1.Adddata(1, "aleena", "analyst trainee", 40000);
            e1.Adddata(2, "anand johnson", " associate trainee", 50000);
            e1.Adddata(3, "adarsh", "tourist trainee", 450000);
           // Console.WriteLine(e1.Display());
            e1.Display();
            e1.Removedata(1);
            Console.WriteLine();
            Console.WriteLine("after removing  one record the list will be...");
            Console.WriteLine();
            e1.Display();
        }   
    }
}
