using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    class Program
    {

        public delegate void Mydelg(string s);
        static void Main(string[] args)
        {
            string str = "twinkle twinkle";
            int i = str.WordCount();
            Console.WriteLine(i);
       
        }
    }
}
