using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fileopearation
{
    class Program
    {
        static void Main(string[] args)
        {
            Fileop f1 = new Fileop();
            f1.CreateFile();
            f1.Display();
             f1.AddFile();
            f1.Deleteelement();
        }
    }
}
