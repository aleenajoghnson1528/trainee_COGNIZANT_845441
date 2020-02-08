using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sortedlistexample
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList slist = new SortedList();
            slist.Add("aleena", 123);
            slist.Add("anand", 345);
            slist.Add("adarsh", 678);
            slist.Add("johnson", 698);
            foreach(string k in slist.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();
            foreach (int i in slist.Values)
            {
                Console.WriteLine(i);
            }
        }
    }
}
