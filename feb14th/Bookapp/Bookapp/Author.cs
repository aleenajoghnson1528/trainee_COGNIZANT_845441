using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bookapp
{
    class Author
    {
        [Key]
        public int Aid { get; set; }
        [MaxLength(250)]
        public string Aname { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        public virtual ICollection<Detail> Details { get; set; }
    }
}
