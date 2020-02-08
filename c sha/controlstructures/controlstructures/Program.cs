using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlstructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if(a>10)
            {
                Console.WriteLine("a is greater than 10");
            }
            else if(a<10)
            {
                Console.WriteLine("a is less than 10");
            }
            else
            {
                Console.WriteLine("a is equal to 10");
            }



            int b = 3;
            switch(b)
            {

                case 1: Console.WriteLine("hello how are you?");
                        break;
                case 2:Console.WriteLine("where are you from?");
                        break;
                case 3:Console.WriteLine("how long u have been here?");
                       break;
                default: Console.WriteLine("false. something else");
                         break;
            }
            int num;
            Console.WriteLine("enter a number");
             num =int.Parse( Console.ReadLine());
            for (int i=0;i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }


            int m = 10;
            while(m<100)
            {
                Console.WriteLine("{0} is less than 100",m);
                m = m + 10;
            }

            int p = 10;
            do
            {
                p = p + 10;
                Console.WriteLine("{0} is less than 100", p);
                
            }
            while (p < 100);
        }
    }
}
