using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Scale
    {
        double cm;
        public double Inch
        {
            get { return cm / 2.54; }
            set
            {
                cm = value * 2.54;
            }
        }
        public void showmeasure()
        {
            Console.WriteLine(" measurement in centimeter is  {0}", cm);
        }
    }
}
