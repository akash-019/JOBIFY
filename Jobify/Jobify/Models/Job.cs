//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jobify.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            this.JobApplies = new HashSet<JobApply>();
        }
    
        public int Id { get; set; }
        public string JobType { get; set; }
        public string JobLocation { get; set; }
        public string JobTitle { get; set; }
        public Nullable<int> Salary { get; set; }
        public Nullable<int> Experience { get; set; }
        public Nullable<int> JobSeeker { get; set; }
        public Nullable<int> RecruiterId { get; set; }
        public string Description { get; set; }
    
        public virtual Recruiter Recruiter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobApply> JobApplies { get; set; }
    }
}
