using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Student
    {
        string firstname;
        string secondname;
        //string name;
        int idno;
        string course;
        DateTime joindate;

       public  Student (string fn , string sn) //for read only property
            {
            firstname = fn;
            secondname = sn;
        }
        public string Name //read only property
        {
            get { return string.Format("{0} {1}", firstname, secondname); }
            //set {name=value;}
        }

        public int Idno
        {
            get { return idno; }
            set { idno = value; }

        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime Joindate
        {
             get { return joindate; }
            set { joindate = value; }
        }
    


    }
}
