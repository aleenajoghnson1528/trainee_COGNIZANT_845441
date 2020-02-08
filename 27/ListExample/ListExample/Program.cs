using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stlist = new List<string>();
            stlist.Add("programming languages");
            stlist.Add("c#");
            stlist.Add("java");
            stlist.Add("python");
            stlist.Add("php");
            stlist.Add("c");
            stlist.Add("c++");
            foreach (string s in stlist)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            stlist.Insert(3, "R");
            foreach (string s in stlist)
            {
                Console.WriteLine(s);
            }
        }
    }
}