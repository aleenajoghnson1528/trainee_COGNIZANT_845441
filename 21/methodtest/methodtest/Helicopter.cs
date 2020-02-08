using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Helicopter : Iairborne
    {
        public void Fly()
        {
            Console.WriteLine("A helicopter, or chopper, is a type of rotorcraft in which lift and thrust are supplied by rotors. ");
        }
    }
    class Aeroplane : Iairborne
    {
        public void Fly()
        {
            Console.WriteLine("this is aeroplane");
        }
    }

}
