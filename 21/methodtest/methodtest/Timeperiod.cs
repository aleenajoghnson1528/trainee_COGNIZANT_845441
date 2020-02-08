using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Timeperiod
    {

        double seconds;
        public double Hours
        {
            get { return seconds / 3600; }
            set
            {
                 if (value<0 || value >24)
                {
                    throw new Exception("invalid entering");
                }
                seconds = value * 3600;
            }
        }

        public void showseconds()
        {
            Console.WriteLine(" time in second is  {0}", seconds);
        }
    }
}
