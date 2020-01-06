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
    
    public partial class tblCommisionStructureLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCommisionStructureLine()
        {
            this.tblPolicyCommisionPayment = new HashSet<tblPolicyCommisionPayment>();
        }
    
        public int ComStructLineID { get; set; }
        public Nullable<int> ComStructID { get; set; }
        public Nullable<int> RateCategoryID { get; set; }
        public bool IsAgeConsider { get; set; }
        public Nullable<int> AgeFrom { get; set; }
        public Nullable<int> AgeTo { get; set; }
        public bool isFixed { get; set; }
        public Nullable<double> RateValue { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
    
        public virtual tblCommisionStructureHeader tblCommisionStructureHeader { get; set; }
        public virtual tblRateCategory tblRateCategory { get; set; }
        public virtual tblUser tblUser { get; set; }
        public virtual tblUser tblUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPolicyCommisionPayment> tblPolicyCommisionPayment { get; set; }
    }
}