using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatortest
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, opt;
            Console.WriteLine(".....CALCULATOR..,....");
              Console.WriteLine("menu");
            Console.WriteLine("1.addition");
            Console.WriteLine("2.subtarction");
            Console.WriteLine("3.multiplication");
            Console.WriteLine("4.division");
            Console.WriteLine("enter your option");
            opt = int.Parse(Console.ReadLine());
            Console.WriteLine("enter first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = int.Parse(Console.ReadLine());


            Calculator c1 = new Calculator(num1,num2);
            if (opt == 1)
            {
                int data = c1.add();

                Console.WriteLine(data);

            }
            else if (opt == 2)
            {
                int data1 = c1.sub();
                Console.WriteLine(data1);
            }
            else if (opt == 3)
            {
                int data2 = c1.mul();
                Console.WriteLine(data2);
            }

            else if (opt == 4)
            { int data3 = c1.div();
                Console.WriteLine(data3);
            }
            else
            {
                Console.WriteLine("wrong option");
            }
            Console.ReadLine();

        }
    }
}
