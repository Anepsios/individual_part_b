//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BootcampLinq
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assignments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assignments()
        {
            this.CourseAssignments = new HashSet<CourseAssignments>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string AssignmentDescription { get; set; }
        public System.DateTime SubmissionDate { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseAssignments> CourseAssignments { get; set; }
    }
}
