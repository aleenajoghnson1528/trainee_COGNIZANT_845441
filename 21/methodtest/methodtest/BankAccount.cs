using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class BankAccount
    {
       public int Account_no { get; set; }
        public double Balance { get; set; }
       
        public virtual void InterestAmount(double Balance)
        {

            double si = Balance * 5 * 10 / 100;
            Console.WriteLine("intrest is {0}",si);
        }
    }
}
