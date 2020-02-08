using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Circle:Shape
    {

        public override double Area(int r)
        {
            double area = 2 * 3.14 * r;
            Console.WriteLine("area of circle is {0}",area);
            return area;

        }
    }
}
