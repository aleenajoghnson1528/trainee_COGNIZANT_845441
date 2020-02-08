using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateArea
{
    class Program
    {
        public delegate string Mydel(int x, int y);
        static void Main(string[] args)
        {
            Mydel delg = new Mydel(AreaRect);
           
            Console.WriteLine(delg(5, 6));
            delg += new Mydel(Square);
            
            Console.WriteLine(delg(3,2));
        }
        static string AreaRect(int x, int y)
        {
            int result = x * y;
            return (string.Format("area of square is{0}", result));
        }
        static string Square(int x,int y)

        {
            int result = x * y;
            return (string.Format("area of square is {0}", result));
        }
    }
}
