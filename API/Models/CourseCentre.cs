//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseCentre
    {
        public int CourseCentreId { get; set; }
        public int CourseId { get; set; }
        public int CentreId { get; set; }
        public int userId { get; set; }
        public Nullable<double> Marks { get; set; }
        public string Comments { get; set; }
        public Nullable<bool> deregistred { get; set; }
    
        public virtual Centre Centre { get; set; }
        public virtual Cours Cours { get; set; }
        public virtual User User { get; set; }
    }
}
