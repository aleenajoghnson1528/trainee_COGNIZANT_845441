using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Demo
    {






        int no;
        int no1;
        public Demo()
        { }
        public Demo(int num1, int num2)
        {
            no = num1;
            no1 = num2;
        }
        public static Demo operator +(Demo x, Demo y)

        {
            Demo t = new Demo();
            t.no = x.no + y.no;
            t.no1 = x.no1 + y.no1;
            return t;

        }
       
        public static Demo operator -(Demo x, Demo y)

        {
            Demo t = new Demo();
            t.no = x.no - y.no;
            t.no1 = x.no1 - y.no1;
            return t;

        }


        public static Demo operator *(Demo x, Demo y)
        {
            Demo t = new Demo();
            t.no = x.no * y.no;
            t.no1 = x.no1 * y.no1;
            return t;
        }

        public void ShowData()
        {
            Console.WriteLine("{0} \n {1}", no, no1);
        }
    }
}
