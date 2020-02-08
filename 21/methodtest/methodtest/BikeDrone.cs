using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class BikeDrone:Bike,IDrone
    {
        public void  getfeature()
        {
            Console.WriteLine("heavy drone");
        }
        public void display()
        {
            Console.WriteLine("new bike");
            
        }
    }
}
