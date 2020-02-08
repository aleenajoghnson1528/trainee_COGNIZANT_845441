using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace result
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam obj1 = new Exam();
            Console.WriteLine();
            obj1.GetData(1, "aleena", "CSE", 80, 85, 80);
            obj1.ShowData();
        }
    }
}
