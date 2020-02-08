using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Ship : Vehicle1
    {
        public void Showship()
        {
            Console.WriteLine("from ship");
        }
        new public void Showvehicle() // same method in base class can hide using new keyword
        {
            Console.WriteLine("linear ship");
        }
    }
}
