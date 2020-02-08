using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{

    enum department
    {
        physics = 10,
        chemistry,
        maths = 15,
        biology = 18
    }
    enum weekdays
    {
        sunday = 1,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            int d = (int)department.maths;

          Console.WriteLine("Departmentid of maths is : {0}",d);

            int c = (int)department.chemistry;
            Console.WriteLine("Deparetment id of chemistry is : {0}", c);


            int w = (int)weekdays.monday;
            Console.WriteLine("monday is {0} th/st day", w);

            int z = (int)weekdays.friday;
            Console.WriteLine("friday is {0}", z);
        }
    }
}
