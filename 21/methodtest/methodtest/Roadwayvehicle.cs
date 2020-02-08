using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Roadwayvehicle: Vehicle1
    {
        public virtual void Show()
        {
            Console.WriteLine("from road vehicle");
        }
    }
}
