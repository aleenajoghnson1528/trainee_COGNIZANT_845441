using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryactivity
{
    public class Newclass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayId()
        {
            return string.Format("id is {0}", Id);
        }
        public string DisplayName()
        {
            return string.Format("name is {0}", Name);
        }


    }
}
