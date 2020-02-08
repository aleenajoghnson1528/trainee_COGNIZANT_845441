using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLibrary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Displayid()
        {
            return string.Format("id is {0}", Id);
        }
        public string DisplayName()
        {
            return string.Format("name is {0}", Name);
        }
    }
}
