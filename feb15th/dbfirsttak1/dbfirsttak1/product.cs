//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbfirsttak1
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int Pid { get; set; }
        public int Cid { get; set; }
        public string Title { get; set; }
        public double price { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
