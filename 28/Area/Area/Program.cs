using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        public delegate void Deleventhandler();
        public static event Deleventhandler handler;
        static void Main(string[] args)
        {
            handler += new Deleventhandler(Square);
            handler += new Deleventhandler(Circle);
            handler.Invoke();
        }

        static void Circle()
        {
            double r = 12.5;
            double ar = Math.PI * r * r;
            Console.WriteLine("area of circle is {0}", ar);
        }
        static void Square()
        {
            int l = 45;
            int y = 5;
            double area = l * y;
            Console.WriteLine("area of square is {0}", area);
        }
    }
}
