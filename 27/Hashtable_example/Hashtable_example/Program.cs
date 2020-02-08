using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashtable_example
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable hst = new Hashtable();
            hst.Add("aleena", "12345");
            hst.Add("anand", "125");
            hst.Add("adarsh", "145");


            foreach(string k in hst.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();

            foreach (string h in hst.Values)
            {
                Console.WriteLine(h);
            }
            Console.WriteLine();

            hst.Remove("adarsh");


       
            foreach (string k in hst.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();
        }
    }
}
