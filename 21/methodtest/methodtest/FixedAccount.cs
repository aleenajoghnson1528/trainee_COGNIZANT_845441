using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class FixedAccount : BankAccount
    {
        public override void InterestAmount(double Balance)
        {
            double si = Balance * 5 * 10 * 3 / 10000;
            Console.WriteLine(" intrest {0}",si);
        }
    }
}
