//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IBMS.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblIntroducer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblIntroducer()
        {
            this.tblIntroducerBusinessUnits = new HashSet<tblIntroducerBusinessUnit>();
        }
    
        public int IntroducerID { get; set; }
        public string IntroducerName { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
    
        public virtual tblUser tblUser { get; set; }
        public virtual tblUser tblUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblIntroducerBusinessUnit> tblIntroducerBusinessUnits { get; set; }
    }
}
