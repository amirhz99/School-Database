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
    
    public partial class take
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public take()
        {
            this.sections = new HashSet<section>();
        }
    
        public int Id { get; set; }
        public Nullable<int> course_id { get; set; }
        public Nullable<int> sec_id { get; set; }
        public string semester { get; set; }
        public Nullable<int> year { get; set; }
        public string grade { get; set; }
    
        public virtual Student Student { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<section> sections { get; set; }
    }
}
