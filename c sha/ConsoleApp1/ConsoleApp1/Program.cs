using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypeexample
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 10.95f;
            Console.WriteLine("value of f is {0}", f);
            
            byte b = 255;
            Console.WriteLine("value of  b is {0}", b);
            
            short s = 359;
            Console.WriteLine("value of  s is {0}", s);
            
            int i = 345;
            Console.WriteLine("value of  i is {0}", i);
            
            uint u = 99999;
            Console.WriteLine("value of  u is {0}", u);
           
            long l = 18643867;
            Console.WriteLine("value of  l is {0}", l);
            
            ulong p = 366373;
            Console.WriteLine("value of  p is {0}", p);
           
            double d = 3658d;
            Console.WriteLine("value of  d is {0}", d);
          
            decimal m = 386638m;
            Console.WriteLine("value of  m is {0}", m);
           
            DateTime dt = DateTime.Now;
            Console.WriteLine("The current date is {0}", dt);


            Console.WriteLine("short date is {0}", dt.ToShortDateString());
            Console.WriteLine("The long date is {0}", dt.ToLongDateString());
            Console.WriteLine("the short time is {0}", dt.ToShortTimeString());
            Console.WriteLine("The long time string  {0}", dt.ToLongTimeString());

            Console.ReadKey();



        }
    }
}
