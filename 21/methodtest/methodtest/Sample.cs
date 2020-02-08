using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Sample
    {
        int no = 0;
        static int cnt = 0;
        public Sample()
        {
            no++;
            cnt++;
            Console.WriteLine("no {0} \n count {1}", no, cnt);
        }
        public static void show()
        {
            Console.WriteLine("function executing {0} times", cnt);
            //Console.WriteLine("function executing {0} times", no); // this will show erro. static method only access static variable
        }
    }
}
