using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idimarrayemp
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] employee = new String[6];
            Console.WriteLine("Enter the employee names:");
            for(int i=0;i<employee.Length;i++)
            {
                employee[i] = Console.ReadLine();
            }
            for(int i=0;i<employee.Length;i++)
            {
                Console.WriteLine("name of the employee no {0} : {1}", i + 1, employee[i]);
            }
            Console.ReadKey();
        }
    }
}
