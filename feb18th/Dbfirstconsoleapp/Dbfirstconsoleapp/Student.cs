//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dbfirstconsoleapp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int school_id { get; set; }
        public int Course_id { get; set; }
    
        public virtual Course_offering Course_offering { get; set; }
        public virtual School School { get; set; }
    }
}
