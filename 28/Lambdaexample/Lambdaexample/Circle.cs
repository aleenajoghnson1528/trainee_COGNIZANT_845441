using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdaexample
{
    class Circle
    {
        private double radius;
        string st;
        public double Calculate(Func<double, double> mp)

        {
            return mp(radius);
        }
        public string Changecase(Func<string,string>uc)
        {
            return uc(st);
        }
    }
}
