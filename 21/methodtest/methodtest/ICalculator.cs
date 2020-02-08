using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    interface ICalculator
    {
        int add(int a, int b);
    }
    interface ICalculator1
    {
        int sub(int a, int b);
    }
    interface ICalculator2
    {
        int mul(int a, int b);

    }
    interface ICalculator3
    {
        int div(int a, int b);
    }
    class Calculation: ICalculator, ICalculator1, ICalculator2, ICalculator3
    {
        public int result1;
        public int add(int a,int b)
        {
            return result1 = a + b;
        }
        public int result2;
        public int sub(int a,int b)
        {
            return result2 = a - b;
        }
          public int result3;
            public int mul(int a,int b)
        {
            return result3 = a * b;
        }
        public int result4;
        public int div(int a, int b)
        {
            return result4 = a /b;
        }
    }
}
