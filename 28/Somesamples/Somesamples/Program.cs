using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somesamples
{
    class Program
    {
        public delegate string Mydel(int x, int y);
        static void Main(string[] args)
        {

            var obj = new SomeSamples<string>();
            obj[0] = "trial";
            Console.WriteLine(obj[0]);
            var obj1 = new SomeSamples<Current>();
            obj1[0] = new Current
            {
                A = 5,
            Mark = "hello"
            };
            obj1[1] = new Current
            {
                A = 10,
                Mark = "hai"
            };
            Console.WriteLine("{0}  {1}  ",obj1[0].A,obj1[0].Mark); 

        }
    }
}
