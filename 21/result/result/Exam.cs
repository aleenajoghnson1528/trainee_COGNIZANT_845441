using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace result
{
    class Exam
    {
        int rolno;
        string name;
        string department;
        int mark1;
        int mark2;
        int mark3;
        public void GetData(int rlno, string nm, string dep, int m1, int m2, int m3)
        {
            rolno = rlno;
            name = nm;
            department = dep;
            mark1 = m1;
            mark2 = m2;
            mark3 = m3;
        }
        public void ShowData()
        {
            Console.WriteLine(rolno);
            Console.WriteLine(name);
            Console.WriteLine(" department id is " + department);
            Console.WriteLine("mark for computer science is " + mark1);
            Console.WriteLine("mark for java is " + mark2);
            Console.WriteLine("mark for data base is " + mark3);


        }
    }
}
