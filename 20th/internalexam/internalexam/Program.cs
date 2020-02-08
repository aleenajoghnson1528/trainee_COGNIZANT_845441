using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internalexam
{

    class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;

            }

            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person obj = new Person();
            obj.Name = "aleena";
            Console.WriteLine(obj.Name);
        }
    }
}
