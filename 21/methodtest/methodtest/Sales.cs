using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Sales
    {
        string pname;
        int qty;
        double price;
        public static double t;
       public static double totalsales;
      
        public Sales()
        { }
        public  Sales( int qnty, double pri) //for read only property
        {
            qty = qnty;
            price = pri;
            
        }

        public double display()
        {
            
            double total = qty * price;
            totalsales = total + totalsales;
            t = t + 1;
            return (total);
           

        }
        public static void show()
        {
            Console.WriteLine("total sales is {0}", totalsales);

        }
        public static void show1()
        {
            Console.WriteLine("number of the sales is {0}", t);
        }
    }
}
