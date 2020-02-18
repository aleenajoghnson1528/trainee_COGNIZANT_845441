using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Bookapp
{
    class Book
    {
        [Key]
        public int Bid { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [Required]
        public double Price { get; set; }
        public virtual ICollection<Detail>Details { get; set; }
    }
}
