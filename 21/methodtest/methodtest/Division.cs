using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Divisionnew
    {
       public int result =0;

       public Divisionnew ()
        {
            
        }

        public double Divisiond(int num1,int num2)
        {
            try
            {
               result = num1 / num2;
                Console.WriteLine("hello");

                return result;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception arise {0}", e);
                throw e;
               
            }
            finally
            {
                Console.WriteLine("result is {0}", result);
            }

           

        }
    }
}
