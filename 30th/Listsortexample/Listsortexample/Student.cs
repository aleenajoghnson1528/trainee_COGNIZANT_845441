using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listsortexample
{
    class Student //: IComparable<Student>
    {
        public int ID { get; set; }
        public string StudentNAme { get; set; }
        public string Course { get; set; }


        /*  public int CompareTo(Student b)
          {

              return this.ID.CompareTo(b.ID);
          }*/

        public List<Student> ListDemo(List<Student> lst)
        {
            var ch = from element in lst
                     orderby element.StudentNAme
                     select element;
            List<Student> st = ch.ToList();
            return st;
        }
    }
}
