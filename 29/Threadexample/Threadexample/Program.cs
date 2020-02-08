using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threadexample
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart tsd = new ThreadStart(getNumbers);
            Thread th = new Thread(tsd);
            th.Start(); 
            ThreadStart td = new ThreadStart(Getevennumbers);
            Thread t = new Thread(td);
            t.Start();  
        }
        public static void getNumbers()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("{0}", i);
                Thread.Sleep(500);
            }
        }
        public static void Getevennumbers()
        {
            for (int i = 2; i <= 20;i=i+2)
            {

                Console.WriteLine("{0}", i);
            }
        
        }

       
    }
}
