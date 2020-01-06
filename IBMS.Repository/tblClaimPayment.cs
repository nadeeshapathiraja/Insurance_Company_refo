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
    
    public partial class tblClaimPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblClaimPayment()
        {
            this.tblClaimPaymentMethods = new HashSet<tblClaimPaymentMethod>();
        }
    
        public int ClaimPaymentID { get; set; }
        public Nullable<int> ClaimRecordingID { get; set; }
        public Nullable<decimal> ClaimAmount { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }
        public bool IsCompleted { get; set; }
        public string Notes { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual tblUser tblUser { get; set; }
        public virtual tblUser tblUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClaimPaymentMethod> tblClaimPaymentMethods { get; set; }
        public virtual tblClaimRecording tblClaimRecording { get; set; }
    }
}
