//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exammanagementsystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Place { get; set; }
        public int Course_id { get; set; }
        public System.DateTime Exam_date { get; set; }
        public int Sid { get; set; }
    
        public virtual Course_offering Course_offering { get; set; }
        public virtual Student Student { get; set; }
    }
}
