using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatortest
{
    class Calculator
    {
        int num1;
        int num2;
        public Calculator()
        { }
        public Calculator(int no1, int no2)
        {
            num1 = no1;
            num2 = no2;
        }
       
        public int add()
        {
            return num1 + num2;
        }
        public int sub()
        {
            return num1 - num2;
        }
        public int mul()
        {
            return num1 * num2;
        }
        public int div()
        {
            return num1 / num2;
        }
    }

}
