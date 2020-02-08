using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Doitnew:IHello,Inew
    {
        public void Getit()
        {
            Console.WriteLine("hello");
        }
        public void Gotit()
        {
            Console.WriteLine("hai");
        }
    }
}
