using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdaexample
{
    class Program
    {
        public delegate void Mydelg(string s);  //for anaymous method

        static void Main(string[] args)
        {
            // lambdaexpressionexample();
            // multiplicationexample();

            //LamabaLinqOrder();

            //squareofanumber();
            //counttest();

            // ananymousexample();
            //task16areaoftriangle();
            Circle circle = new Circle();
            Console.WriteLine("enter radius of circle");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(circle.Calculate(x => 2 * (p + p * p)));
            Console.WriteLine(circle.Calculate(r => 2* Math.PI * p));
            Console.WriteLine();
            Console.WriteLine(circle.Calculate(r => Math.PI * p*p));
            Console.WriteLine(circle.Calculate(a => p * p * p));
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            Console.WriteLine(circle.Changecase(a => s.ToUpper()));
            Console.WriteLine("enter a string");
            string t = Console.ReadLine();
            Console.WriteLine(circle.Changecase(a => t.ToLower()));


        }

        private static void task16areaoftriangle()
        {
            Func<double, double, double> Calc = (x, y) => .5 * x * y;
            Console.WriteLine(Calc(5, 2));
        }

        private static void ananymousexample()
        {
            Mydelg delgt = a => Console.WriteLine(a);    //ananymous method
            delgt("hello");
        }

        private static void counttest()
        {
            int[] scores = { 78, 67, 89, 90, 86, 77, 65, 87, 98 };
            int exelent = scores.Where(n => n >= 85).Count();
            int aPlus = scores.Where(n => n >= 75).Count() - exelent;
            Console.WriteLine(exelent);
            Console.WriteLine(aPlus);
        }

        private static void squareofanumber()
        {
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(",", squaredNumbers));
        }

        private static void LamabaLinqOrder()
        {
            int[] nos = { 45, 23, 12, 98, 65 };
            var sort = nos.OrderBy(x => x);   //var is implicitly typed variable. var variable cant use as a instance variable. OrderBy is a Linq expression. orderby is a previously defined exteniton method. likewisw we can define our own methods. 
            Console.WriteLine(string.Join(" ", sort)); // in sort variable there is sorted array with integer type. so we explicitly convert it into string
        }





        private static void multiplicationexample()
        {
            Func<int, double, double> Calc = (x, y) => x * y;
            Console.WriteLine(Calc(12, 10.8));
        }

        private static void lambdaexpressionexample()
        {
            Func<int, int> Cube = a => a * a * a;  //take int input and produce integer output, Fun is a deligate that include a method, cube is method name, in func we can increas eparameter upo 16. if parameters are more than one it should be inside the bracket
            int cr = int.Parse(Console.ReadLine());
            Console.WriteLine(Cube(cr));
        }
    }
}
