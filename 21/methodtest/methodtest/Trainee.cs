using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Trainee
    {

        //data fields
        string name, id, address; //instance variables can use in all methods inside a class
        public int age;
        public void Getdata(string nm, string id, string adr, int ag)
        {
            name = nm;
            this.id = id; // this indicate current class variale. when same name for local variable and class variable
            address = adr;
            age = ag;
        }
        public void ShowData()
        {
            Console.WriteLine(name);
            Console.WriteLine(id + " " + address);
            Console.WriteLine(age);
        }
    }
}
