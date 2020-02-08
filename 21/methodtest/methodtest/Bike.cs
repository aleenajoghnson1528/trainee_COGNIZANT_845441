using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Bike
    {
       public  int Price { get; set; }
        public int Model { get; set; }
        public void display()
        {
            Console.WriteLine("1999 model bike");
            Console.WriteLine("price {0}", Price);
            Console.WriteLine("model 99{0}", Model);
        }

    }
}
