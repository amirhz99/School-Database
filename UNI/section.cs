//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UNI
{
    using System;
    using System.Collections.Generic;
    
    public partial class section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public section()
        {
            this.courses = new HashSet<course>();
        }
    
        public int course_id { get; set; }
        public int sec_id { get; set; }
        public string semester { get; set; }
        public string year { get; set; }
        public string building { get; set; }
        public Nullable<int> room_no { get; set; }
        public Nullable<int> time_slot_id { get; set; }
    
        public virtual take take { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<course> courses { get; set; }
        public virtual teach teach { get; set; }
        public virtual classroom classroom { get; set; }
    }
}
