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
    
    public partial class tblCurrency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCurrency()
        {
            this.tblPolicyInformationRecordings = new HashSet<tblPolicyInformationRecording>();
            this.tblPolicyInformationRecordings1 = new HashSet<tblPolicyInformationRecording>();
        }
    
        public int CurrencyID { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public int CountryID { get; set; }
        public Nullable<int> BUID { get; set; }
    
        public virtual tblCountry tblCountry { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPolicyInformationRecording> tblPolicyInformationRecordings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPolicyInformationRecording> tblPolicyInformationRecordings1 { get; set; }
    }
}
