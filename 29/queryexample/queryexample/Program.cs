using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queryexample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> clst = new List<Course>()
            {
                new Course{Cid=1,Cname="c#",Fees=7000,StartDate=Convert.ToDateTime("10-02-2020") },
                 new Course{Cid=2,Cname="java",Fees=5000,StartDate=Convert.ToDateTime("01-01-2020") },
                     new Course{Cid=3,Cname="python",Fees=2000,StartDate=Convert.ToDateTime("10-02-2020") },
                    new Course{Cid=4,Cname="c",Fees=4500,StartDate=Convert.ToDateTime("05-02-2020") },
            };

            var query =
                         from aq in clst
                         orderby aq.Fees
                         select aq;   //query must end with select clause
                        
            foreach(var q in query)
            {
                Console.WriteLine("{0}", q.Cid);
                Console.WriteLine();
                Console.WriteLine("{0}" ,q.Cname);
                Console.WriteLine();
                Console.WriteLine("{0}", q.StartDate.ToShortDateString());
                Console.WriteLine();
                Console.WriteLine("{0}", q.Fees);
              
            }
        }
    }
}
